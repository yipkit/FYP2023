
namespace FYP_sale_book_system
{
    partial class sales_re_order
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
            this.label8 = new System.Windows.Forms.Label();
            this.snid1_txt = new System.Windows.Forms.ComboBox();
            this.location_txt = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.date_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.re_order_no_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.item_name_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.snid_label = new System.Windows.Forms.Label();
            this.item_qty_txt = new System.Windows.Forms.TextBox();
            this.qty_label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.snid_txt = new System.Windows.Forms.ComboBox();
            this.location_id_txt = new System.Windows.Forms.ComboBox();
            this.note = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.re_order_list = new System.Windows.Forms.ListBox();
            this.add_item = new System.Windows.Forms.Button();
            this.restart_btn = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(434, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 12);
            this.label8.TabIndex = 44;
            this.label8.Text = "Note";
            // 
            // snid1_txt
            // 
            this.snid1_txt.FormattingEnabled = true;
            this.snid1_txt.Location = new System.Drawing.Point(84, 97);
            this.snid1_txt.Name = "snid1_txt";
            this.snid1_txt.Size = new System.Drawing.Size(121, 20);
            this.snid1_txt.TabIndex = 34;
            this.snid1_txt.SelectedIndexChanged += new System.EventHandler(this.snid1_txt_SelectedIndexChanged);
            // 
            // location_txt
            // 
            this.location_txt.FormattingEnabled = true;
            this.location_txt.Location = new System.Drawing.Point(554, 31);
            this.location_txt.Name = "location_txt";
            this.location_txt.Size = new System.Drawing.Size(121, 20);
            this.location_txt.TabIndex = 33;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.snid1_txt);
            this.groupBox2.Controls.Add(this.location_txt);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.date_txt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.re_order_no_txt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.item_name_txt);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.snid_label);
            this.groupBox2.Controls.Add(this.item_qty_txt);
            this.groupBox2.Controls.Add(this.qty_label);
            this.groupBox2.Location = new System.Drawing.Point(12, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(705, 130);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 12);
            this.label2.TabIndex = 21;
            this.label2.Text = "Order date :";
            // 
            // date_txt
            // 
            this.date_txt.Location = new System.Drawing.Point(332, 27);
            this.date_txt.Name = "date_txt";
            this.date_txt.ReadOnly = true;
            this.date_txt.Size = new System.Drawing.Size(100, 22);
            this.date_txt.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 12);
            this.label5.TabIndex = 24;
            this.label5.Text = "Re-order No :";
            // 
            // re_order_no_txt
            // 
            this.re_order_no_txt.Location = new System.Drawing.Point(93, 24);
            this.re_order_no_txt.Name = "re_order_no_txt";
            this.re_order_no_txt.ReadOnly = true;
            this.re_order_no_txt.Size = new System.Drawing.Size(100, 22);
            this.re_order_no_txt.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(466, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 12);
            this.label3.TabIndex = 22;
            this.label3.Text = "Location ID :";
            // 
            // item_name_txt
            // 
            this.item_name_txt.Location = new System.Drawing.Point(332, 93);
            this.item_name_txt.Name = "item_name_txt";
            this.item_name_txt.ReadOnly = true;
            this.item_name_txt.Size = new System.Drawing.Size(100, 22);
            this.item_name_txt.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "Item name :";
            // 
            // snid_label
            // 
            this.snid_label.AutoSize = true;
            this.snid_label.Location = new System.Drawing.Point(17, 100);
            this.snid_label.Name = "snid_label";
            this.snid_label.Size = new System.Drawing.Size(37, 12);
            this.snid_label.TabIndex = 4;
            this.snid_label.Text = "SNID :";
            // 
            // item_qty_txt
            // 
            this.item_qty_txt.Location = new System.Drawing.Point(554, 90);
            this.item_qty_txt.Name = "item_qty_txt";
            this.item_qty_txt.Size = new System.Drawing.Size(100, 22);
            this.item_qty_txt.TabIndex = 3;
            // 
            // qty_label
            // 
            this.qty_label.AutoSize = true;
            this.qty_label.Location = new System.Drawing.Point(504, 96);
            this.qty_label.Name = "qty_label";
            this.qty_label.Size = new System.Drawing.Size(31, 12);
            this.qty_label.TabIndex = 5;
            this.qty_label.Text = "Qty : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(199, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 12);
            this.label6.TabIndex = 32;
            this.label6.Text = "Location ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 12);
            this.label4.TabIndex = 31;
            this.label4.Text = "SNID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.search_btn);
            this.groupBox1.Controls.Add(this.snid_txt);
            this.groupBox1.Controls.Add(this.location_id_txt);
            this.groupBox1.Location = new System.Drawing.Point(12, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 76);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Low Stock Item";
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(319, 47);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 30;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // snid_txt
            // 
            this.snid_txt.FormattingEnabled = true;
            this.snid_txt.Location = new System.Drawing.Point(19, 50);
            this.snid_txt.Name = "snid_txt";
            this.snid_txt.Size = new System.Drawing.Size(121, 20);
            this.snid_txt.TabIndex = 28;
            // 
            // location_id_txt
            // 
            this.location_id_txt.FormattingEnabled = true;
            this.location_id_txt.Location = new System.Drawing.Point(162, 50);
            this.location_id_txt.Name = "location_id_txt";
            this.location_id_txt.Size = new System.Drawing.Size(121, 20);
            this.location_id_txt.TabIndex = 29;
            // 
            // note
            // 
            this.note.FormattingEnabled = true;
            this.note.ItemHeight = 12;
            this.note.Location = new System.Drawing.Point(433, 274);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(568, 124);
            this.note.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 12);
            this.label7.TabIndex = 43;
            this.label7.Text = "Re-Order List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 423);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(911, 150);
            this.dataGridView1.TabIndex = 38;
            // 
            // re_order_list
            // 
            this.re_order_list.FormattingEnabled = true;
            this.re_order_list.ItemHeight = 12;
            this.re_order_list.Location = new System.Drawing.Point(2, 274);
            this.re_order_list.Name = "re_order_list";
            this.re_order_list.Size = new System.Drawing.Size(392, 124);
            this.re_order_list.TabIndex = 37;
            // 
            // add_item
            // 
            this.add_item.Location = new System.Drawing.Point(750, 83);
            this.add_item.Name = "add_item";
            this.add_item.Size = new System.Drawing.Size(75, 23);
            this.add_item.TabIndex = 36;
            this.add_item.Text = "Create";
            this.add_item.UseVisualStyleBackColor = true;
            this.add_item.Click += new System.EventHandler(this.add_item_Click);
            // 
            // restart_btn
            // 
            this.restart_btn.Location = new System.Drawing.Point(750, 128);
            this.restart_btn.Name = "restart_btn";
            this.restart_btn.Size = new System.Drawing.Size(75, 23);
            this.restart_btn.TabIndex = 39;
            this.restart_btn.Text = "Refresh Data";
            this.restart_btn.UseVisualStyleBackColor = true;
            this.restart_btn.Click += new System.EventHandler(this.restart_btn_Click);
            // 
            // close
            // 
            this.close.Font = new System.Drawing.Font("新細明體", 12F);
            this.close.Location = new System.Drawing.Point(926, 40);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 35;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // sales_re_order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 600);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.note);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.re_order_list);
            this.Controls.Add(this.add_item);
            this.Controls.Add(this.restart_btn);
            this.Controls.Add(this.close);
            this.Name = "sales_re_order";
            this.Text = "Re Order";
            this.Load += new System.EventHandler(this.sales_re_order_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox snid1_txt;
        private System.Windows.Forms.ComboBox location_txt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox date_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox re_order_no_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox item_name_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label snid_label;
        private System.Windows.Forms.TextBox item_qty_txt;
        private System.Windows.Forms.Label qty_label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.ComboBox snid_txt;
        private System.Windows.Forms.ComboBox location_id_txt;
        private System.Windows.Forms.ListBox note;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox re_order_list;
        private System.Windows.Forms.Button add_item;
        private System.Windows.Forms.Button restart_btn;
        private System.Windows.Forms.Button close;
    }
}