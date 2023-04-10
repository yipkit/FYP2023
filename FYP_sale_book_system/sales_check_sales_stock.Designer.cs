
namespace FYP_sale_book_system
{
    partial class sales_check_sales_stock
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
            this.note = new System.Windows.Forms.ListBox();
            this.clear_btn = new System.Windows.Forms.Button();
            this.sort_btn = new System.Windows.Forms.Button();
            this.date_txt = new System.Windows.Forms.DateTimePicker();
            this.snid_txt = new System.Windows.Forms.ComboBox();
            this.location_id_txt = new System.Windows.Forms.ComboBox();
            this.sale_stock_data = new System.Windows.Forms.DataGridView();
            this.reorder = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.update_btn = new System.Windows.Forms.Button();
            this.qty_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sale_stock_lv_label = new System.Windows.Forms.Label();
            this.show_stock_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sale_stock_data)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // note
            // 
            this.note.FormattingEnabled = true;
            this.note.ItemHeight = 12;
            this.note.Location = new System.Drawing.Point(558, 71);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(602, 184);
            this.note.TabIndex = 14;
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(390, 29);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(75, 23);
            this.clear_btn.TabIndex = 13;
            this.clear_btn.Text = "Refresh Data";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // sort_btn
            // 
            this.sort_btn.Location = new System.Drawing.Point(206, 121);
            this.sort_btn.Name = "sort_btn";
            this.sort_btn.Size = new System.Drawing.Size(75, 23);
            this.sort_btn.TabIndex = 11;
            this.sort_btn.Text = "Sort";
            this.sort_btn.UseVisualStyleBackColor = true;
            this.sort_btn.Click += new System.EventHandler(this.sort_btn_Click);
            // 
            // date_txt
            // 
            this.date_txt.CustomFormat = "yy-MM-dd";
            this.date_txt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_txt.Location = new System.Drawing.Point(64, 70);
            this.date_txt.Name = "date_txt";
            this.date_txt.Size = new System.Drawing.Size(200, 22);
            this.date_txt.TabIndex = 10;
            // 
            // snid_txt
            // 
            this.snid_txt.FormattingEnabled = true;
            this.snid_txt.Location = new System.Drawing.Point(89, 30);
            this.snid_txt.Name = "snid_txt";
            this.snid_txt.Size = new System.Drawing.Size(121, 20);
            this.snid_txt.TabIndex = 9;
            // 
            // location_id_txt
            // 
            this.location_id_txt.FormattingEnabled = true;
            this.location_id_txt.Location = new System.Drawing.Point(80, 166);
            this.location_id_txt.Name = "location_id_txt";
            this.location_id_txt.Size = new System.Drawing.Size(121, 20);
            this.location_id_txt.TabIndex = 8;
            // 
            // sale_stock_data
            // 
            this.sale_stock_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sale_stock_data.Location = new System.Drawing.Point(17, 279);
            this.sale_stock_data.Name = "sale_stock_data";
            this.sale_stock_data.ReadOnly = true;
            this.sale_stock_data.RowTemplate.Height = 24;
            this.sale_stock_data.Size = new System.Drawing.Size(1457, 150);
            this.sale_stock_data.TabIndex = 11;
            // 
            // reorder
            // 
            this.reorder.Location = new System.Drawing.Point(390, 83);
            this.reorder.Name = "reorder";
            this.reorder.Size = new System.Drawing.Size(75, 23);
            this.reorder.TabIndex = 10;
            this.reorder.Text = "Re-order";
            this.reorder.UseVisualStyleBackColor = true;
            this.reorder.Click += new System.EventHandler(this.reorder_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(390, 156);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 9;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "Location ID :";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(17, 70);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(32, 12);
            this.label.TabIndex = 5;
            this.label.Text = "Date :";
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(206, 164);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(75, 23);
            this.update_btn.TabIndex = 4;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // qty_txt
            // 
            this.qty_txt.Location = new System.Drawing.Point(80, 118);
            this.qty_txt.Name = "qty_txt";
            this.qty_txt.Size = new System.Drawing.Size(100, 22);
            this.qty_txt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Qty :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "SNID : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sort_btn);
            this.groupBox1.Controls.Add(this.date_txt);
            this.groupBox1.Controls.Add(this.snid_txt);
            this.groupBox1.Controls.Add(this.location_id_txt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.update_btn);
            this.groupBox1.Controls.Add(this.qty_txt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(39, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 202);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update stock";
            // 
            // sale_stock_lv_label
            // 
            this.sale_stock_lv_label.AutoSize = true;
            this.sale_stock_lv_label.Font = new System.Drawing.Font("新細明體", 9F);
            this.sale_stock_lv_label.Location = new System.Drawing.Point(556, 48);
            this.sale_stock_lv_label.Name = "sale_stock_lv_label";
            this.sale_stock_lv_label.Size = new System.Drawing.Size(27, 12);
            this.sale_stock_lv_label.TabIndex = 8;
            this.sale_stock_lv_label.Text = "Note";
            // 
            // show_stock_btn
            // 
            this.show_stock_btn.Location = new System.Drawing.Point(390, 207);
            this.show_stock_btn.Name = "show_stock_btn";
            this.show_stock_btn.Size = new System.Drawing.Size(75, 23);
            this.show_stock_btn.TabIndex = 15;
            this.show_stock_btn.Text = "Show Stock";
            this.show_stock_btn.UseVisualStyleBackColor = true;
            this.show_stock_btn.Click += new System.EventHandler(this.show_stock_btn_Click);
            // 
            // sales_check_sales_stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1492, 461);
            this.Controls.Add(this.show_stock_btn);
            this.Controls.Add(this.note);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.sale_stock_data);
            this.Controls.Add(this.reorder);
            this.Controls.Add(this.close);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sale_stock_lv_label);
            this.Name = "sales_check_sales_stock";
            this.Text = "Check Sales Stock";
            this.Load += new System.EventHandler(this.sales_check_sales_stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sale_stock_data)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox note;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button sort_btn;
        private System.Windows.Forms.DateTimePicker date_txt;
        private System.Windows.Forms.ComboBox snid_txt;
        private System.Windows.Forms.ComboBox location_id_txt;
        private System.Windows.Forms.DataGridView sale_stock_data;
        private System.Windows.Forms.Button reorder;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.TextBox qty_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label sale_stock_lv_label;
        private System.Windows.Forms.Button show_stock_btn;
    }
}