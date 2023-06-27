
namespace FYP_sale_book_system
{
    partial class procurement_invoice_record
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
            this.close = new System.Windows.Forms.Button();
            this.supplier_txt = new System.Windows.Forms.ComboBox();
            this.snid_txt = new System.Windows.Forms.ComboBox();
            this.s_address1_txt = new System.Windows.Forms.TextBox();
            this.s_dept_txt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.restart_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.r_date_txt = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.complete_radio = new System.Windows.Forms.RadioButton();
            this.non_complete_radio = new System.Windows.Forms.RadioButton();
            this.remark_txt = new System.Windows.Forms.TextBox();
            this.qty_txt = new System.Windows.Forms.TextBox();
            this.item_name_txt = new System.Windows.Forms.TextBox();
            this.s_address_txt = new System.Windows.Forms.TextBox();
            this.s_phone_txt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.invoice_no_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.company_id_txt = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.supplier_id_txt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(1058, 36);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 89;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // supplier_txt
            // 
            this.supplier_txt.FormattingEnabled = true;
            this.supplier_txt.Location = new System.Drawing.Point(111, 256);
            this.supplier_txt.Name = "supplier_txt";
            this.supplier_txt.Size = new System.Drawing.Size(100, 20);
            this.supplier_txt.TabIndex = 87;
            this.supplier_txt.SelectedIndexChanged += new System.EventHandler(this.supplier_txt_SelectedIndexChanged);
            // 
            // snid_txt
            // 
            this.snid_txt.FormattingEnabled = true;
            this.snid_txt.Location = new System.Drawing.Point(76, 107);
            this.snid_txt.Name = "snid_txt";
            this.snid_txt.Size = new System.Drawing.Size(121, 20);
            this.snid_txt.TabIndex = 86;
            this.snid_txt.SelectedIndexChanged += new System.EventHandler(this.snid_txt_SelectedIndexChanged);
            // 
            // s_address1_txt
            // 
            this.s_address1_txt.Location = new System.Drawing.Point(111, 346);
            this.s_address1_txt.Name = "s_address1_txt";
            this.s_address1_txt.ReadOnly = true;
            this.s_address1_txt.Size = new System.Drawing.Size(478, 22);
            this.s_address1_txt.TabIndex = 84;
            // 
            // s_dept_txt
            // 
            this.s_dept_txt.Location = new System.Drawing.Point(538, 256);
            this.s_dept_txt.Name = "s_dept_txt";
            this.s_dept_txt.ReadOnly = true;
            this.s_dept_txt.Size = new System.Drawing.Size(100, 22);
            this.s_dept_txt.TabIndex = 83;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(425, 259);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 12);
            this.label11.TabIndex = 82;
            this.label11.Text = "Supplier Department :";
            // 
            // restart_btn
            // 
            this.restart_btn.Location = new System.Drawing.Point(889, 179);
            this.restart_btn.Name = "restart_btn";
            this.restart_btn.Size = new System.Drawing.Size(75, 23);
            this.restart_btn.TabIndex = 81;
            this.restart_btn.Text = "Restart";
            this.restart_btn.UseVisualStyleBackColor = true;
            this.restart_btn.Click += new System.EventHandler(this.restart_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(743, 179);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 23);
            this.save_btn.TabIndex = 80;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 491);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1195, 150);
            this.dataGridView1.TabIndex = 79;
            // 
            // r_date_txt
            // 
            this.r_date_txt.CustomFormat = "yy-MM-dd";
            this.r_date_txt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.r_date_txt.Location = new System.Drawing.Point(316, 54);
            this.r_date_txt.Name = "r_date_txt";
            this.r_date_txt.Size = new System.Drawing.Size(100, 22);
            this.r_date_txt.TabIndex = 90;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.complete_radio);
            this.groupBox1.Controls.Add(this.non_complete_radio);
            this.groupBox1.Location = new System.Drawing.Point(699, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 100);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Receive Status";
            // 
            // complete_radio
            // 
            this.complete_radio.AutoSize = true;
            this.complete_radio.Location = new System.Drawing.Point(12, 52);
            this.complete_radio.Name = "complete_radio";
            this.complete_radio.Size = new System.Drawing.Size(68, 16);
            this.complete_radio.TabIndex = 1;
            this.complete_radio.TabStop = true;
            this.complete_radio.Text = "Complete";
            this.complete_radio.UseVisualStyleBackColor = true;
            this.complete_radio.CheckedChanged += new System.EventHandler(this.complete_radio_CheckedChanged);
            // 
            // non_complete_radio
            // 
            this.non_complete_radio.AutoSize = true;
            this.non_complete_radio.Location = new System.Drawing.Point(134, 52);
            this.non_complete_radio.Name = "non_complete_radio";
            this.non_complete_radio.Size = new System.Drawing.Size(92, 16);
            this.non_complete_radio.TabIndex = 0;
            this.non_complete_radio.TabStop = true;
            this.non_complete_radio.Text = "Non-Complete";
            this.non_complete_radio.UseVisualStyleBackColor = true;
            this.non_complete_radio.CheckedChanged += new System.EventHandler(this.non_complete_radio_CheckedChanged);
            // 
            // remark_txt
            // 
            this.remark_txt.Location = new System.Drawing.Point(76, 176);
            this.remark_txt.Name = "remark_txt";
            this.remark_txt.Size = new System.Drawing.Size(509, 22);
            this.remark_txt.TabIndex = 77;
            // 
            // qty_txt
            // 
            this.qty_txt.Location = new System.Drawing.Point(485, 110);
            this.qty_txt.Name = "qty_txt";
            this.qty_txt.Size = new System.Drawing.Size(100, 22);
            this.qty_txt.TabIndex = 76;
            // 
            // item_name_txt
            // 
            this.item_name_txt.Location = new System.Drawing.Point(285, 110);
            this.item_name_txt.Name = "item_name_txt";
            this.item_name_txt.ReadOnly = true;
            this.item_name_txt.Size = new System.Drawing.Size(100, 22);
            this.item_name_txt.TabIndex = 75;
            // 
            // s_address_txt
            // 
            this.s_address_txt.Location = new System.Drawing.Point(108, 293);
            this.s_address_txt.Name = "s_address_txt";
            this.s_address_txt.ReadOnly = true;
            this.s_address_txt.Size = new System.Drawing.Size(478, 22);
            this.s_address_txt.TabIndex = 74;
            // 
            // s_phone_txt
            // 
            this.s_phone_txt.Location = new System.Drawing.Point(316, 255);
            this.s_phone_txt.Name = "s_phone_txt";
            this.s_phone_txt.ReadOnly = true;
            this.s_phone_txt.Size = new System.Drawing.Size(100, 22);
            this.s_phone_txt.TabIndex = 73;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 12);
            this.label9.TabIndex = 72;
            this.label9.Text = "Remark :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(423, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 12);
            this.label8.TabIndex = 71;
            this.label8.Text = "Qty :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(207, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 12);
            this.label7.TabIndex = 70;
            this.label7.Text = "Book Name :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 12);
            this.label6.TabIndex = 69;
            this.label6.Text = "SNID :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 12);
            this.label5.TabIndex = 68;
            this.label5.Text = "Receive Date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 12);
            this.label4.TabIndex = 67;
            this.label4.Text = "Supplier Address :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 12);
            this.label3.TabIndex = 66;
            this.label3.Text = "Supplier Phone :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 12);
            this.label2.TabIndex = 65;
            this.label2.Text = "Supplier Name :";
            // 
            // invoice_no_txt
            // 
            this.invoice_no_txt.Location = new System.Drawing.Point(111, 54);
            this.invoice_no_txt.Name = "invoice_no_txt";
            this.invoice_no_txt.Size = new System.Drawing.Size(100, 22);
            this.invoice_no_txt.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 12);
            this.label1.TabIndex = 63;
            this.label1.Text = "Invoice No :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(664, 278);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 12);
            this.label12.TabIndex = 92;
            this.label12.Text = "Supplier Information";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 466);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 12);
            this.label13.TabIndex = 93;
            this.label13.Text = "Invoice Information";
            // 
            // company_id_txt
            // 
            this.company_id_txt.FormattingEnabled = true;
            this.company_id_txt.Location = new System.Drawing.Point(503, 54);
            this.company_id_txt.Name = "company_id_txt";
            this.company_id_txt.Size = new System.Drawing.Size(121, 20);
            this.company_id_txt.TabIndex = 94;
            this.company_id_txt.SelectedIndexChanged += new System.EventHandler(this.company_id_txt_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(439, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 12);
            this.label14.TabIndex = 95;
            this.label14.Text = "Company";
            // 
            // supplier_id_txt
            // 
            this.supplier_id_txt.Location = new System.Drawing.Point(111, 217);
            this.supplier_id_txt.Name = "supplier_id_txt";
            this.supplier_id_txt.ReadOnly = true;
            this.supplier_id_txt.Size = new System.Drawing.Size(100, 22);
            this.supplier_id_txt.TabIndex = 96;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 220);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 12);
            this.label15.TabIndex = 97;
            this.label15.Text = "Supplier ID :";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(616, 293);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(593, 150);
            this.dataGridView2.TabIndex = 98;
            // 
            // procurement_invoice_record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 657);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.supplier_id_txt);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.company_id_txt);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.close);
            this.Controls.Add(this.supplier_txt);
            this.Controls.Add(this.snid_txt);
            this.Controls.Add(this.s_address1_txt);
            this.Controls.Add(this.s_dept_txt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.restart_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.r_date_txt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.remark_txt);
            this.Controls.Add(this.qty_txt);
            this.Controls.Add(this.item_name_txt);
            this.Controls.Add(this.s_address_txt);
            this.Controls.Add(this.s_phone_txt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.invoice_no_txt);
            this.Controls.Add(this.label1);
            this.Name = "procurement_invoice_record";
            this.Text = "Invoice Record";
            this.Load += new System.EventHandler(this.procurement_invoice_record_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.ComboBox supplier_txt;
        private System.Windows.Forms.ComboBox snid_txt;
        private System.Windows.Forms.TextBox s_address1_txt;
        private System.Windows.Forms.TextBox s_dept_txt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button restart_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker r_date_txt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton complete_radio;
        private System.Windows.Forms.RadioButton non_complete_radio;
        private System.Windows.Forms.TextBox remark_txt;
        private System.Windows.Forms.TextBox qty_txt;
        private System.Windows.Forms.TextBox item_name_txt;
        private System.Windows.Forms.TextBox s_address_txt;
        private System.Windows.Forms.TextBox s_phone_txt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox invoice_no_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox company_id_txt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox supplier_id_txt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}