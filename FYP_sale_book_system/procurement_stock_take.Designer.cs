
namespace FYP_sale_book_system
{
    partial class procurement_stock_take
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
            this.date_txt = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.search_txt = new System.Windows.Forms.TextBox();
            this.snid_txt = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.restart_btn = new System.Windows.Forms.Button();
            this.ManualUpdate_groupBox = new System.Windows.Forms.GroupBox();
            this.ref_label = new System.Windows.Forms.Label();
            this.product_name_label = new System.Windows.Forms.Label();
            this.qty_label = new System.Windows.Forms.Label();
            this.date_label = new System.Windows.Forms.Label();
            this.book_name_txt = new System.Windows.Forms.TextBox();
            this.qty_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.update_btn = new System.Windows.Forms.Button();
            this.remark_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.stocktake_id_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.stock_take_data = new System.Windows.Forms.DataGridView();
            this.close = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.ManualUpdate_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stock_take_data)).BeginInit();
            this.SuspendLayout();
            // 
            // date_txt
            // 
            this.date_txt.CustomFormat = "yy-MM-dd";
            this.date_txt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_txt.Location = new System.Drawing.Point(102, 163);
            this.date_txt.Name = "date_txt";
            this.date_txt.Size = new System.Drawing.Size(100, 22);
            this.date_txt.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F);
            this.label4.Location = new System.Drawing.Point(30, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 41;
            this.label4.Text = "Origin Data";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "Stock Take ID :";
            // 
            // search_txt
            // 
            this.search_txt.Location = new System.Drawing.Point(93, 30);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(230, 22);
            this.search_txt.TabIndex = 0;
            // 
            // snid_txt
            // 
            this.snid_txt.Location = new System.Drawing.Point(102, 55);
            this.snid_txt.Name = "snid_txt";
            this.snid_txt.ReadOnly = true;
            this.snid_txt.Size = new System.Drawing.Size(100, 22);
            this.snid_txt.TabIndex = 5;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(329, 28);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 2;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.search_btn);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.restart_btn);
            this.groupBox1.Controls.Add(this.search_txt);
            this.groupBox1.Location = new System.Drawing.Point(4, 283);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(962, 75);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "search";
            // 
            // restart_btn
            // 
            this.restart_btn.Location = new System.Drawing.Point(638, 28);
            this.restart_btn.Name = "restart_btn";
            this.restart_btn.Size = new System.Drawing.Size(75, 23);
            this.restart_btn.TabIndex = 33;
            this.restart_btn.Text = "Refresh Data";
            this.restart_btn.UseVisualStyleBackColor = true;
            this.restart_btn.Click += new System.EventHandler(this.restart_btn_Click);
            // 
            // ManualUpdate_groupBox
            // 
            this.ManualUpdate_groupBox.Controls.Add(this.date_txt);
            this.ManualUpdate_groupBox.Controls.Add(this.snid_txt);
            this.ManualUpdate_groupBox.Controls.Add(this.ref_label);
            this.ManualUpdate_groupBox.Controls.Add(this.product_name_label);
            this.ManualUpdate_groupBox.Controls.Add(this.qty_label);
            this.ManualUpdate_groupBox.Controls.Add(this.date_label);
            this.ManualUpdate_groupBox.Controls.Add(this.book_name_txt);
            this.ManualUpdate_groupBox.Controls.Add(this.qty_txt);
            this.ManualUpdate_groupBox.Controls.Add(this.label7);
            this.ManualUpdate_groupBox.Controls.Add(this.update_btn);
            this.ManualUpdate_groupBox.Controls.Add(this.remark_txt);
            this.ManualUpdate_groupBox.Controls.Add(this.label6);
            this.ManualUpdate_groupBox.Controls.Add(this.stocktake_id_txt);
            this.ManualUpdate_groupBox.Location = new System.Drawing.Point(7, 14);
            this.ManualUpdate_groupBox.Name = "ManualUpdate_groupBox";
            this.ManualUpdate_groupBox.Size = new System.Drawing.Size(959, 246);
            this.ManualUpdate_groupBox.TabIndex = 42;
            this.ManualUpdate_groupBox.TabStop = false;
            this.ManualUpdate_groupBox.Text = "Manual Update";
            // 
            // ref_label
            // 
            this.ref_label.AutoSize = true;
            this.ref_label.Font = new System.Drawing.Font("新細明體", 9F);
            this.ref_label.Location = new System.Drawing.Point(59, 58);
            this.ref_label.Name = "ref_label";
            this.ref_label.Size = new System.Drawing.Size(37, 12);
            this.ref_label.TabIndex = 1;
            this.ref_label.Text = "SNID :";
            // 
            // product_name_label
            // 
            this.product_name_label.AutoSize = true;
            this.product_name_label.Font = new System.Drawing.Font("新細明體", 9F);
            this.product_name_label.Location = new System.Drawing.Point(28, 93);
            this.product_name_label.Name = "product_name_label";
            this.product_name_label.Size = new System.Drawing.Size(67, 12);
            this.product_name_label.TabIndex = 2;
            this.product_name_label.Text = "Book Name :";
            // 
            // qty_label
            // 
            this.qty_label.AutoSize = true;
            this.qty_label.Font = new System.Drawing.Font("新細明體", 9F);
            this.qty_label.Location = new System.Drawing.Point(67, 129);
            this.qty_label.Name = "qty_label";
            this.qty_label.Size = new System.Drawing.Size(28, 12);
            this.qty_label.TabIndex = 3;
            this.qty_label.Text = "Qty :";
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Font = new System.Drawing.Font("新細明體", 9F);
            this.date_label.Location = new System.Drawing.Point(44, 170);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(32, 12);
            this.date_label.TabIndex = 4;
            this.date_label.Text = "Date :";
            // 
            // book_name_txt
            // 
            this.book_name_txt.Location = new System.Drawing.Point(102, 90);
            this.book_name_txt.Name = "book_name_txt";
            this.book_name_txt.ReadOnly = true;
            this.book_name_txt.Size = new System.Drawing.Size(100, 22);
            this.book_name_txt.TabIndex = 6;
            // 
            // qty_txt
            // 
            this.qty_txt.Location = new System.Drawing.Point(102, 126);
            this.qty_txt.Name = "qty_txt";
            this.qty_txt.Size = new System.Drawing.Size(100, 22);
            this.qty_txt.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 12);
            this.label7.TabIndex = 27;
            this.label7.Text = "Remark : ";
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(416, 194);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(75, 23);
            this.update_btn.TabIndex = 11;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // remark_txt
            // 
            this.remark_txt.Location = new System.Drawing.Point(102, 191);
            this.remark_txt.Name = "remark_txt";
            this.remark_txt.Size = new System.Drawing.Size(280, 22);
            this.remark_txt.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 12);
            this.label6.TabIndex = 20;
            this.label6.Text = "Stock take ID :";
            // 
            // stocktake_id_txt
            // 
            this.stocktake_id_txt.Location = new System.Drawing.Point(102, 24);
            this.stocktake_id_txt.Name = "stocktake_id_txt";
            this.stocktake_id_txt.Size = new System.Drawing.Size(100, 22);
            this.stocktake_id_txt.TabIndex = 21;
            this.stocktake_id_txt.TextChanged += new System.EventHandler(this.stocktake_id_txt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F);
            this.label3.Location = new System.Drawing.Point(34, 618);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "Update List";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(16, 442);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(962, 150);
            this.dataGridView2.TabIndex = 38;
            // 
            // stock_take_data
            // 
            this.stock_take_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stock_take_data.Location = new System.Drawing.Point(16, 653);
            this.stock_take_data.Name = "stock_take_data";
            this.stock_take_data.ReadOnly = true;
            this.stock_take_data.RowTemplate.Height = 24;
            this.stock_take_data.Size = new System.Drawing.Size(962, 150);
            this.stock_take_data.TabIndex = 37;
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(1001, 27);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 36;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // procurement_stock_take
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 823);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ManualUpdate_groupBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.stock_take_data);
            this.Controls.Add(this.close);
            this.Name = "procurement_stock_take";
            this.Text = "Stock Take";
            this.Load += new System.EventHandler(this.procurement_stock_take_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ManualUpdate_groupBox.ResumeLayout(false);
            this.ManualUpdate_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stock_take_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker date_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox search_txt;
        private System.Windows.Forms.TextBox snid_txt;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button restart_btn;
        private System.Windows.Forms.GroupBox ManualUpdate_groupBox;
        private System.Windows.Forms.Label ref_label;
        private System.Windows.Forms.Label product_name_label;
        private System.Windows.Forms.Label qty_label;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.TextBox book_name_txt;
        private System.Windows.Forms.TextBox qty_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.TextBox remark_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox stocktake_id_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView stock_take_data;
        private System.Windows.Forms.Button close;
    }
}