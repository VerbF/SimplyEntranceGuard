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
            CheckinForm form_checkin = new CheckinForm(form_main);
            Panel panel_main = form_main.panel_main;

            form_checkin.TopLevel = false;
            form_checkin.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;//设置窗体为非边框样式
            form_checkin.Dock = System.Windows.Forms.DockStyle.Fill;                  //设置样式是否填充整个panel ;
            panel_main.Controls.Clear();
            panel_main.Controls.Add(form_checkin);
            panel_main.BorderStyle = BorderStyle.FixedSingle;
            form_main.btn_form_switch_checkin.Show();
            form_main.btn_form_switch_staff_management.Show();
            form_checkin.Show();                      //窗体运行

        }

    }
}
