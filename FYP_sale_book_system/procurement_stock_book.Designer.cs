
namespace FYP_sale_book_system
{
    partial class procurement_stock_book
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
            this.defect_radio = new System.Windows.Forms.RadioButton();
            this.normal_radio = new System.Windows.Forms.RadioButton();
            this.in_radiio = new System.Windows.Forms.RadioButton();
            this.date_txt = new System.Windows.Forms.DateTimePicker();
            this.supplier_txt = new System.Windows.Forms.ComboBox();
            this.sh_supplier_btn = new System.Windows.Forms.Button();
            this.stock_book_no_txt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.out_radio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.restart_btn = new System.Windows.Forms.Button();
            this.car_no_txt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cust_name_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.time_txt = new System.Windows.Forms.TextBox();
            this.invoice_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.update_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.book_name_txt = new System.Windows.Forms.TextBox();
            this.Qty_txt = new System.Windows.Forms.TextBox();
            this.snid_txt = new System.Windows.Forms.TextBox();
            this.close_btn = new System.Windows.Forms.Button();
            this.display_list = new System.Windows.Forms.DataGridView();
            this.dept_txt = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.display_list)).BeginInit();
            this.SuspendLayout();
            // 
            // defect_radio
            // 
            this.defect_radio.AutoSize = true;
            this.defect_radio.Location = new System.Drawing.Point(132, 51);
            this.defect_radio.Name = "defect_radio";
            this.defect_radio.Size = new System.Drawing.Size(53, 16);
            this.defect_radio.TabIndex = 1;
            this.defect_radio.TabStop = true;
            this.defect_radio.Text = "Defect";
            this.defect_radio.UseVisualStyleBackColor = true;
            this.defect_radio.CheckedChanged += new System.EventHandler(this.defect_radio_CheckedChanged);
            // 
            // normal_radio
            // 
            this.normal_radio.AutoSize = true;
            this.normal_radio.Location = new System.Drawing.Point(24, 51);
            this.normal_radio.Name = "normal_radio";
            this.normal_radio.Size = new System.Drawing.Size(58, 16);
            this.normal_radio.TabIndex = 0;
            this.normal_radio.TabStop = true;
            this.normal_radio.Text = "Normal";
            this.normal_radio.UseVisualStyleBackColor = true;
            this.normal_radio.CheckedChanged += new System.EventHandler(this.normal_radio_CheckedChanged);
            // 
            // in_radiio
            // 
            this.in_radiio.AutoSize = true;
            this.in_radiio.Location = new System.Drawing.Point(23, 51);
            this.in_radiio.Name = "in_radiio";
            this.in_radiio.Size = new System.Drawing.Size(35, 16);
            this.in_radiio.TabIndex = 0;
            this.in_radiio.TabStop = true;
            this.in_radiio.Text = "IN";
            this.in_radiio.UseVisualStyleBackColor = true;
            this.in_radiio.CheckedChanged += new System.EventHandler(this.in_radiio_CheckedChanged);
            // 
            // date_txt
            // 
            this.date_txt.CustomFormat = "yy-MM-dd";
            this.date_txt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_txt.Location = new System.Drawing.Point(290, 64);
            this.date_txt.Name = "date_txt";
            this.date_txt.Size = new System.Drawing.Size(135, 22);
            this.date_txt.TabIndex = 135;
            // 
            // supplier_txt
            // 
            this.supplier_txt.FormattingEnabled = true;
            this.supplier_txt.Location = new System.Drawing.Point(956, 64);
            this.supplier_txt.Name = "supplier_txt";
            this.supplier_txt.Size = new System.Drawing.Size(121, 20);
            this.supplier_txt.TabIndex = 134;
            // 
            // sh_supplier_btn
            // 
            this.sh_supplier_btn.Location = new System.Drawing.Point(275, 16);
            this.sh_supplier_btn.Name = "sh_supplier_btn";
            this.sh_supplier_btn.Size = new System.Drawing.Size(95, 23);
            this.sh_supplier_btn.TabIndex = 133;
            this.sh_supplier_btn.Text = "Show Supplier";
            this.sh_supplier_btn.UseVisualStyleBackColor = true;
            this.sh_supplier_btn.Click += new System.EventHandler(this.sh_supplier_btn_Click);
            // 
            // stock_book_no_txt
            // 
            this.stock_book_no_txt.Location = new System.Drawing.Point(114, 20);
            this.stock_book_no_txt.Name = "stock_book_no_txt";
            this.stock_book_no_txt.Size = new System.Drawing.Size(121, 22);
            this.stock_book_no_txt.TabIndex = 132;
            this.stock_book_no_txt.TextChanged += new System.EventHandler(this.stock_book_no_txt_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 12);
            this.label11.TabIndex = 131;
            this.label11.Text = "Stock Book No :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.out_radio);
            this.groupBox2.Controls.Add(this.in_radiio);
            this.groupBox2.Location = new System.Drawing.Point(1107, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 117);
            this.groupBox2.TabIndex = 130;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item Status";
            // 
            // out_radio
            // 
            this.out_radio.AutoSize = true;
            this.out_radio.Location = new System.Drawing.Point(117, 51);
            this.out_radio.Name = "out_radio";
            this.out_radio.Size = new System.Drawing.Size(46, 16);
            this.out_radio.TabIndex = 1;
            this.out_radio.TabStop = true;
            this.out_radio.Text = "OUT";
            this.out_radio.UseVisualStyleBackColor = true;
            this.out_radio.CheckedChanged += new System.EventHandler(this.out_radio_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.defect_radio);
            this.groupBox1.Controls.Add(this.normal_radio);
            this.groupBox1.Location = new System.Drawing.Point(872, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 117);
            this.groupBox1.TabIndex = 129;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock Type";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(652, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 12);
            this.label10.TabIndex = 127;
            this.label10.Text = "Department : ";
            // 
            // restart_btn
            // 
            this.restart_btn.Location = new System.Drawing.Point(549, 16);
            this.restart_btn.Name = "restart_btn";
            this.restart_btn.Size = new System.Drawing.Size(75, 23);
            this.restart_btn.TabIndex = 126;
            this.restart_btn.Text = "Restart";
            this.restart_btn.UseVisualStyleBackColor = true;
            this.restart_btn.Click += new System.EventHandler(this.restart_btn_Click);
            // 
            // car_no_txt
            // 
            this.car_no_txt.Location = new System.Drawing.Point(1178, 66);
            this.car_no_txt.Name = "car_no_txt";
            this.car_no_txt.Size = new System.Drawing.Size(100, 22);
            this.car_no_txt.TabIndex = 125;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1109, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 12);
            this.label9.TabIndex = 124;
            this.label9.Text = "Car No :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(870, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 12);
            this.label8.TabIndex = 123;
            this.label8.Text = "Supplier Name :";
            // 
            // cust_name_txt
            // 
            this.cust_name_txt.Location = new System.Drawing.Point(754, 61);
            this.cust_name_txt.Name = "cust_name_txt";
            this.cust_name_txt.ReadOnly = true;
            this.cust_name_txt.Size = new System.Drawing.Size(100, 22);
            this.cust_name_txt.TabIndex = 122;
            this.cust_name_txt.Text = "N/A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(652, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 12);
            this.label7.TabIndex = 121;
            this.label7.Text = "Customer Name :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(456, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 120;
            this.label6.Text = "Time :";
            // 
            // time_txt
            // 
            this.time_txt.Location = new System.Drawing.Point(503, 62);
            this.time_txt.Name = "time_txt";
            this.time_txt.ReadOnly = true;
            this.time_txt.Size = new System.Drawing.Size(121, 22);
            this.time_txt.TabIndex = 119;
            // 
            // invoice_txt
            // 
            this.invoice_txt.Location = new System.Drawing.Point(95, 65);
            this.invoice_txt.Name = "invoice_txt";
            this.invoice_txt.ReadOnly = true;
            this.invoice_txt.Size = new System.Drawing.Size(121, 22);
            this.invoice_txt.TabIndex = 118;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 12);
            this.label5.TabIndex = 117;
            this.label5.Text = "Invoice No :";
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(412, 16);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(96, 23);
            this.update_btn.TabIndex = 116;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 109;
            this.label1.Text = "SNID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 12);
            this.label4.TabIndex = 115;
            this.label4.Text = "Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(454, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 12);
            this.label3.TabIndex = 114;
            this.label3.Text = "Qty :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 113;
            this.label2.Text = "Book name :";
            // 
            // book_name_txt
            // 
            this.book_name_txt.Location = new System.Drawing.Point(305, 131);
            this.book_name_txt.Name = "book_name_txt";
            this.book_name_txt.ReadOnly = true;
            this.book_name_txt.Size = new System.Drawing.Size(121, 22);
            this.book_name_txt.TabIndex = 112;
            // 
            // Qty_txt
            // 
            this.Qty_txt.Location = new System.Drawing.Point(503, 130);
            this.Qty_txt.Name = "Qty_txt";
            this.Qty_txt.ReadOnly = true;
            this.Qty_txt.Size = new System.Drawing.Size(121, 22);
            this.Qty_txt.TabIndex = 111;
            // 
            // snid_txt
            // 
            this.snid_txt.Location = new System.Drawing.Point(95, 131);
            this.snid_txt.Name = "snid_txt";
            this.snid_txt.ReadOnly = true;
            this.snid_txt.Size = new System.Drawing.Size(121, 22);
            this.snid_txt.TabIndex = 110;
            // 
            // close_btn
            // 
            this.close_btn.Location = new System.Drawing.Point(1203, 18);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(75, 23);
            this.close_btn.TabIndex = 108;
            this.close_btn.Text = "Close";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // display_list
            // 
            this.display_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.display_list.Location = new System.Drawing.Point(27, 283);
            this.display_list.Name = "display_list";
            this.display_list.ReadOnly = true;
            this.display_list.RowTemplate.Height = 24;
            this.display_list.Size = new System.Drawing.Size(1304, 150);
            this.display_list.TabIndex = 107;
            // 
            // dept_txt
            // 
            this.dept_txt.FormattingEnabled = true;
            this.dept_txt.Location = new System.Drawing.Point(733, 131);
            this.dept_txt.Name = "dept_txt";
            this.dept_txt.Size = new System.Drawing.Size(121, 20);
            this.dept_txt.TabIndex = 136;
            this.dept_txt.SelectedIndexChanged += new System.EventHandler(this.dept_txt_SelectedIndexChanged);
            // 
            // procurement_stock_book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 460);
            this.Controls.Add(this.dept_txt);
            this.Controls.Add(this.date_txt);
            this.Controls.Add(this.supplier_txt);
            this.Controls.Add(this.sh_supplier_btn);
            this.Controls.Add(this.stock_book_no_txt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.restart_btn);
            this.Controls.Add(this.car_no_txt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cust_name_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.time_txt);
            this.Controls.Add(this.invoice_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.book_name_txt);
            this.Controls.Add(this.Qty_txt);
            this.Controls.Add(this.snid_txt);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.display_list);
            this.Name = "procurement_stock_book";
            this.Text = "Procurement Stock Book";
            this.Load += new System.EventHandler(this.procurement_stock_book_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.display_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton defect_radio;
        private System.Windows.Forms.RadioButton normal_radio;
        private System.Windows.Forms.RadioButton in_radiio;
        private System.Windows.Forms.DateTimePicker date_txt;
        private System.Windows.Forms.ComboBox supplier_txt;
        private System.Windows.Forms.Button sh_supplier_btn;
        private System.Windows.Forms.TextBox stock_book_no_txt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton out_radio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button restart_btn;
        private System.Windows.Forms.TextBox car_no_txt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox cust_name_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox time_txt;
        private System.Windows.Forms.TextBox invoice_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox book_name_txt;
        private System.Windows.Forms.TextBox Qty_txt;
        private System.Windows.Forms.TextBox snid_txt;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.DataGridView display_list;
        private System.Windows.Forms.ComboBox dept_txt;
    }
}