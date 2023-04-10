
namespace FYP_sale_book_system
{
    partial class procurement_create_purchase_order
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
            this.close_btn = new System.Windows.Forms.Button();
            this.supplier_id_txt = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.company_name_txt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.c_address_txt = new System.Windows.Forms.TextBox();
            this.c_phone_txt = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.show_supplier_btn = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.restart_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.supplier_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.s_address_txt = new System.Windows.Forms.TextBox();
            this.s_phone_txt = new System.Windows.Forms.TextBox();
            this.remark_txt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.unit_price_txt = new System.Windows.Forms.TextBox();
            this.item_total_price_txt = new System.Windows.Forms.TextBox();
            this.create = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.qty_txt = new System.Windows.Forms.TextBox();
            this.book_name_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.po_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.location_id_txt = new System.Windows.Forms.ComboBox();
            this.date_txt = new System.Windows.Forms.DateTimePicker();
            this.note = new System.Windows.Forms.ListBox();
            this.snid_txt = new System.Windows.Forms.ComboBox();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // close_btn
            // 
            this.close_btn.Location = new System.Drawing.Point(688, 48);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(75, 23);
            this.close_btn.TabIndex = 36;
            this.close_btn.Text = "Close";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // supplier_id_txt
            // 
            this.supplier_id_txt.FormattingEnabled = true;
            this.supplier_id_txt.Location = new System.Drawing.Point(82, 21);
            this.supplier_id_txt.Name = "supplier_id_txt";
            this.supplier_id_txt.Size = new System.Drawing.Size(121, 20);
            this.supplier_id_txt.TabIndex = 32;
            this.supplier_id_txt.SelectedIndexChanged += new System.EventHandler(this.supplier_id_txt_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.company_name_txt);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.c_address_txt);
            this.groupBox3.Controls.Add(this.c_phone_txt);
            this.groupBox3.Location = new System.Drawing.Point(15, 369);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(898, 148);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ship To";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 12);
            this.label12.TabIndex = 20;
            this.label12.Text = "Company Name :";
            // 
            // company_name_txt
            // 
            this.company_name_txt.Location = new System.Drawing.Point(137, 15);
            this.company_name_txt.Name = "company_name_txt";
            this.company_name_txt.ReadOnly = true;
            this.company_name_txt.Size = new System.Drawing.Size(111, 22);
            this.company_name_txt.TabIndex = 19;
            this.company_name_txt.TextChanged += new System.EventHandler(this.company_name_txt_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 12);
            this.label11.TabIndex = 21;
            this.label11.Text = "Compary address :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 12);
            this.label10.TabIndex = 22;
            this.label10.Text = "Company phone no. :";
            // 
            // c_address_txt
            // 
            this.c_address_txt.Location = new System.Drawing.Point(150, 107);
            this.c_address_txt.Name = "c_address_txt";
            this.c_address_txt.ReadOnly = true;
            this.c_address_txt.Size = new System.Drawing.Size(687, 22);
            this.c_address_txt.TabIndex = 23;
            // 
            // c_phone_txt
            // 
            this.c_phone_txt.Location = new System.Drawing.Point(137, 58);
            this.c_phone_txt.Name = "c_phone_txt";
            this.c_phone_txt.ReadOnly = true;
            this.c_phone_txt.Size = new System.Drawing.Size(111, 22);
            this.c_phone_txt.TabIndex = 24;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.location_id_txt);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.supplier_id_txt);
            this.groupBox4.Controls.Add(this.show_supplier_btn);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Location = new System.Drawing.Point(23, 28);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(649, 52);
            this.groupBox4.TabIndex = 35;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search";
            // 
            // show_supplier_btn
            // 
            this.show_supplier_btn.Location = new System.Drawing.Point(473, 20);
            this.show_supplier_btn.Name = "show_supplier_btn";
            this.show_supplier_btn.Size = new System.Drawing.Size(154, 23);
            this.show_supplier_btn.TabIndex = 4;
            this.show_supplier_btn.Text = "Show Supplier Information ";
            this.show_supplier_btn.UseVisualStyleBackColor = true;
            this.show_supplier_btn.Click += new System.EventHandler(this.show_supplier_btn_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 12);
            this.label15.TabIndex = 29;
            this.label15.Text = "Supplier ID :";
            // 
            // restart_btn
            // 
            this.restart_btn.Location = new System.Drawing.Point(838, 33);
            this.restart_btn.Name = "restart_btn";
            this.restart_btn.Size = new System.Drawing.Size(75, 23);
            this.restart_btn.TabIndex = 3;
            this.restart_btn.Text = "Restart";
            this.restart_btn.UseVisualStyleBackColor = true;
            this.restart_btn.Click += new System.EventHandler(this.restart_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.supplier_txt);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.s_address_txt);
            this.groupBox2.Controls.Add(this.s_phone_txt);
            this.groupBox2.Location = new System.Drawing.Point(15, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(898, 128);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Purchase From";
            // 
            // supplier_txt
            // 
            this.supplier_txt.Location = new System.Drawing.Point(130, 15);
            this.supplier_txt.Name = "supplier_txt";
            this.supplier_txt.ReadOnly = true;
            this.supplier_txt.Size = new System.Drawing.Size(100, 22);
            this.supplier_txt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Supplier Name :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "Supplier address :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "Supplier phone no. :";
            // 
            // s_address_txt
            // 
            this.s_address_txt.Location = new System.Drawing.Point(130, 91);
            this.s_address_txt.Name = "s_address_txt";
            this.s_address_txt.ReadOnly = true;
            this.s_address_txt.Size = new System.Drawing.Size(687, 22);
            this.s_address_txt.TabIndex = 15;
            // 
            // s_phone_txt
            // 
            this.s_phone_txt.Location = new System.Drawing.Point(130, 54);
            this.s_phone_txt.Name = "s_phone_txt";
            this.s_phone_txt.ReadOnly = true;
            this.s_phone_txt.Size = new System.Drawing.Size(100, 22);
            this.s_phone_txt.TabIndex = 16;
            // 
            // remark_txt
            // 
            this.remark_txt.Location = new System.Drawing.Point(549, 184);
            this.remark_txt.Name = "remark_txt";
            this.remark_txt.Size = new System.Drawing.Size(100, 22);
            this.remark_txt.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(37, 187);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 12);
            this.label14.TabIndex = 28;
            this.label14.Text = "Item Total Price : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(37, 128);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 12);
            this.label13.TabIndex = 27;
            this.label13.Text = "Item Unit Price :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(471, 187);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 12);
            this.label16.TabIndex = 31;
            this.label16.Text = "Remark :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.snid_txt);
            this.groupBox1.Controls.Add(this.date_txt);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.restart_btn);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.remark_txt);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.unit_price_txt);
            this.groupBox1.Controls.Add(this.item_total_price_txt);
            this.groupBox1.Controls.Add(this.create);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.qty_txt);
            this.groupBox1.Controls.Add(this.book_name_txt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.po_txt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(941, 542);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Purchase order";
            // 
            // unit_price_txt
            // 
            this.unit_price_txt.Location = new System.Drawing.Point(131, 125);
            this.unit_price_txt.Name = "unit_price_txt";
            this.unit_price_txt.ReadOnly = true;
            this.unit_price_txt.Size = new System.Drawing.Size(100, 22);
            this.unit_price_txt.TabIndex = 26;
            // 
            // item_total_price_txt
            // 
            this.item_total_price_txt.Location = new System.Drawing.Point(131, 184);
            this.item_total_price_txt.Name = "item_total_price_txt";
            this.item_total_price_txt.ReadOnly = true;
            this.item_total_price_txt.Size = new System.Drawing.Size(100, 22);
            this.item_total_price_txt.TabIndex = 25;
            this.item_total_price_txt.TextChanged += new System.EventHandler(this.item_total_price_txt_TextChanged);
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(715, 33);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(75, 23);
            this.create.TabIndex = 12;
            this.create.Text = "Create";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(491, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "Qty :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "Book Name :";
            // 
            // qty_txt
            // 
            this.qty_txt.Location = new System.Drawing.Point(549, 83);
            this.qty_txt.Name = "qty_txt";
            this.qty_txt.Size = new System.Drawing.Size(100, 22);
            this.qty_txt.TabIndex = 9;
            this.qty_txt.TextChanged += new System.EventHandler(this.qty_txt_TextChanged);
            // 
            // book_name_txt
            // 
            this.book_name_txt.Location = new System.Drawing.Point(334, 83);
            this.book_name_txt.Name = "book_name_txt";
            this.book_name_txt.ReadOnly = true;
            this.book_name_txt.Size = new System.Drawing.Size(100, 22);
            this.book_name_txt.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "SNID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date :";
            // 
            // po_txt
            // 
            this.po_txt.Location = new System.Drawing.Point(131, 26);
            this.po_txt.Name = "po_txt";
            this.po_txt.ReadOnly = true;
            this.po_txt.Size = new System.Drawing.Size(100, 22);
            this.po_txt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "P.O. No :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 664);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1225, 195);
            this.dataGridView1.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(981, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 12);
            this.label9.TabIndex = 37;
            this.label9.Text = "Note";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label17.Location = new System.Drawing.Point(209, 26);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 12);
            this.label17.TabIndex = 25;
            this.label17.Text = "Company ID :";
            // 
            // location_id_txt
            // 
            this.location_id_txt.FormattingEnabled = true;
            this.location_id_txt.Location = new System.Drawing.Point(287, 20);
            this.location_id_txt.Name = "location_id_txt";
            this.location_id_txt.Size = new System.Drawing.Size(121, 20);
            this.location_id_txt.TabIndex = 33;
            this.location_id_txt.SelectedIndexChanged += new System.EventHandler(this.location_id_txt_SelectedIndexChanged);
            // 
            // date_txt
            // 
            this.date_txt.CustomFormat = "yy-MM-dd";
            this.date_txt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_txt.Location = new System.Drawing.Point(301, 23);
            this.date_txt.Name = "date_txt";
            this.date_txt.Size = new System.Drawing.Size(135, 22);
            this.date_txt.TabIndex = 167;
            // 
            // note
            // 
            this.note.ForeColor = System.Drawing.SystemColors.WindowText;
            this.note.FormattingEnabled = true;
            this.note.HorizontalScrollbar = true;
            this.note.ItemHeight = 12;
            this.note.Location = new System.Drawing.Point(769, 28);
            this.note.Name = "note";
            this.note.ScrollAlwaysVisible = true;
            this.note.Size = new System.Drawing.Size(471, 76);
            this.note.TabIndex = 38;
            // 
            // snid_txt
            // 
            this.snid_txt.FormattingEnabled = true;
            this.snid_txt.Location = new System.Drawing.Point(123, 83);
            this.snid_txt.Name = "snid_txt";
            this.snid_txt.Size = new System.Drawing.Size(121, 20);
            this.snid_txt.TabIndex = 168;
            this.snid_txt.SelectedIndexChanged += new System.EventHandler(this.snid_txt_SelectedIndexChanged);
            // 
            // procurement_create_purchase_order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 876);
            this.Controls.Add(this.note);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "procurement_create_purchase_order";
            this.Text = "Create Purchase Order";
            this.Load += new System.EventHandler(this.procurement_create_purchase_order_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.ComboBox supplier_id_txt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox company_name_txt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox c_address_txt;
        private System.Windows.Forms.TextBox c_phone_txt;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button show_supplier_btn;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button restart_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox supplier_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox s_address_txt;
        private System.Windows.Forms.TextBox s_phone_txt;
        private System.Windows.Forms.TextBox remark_txt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox unit_price_txt;
        private System.Windows.Forms.TextBox item_total_price_txt;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox qty_txt;
        private System.Windows.Forms.TextBox book_name_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox po_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox location_id_txt;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker date_txt;
        private System.Windows.Forms.ListBox note;
        private System.Windows.Forms.ComboBox snid_txt;
    }
}