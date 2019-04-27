namespace SimplyEntranceGuard
{
    partial class CheckinForm
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
            this.btn_update = new System.Windows.Forms.Button();
            this.listView_checkin = new System.Windows.Forms.ListView();
            this.listView_not_checkin = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listView_late = new System.Windows.Forms.ListView();
            this.tbox_start_time = new System.Windows.Forms.TextBox();
            this.tbox_end_time = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(29, 23);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(134, 56);
            this.btn_update.TabIndex = 0;
            this.btn_update.Text = "刷新";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.Btn_update_Click);
            // 
            // listView_checkin
            // 
            this.listView_checkin.FullRowSelect = true;
            this.listView_checkin.Location = new System.Drawing.Point(29, 149);
            this.listView_checkin.Name = "listView_checkin";
            this.listView_checkin.Size = new System.Drawing.Size(341, 330);
            this.listView_checkin.TabIndex = 1;
            this.listView_checkin.UseCompatibleStateImageBehavior = false;
            // 
            // listView_not_checkin
            // 
            this.listView_not_checkin.Location = new System.Drawing.Point(751, 149);
            this.listView_not_checkin.Name = "listView_not_checkin";
            this.listView_not_checkin.Size = new System.Drawing.Size(177, 330);
            this.listView_not_checkin.TabIndex = 2;
            this.listView_not_checkin.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "已考勤人员";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(798, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "未考勤人员";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(468, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "迟到人员";
            // 
            // listView_late
            // 
            this.listView_late.Location = new System.Drawing.Point(390, 149);
            this.listView_late.Name = "listView_late";
            this.listView_late.Size = new System.Drawing.Size(317, 330);
            this.listView_late.TabIndex = 5;
            this.listView_late.UseCompatibleStateImageBehavior = false;
            // 
            // tbox_start_time
            // 
            this.tbox_start_time.Location = new System.Drawing.Point(205, 54);
            this.tbox_start_time.Name = "tbox_start_time";
            this.tbox_start_time.Size = new System.Drawing.Size(100, 25);
            this.tbox_start_time.TabIndex = 7;
            this.tbox_start_time.Text = "08:00:00";
            // 
            // tbox_end_time
            // 
            this.tbox_end_time.Location = new System.Drawing.Point(338, 54);
            this.tbox_end_time.Name = "tbox_end_time";
            this.tbox_end_time.Size = new System.Drawing.Size(100, 25);
            this.tbox_end_time.TabIndex = 8;
            this.tbox_end_time.Text = "09:00:00";
            // 
            // CheckinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 532);
            this.Controls.Add(this.tbox_end_time);
            this.Controls.Add(this.tbox_start_time);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView_late);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView_not_checkin);
            this.Controls.Add(this.listView_checkin);
            this.Controls.Add(this.btn_update);
            this.Name = "CheckinForm";
            this.Text = "CheckinForm";
            this.Load += new System.EventHandler(this.CheckinForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.ListView listView_checkin;
        private System.Windows.Forms.ListView listView_not_checkin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView_late;
        private System.Windows.Forms.TextBox tbox_start_time;
        private System.Windows.Forms.TextBox tbox_end_time;
    }
}