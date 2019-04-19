using SimplyEntranceGuard.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplyEntranceGuard
{
    public partial class StaffManagementForm : Form
    {
        public MainForm form_main;
        public string select_row_card_id;
        public StaffManagementForm(MainForm form)
        {
            InitializeComponent();
            form_main = form;
        }

        private void StaffManagementForm_Load(object sender, EventArgs e)
        {
            //设置人员列表标题
            listView_staff.Columns.Add("员工姓名", 60, HorizontalAlignment.Center);    //将列头添加到ListView控件。
            listView_staff.Columns.Add("门禁卡号", 60, HorizontalAlignment.Center);    //将列头添加到ListView控件。
            listView_staff.Columns.Add("所在部门", 60, HorizontalAlignment.Center);    //将列头添加到ListView控件。
            listView_staff.View = System.Windows.Forms.View.Details;
            //显示列表信息
            UpdateStaffList();

        }
        /// <summary>
        /// 保存修改信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_save_info_Click(object sender, EventArgs e)
        {
            string new_card_id = tbox_card_id.Text;
            DatabaseUtility databaseUtility = new DatabaseUtility();
            string sql_str = "select * from staff where card_id = '" + new_card_id+"'";
            DataTable dataTable = databaseUtility.SelectSql(sql_str);
            if(dataTable.Rows.Count != 0)
            {
                MessageBox.Show("该卡号已被使用，请重新输入！");
            }
            else
            {
                sql_str = "update staff set card_id = '" + new_card_id + "' where card_id= '" + select_row_card_id + "'";
                bool isSuccess = databaseUtility.UpdateSql(sql_str) == true;
                if (isSuccess)
                {
                    MessageBox.Show("保存成功！");
                    UpdateStaffList();
                }
                else
                {
                    MessageBox.Show("保存失败，请重试！");
                }
            }
        }
        //选中行改变事件
        private void ListView_staff_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedIndexCollection indexes = this.listView_staff.SelectedIndices;
            if (indexes.Count > 0)
            {
                int index = indexes[0];
                string name = this.listView_staff.Items[index].SubItems[0].Text;//获取第一列的值 姓名
                string card_id = this.listView_staff.Items[index].SubItems[1].Text;//获取第二列的值 卡号
                string department_name = this.listView_staff.Items[index].SubItems[2].Text;//获取第二列的值 部门
                tbox_name.Text = name;
                tbox_card_id.Text = card_id;
                tbox_department_name.Text = department_name;

                select_row_card_id = card_id;
            }          
 
        }
        /// <summary>
        /// 更新人员列表
        /// </summary>
        public void UpdateStaffList()
        {
            listView_staff.BeginUpdate();   //数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁并大大提高加载速度
            listView_staff.Items.Clear();     //清除原数据

            //从数据库中获取全部人员信息
            DatabaseUtility databaseUtility = new DatabaseUtility();
            List<Staff> staffs = databaseUtility.GetAllStaffs();
            databaseUtility.CloseConnection();

            //显示人员列表
            foreach (Staff staff in staffs)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = staff.Name;
                listViewItem.SubItems.Add(staff.CardID);
                listViewItem.SubItems.Add(staff.DepartmentName);

                this.listView_staff.Items.Add(listViewItem);
            }

            listView_staff.EndUpdate();  //结束数据处理，UI界面一次性绘制。
        }
    }
}
