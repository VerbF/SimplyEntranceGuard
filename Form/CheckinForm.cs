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
    public partial class CheckinForm : Form
    {
        public MainForm form_main;
        public string start_time;
        public string end_time;
        public CheckinForm(MainForm form)
        {
            InitializeComponent();
            form_main = form;
        }
        private void CheckinForm_Load(object sender, EventArgs e)
        {
            //设置列表标题
            listView_checkin.Columns.Add("员工姓名", 60, HorizontalAlignment.Center);    //将列头添加到ListView控件。
            listView_checkin.Columns.Add("考勤时间", 60, HorizontalAlignment.Center);    //将列头添加到ListView控件。
            listView_checkin.Columns.Add("所在部门", 60, HorizontalAlignment.Center);    //将列头添加到ListView控件。
            this.listView_checkin.View = System.Windows.Forms.View.Details;
        }
        /// <summary>
        /// 更新考勤数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_update_Click(object sender, EventArgs e)
        {
            //从数据库中获取全部人员信息
            DatabaseUtility databaseUtility = new DatabaseUtility();
            List<Staff> staffs = databaseUtility.GetAllStaffs();
            List<CheckinRecord> records_checkin = new List<CheckinRecord>();
            List<CheckinRecord> records_late = new List<CheckinRecord>();
            List<CheckinRecord> records_not_checkin = new List<CheckinRecord>();
            databaseUtility.CloseConnection();

            listView_checkin.BeginUpdate();   //数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁并大大提高加载速度
            listView_checkin.Items.Clear();     //清除原数据

            List<CheckinRecord> records = form_main.fileUtility.GetNewCheckinRecord();//获得考勤数据


            foreach(CheckinRecord record in records)
            {
                /*ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = record.staff.Name;
                listViewItem.SubItems.Add(record.CheckinTime);
                this.listView_checkin.Items.Add(listViewItem);*/
                
            }


            this.listView_checkin.EndUpdate();  //结束数据处理，UI界面一次性绘制。
        }

       
    }
}
