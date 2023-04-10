
namespace FYP_sale_book_system
{
    partial class Accounting_Purchase_Order_Approval
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.restart_btn = new System.Windows.Forms.Button();
            this.pur_number_txt = new System.Windows.Forms.ComboBox();
            this.reject_btn = new System.Windows.Forms.Button();
            this.approval_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.close_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.restart_btn);
            this.groupBox1.Controls.Add(this.pur_number_txt);
            this.groupBox1.Controls.Add(this.reject_btn);
            this.groupBox1.Controls.Add(this.approval_btn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(35, 259);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(731, 168);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Action";
            // 
            // restart_btn
            // 
            this.restart_btn.Location = new System.Drawing.Point(489, 73);
            this.restart_btn.Name = "restart_btn";
            this.restart_btn.Size = new System.Drawing.Size(75, 23);
            this.restart_btn.TabIndex = 5;
            this.restart_btn.Text = "Restart";
            this.restart_btn.UseVisualStyleBackColor = true;
            this.restart_btn.Click += new System.EventHandler(this.restart_btn_Click);
            // 
            // pur_number_txt
            // 
            this.pur_number_txt.FormattingEnabled = true;
            this.pur_number_txt.Location = new System.Drawing.Point(100, 73);
            this.pur_number_txt.Name = "pur_number_txt";
            this.pur_number_txt.Size = new System.Drawing.Size(121, 20);
            this.pur_number_txt.TabIndex = 4;
            this.pur_number_txt.SelectedIndexChanged += new System.EventHandler(this.pur_number_txt_SelectedIndexChanged);
            // 
            // reject_btn
            // 
            this.reject_btn.Location = new System.Drawing.Point(378, 74);
            this.reject_btn.Name = "reject_btn";
            this.reject_btn.Size = new System.Drawing.Size(75, 23);
            this.reject_btn.TabIndex = 3;
            this.reject_btn.Text = "Reject";
            this.reject_btn.UseVisualStyleBackColor = true;
            this.reject_btn.Click += new System.EventHandler(this.reject_btn_Click);
            // 
            // approval_btn
            // 
            this.approval_btn.Location = new System.Drawing.Point(258, 74);
            this.approval_btn.Name = "approval_btn";
            this.approval_btn.Size = new System.Drawing.Size(75, 23);
            this.approval_btn.TabIndex = 2;
            this.approval_btn.Text = "Approval";
            this.approval_btn.UseVisualStyleBackColor = true;
            this.approval_btn.Click += new System.EventHandler(this.approval_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "P.O. number :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(731, 188);
            this.dataGridView1.TabIndex = 5;
            // 
            // close_btn
            // 
            this.close_btn.Location = new System.Drawing.Point(691, 23);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(75, 23);
            this.close_btn.TabIndex = 7;
            this.close_btn.Text = "Close";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // Accounting_Purchase_Order_Approval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.close_btn);
            this.Name = "Accounting_Purchase_Order_Approval";
            this.Text = "Accounting_Purchase_Order_Approval";
            this.Load += new System.EventHandler(this.Accounting_Purchase_Order_Approval_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button reject_btn;
        private System.Windows.Forms.Button approval_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.ComboBox pur_number_txt;
        private System.Windows.Forms.Button restart_btn;
    }
}