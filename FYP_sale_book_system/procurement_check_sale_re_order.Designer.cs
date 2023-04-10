
namespace FYP_sale_book_system
{
    partial class procurement_check_sale_re_order
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.date_txt = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.re_order_id_txt = new System.Windows.Forms.ComboBox();
            this.show_procurement_stock = new System.Windows.Forms.Button();
            this.Search_btn = new System.Windows.Forms.Button();
            this.show_re_order = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.time_txt = new System.Windows.Forms.TextBox();
            this.restart_btn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.location_id_txt = new System.Windows.Forms.TextBox();
            this.re_order_no_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.snid1_txt = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.note_txt = new System.Windows.Forms.TextBox();
            this.qty_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.update_btn = new System.Windows.Forms.Button();
            this.snid_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.close_btn = new System.Windows.Forms.Button();
            this.re_order_txt = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.complete_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // date_txt
            // 
            this.date_txt.CustomFormat = "yy-MM-dd";
            this.date_txt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_txt.Location = new System.Drawing.Point(141, 218);
            this.date_txt.Name = "date_txt";
            this.date_txt.Size = new System.Drawing.Size(118, 22);
            this.date_txt.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(59, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 12);
            this.label13.TabIndex = 27;
            this.label13.Text = "Re-order ID :";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 615);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1044, 150);
            this.dataGridView2.TabIndex = 26;
            // 
            // re_order_id_txt
            // 
            this.re_order_id_txt.FormattingEnabled = true;
            this.re_order_id_txt.Location = new System.Drawing.Point(146, 26);
            this.re_order_id_txt.Name = "re_order_id_txt";
            this.re_order_id_txt.Size = new System.Drawing.Size(121, 20);
            this.re_order_id_txt.TabIndex = 17;
            this.re_order_id_txt.SelectedIndexChanged += new System.EventHandler(this.re_order_id_txt_SelectedIndexChanged);
            // 
            // show_procurement_stock
            // 
            this.show_procurement_stock.Location = new System.Drawing.Point(442, 40);
            this.show_procurement_stock.Name = "show_procurement_stock";
            this.show_procurement_stock.Size = new System.Drawing.Size(164, 23);
            this.show_procurement_stock.TabIndex = 21;
            this.show_procurement_stock.Text = "Show Procurement Stock";
            this.show_procurement_stock.UseVisualStyleBackColor = true;
            this.show_procurement_stock.Click += new System.EventHandler(this.show_inventory_stock_Click);
            // 
            // Search_btn
            // 
            this.Search_btn.Location = new System.Drawing.Point(155, 40);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(75, 23);
            this.Search_btn.TabIndex = 19;
            this.Search_btn.Text = "Search";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // show_re_order
            // 
            this.show_re_order.Location = new System.Drawing.Point(254, 40);
            this.show_re_order.Name = "show_re_order";
            this.show_re_order.Size = new System.Drawing.Size(152, 23);
            this.show_re_order.TabIndex = 20;
            this.show_re_order.Text = "Show Sale Re-Order";
            this.show_re_order.UseVisualStyleBackColor = true;
            this.show_re_order.Click += new System.EventHandler(this.show_re_order_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(81, 269);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 12);
            this.label12.TabIndex = 26;
            this.label12.Text = "Time :";
            // 
            // time_txt
            // 
            this.time_txt.Location = new System.Drawing.Point(141, 266);
            this.time_txt.Name = "time_txt";
            this.time_txt.ReadOnly = true;
            this.time_txt.Size = new System.Drawing.Size(118, 22);
            this.time_txt.TabIndex = 25;
            // 
            // restart_btn
            // 
            this.restart_btn.Location = new System.Drawing.Point(495, 126);
            this.restart_btn.Name = "restart_btn";
            this.restart_btn.Size = new System.Drawing.Size(75, 23);
            this.restart_btn.TabIndex = 14;
            this.restart_btn.Text = "Restart";
            this.restart_btn.UseVisualStyleBackColor = true;
            this.restart_btn.Click += new System.EventHandler(this.restart_btn_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(81, 225);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 12);
            this.label11.TabIndex = 23;
            this.label11.Text = "Date :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(59, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 12);
            this.label10.TabIndex = 22;
            this.label10.Text = "Location ID :";
            // 
            // location_id_txt
            // 
            this.location_id_txt.Location = new System.Drawing.Point(149, 106);
            this.location_id_txt.Name = "location_id_txt";
            this.location_id_txt.ReadOnly = true;
            this.location_id_txt.Size = new System.Drawing.Size(118, 22);
            this.location_id_txt.TabIndex = 21;
            // 
            // re_order_no_txt
            // 
            this.re_order_no_txt.Location = new System.Drawing.Point(146, 61);
            this.re_order_no_txt.Name = "re_order_no_txt";
            this.re_order_no_txt.ReadOnly = true;
            this.re_order_no_txt.Size = new System.Drawing.Size(121, 22);
            this.re_order_no_txt.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 12);
            this.label7.TabIndex = 22;
            this.label7.Text = "SNID";
            // 
            // snid1_txt
            // 
            this.snid1_txt.FormattingEnabled = true;
            this.snid1_txt.Location = new System.Drawing.Point(6, 40);
            this.snid1_txt.Name = "snid1_txt";
            this.snid1_txt.Size = new System.Drawing.Size(121, 20);
            this.snid1_txt.TabIndex = 18;
            this.snid1_txt.SelectedIndexChanged += new System.EventHandler(this.model_no_txt_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(59, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 12);
            this.label9.TabIndex = 19;
            this.label9.Text = "Re-order No :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "SNID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "Note :";
            // 
            // note_txt
            // 
            this.note_txt.BackColor = System.Drawing.SystemColors.Info;
            this.note_txt.Location = new System.Drawing.Point(409, 40);
            this.note_txt.Name = "note_txt";
            this.note_txt.ReadOnly = true;
            this.note_txt.Size = new System.Drawing.Size(237, 22);
            this.note_txt.TabIndex = 15;
            // 
            // qty_txt
            // 
            this.qty_txt.Location = new System.Drawing.Point(149, 175);
            this.qty_txt.Name = "qty_txt";
            this.qty_txt.ReadOnly = true;
            this.qty_txt.Size = new System.Drawing.Size(118, 22);
            this.qty_txt.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-161, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "Qty :";
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(378, 126);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(75, 23);
            this.update_btn.TabIndex = 11;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // snid_txt
            // 
            this.snid_txt.Location = new System.Drawing.Point(149, 142);
            this.snid_txt.Name = "snid_txt";
            this.snid_txt.ReadOnly = true;
            this.snid_txt.Size = new System.Drawing.Size(118, 22);
            this.snid_txt.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-161, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ref No :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.snid1_txt);
            this.groupBox3.Controls.Add(this.show_procurement_stock);
            this.groupBox3.Controls.Add(this.Search_btn);
            this.groupBox3.Controls.Add(this.show_re_order);
            this.groupBox3.Location = new System.Drawing.Point(12, 499);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(637, 75);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.date_txt);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.re_order_id_txt);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.time_txt);
            this.groupBox2.Controls.Add(this.restart_btn);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.location_id_txt);
            this.groupBox2.Controls.Add(this.re_order_no_txt);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.note_txt);
            this.groupBox2.Controls.Add(this.qty_txt);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.update_btn);
            this.groupBox2.Controls.Add(this.snid_txt);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(665, 353);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Stock";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "Qty :";
            // 
            // close_btn
            // 
            this.close_btn.Location = new System.Drawing.Point(602, 67);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(75, 23);
            this.close_btn.TabIndex = 24;
            this.close_btn.Text = "Close";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // re_order_txt
            // 
            this.re_order_txt.FormattingEnabled = true;
            this.re_order_txt.Location = new System.Drawing.Point(110, 45);
            this.re_order_txt.Name = "re_order_txt";
            this.re_order_txt.Size = new System.Drawing.Size(121, 20);
            this.re_order_txt.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.re_order_txt);
            this.groupBox1.Controls.Add(this.complete_btn);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 100);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sale Re-order";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Re-order ID :";
            // 
            // complete_btn
            // 
            this.complete_btn.Location = new System.Drawing.Point(268, 45);
            this.complete_btn.Name = "complete_btn";
            this.complete_btn.Size = new System.Drawing.Size(75, 23);
            this.complete_btn.TabIndex = 2;
            this.complete_btn.Text = "Complete";
            this.complete_btn.UseVisualStyleBackColor = true;
            this.complete_btn.Click += new System.EventHandler(this.complete_btn_Click);
            // 
            // procurement_check_sale_re_order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 777);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.groupBox1);
            this.Name = "procurement_check_sale_re_order";
            this.Text = "procurement_check_sale_re_order";
            this.Load += new System.EventHandler(this.procurement_check_sale_re_order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DateTimePicker date_txt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox re_order_id_txt;
        private System.Windows.Forms.Button show_procurement_stock;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.Button show_re_order;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox time_txt;
        private System.Windows.Forms.Button restart_btn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox location_id_txt;
        private System.Windows.Forms.TextBox re_order_no_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox snid1_txt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox note_txt;
        private System.Windows.Forms.TextBox qty_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.TextBox snid_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.ComboBox re_order_txt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button complete_btn;
    }
}