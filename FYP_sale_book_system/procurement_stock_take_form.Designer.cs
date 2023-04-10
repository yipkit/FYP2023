
namespace FYP_sale_book_system
{
    partial class procurement_stock_take_form
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
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.c_f_date_txt = new System.Windows.Forms.DateTimePicker();
            this.CreateSalesStockFrom_groupBox = new System.Windows.Forms.GroupBox();
            this.gen_form_btn = new System.Windows.Forms.Button();
            this.show_stock_take_form_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.stock_take_form_no_txt = new System.Windows.Forms.TextBox();
            this.clean_value_txt = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.location_id_txt = new System.Windows.Forms.ComboBox();
            this.procure_stock_btn = new System.Windows.Forms.Button();
            this.CreateSalesStockFrom_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // c_f_date_txt
            // 
            this.c_f_date_txt.CustomFormat = "yy-MM-dd";
            this.c_f_date_txt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.c_f_date_txt.Location = new System.Drawing.Point(321, 17);
            this.c_f_date_txt.Name = "c_f_date_txt";
            this.c_f_date_txt.Size = new System.Drawing.Size(100, 22);
            this.c_f_date_txt.TabIndex = 59;
            // 
            // CreateSalesStockFrom_groupBox
            // 
            this.CreateSalesStockFrom_groupBox.Controls.Add(this.procure_stock_btn);
            this.CreateSalesStockFrom_groupBox.Controls.Add(this.location_id_txt);
            this.CreateSalesStockFrom_groupBox.Controls.Add(this.label2);
            this.CreateSalesStockFrom_groupBox.Controls.Add(this.gen_form_btn);
            this.CreateSalesStockFrom_groupBox.Controls.Add(this.show_stock_take_form_btn);
            this.CreateSalesStockFrom_groupBox.Controls.Add(this.c_f_date_txt);
            this.CreateSalesStockFrom_groupBox.Controls.Add(this.label7);
            this.CreateSalesStockFrom_groupBox.Controls.Add(this.label10);
            this.CreateSalesStockFrom_groupBox.Controls.Add(this.stock_take_form_no_txt);
            this.CreateSalesStockFrom_groupBox.Controls.Add(this.clean_value_txt);
            this.CreateSalesStockFrom_groupBox.Location = new System.Drawing.Point(18, 19);
            this.CreateSalesStockFrom_groupBox.Name = "CreateSalesStockFrom_groupBox";
            this.CreateSalesStockFrom_groupBox.Size = new System.Drawing.Size(447, 196);
            this.CreateSalesStockFrom_groupBox.TabIndex = 60;
            this.CreateSalesStockFrom_groupBox.TabStop = false;
            this.CreateSalesStockFrom_groupBox.Text = "Create Sales Stock Take  Form";
            // 
            // gen_form_btn
            // 
            this.gen_form_btn.Location = new System.Drawing.Point(240, 80);
            this.gen_form_btn.Name = "gen_form_btn";
            this.gen_form_btn.Size = new System.Drawing.Size(75, 23);
            this.gen_form_btn.TabIndex = 61;
            this.gen_form_btn.Text = "Gen Form";
            this.gen_form_btn.UseVisualStyleBackColor = true;
            this.gen_form_btn.Click += new System.EventHandler(this.gen_form_btn_Click);
            // 
            // show_stock_take_form_btn
            // 
            this.show_stock_take_form_btn.Location = new System.Drawing.Point(240, 130);
            this.show_stock_take_form_btn.Name = "show_stock_take_form_btn";
            this.show_stock_take_form_btn.Size = new System.Drawing.Size(172, 23);
            this.show_stock_take_form_btn.TabIndex = 60;
            this.show_stock_take_form_btn.Text = "Show Stock Take Form";
            this.show_stock_take_form_btn.UseVisualStyleBackColor = true;
            this.show_stock_take_form_btn.Click += new System.EventHandler(this.show_stock_take_form_btn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(226, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 12);
            this.label7.TabIndex = 51;
            this.label7.Text = "Create form date :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 12);
            this.label10.TabIndex = 56;
            this.label10.Text = "Stock Take Form No :";
            // 
            // stock_take_form_no_txt
            // 
            this.stock_take_form_no_txt.Location = new System.Drawing.Point(120, 21);
            this.stock_take_form_no_txt.Name = "stock_take_form_no_txt";
            this.stock_take_form_no_txt.ReadOnly = true;
            this.stock_take_form_no_txt.Size = new System.Drawing.Size(100, 22);
            this.stock_take_form_no_txt.TabIndex = 55;
            // 
            // clean_value_txt
            // 
            this.clean_value_txt.Location = new System.Drawing.Point(337, 80);
            this.clean_value_txt.Name = "clean_value_txt";
            this.clean_value_txt.Size = new System.Drawing.Size(75, 23);
            this.clean_value_txt.TabIndex = 46;
            this.clean_value_txt.Text = "Restart";
            this.clean_value_txt.UseVisualStyleBackColor = true;
            this.clean_value_txt.Click += new System.EventHandler(this.clean_value_txt_Click);
            // 
            // close_btn
            // 
            this.close_btn.Location = new System.Drawing.Point(915, 29);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(75, 23);
            this.close_btn.TabIndex = 59;
            this.close_btn.Text = "Close";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 238);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1303, 150);
            this.dataGridView1.TabIndex = 62;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(531, 65);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(319, 150);
            this.dataGridView2.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(531, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 12);
            this.label1.TabIndex = 64;
            this.label1.Text = "Company Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 12);
            this.label2.TabIndex = 62;
            this.label2.Text = "Location ID:";
            // 
            // location_id_txt
            // 
            this.location_id_txt.FormattingEnabled = true;
            this.location_id_txt.Location = new System.Drawing.Point(78, 77);
            this.location_id_txt.Name = "location_id_txt";
            this.location_id_txt.Size = new System.Drawing.Size(121, 20);
            this.location_id_txt.TabIndex = 63;
            // 
            // procure_stock_btn
            // 
            this.procure_stock_btn.Location = new System.Drawing.Point(240, 159);
            this.procure_stock_btn.Name = "procure_stock_btn";
            this.procure_stock_btn.Size = new System.Drawing.Size(172, 23);
            this.procure_stock_btn.TabIndex = 64;
            this.procure_stock_btn.Text = "Show Procurement Stock";
            this.procure_stock_btn.UseVisualStyleBackColor = true;
            this.procure_stock_btn.Click += new System.EventHandler(this.procure_stock_btn_Click);
            // 
            // procurement_stock_take_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 400);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CreateSalesStockFrom_groupBox);
            this.Controls.Add(this.close_btn);
            this.Name = "procurement_stock_take_form";
            this.Text = "Stock Take Form";
            this.Load += new System.EventHandler(this.procurement_stock_take_form_Load);
            this.CreateSalesStockFrom_groupBox.ResumeLayout(false);
            this.CreateSalesStockFrom_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DateTimePicker c_f_date_txt;
        private System.Windows.Forms.GroupBox CreateSalesStockFrom_groupBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox stock_take_form_no_txt;
        private System.Windows.Forms.Button clean_value_txt;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Button show_stock_take_form_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button gen_form_btn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox location_id_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button procure_stock_btn;
    }
}