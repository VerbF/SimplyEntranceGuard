namespace SimplyEntranceGuard.MyForm
{
    partial class QueryForm
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
            this.components = new System.ComponentModel.Container();
            this.btn_query = new System.Windows.Forms.Button();
            this.listView_query_result = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_query_date = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_query
            // 
            this.btn_query.Location = new System.Drawing.Point(687, 128);
            this.btn_query.Name = "btn_query";
            this.btn_query.Size = new System.Drawing.Size(107, 49);
            this.btn_query.TabIndex = 0;
            this.btn_query.Text = "查询";
            this.btn_query.UseVisualStyleBackColor = true;
            this.btn_query.Click += new System.EventHandler(this.Btn_query_Click);
            // 
            // listView_query_result
            // 
            this.listView_query_result.Location = new System.Drawing.Point(69, 128);
            this.listView_query_result.Name = "listView_query_result";
            this.listView_query_result.Size = new System.Drawing.Size(346, 335);
            this.listView_query_result.TabIndex = 1;
            this.listView_query_result.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "查询结果";
            // 
            // tbox_query_date
            // 
            this.tbox_query_date.Location = new System.Drawing.Point(480, 128);
            this.tbox_query_date.Name = "tbox_query_date";
            this.tbox_query_date.Size = new System.Drawing.Size(100, 25);
            this.tbox_query_date.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(480, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "查询日期";
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 521);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbox_query_date);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView_query_result);
            this.Controls.Add(this.btn_query);
            this.Name = "QueryForm";
            this.Text = "QueryForm";
            this.Load += new System.EventHandler(this.QueryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_query;
        private System.Windows.Forms.ListView listView_query_result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_query_date;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
    }
}