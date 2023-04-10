
namespace FYP_sale_book_system
{
    partial class procurement_update_stock
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
            this.supplier_txt = new System.Windows.Forms.ComboBox();
            this.address_txt = new System.Windows.Forms.TextBox();
            this.phone_txt = new System.Windows.Forms.TextBox();
            this.phone_no_txt = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.snid1_txt = new System.Windows.Forms.ComboBox();
            this.search = new System.Windows.Forms.Button();
            this.show_supplier = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.Button();
            this.snid_txt = new System.Windows.Forms.ComboBox();
            this.date_txt = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.show_authors = new System.Windows.Forms.Button();
            this.show_stock_bk = new System.Windows.Forms.Button();
            this.sh_procure_stoc = new System.Windows.Forms.Button();
            this.delivery_note_btn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.car_no_txt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dept_txt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.out_radio = new System.Windows.Forms.RadioButton();
            this.in_radiio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.defect_radio = new System.Windows.Forms.RadioButton();
            this.normal_radio = new System.Windows.Forms.RadioButton();
            this.remark_txt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cust_name_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.invoice_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.update_btn = new System.Windows.Forms.Button();
            this.restart_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.time_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.item_name_txt = new System.Windows.Forms.TextBox();
            this.Qty_txt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.invoice_btn = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // supplier_txt
            // 
            this.supplier_txt.FormattingEnabled = true;
            this.supplier_txt.Location = new System.Drawing.Point(92, 31);
            this.supplier_txt.Name = "supplier_txt";
            this.supplier_txt.Size = new System.Drawing.Size(121, 20);
            this.supplier_txt.TabIndex = 137;
            this.supplier_txt.SelectedIndexChanged += new System.EventHandler(this.supplier_txt_SelectedIndexChanged);
            // 
            // address_txt
            // 
            this.address_txt.Location = new System.Drawing.Point(83, 84);
            this.address_txt.Name = "address_txt";
            this.address_txt.ReadOnly = true;
            this.address_txt.Size = new System.Drawing.Size(487, 22);
            this.address_txt.TabIndex = 134;
            // 
            // phone_txt
            // 
            this.phone_txt.Location = new System.Drawing.Point(470, 31);
            this.phone_txt.Name = "phone_txt";
            this.phone_txt.ReadOnly = true;
            this.phone_txt.Size = new System.Drawing.Size(100, 22);
            this.phone_txt.TabIndex = 136;
            // 
            // phone_no_txt
            // 
            this.phone_no_txt.AutoSize = true;
            this.phone_no_txt.Location = new System.Drawing.Point(407, 34);
            this.phone_no_txt.Name = "phone_no_txt";
            this.phone_no_txt.Size = new System.Drawing.Size(57, 12);
            this.phone_no_txt.TabIndex = 135;
            this.phone_no_txt.Text = "Phone No :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(49, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 12);
            this.label12.TabIndex = 6;
            this.label12.Text = "SNID";
            // 
            // snid1_txt
            // 
            this.snid1_txt.FormattingEnabled = true;
            this.snid1_txt.Location = new System.Drawing.Point(6, 46);
            this.snid1_txt.Name = "snid1_txt";
            this.snid1_txt.Size = new System.Drawing.Size(121, 20);
            this.snid1_txt.TabIndex = 5;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(133, 44);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 4;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // show_supplier
            // 
            this.show_supplier.Location = new System.Drawing.Point(601, 46);
            this.show_supplier.Name = "show_supplier";
            this.show_supplier.Size = new System.Drawing.Size(96, 23);
            this.show_supplier.TabIndex = 3;
            this.show_supplier.Text = "Show Supplier";
            this.show_supplier.UseVisualStyleBackColor = true;
            this.show_supplier.Click += new System.EventHandler(this.show_supplier_Click);
            // 
            // close_btn
            // 
            this.close_btn.Location = new System.Drawing.Point(1129, 8);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(75, 23);
            this.close_btn.TabIndex = 168;
            this.close_btn.Text = "Close";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // snid_txt
            // 
            this.snid_txt.FormattingEnabled = true;
            this.snid_txt.Location = new System.Drawing.Point(114, 229);
            this.snid_txt.Name = "snid_txt";
            this.snid_txt.Size = new System.Drawing.Size(121, 20);
            this.snid_txt.TabIndex = 167;
            this.snid_txt.SelectedIndexChanged += new System.EventHandler(this.snid_txt_SelectedIndexChanged);
            // 
            // date_txt
            // 
            this.date_txt.CustomFormat = "yy-MM-dd";
            this.date_txt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_txt.Location = new System.Drawing.Point(320, 159);
            this.date_txt.Name = "date_txt";
            this.date_txt.Size = new System.Drawing.Size(135, 22);
            this.date_txt.TabIndex = 166;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.snid1_txt);
            this.groupBox4.Controls.Add(this.search);
            this.groupBox4.Controls.Add(this.show_supplier);
            this.groupBox4.Controls.Add(this.show_authors);
            this.groupBox4.Controls.Add(this.show_stock_bk);
            this.groupBox4.Controls.Add(this.sh_procure_stoc);
            this.groupBox4.Location = new System.Drawing.Point(38, 283);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(711, 83);
            this.groupBox4.TabIndex = 165;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search";
            // 
            // show_authors
            // 
            this.show_authors.Location = new System.Drawing.Point(494, 46);
            this.show_authors.Name = "show_authors";
            this.show_authors.Size = new System.Drawing.Size(101, 23);
            this.show_authors.TabIndex = 2;
            this.show_authors.Text = "Show Authors";
            this.show_authors.UseVisualStyleBackColor = true;
            this.show_authors.Click += new System.EventHandler(this.show_authors_Click);
            // 
            // show_stock_bk
            // 
            this.show_stock_bk.Location = new System.Drawing.Point(379, 46);
            this.show_stock_bk.Name = "show_stock_bk";
            this.show_stock_bk.Size = new System.Drawing.Size(106, 23);
            this.show_stock_bk.TabIndex = 1;
            this.show_stock_bk.Text = "Show Stock Book";
            this.show_stock_bk.UseVisualStyleBackColor = true;
            this.show_stock_bk.Click += new System.EventHandler(this.show_stock_bk_Click);
            // 
            // sh_procure_stoc
            // 
            this.sh_procure_stoc.Location = new System.Drawing.Point(214, 46);
            this.sh_procure_stoc.Name = "sh_procure_stoc";
            this.sh_procure_stoc.Size = new System.Drawing.Size(159, 23);
            this.sh_procure_stoc.TabIndex = 0;
            this.sh_procure_stoc.Text = "Show Procurement Stock";
            this.sh_procure_stoc.UseVisualStyleBackColor = true;
            this.sh_procure_stoc.Click += new System.EventHandler(this.sh_procure_stoc_Click);
            // 
            // delivery_note_btn
            // 
            this.delivery_note_btn.Location = new System.Drawing.Point(957, 283);
            this.delivery_note_btn.Name = "delivery_note_btn";
            this.delivery_note_btn.Size = new System.Drawing.Size(103, 23);
            this.delivery_note_btn.TabIndex = 164;
            this.delivery_note_btn.Text = "Delivery Note";
            this.delivery_note_btn.UseVisualStyleBackColor = true;
            this.delivery_note_btn.Click += new System.EventHandler(this.delivery_note_btn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.supplier_txt);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.address_txt);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.phone_txt);
            this.groupBox3.Controls.Add(this.phone_no_txt);
            this.groupBox3.Controls.Add(this.car_no_txt);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.dept_txt);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(47, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(864, 117);
            this.groupBox3.TabIndex = 163;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Supplier Information";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 12);
            this.label8.TabIndex = 117;
            this.label8.Text = "Supplier Name :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 87);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 12);
            this.label14.TabIndex = 133;
            this.label14.Text = "Address :";
            // 
            // car_no_txt
            // 
            this.car_no_txt.Location = new System.Drawing.Point(287, 34);
            this.car_no_txt.Name = "car_no_txt";
            this.car_no_txt.Size = new System.Drawing.Size(100, 22);
            this.car_no_txt.TabIndex = 120;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(221, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 12);
            this.label9.TabIndex = 118;
            this.label9.Text = "Car No :";
            // 
            // dept_txt
            // 
            this.dept_txt.Location = new System.Drawing.Point(698, 31);
            this.dept_txt.Name = "dept_txt";
            this.dept_txt.ReadOnly = true;
            this.dept_txt.Size = new System.Drawing.Size(100, 22);
            this.dept_txt.TabIndex = 123;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(605, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 12);
            this.label10.TabIndex = 122;
            this.label10.Text = "Department : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.out_radio);
            this.groupBox2.Controls.Add(this.in_radiio);
            this.groupBox2.Location = new System.Drawing.Point(934, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 91);
            this.groupBox2.TabIndex = 162;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.defect_radio);
            this.groupBox1.Controls.Add(this.normal_radio);
            this.groupBox1.Location = new System.Drawing.Point(934, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 72);
            this.groupBox1.TabIndex = 161;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock Type";
            // 
            // defect_radio
            // 
            this.defect_radio.AutoSize = true;
            this.defect_radio.Location = new System.Drawing.Point(131, 33);
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
            this.normal_radio.Location = new System.Drawing.Point(23, 33);
            this.normal_radio.Name = "normal_radio";
            this.normal_radio.Size = new System.Drawing.Size(58, 16);
            this.normal_radio.TabIndex = 0;
            this.normal_radio.TabStop = true;
            this.normal_radio.Text = "Normal";
            this.normal_radio.UseVisualStyleBackColor = true;
            this.normal_radio.CheckedChanged += new System.EventHandler(this.normal_radio_CheckedChanged);
            // 
            // remark_txt
            // 
            this.remark_txt.Location = new System.Drawing.Point(787, 231);
            this.remark_txt.Name = "remark_txt";
            this.remark_txt.Size = new System.Drawing.Size(100, 22);
            this.remark_txt.TabIndex = 160;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(701, 239);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 12);
            this.label15.TabIndex = 159;
            this.label15.Text = "Remark :";
            // 
            // cust_name_txt
            // 
            this.cust_name_txt.Location = new System.Drawing.Point(783, 160);
            this.cust_name_txt.Name = "cust_name_txt";
            this.cust_name_txt.ReadOnly = true;
            this.cust_name_txt.Size = new System.Drawing.Size(100, 22);
            this.cust_name_txt.TabIndex = 157;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(485, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 155;
            this.label6.Text = "Time :";
            // 
            // invoice_txt
            // 
            this.invoice_txt.Location = new System.Drawing.Point(124, 164);
            this.invoice_txt.Name = "invoice_txt";
            this.invoice_txt.Size = new System.Drawing.Size(121, 22);
            this.invoice_txt.TabIndex = 153;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 12);
            this.label5.TabIndex = 152;
            this.label5.Text = "Invoice No :";
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(957, 239);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(96, 23);
            this.update_btn.TabIndex = 151;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // restart_btn
            // 
            this.restart_btn.Location = new System.Drawing.Point(1080, 239);
            this.restart_btn.Name = "restart_btn";
            this.restart_btn.Size = new System.Drawing.Size(75, 23);
            this.restart_btn.TabIndex = 158;
            this.restart_btn.Text = "Restart";
            this.restart_btn.UseVisualStyleBackColor = true;
            this.restart_btn.Click += new System.EventHandler(this.restart_btn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(681, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 12);
            this.label7.TabIndex = 156;
            this.label7.Text = "Customer Name :";
            // 
            // time_txt
            // 
            this.time_txt.Location = new System.Drawing.Point(532, 161);
            this.time_txt.Name = "time_txt";
            this.time_txt.ReadOnly = true;
            this.time_txt.Size = new System.Drawing.Size(121, 22);
            this.time_txt.TabIndex = 154;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 145;
            this.label1.Text = "SNID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 12);
            this.label4.TabIndex = 150;
            this.label4.Text = "Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 12);
            this.label3.TabIndex = 149;
            this.label3.Text = "Qty :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 12);
            this.label2.TabIndex = 148;
            this.label2.Text = "Item name :";
            // 
            // item_name_txt
            // 
            this.item_name_txt.Location = new System.Drawing.Point(334, 230);
            this.item_name_txt.Name = "item_name_txt";
            this.item_name_txt.ReadOnly = true;
            this.item_name_txt.Size = new System.Drawing.Size(121, 22);
            this.item_name_txt.TabIndex = 147;
            // 
            // Qty_txt
            // 
            this.Qty_txt.Location = new System.Drawing.Point(532, 229);
            this.Qty_txt.Name = "Qty_txt";
            this.Qty_txt.Size = new System.Drawing.Size(121, 22);
            this.Qty_txt.TabIndex = 146;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 381);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1165, 150);
            this.dataGridView1.TabIndex = 144;
            // 
            // invoice_btn
            // 
            this.invoice_btn.Location = new System.Drawing.Point(957, 327);
            this.invoice_btn.Name = "invoice_btn";
            this.invoice_btn.Size = new System.Drawing.Size(103, 23);
            this.invoice_btn.TabIndex = 169;
            this.invoice_btn.Text = "Invoice";
            this.invoice_btn.UseVisualStyleBackColor = true;
            this.invoice_btn.Click += new System.EventHandler(this.invoice_btn_Click);
            // 
            // procurement_update_stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 555);
            this.Controls.Add(this.invoice_btn);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.snid_txt);
            this.Controls.Add(this.date_txt);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.delivery_note_btn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.remark_txt);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cust_name_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.invoice_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.restart_btn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.time_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.item_name_txt);
            this.Controls.Add(this.Qty_txt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "procurement_update_stock";
            this.Text = "Update Stock";
            this.Load += new System.EventHandler(this.procurement_update_stock_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox supplier_txt;
        private System.Windows.Forms.TextBox address_txt;
        private System.Windows.Forms.TextBox phone_txt;
        private System.Windows.Forms.Label phone_no_txt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox snid1_txt;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button show_supplier;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.ComboBox snid_txt;
        private System.Windows.Forms.DateTimePicker date_txt;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button show_authors;
        private System.Windows.Forms.Button show_stock_bk;
        private System.Windows.Forms.Button sh_procure_stoc;
        private System.Windows.Forms.Button delivery_note_btn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox car_no_txt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox dept_txt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton out_radio;
        private System.Windows.Forms.RadioButton in_radiio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton defect_radio;
        private System.Windows.Forms.RadioButton normal_radio;
        private System.Windows.Forms.TextBox remark_txt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox cust_name_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox invoice_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button restart_btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox time_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox item_name_txt;
        private System.Windows.Forms.TextBox Qty_txt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button invoice_btn;
    }
}