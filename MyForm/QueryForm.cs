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

namespace SimplyEntranceGuard.MyForm
{
    public partial class QueryForm : Form
    {
        public MainForm form_main;
        public QueryForm(MainForm form)
        {
            InitializeComponent();
            form_main = form;
        }

        private void QueryForm_Load(object sender, EventArgs e)
        {
            //设置已考勤人员列表标题
            listView_query_result.Columns.Add("员工姓名", 60, HorizontalAlignment.Center);    //将列头添加到ListView控件。
            listView_query_result.Columns.Add("考勤时间", 120, HorizontalAlignment.Center);    //将列头添加到ListView控件。
            listView_query_result.Columns.Add("所在部门", 60, HorizontalAlignment.Center);    //将列头添加到ListView控件。
            listView_query_result.View = System.Windows.Forms.View.Details;

            tbox_query_date.Text = DateTime.Now.ToShortDateString().ToString();
        }

        private void Btn_query_Click(object sender, EventArgs e)
        {
            //从数据库中获取全部人员信息
            DatabaseUtility databaseUtility = new DatabaseUtility();
            List<CheckinRecord> records = databaseUtility.GetAllRecords();
            databaseUtility.CloseConnection();

            listView_query_result.BeginUpdate();   //数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁并大大提高加载速度
            listView_query_result.Items.Clear();
            //显示查询结果
            foreach (CheckinRecord record in records)
            {
                string query_date = tbox_query_date.Text;
                string record_date = record.CheckinTime.Substring(0, record.CheckinTime.IndexOf("-"));
                if (query_date != record_date)
                    continue;
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = record.staff.Name;
                listViewItem.SubItems.Add(record.CheckinTime);
                listViewItem.SubItems.Add(record.staff.DepartmentName);

                this.listView_query_result.Items.Add(listViewItem);
            }

            listView_query_result.EndUpdate();  //结束数据处理，UI界面一次性绘制。
        }
    }
}
