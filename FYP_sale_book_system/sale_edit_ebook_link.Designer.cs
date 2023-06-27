
namespace FYP_sale_book_system
{
    partial class sale_edit_ebook_link
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
            this.label1 = new System.Windows.Forms.Label();
            this.ebook_id_txt = new System.Windows.Forms.ComboBox();
            this.ebook_link_txt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.update_link_btn = new System.Windows.Forms.Button();
            this.restart_btn = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.Button();
            this.ebook_status_txt = new System.Windows.Forms.ComboBox();
            this.e_book_status_radioBtn = new System.Windows.Forms.RadioButton();
            this.ebook_link_radioBtn = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-book ID:";
            // 
            // ebook_id_txt
            // 
            this.ebook_id_txt.FormattingEnabled = true;
            this.ebook_id_txt.Location = new System.Drawing.Point(108, 24);
            this.ebook_id_txt.Name = "ebook_id_txt";
            this.ebook_id_txt.Size = new System.Drawing.Size(128, 20);
            this.ebook_id_txt.TabIndex = 1;
            // 
            // ebook_link_txt
            // 
            this.ebook_link_txt.Location = new System.Drawing.Point(108, 129);
            this.ebook_link_txt.Name = "ebook_link_txt";
            this.ebook_link_txt.Size = new System.Drawing.Size(667, 22);
            this.ebook_link_txt.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 240);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(736, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // update_link_btn
            // 
            this.update_link_btn.Location = new System.Drawing.Point(306, 21);
            this.update_link_btn.Name = "update_link_btn";
            this.update_link_btn.Size = new System.Drawing.Size(75, 23);
            this.update_link_btn.TabIndex = 6;
            this.update_link_btn.Text = "Update";
            this.update_link_btn.UseVisualStyleBackColor = true;
            this.update_link_btn.Click += new System.EventHandler(this.update_link_btn_Click);
            // 
            // restart_btn
            // 
            this.restart_btn.Location = new System.Drawing.Point(387, 21);
            this.restart_btn.Name = "restart_btn";
            this.restart_btn.Size = new System.Drawing.Size(75, 23);
            this.restart_btn.TabIndex = 7;
            this.restart_btn.Text = "Restart";
            this.restart_btn.UseVisualStyleBackColor = true;
            this.restart_btn.Click += new System.EventHandler(this.restart_btn_Click);
            // 
            // close_btn
            // 
            this.close_btn.Location = new System.Drawing.Point(468, 22);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(75, 23);
            this.close_btn.TabIndex = 8;
            this.close_btn.Text = "Close";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // ebook_status_txt
            // 
            this.ebook_status_txt.FormattingEnabled = true;
            this.ebook_status_txt.Location = new System.Drawing.Point(108, 77);
            this.ebook_status_txt.Name = "ebook_status_txt";
            this.ebook_status_txt.Size = new System.Drawing.Size(128, 20);
            this.ebook_status_txt.TabIndex = 9;
            // 
            // e_book_status_radioBtn
            // 
            this.e_book_status_radioBtn.AutoSize = true;
            this.e_book_status_radioBtn.Location = new System.Drawing.Point(9, 81);
            this.e_book_status_radioBtn.Name = "e_book_status_radioBtn";
            this.e_book_status_radioBtn.Size = new System.Drawing.Size(56, 16);
            this.e_book_status_radioBtn.TabIndex = 10;
            this.e_book_status_radioBtn.TabStop = true;
            this.e_book_status_radioBtn.Text = "Status :";
            this.e_book_status_radioBtn.UseVisualStyleBackColor = true;
            this.e_book_status_radioBtn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // ebook_link_radioBtn
            // 
            this.ebook_link_radioBtn.AutoSize = true;
            this.ebook_link_radioBtn.Location = new System.Drawing.Point(9, 130);
            this.ebook_link_radioBtn.Name = "ebook_link_radioBtn";
            this.ebook_link_radioBtn.Size = new System.Drawing.Size(86, 16);
            this.ebook_link_radioBtn.TabIndex = 11;
            this.ebook_link_radioBtn.TabStop = true;
            this.ebook_link_radioBtn.Text = "E-book Link:";
            this.ebook_link_radioBtn.UseVisualStyleBackColor = true;
            this.ebook_link_radioBtn.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // sale_edit_ebook_link
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ebook_link_radioBtn);
            this.Controls.Add(this.e_book_status_radioBtn);
            this.Controls.Add(this.ebook_status_txt);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.restart_btn);
            this.Controls.Add(this.update_link_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ebook_link_txt);
            this.Controls.Add(this.ebook_id_txt);
            this.Controls.Add(this.label1);
            this.Name = "sale_edit_ebook_link";
            this.Text = "Sale Edit Ebook Link";
            this.Load += new System.EventHandler(this.sale_edit_ebook_link_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ebook_id_txt;
        private System.Windows.Forms.TextBox ebook_link_txt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button update_link_btn;
        private System.Windows.Forms.Button restart_btn;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.ComboBox ebook_status_txt;
        private System.Windows.Forms.RadioButton e_book_status_radioBtn;
        private System.Windows.Forms.RadioButton ebook_link_radioBtn;
    }
}