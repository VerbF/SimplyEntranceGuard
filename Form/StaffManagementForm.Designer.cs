namespace SimplyEntranceGuard
{
    partial class StaffManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView_staff = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_save_info = new System.Windows.Forms.Button();
            this.tbox_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbox_card_id = new System.Windows.Forms.TextBox();
            this.tbox_department_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_staff
            // 
            this.listView_staff.FullRowSelect = true;
            this.listView_staff.Location = new System.Drawing.Point(34, 58);
            this.listView_staff.Name = "listView_staff";
            this.listView_staff.Size = new System.Drawing.Size(241, 310);
            this.listView_staff.TabIndex = 0;
            this.listView_staff.UseCompatibleStateImageBehavior = false;
            this.listView_staff.SelectedIndexChanged += new System.EventHandler(this.ListView_staff_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "人员列表";
            // 
            // btn_save_info
            // 
            this.btn_save_info.Location = new System.Drawing.Point(60, 235);
            this.btn_save_info.Name = "btn_save_info";
            this.btn_save_info.Size = new System.Drawing.Size(90, 35);
            this.btn_save_info.TabIndex = 2;
            this.btn_save_info.Text = "保存";
            this.btn_save_info.UseVisualStyleBackColor = true;
            this.btn_save_info.Click += new System.EventHandler(this.Btn_save_info_Click);
            // 
            // tbox_name
            // 
            this.tbox_name.Location = new System.Drawing.Point(97, 21);
            this.tbox_name.Name = "tbox_name";
            this.tbox_name.ReadOnly = true;
            this.tbox_name.Size = new System.Drawing.Size(100, 25);
            this.tbox_name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "卡号";
            // 
            // tbox_card_id
            // 
            this.tbox_card_id.Location = new System.Drawing.Point(97, 89);
            this.tbox_card_id.Name = "tbox_card_id";
            this.tbox_card_id.Size = new System.Drawing.Size(100, 25);
            this.tbox_card_id.TabIndex = 6;
            // 
            // tbox_department_name
            // 
            this.tbox_department_name.Location = new System.Drawing.Point(97, 143);
            this.tbox_department_name.Name = "tbox_department_name";
            this.tbox_department_name.ReadOnly = true;
            this.tbox_department_name.Size = new System.Drawing.Size(100, 25);
            this.tbox_department_name.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "部门";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_save_info);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbox_card_id);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbox_name);
            this.panel1.Controls.Add(this.tbox_department_name);
            this.panel1.Location = new System.Drawing.Point(330, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 310);
            this.panel1.TabIndex = 9;
            // 
            // StaffManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 403);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView_staff);
            this.Name = "StaffManagementForm";
            this.Text = "StaffManagementForm";
            this.Load += new System.EventHandler(this.StaffManagementForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_staff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_save_info;
        private System.Windows.Forms.TextBox tbox_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbox_card_id;
        private System.Windows.Forms.TextBox tbox_department_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
    }
}