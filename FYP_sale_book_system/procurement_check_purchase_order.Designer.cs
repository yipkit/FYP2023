
namespace FYP_sale_book_system
{
    partial class procurement_check_purchase_order
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
            this.po_txt = new System.Windows.Forms.ComboBox();
            this.close_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.total_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.company_name_txt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.c_address_txt = new System.Windows.Forms.TextBox();
            this.c_phone_txt = new System.Windows.Forms.TextBox();
            this.s_phone_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.supplier_txt = new System.Windows.Forms.TextBox();
            this.enter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.s_address_txt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // po_txt
            // 
            this.po_txt.FormattingEnabled = true;
            this.po_txt.Location = new System.Drawing.Point(117, 24);
            this.po_txt.Name = "po_txt";
            this.po_txt.Size = new System.Drawing.Size(121, 20);
            this.po_txt.TabIndex = 52;
            this.po_txt.SelectedIndexChanged += new System.EventHandler(this.po_txt_SelectedIndexChanged);
            // 
            // close_btn
            // 
            this.close_btn.Location = new System.Drawing.Point(406, 21);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(75, 23);
            this.close_btn.TabIndex = 51;
            this.close_btn.Text = "Close";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(325, 21);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(75, 23);
            this.clear_btn.TabIndex = 50;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(869, 68);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(309, 150);
            this.dataGridView2.TabIndex = 49;
            // 
            // total_txt
            // 
            this.total_txt.Location = new System.Drawing.Point(538, 632);
            this.total_txt.Name = "total_txt";
            this.total_txt.ReadOnly = true;
            this.total_txt.Size = new System.Drawing.Size(100, 22);
            this.total_txt.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(463, 635);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 12);
            this.label3.TabIndex = 47;
            this.label3.Text = "Total Price :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.company_name_txt);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.c_address_txt);
            this.groupBox3.Controls.Add(this.c_phone_txt);
            this.groupBox3.Location = new System.Drawing.Point(12, 213);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(835, 148);
            this.groupBox3.TabIndex = 46;
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
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 110);
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
            this.c_address_txt.Location = new System.Drawing.Point(137, 107);
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
            // s_phone_txt
            // 
            this.s_phone_txt.Location = new System.Drawing.Point(130, 54);
            this.s_phone_txt.Name = "s_phone_txt";
            this.s_phone_txt.ReadOnly = true;
            this.s_phone_txt.Size = new System.Drawing.Size(100, 22);
            this.s_phone_txt.TabIndex = 16;
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
            // supplier_txt
            // 
            this.supplier_txt.Location = new System.Drawing.Point(130, 15);
            this.supplier_txt.Name = "supplier_txt";
            this.supplier_txt.ReadOnly = true;
            this.supplier_txt.Size = new System.Drawing.Size(100, 22);
            this.supplier_txt.TabIndex = 2;
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(244, 22);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(75, 23);
            this.enter.TabIndex = 44;
            this.enter.Text = "Enter";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 12);
            this.label1.TabIndex = 43;
            this.label1.Text = "Purchase Order No :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 378);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(626, 231);
            this.dataGridView1.TabIndex = 42;
            // 
            // s_address_txt
            // 
            this.s_address_txt.Location = new System.Drawing.Point(130, 91);
            this.s_address_txt.Name = "s_address_txt";
            this.s_address_txt.ReadOnly = true;
            this.s_address_txt.Size = new System.Drawing.Size(687, 22);
            this.s_address_txt.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.supplier_txt);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.s_address_txt);
            this.groupBox2.Controls.Add(this.s_phone_txt);
            this.groupBox2.Location = new System.Drawing.Point(12, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(835, 128);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Purchase From";
            // 
            // procurement_check_purchase_order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 720);
            this.Controls.Add(this.po_txt);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.total_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Name = "procurement_check_purchase_order";
            this.Text = "Check Purchase Order";
            this.Load += new System.EventHandler(this.procurement_check_purchase_order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox po_txt;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox total_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox company_name_txt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox c_address_txt;
        private System.Windows.Forms.TextBox c_phone_txt;
        private System.Windows.Forms.TextBox s_phone_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox supplier_txt;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox s_address_txt;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}