namespace SimplyEntranceGuard
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_form_switch_checkin = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_form_switch_staff_management = new System.Windows.Forms.Button();
            this.panel_main = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btn_form_switch_checkin
            // 
            this.btn_form_switch_checkin.AccessibleName = "true";
            this.btn_form_switch_checkin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_form_switch_checkin.Location = new System.Drawing.Point(958, 42);
            this.btn_form_switch_checkin.Name = "btn_form_switch_checkin";
            this.btn_form_switch_checkin.Size = new System.Drawing.Size(98, 46);
            this.btn_form_switch_checkin.TabIndex = 0;
            this.btn_form_switch_checkin.Text = "考勤信息";
            this.btn_form_switch_checkin.UseVisualStyleBackColor = true;
            this.btn_form_switch_checkin.Click += new System.EventHandler(this.Btn_form_switch_checkin_form_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btn_form_switch_staff_management
            // 
            this.btn_form_switch_staff_management.AccessibleName = "true";
            this.btn_form_switch_staff_management.Location = new System.Drawing.Point(958, 140);
            this.btn_form_switch_staff_management.Name = "btn_form_switch_staff_management";
            this.btn_form_switch_staff_management.Size = new System.Drawing.Size(98, 46);
            this.btn_form_switch_staff_management.TabIndex = 3;
            this.btn_form_switch_staff_management.Text = "人员管理";
            this.btn_form_switch_staff_management.UseVisualStyleBackColor = true;
            this.btn_form_switch_staff_management.Click += new System.EventHandler(this.Btn_form_switch_staff_management_Click);
            // 
            // panel_main
            // 
            this.panel_main.AccessibleName = "true";
            this.panel_main.Location = new System.Drawing.Point(1, 1);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(928, 556);
            this.panel_main.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 563);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.btn_form_switch_staff_management);
            this.Controls.Add(this.btn_form_switch_checkin);
            this.Name = "MainForm";
            this.Text = "门禁后台管理系统";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.Button btn_form_switch_checkin;
        public System.Windows.Forms.Panel panel_main;
        public System.Windows.Forms.Button btn_form_switch_staff_management;
    }
}

