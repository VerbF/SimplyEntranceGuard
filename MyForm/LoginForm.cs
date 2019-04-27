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
    public partial class LoginForm : Form
    {
        public MainForm form_main;
        public LoginForm(MainForm form)
        {
            InitializeComponent();
            form_main = form;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            string user_id = tbox_id.Text;
            string user_password = tbox_password.Text;
            DatabaseUtility databaseUtility = new DatabaseUtility();
            string sql_str = "select * from user  where user_id = '" + user_id +"'";
            if(databaseUtility.SelectSql(sql_str).Rows.Count == 0)
            {
                MessageBox.Show("账户不存在！");
                return;
            }
            else 
            {
                DataTable dataTable = databaseUtility.SelectSql(sql_str);
                DataRow row = dataTable.Rows[0];
                string true_passowrd = row["user_password"].ToString();
                if(!true_passowrd.Equals(user_password))
                {
                    MessageBox.Show("密码错误！");
                    return;
                }
                else//进入主界面
                {
                    CheckinForm form_checkin = new CheckinForm(form_main);
                    Panel panel_main = form_main.panel_main;

                    form_checkin.TopLevel = false;
                    form_checkin.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;//设置窗体为非边框样式
                    form_checkin.Dock = System.Windows.Forms.DockStyle.Fill;                  //设置样式是否填充整个panel ;
                    panel_main.Controls.Clear();
                    panel_main.Controls.Add(form_checkin);
                    panel_main.BorderStyle = BorderStyle.FixedSingle;
                    
                    form_main.btn_form_switch_checkin.Show();//显示掩藏的按钮
                    form_main.btn_form_switch_staff_management.Show();//显示掩藏的按钮
                    form_main.btn_form_switch_query.Show();//显示掩藏的按钮
                    form_checkin.Show();                      //窗体运行
                }

            }

            

        }

    }
}
