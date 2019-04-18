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
    public partial class MainForm : Form
    {
        public Form form_staff_management;
        public Form form_checkin;
        public Form form_login;
        public Form form_main;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            form_checkin = new CheckinForm();
            form_staff_management =  new StaffManagementForm();
            form_login = new LoginForm(this);
            form_main = this;


            form_login.TopLevel = false;
            form_login.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;//设置窗体为非边框样式
            form_login.Dock = System.Windows.Forms.DockStyle.Fill;                  //设置样式是否填充整个panel ;
            panel_main.Controls.Clear();
            panel_main.Controls.Add(form_login);
            btn_form_switch_checkin.Hide();//隐藏按钮
            btn_form_switch_staff_management.Hide();//隐藏按钮
            form_login.Show();                      //窗体运行


        }

        private void Btn_form_switch_checkin_form_Click(object sender, EventArgs e)
        {

            form_checkin.TopLevel = false;
            form_checkin.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;//设置窗体为非边框样式
            form_checkin.Dock = System.Windows.Forms.DockStyle.Fill;                  //设置样式是否填充整个panel ;
            panel_main.Controls.Clear();
            panel_main.Controls.Add(form_checkin);
            form_checkin.Show();                      //窗体运行
        }

        private void Btn_form_switch_staff_management_Click(object sender, EventArgs e)
        {
            form_staff_management.TopLevel = false;
            form_staff_management.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;//设置窗体为非边框样式
            form_staff_management.Dock = System.Windows.Forms.DockStyle.Fill;                  //设置样式是否填充整个panel ;
            panel_main.Controls.Clear();
            panel_main.Controls.Add(form_staff_management);
            form_staff_management.Show();                      //窗体运行
        }

    }
}
