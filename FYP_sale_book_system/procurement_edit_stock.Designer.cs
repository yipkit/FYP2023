
namespace FYP_sale_book_system
{
    partial class procurement_edit_stock
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
            this.sale_radioBtn = new System.Windows.Forms.RadioButton();
            this.procure_radioBtn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.update_btn = new System.Windows.Forms.Button();
            this.snid_txt = new System.Windows.Forms.ComboBox();
            this.stock_lv_txt = new System.Windows.Forms.TextBox();
            this.location_id_txt = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.stock_lv_radioBtn = new System.Windows.Forms.RadioButton();
            this.unit_price_radioBtn = new System.Windows.Forms.RadioButton();
            this.unit_price_txt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.restart_btn = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.show_sale_stock_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.update_status_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.book_status_txt = new System.Windows.Forms.ComboBox();
            this.snid_status_txt = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // sale_radioBtn
            // 
            this.sale_radioBtn.AutoSize = true;
            this.sale_radioBtn.Location = new System.Drawing.Point(6, 21);
            this.sale_radioBtn.Name = "sale_radioBtn";
            this.sale_radioBtn.Size = new System.Drawing.Size(99, 16);
            this.sale_radioBtn.TabIndex = 0;
            this.sale_radioBtn.TabStop = true;
            this.sale_radioBtn.Text = "Sale Department";
            this.sale_radioBtn.UseVisualStyleBackColor = true;
            this.sale_radioBtn.CheckedChanged += new System.EventHandler(this.sale_radioBtn_CheckedChanged);
            // 
            // procure_radioBtn
            // 
            this.procure_radioBtn.AutoSize = true;
            this.procure_radioBtn.Location = new System.Drawing.Point(111, 23);
            this.procure_radioBtn.Name = "procure_radioBtn";
            this.procure_radioBtn.Size = new System.Drawing.Size(139, 16);
            this.procure_radioBtn.TabIndex = 1;
            this.procure_radioBtn.TabStop = true;
            this.procure_radioBtn.Text = "Procurement Department";
            this.procure_radioBtn.UseVisualStyleBackColor = true;
            this.procure_radioBtn.CheckedChanged += new System.EventHandler(this.procure_radioBtn_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "SNID:";
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(227, 75);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(75, 23);
            this.update_btn.TabIndex = 3;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // snid_txt
            // 
            this.snid_txt.FormattingEnabled = true;
            this.snid_txt.Location = new System.Drawing.Point(100, 23);
            this.snid_txt.Name = "snid_txt";
            this.snid_txt.Size = new System.Drawing.Size(121, 20);
            this.snid_txt.TabIndex = 4;
            // 
            // stock_lv_txt
            // 
            this.stock_lv_txt.Location = new System.Drawing.Point(100, 75);
            this.stock_lv_txt.Name = "stock_lv_txt";
            this.stock_lv_txt.Size = new System.Drawing.Size(121, 22);
            this.stock_lv_txt.TabIndex = 5;
            // 
            // location_id_txt
            // 
            this.location_id_txt.FormattingEnabled = true;
            this.location_id_txt.Location = new System.Drawing.Point(100, 49);
            this.location_id_txt.Name = "location_id_txt";
            this.location_id_txt.Size = new System.Drawing.Size(121, 20);
            this.location_id_txt.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Location ID:";
            // 
            // stock_lv_radioBtn
            // 
            this.stock_lv_radioBtn.AutoSize = true;
            this.stock_lv_radioBtn.Location = new System.Drawing.Point(9, 78);
            this.stock_lv_radioBtn.Name = "stock_lv_radioBtn";
            this.stock_lv_radioBtn.Size = new System.Drawing.Size(81, 16);
            this.stock_lv_radioBtn.TabIndex = 9;
            this.stock_lv_radioBtn.TabStop = true;
            this.stock_lv_radioBtn.Text = "Stock Level:";
            this.stock_lv_radioBtn.UseVisualStyleBackColor = true;
            this.stock_lv_radioBtn.CheckedChanged += new System.EventHandler(this.stock_lv_radioBtn_CheckedChanged);
            // 
            // unit_price_radioBtn
            // 
            this.unit_price_radioBtn.AutoSize = true;
            this.unit_price_radioBtn.Location = new System.Drawing.Point(9, 106);
            this.unit_price_radioBtn.Name = "unit_price_radioBtn";
            this.unit_price_radioBtn.Size = new System.Drawing.Size(72, 16);
            this.unit_price_radioBtn.TabIndex = 11;
            this.unit_price_radioBtn.TabStop = true;
            this.unit_price_radioBtn.Text = "Uint Price:";
            this.unit_price_radioBtn.UseVisualStyleBackColor = true;
            this.unit_price_radioBtn.CheckedChanged += new System.EventHandler(this.unit_price_radioBtn_CheckedChanged);
            // 
            // unit_price_txt
            // 
            this.unit_price_txt.Location = new System.Drawing.Point(100, 103);
            this.unit_price_txt.Name = "unit_price_txt";
            this.unit_price_txt.Size = new System.Drawing.Size(121, 22);
            this.unit_price_txt.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(773, 278);
            this.dataGridView1.TabIndex = 12;
            // 
            // restart_btn
            // 
            this.restart_btn.Location = new System.Drawing.Point(332, 75);
            this.restart_btn.Name = "restart_btn";
            this.restart_btn.Size = new System.Drawing.Size(75, 23);
            this.restart_btn.TabIndex = 13;
            this.restart_btn.Text = "Restart";
            this.restart_btn.UseVisualStyleBackColor = true;
            this.restart_btn.Click += new System.EventHandler(this.restart_btn_Click);
            // 
            // close_btn
            // 
            this.close_btn.Location = new System.Drawing.Point(713, 12);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(75, 23);
            this.close_btn.TabIndex = 14;
            this.close_btn.Text = "Close";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.show_sale_stock_btn);
            this.groupBox1.Location = new System.Drawing.Point(517, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 46);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Function";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Show Procurement Stock";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // show_sale_stock_btn
            // 
            this.show_sale_stock_btn.Location = new System.Drawing.Point(6, 17);
            this.show_sale_stock_btn.Name = "show_sale_stock_btn";
            this.show_sale_stock_btn.Size = new System.Drawing.Size(95, 23);
            this.show_sale_stock_btn.TabIndex = 0;
            this.show_sale_stock_btn.Text = "Show Sale Stock";
            this.show_sale_stock_btn.UseVisualStyleBackColor = true;
            this.show_sale_stock_btn.Click += new System.EventHandler(this.show_sale_stock_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sale_radioBtn);
            this.groupBox2.Controls.Add(this.procure_radioBtn);
            this.groupBox2.Location = new System.Drawing.Point(242, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 43);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Department";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.update_btn);
            this.groupBox3.Controls.Add(this.snid_txt);
            this.groupBox3.Controls.Add(this.restart_btn);
            this.groupBox3.Controls.Add(this.stock_lv_txt);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.unit_price_radioBtn);
            this.groupBox3.Controls.Add(this.location_id_txt);
            this.groupBox3.Controls.Add(this.unit_price_txt);
            this.groupBox3.Controls.Add(this.stock_lv_radioBtn);
            this.groupBox3.Location = new System.Drawing.Point(9, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(508, 136);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Edit Item Price and Stock Level";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.update_status_btn);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.book_status_txt);
            this.groupBox4.Controls.Add(this.snid_status_txt);
            this.groupBox4.Location = new System.Drawing.Point(523, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(184, 100);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Edit Item Status";
            // 
            // update_status_btn
            // 
            this.update_status_btn.Location = new System.Drawing.Point(76, 68);
            this.update_status_btn.Name = "update_status_btn";
            this.update_status_btn.Size = new System.Drawing.Size(75, 23);
            this.update_status_btn.TabIndex = 9;
            this.update_status_btn.Text = "Update";
            this.update_status_btn.UseVisualStyleBackColor = true;
            this.update_status_btn.Click += new System.EventHandler(this.update_status_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "Status :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "SNID:";
            // 
            // book_status_txt
            // 
            this.book_status_txt.FormattingEnabled = true;
            this.book_status_txt.Location = new System.Drawing.Point(57, 42);
            this.book_status_txt.Name = "book_status_txt";
            this.book_status_txt.Size = new System.Drawing.Size(121, 20);
            this.book_status_txt.TabIndex = 1;
            // 
            // snid_status_txt
            // 
            this.snid_status_txt.FormattingEnabled = true;
            this.snid_status_txt.Location = new System.Drawing.Point(57, 16);
            this.snid_status_txt.Name = "snid_status_txt";
            this.snid_status_txt.Size = new System.Drawing.Size(121, 20);
            this.snid_status_txt.TabIndex = 0;
            // 
            // procurement_edit_stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "procurement_edit_stock";
            this.Text = "Procurement Edit Stock";
            this.Load += new System.EventHandler(this.procurement_edit_stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton sale_radioBtn;
        private System.Windows.Forms.RadioButton procure_radioBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.ComboBox snid_txt;
        private System.Windows.Forms.TextBox stock_lv_txt;
        private System.Windows.Forms.ComboBox location_id_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton stock_lv_radioBtn;
        private System.Windows.Forms.RadioButton unit_price_radioBtn;
        private System.Windows.Forms.TextBox unit_price_txt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button restart_btn;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button show_sale_stock_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button update_status_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox book_status_txt;
        private System.Windows.Forms.ComboBox snid_status_txt;
    }
}