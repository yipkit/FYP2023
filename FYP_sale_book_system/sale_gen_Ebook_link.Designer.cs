
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 326);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(887, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // ebook_id_txt
            // 
            this.ebook_id_txt.FormattingEnabled = true;
            this.ebook_id_txt.Location = new System.Drawing.Point(181, 30);
            this.ebook_id_txt.Name = "ebook_id_txt";
            this.ebook_id_txt.Size = new System.Drawing.Size(121, 20);
            this.ebook_id_txt.TabIndex = 1;
            // 
            // gen_link_btn
            // 
            this.gen_link_btn.Location = new System.Drawing.Point(308, 30);
            this.gen_link_btn.Name = "gen_link_btn";
            this.gen_link_btn.Size = new System.Drawing.Size(75, 23);
            this.gen_link_btn.TabIndex = 2;
            this.gen_link_btn.Text = "Gen";
            this.gen_link_btn.UseVisualStyleBackColor = true;
            this.gen_link_btn.Click += new System.EventHandler(this.gen_link_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ebook ID:";
            // 
            // close_btn
            // 
            this.close_btn.Location = new System.Drawing.Point(408, 30);
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
            this.label2.Location = new System.Drawing.Point(119, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Save path :";
            // 
            // path_txt
            // 
            this.path_txt.Location = new System.Drawing.Point(181, 84);
            this.path_txt.Name = "path_txt";
            this.path_txt.Size = new System.Drawing.Size(302, 22);
            this.path_txt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "e.g. : E:\\\\";
            // 
            // sale_gen_Ebook_link
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 488);
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
    }
}