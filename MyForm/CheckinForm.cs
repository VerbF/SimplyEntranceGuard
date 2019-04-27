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
            //设置已考勤人员列表标题
            listView_checkin.Columns.Add("员工姓名", 60, HorizontalAlignment.Center);    //将列头添加到ListView控件。
            listView_checkin.Columns.Add("考勤时间", 120, HorizontalAlignment.Center);    //将列头添加到ListView控件。
            listView_checkin.Columns.Add("所在部门", 60, HorizontalAlignment.Center);    //将列头添加到ListView控件。
            listView_checkin.View = System.Windows.Forms.View.Details;

            //设置迟到人员列表标题
            listView_late.Columns.Add("员工姓名", 60, HorizontalAlignment.Center);    //将列头添加到ListView控件。
            listView_late.Columns.Add("考勤时间", 120, HorizontalAlignment.Center);    //将列头添加到ListView控件。
            listView_late.Columns.Add("所在部门", 60, HorizontalAlignment.Center);    //将列头添加到ListView控件。
            listView_late.View = System.Windows.Forms.View.Details;

            //设置未考勤人员列表标题
            listView_not_checkin.Columns.Add("员工姓名", 60, HorizontalAlignment.Center);    //将列头添加到ListView控件。            
            listView_not_checkin.Columns.Add("所在部门", 60, HorizontalAlignment.Center);    //将列头添加到ListView控件。
            listView_not_checkin.View = System.Windows.Forms.View.Details;

        }
        /// <summary>
        /// 更新考勤数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_update_Click(object sender, EventArgs e)
        {

            List<CheckinRecord> records_checkin = new List<CheckinRecord>();
            List<CheckinRecord> records_late = new List<CheckinRecord>();
            List<CheckinRecord> records_not_checkin = new List<CheckinRecord>();

            //获得考勤时间段
            start_time = DateTime.Now.ToShortDateString().ToString() + "-" + tbox_start_time.Text;
            end_time = DateTime.Now.ToShortDateString().ToString()+"-"+ tbox_end_time.Text;

            //从数据库中获取全部人员信息
            DatabaseUtility databaseUtility = new DatabaseUtility();
            List<Staff> staffs = databaseUtility.GetAllStaffs();
            databaseUtility.CloseConnection();

            listView_checkin.BeginUpdate();   //数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁并大大提高加载速度
            listView_late.BeginUpdate();
            listView_not_checkin.BeginUpdate();

            listView_checkin.Items.Clear();     //清除原数据
            listView_late.Items.Clear();     //清除原数据
            listView_not_checkin.Items.Clear();     //清除原数据

            List<CheckinRecord> records = form_main.fileUtility.GetNewCheckinRecord();//获得考勤数据

            SaveCheckinRecords(records);//将考勤数据写入数据库中

            records.Sort();

            //每个人员只保留一条时间最早的考勤记录
            for(int i = 0; i < records.Count();)
            {
                if(i + 1 != records.Count())
                {
                    if (records[i].staff.CardID == records[i + 1].staff.CardID)
                    {
                        if (records[i].CheckinTime.CompareTo(records[i + 1].CheckinTime) > 0)
                            records.Remove(records[i]);
                        else
                            records.Remove(records[i + 1]);
                        continue;
                    }
                }
                ++i;
            }
            //筛选出以考勤人员，迟到人员，未考勤人员
            foreach (CheckinRecord record in records)
            {
                if (record.CheckinTime.CompareTo(end_time) <= 0)
                    records_checkin.Add(record);
                else
                    records_late.Add(record);
                for(int i = 0; i < staffs.Count(); ++i)
                {
                    Staff staff = staffs[i];
                    if (staff.CardID.Equals(record.staff.CardID))
                    {
                        staffs.Remove(staff);
                        break;
                    }
                }
            }
            //显示考勤人员
            foreach(CheckinRecord record in records_checkin)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = record.staff.Name;
                listViewItem.SubItems.Add(record.CheckinTime);
                listViewItem.SubItems.Add(record.staff.DepartmentName);

                this.listView_checkin.Items.Add(listViewItem);
            }
            //显示迟到人员
            foreach (CheckinRecord record in records_late)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = record.staff.Name;
                listViewItem.SubItems.Add(record.CheckinTime);
                listViewItem.SubItems.Add(record.staff.DepartmentName);
                this.listView_late.Items.Add(listViewItem);
            }
            //显示未考勤人员
            foreach (Staff staff in staffs)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = staff.Name;
                listViewItem.SubItems.Add(staff.DepartmentName);
                this.listView_not_checkin.Items.Add(listViewItem);
            }


            listView_checkin.EndUpdate();  //结束数据处理，UI界面一次性绘制。
            listView_late.EndUpdate();
            listView_not_checkin.EndUpdate();
        }
        /// <summary>
        /// 将考勤数据保存在数据库中
        /// </summary>
        /// <param name="records"></param>
       public void SaveCheckinRecords(List<CheckinRecord> records )
       {
            DatabaseUtility databaseUtility = new DatabaseUtility();
            DataTable dataTable = new DataTable();
            foreach(CheckinRecord record in records)
            {
                record.CheckinTime = DateTime.Now.ToShortDateString().ToString() + "-"+record.CheckinTime;
      
                string sql_str = "select * from checkin_record where checkin_time = '" +record.CheckinTime+"' and card_id = '"+ record.staff.CardID+ "'";
                dataTable = databaseUtility.SelectSql(sql_str);
                //若数据库中无此记录
                if(dataTable.Rows.Count == 0)
                {
                    sql_str = "insert into checkin_record(checkin_time,card_id) values('"+record.CheckinTime+"','"+record.staff.CardID+"')";
                    bool isSuccess = databaseUtility.InsertSql(sql_str);
                    if(!isSuccess)
                    {
                        MessageBox.Show("向数据库写入考勤记录错误！");
                    }
                }
            }
            databaseUtility.CloseConnection();
       }
    }
}
