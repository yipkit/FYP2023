
namespace FYP_sale_book_system
{
    partial class sale_gen_Ebook_link
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ebook_id_txt = new System.Windows.Forms.ComboBox();
            this.gen_link_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.close_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.path_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_Email = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBackup = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(887, 168);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ebook_id_txt
            // 
            this.ebook_id_txt.FormattingEnabled = true;
            this.ebook_id_txt.Location = new System.Drawing.Point(72, 235);
            this.ebook_id_txt.Name = "ebook_id_txt";
            this.ebook_id_txt.Size = new System.Drawing.Size(121, 20);
            this.ebook_id_txt.TabIndex = 1;
            // 
            // gen_link_btn
            // 
            this.gen_link_btn.Location = new System.Drawing.Point(199, 235);
            this.gen_link_btn.Name = "gen_link_btn";
            this.gen_link_btn.Size = new System.Drawing.Size(75, 23);
            this.gen_link_btn.TabIndex = 2;
            this.gen_link_btn.Text = "Generate";
            this.gen_link_btn.UseVisualStyleBackColor = true;
            this.gen_link_btn.Click += new System.EventHandler(this.gen_link_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ebook ID:";
            // 
            // close_btn
            // 
            this.close_btn.Location = new System.Drawing.Point(299, 235);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(75, 23);
            this.close_btn.TabIndex = 4;
            this.close_btn.Text = "Close";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Save path :";
            // 
            // path_txt
            // 
            this.path_txt.Location = new System.Drawing.Point(72, 289);
            this.path_txt.Name = "path_txt";
            this.path_txt.Size = new System.Drawing.Size(302, 22);
            this.path_txt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "e.g. : E:\\\\";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "E-Book Information";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(14, 473);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(884, 179);
            this.dataGridView2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 441);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sales Order :";
            // 
            // comboBox_Email
            // 
            this.comboBox_Email.FormattingEnabled = true;
            this.comboBox_Email.Location = new System.Drawing.Point(72, 209);
            this.comboBox_Email.Name = "comboBox_Email";
            this.comboBox_Email.Size = new System.Drawing.Size(302, 20);
            this.comboBox_Email.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "E-mail :";
            // 
            // txtBackup
            // 
            this.txtBackup.Location = new System.Drawing.Point(382, 209);
            this.txtBackup.Name = "txtBackup";
            this.txtBackup.Size = new System.Drawing.Size(279, 22);
            this.txtBackup.TabIndex = 13;
            // 
            // sale_gen_Ebook_link
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 700);
            this.Controls.Add(this.txtBackup);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox_Email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.path_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gen_link_btn);
            this.Controls.Add(this.ebook_id_txt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "sale_gen_Ebook_link";
            this.Text = "Sale Gen Ebook Link";
            this.Load += new System.EventHandler(this.sale_gen_Ebook_link_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox ebook_id_txt;
        private System.Windows.Forms.Button gen_link_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox path_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_Email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBackup;
    }
}