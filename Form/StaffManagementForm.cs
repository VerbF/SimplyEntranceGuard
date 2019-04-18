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
        public StaffManagementForm(MainForm form)
        {
            InitializeComponent();
            form_main = form;
        }

        private void StaffManagementForm_Load(object sender, EventArgs e)
        {

        }
    }
}
