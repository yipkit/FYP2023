
namespace FYP_sale_book_system
{
    partial class sales_StockTake
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comb_Location = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_CreateForm = new System.Windows.Forms.Button();
            this.btn_UpdateStockTakeForm = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_SearchStockTake = new System.Windows.Forms.Button();
            this.comb_ProductID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comb_selectNum = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_PN = new System.Windows.Forms.CheckBox();
            this.checkBox_LN = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_GenStockTakeNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comb_GenLocation = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comb_Qty6 = new System.Windows.Forms.ComboBox();
            this.comb_Qty5 = new System.Windows.Forms.ComboBox();
            this.comb_Qty4 = new System.Windows.Forms.ComboBox();
            this.comb_Qty3 = new System.Windows.Forms.ComboBox();
            this.comb_Qty2 = new System.Windows.Forms.ComboBox();
            this.comb_Qty1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Details = new System.Windows.Forms.TextBox();
            this.comb_StockTakePID = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comb_SelectStockTakeNo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Refash = new System.Windows.Forms.Button();
            this.comb_Qty7 = new System.Windows.Forms.ComboBox();
            this.comb_Qty8 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1000, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Review Sales Stock & Stock Take";
            // 
            // comb_Location
            // 
            this.comb_Location.FormattingEnabled = true;
            this.comb_Location.Location = new System.Drawing.Point(6, 86);
            this.comb_Location.Name = "comb_Location";
            this.comb_Location.Size = new System.Drawing.Size(228, 20);
            this.comb_Location.TabIndex = 2;
            this.comb_Location.Text = "Location";
            this.comb_Location.SelectedIndexChanged += new System.EventHandler(this.comb_Location_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Location Name :";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(112, 247);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(122, 23);
            this.btn_Search.TabIndex = 4;
            this.btn_Search.Text = "Search Sales Stock";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_CreateForm
            // 
            this.btn_CreateForm.Location = new System.Drawing.Point(560, 106);
            this.btn_CreateForm.Name = "btn_CreateForm";
            this.btn_CreateForm.Size = new System.Drawing.Size(154, 23);
            this.btn_CreateForm.TabIndex = 5;
            this.btn_CreateForm.Text = "Create Stock Take Form";
            this.btn_CreateForm.UseVisualStyleBackColor = true;
            this.btn_CreateForm.Click += new System.EventHandler(this.btn_CreateForm_Click);
            // 
            // btn_UpdateStockTakeForm
            // 
            this.btn_UpdateStockTakeForm.Location = new System.Drawing.Point(566, 131);
            this.btn_UpdateStockTakeForm.Name = "btn_UpdateStockTakeForm";
            this.btn_UpdateStockTakeForm.Size = new System.Drawing.Size(154, 23);
            this.btn_UpdateStockTakeForm.TabIndex = 6;
            this.btn_UpdateStockTakeForm.Text = "Update Stock Take Form";
            this.btn_UpdateStockTakeForm.UseVisualStyleBackColor = true;
            this.btn_UpdateStockTakeForm.Click += new System.EventHandler(this.btn_UpdateStockTakeForm_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(128, 595);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(128, 23);
            this.btn_Close.TabIndex = 7;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_SearchStockTake
            // 
            this.btn_SearchStockTake.Location = new System.Drawing.Point(8, 46);
            this.btn_SearchStockTake.Name = "btn_SearchStockTake";
            this.btn_SearchStockTake.Size = new System.Drawing.Size(233, 23);
            this.btn_SearchStockTake.TabIndex = 8;
            this.btn_SearchStockTake.Text = "Search Stock Take";
            this.btn_SearchStockTake.UseVisualStyleBackColor = true;
            this.btn_SearchStockTake.Click += new System.EventHandler(this.btn_SearchStockTake_Click);
            // 
            // comb_ProductID
            // 
            this.comb_ProductID.FormattingEnabled = true;
            this.comb_ProductID.Location = new System.Drawing.Point(6, 154);
            this.comb_ProductID.Name = "comb_ProductID";
            this.comb_ProductID.Size = new System.Drawing.Size(228, 20);
            this.comb_ProductID.TabIndex = 9;
            this.comb_ProductID.Text = "Product ID";
            this.comb_ProductID.SelectedIndexChanged += new System.EventHandler(this.comb_ProductID_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sales Stock ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "Stock Take Number :";
            // 
            // comb_selectNum
            // 
            this.comb_selectNum.FormattingEnabled = true;
            this.comb_selectNum.Location = new System.Drawing.Point(116, 20);
            this.comb_selectNum.Name = "comb_selectNum";
            this.comb_selectNum.Size = new System.Drawing.Size(598, 20);
            this.comb_selectNum.TabIndex = 12;
            this.comb_selectNum.Text = "Select Number";
            this.comb_selectNum.SelectedIndexChanged += new System.EventHandler(this.comb_selectNum_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_PN);
            this.groupBox1.Controls.Add(this.checkBox_LN);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comb_Location);
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comb_ProductID);
            this.groupBox1.Location = new System.Drawing.Point(16, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 287);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Sales Stock";
            // 
            // checkBox_PN
            // 
            this.checkBox_PN.AutoSize = true;
            this.checkBox_PN.Location = new System.Drawing.Point(6, 134);
            this.checkBox_PN.Name = "checkBox_PN";
            this.checkBox_PN.Size = new System.Drawing.Size(15, 14);
            this.checkBox_PN.TabIndex = 12;
            this.checkBox_PN.UseVisualStyleBackColor = true;
            this.checkBox_PN.CheckedChanged += new System.EventHandler(this.checkBox_PN_CheckedChanged);
            // 
            // checkBox_LN
            // 
            this.checkBox_LN.AutoSize = true;
            this.checkBox_LN.Location = new System.Drawing.Point(6, 63);
            this.checkBox_LN.Name = "checkBox_LN";
            this.checkBox_LN.Size = new System.Drawing.Size(15, 14);
            this.checkBox_LN.TabIndex = 11;
            this.checkBox_LN.UseVisualStyleBackColor = true;
            this.checkBox_LN.CheckedChanged += new System.EventHandler(this.checkBox_LN_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btn_SearchStockTake);
            this.groupBox2.Controls.Add(this.comb_selectNum);
            this.groupBox2.Location = new System.Drawing.Point(294, 358);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(720, 89);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Review Stock Take";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_GenStockTakeNo);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.comb_GenLocation);
            this.groupBox3.Controls.Add(this.btn_CreateForm);
            this.groupBox3.Location = new System.Drawing.Point(294, 206);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(720, 146);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Create Stock Take ";
            // 
            // txt_GenStockTakeNo
            // 
            this.txt_GenStockTakeNo.Location = new System.Drawing.Point(17, 37);
            this.txt_GenStockTakeNo.Name = "txt_GenStockTakeNo";
            this.txt_GenStockTakeNo.ReadOnly = true;
            this.txt_GenStockTakeNo.Size = new System.Drawing.Size(697, 22);
            this.txt_GenStockTakeNo.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "Gen Stock Take No.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "Location Name :";
            // 
            // comb_GenLocation
            // 
            this.comb_GenLocation.FormattingEnabled = true;
            this.comb_GenLocation.Location = new System.Drawing.Point(15, 80);
            this.comb_GenLocation.Name = "comb_GenLocation";
            this.comb_GenLocation.Size = new System.Drawing.Size(699, 20);
            this.comb_GenLocation.TabIndex = 11;
            this.comb_GenLocation.Text = "Location";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comb_Qty8);
            this.groupBox4.Controls.Add(this.comb_Qty7);
            this.groupBox4.Controls.Add(this.comb_Qty6);
            this.groupBox4.Controls.Add(this.comb_Qty5);
            this.groupBox4.Controls.Add(this.comb_Qty4);
            this.groupBox4.Controls.Add(this.comb_Qty3);
            this.groupBox4.Controls.Add(this.comb_Qty2);
            this.groupBox4.Controls.Add(this.comb_Qty1);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txt_Details);
            this.groupBox4.Controls.Add(this.comb_StockTakePID);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.comb_SelectStockTakeNo);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.btn_UpdateStockTakeForm);
            this.groupBox4.Location = new System.Drawing.Point(294, 453);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(720, 165);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Update Stock Take Form";
            // 
            // comb_Qty6
            // 
            this.comb_Qty6.FormattingEnabled = true;
            this.comb_Qty6.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comb_Qty6.Location = new System.Drawing.Point(285, 72);
            this.comb_Qty6.Name = "comb_Qty6";
            this.comb_Qty6.Size = new System.Drawing.Size(31, 20);
            this.comb_Qty6.TabIndex = 31;
            this.comb_Qty6.Text = "0";
            // 
            // comb_Qty5
            // 
            this.comb_Qty5.FormattingEnabled = true;
            this.comb_Qty5.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comb_Qty5.Location = new System.Drawing.Point(247, 72);
            this.comb_Qty5.Name = "comb_Qty5";
            this.comb_Qty5.Size = new System.Drawing.Size(31, 20);
            this.comb_Qty5.TabIndex = 30;
            this.comb_Qty5.Text = "0";
            // 
            // comb_Qty4
            // 
            this.comb_Qty4.FormattingEnabled = true;
            this.comb_Qty4.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comb_Qty4.Location = new System.Drawing.Point(211, 72);
            this.comb_Qty4.Name = "comb_Qty4";
            this.comb_Qty4.Size = new System.Drawing.Size(30, 20);
            this.comb_Qty4.TabIndex = 29;
            this.comb_Qty4.Text = "0";
            // 
            // comb_Qty3
            // 
            this.comb_Qty3.FormattingEnabled = true;
            this.comb_Qty3.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comb_Qty3.Location = new System.Drawing.Point(176, 72);
            this.comb_Qty3.Name = "comb_Qty3";
            this.comb_Qty3.Size = new System.Drawing.Size(29, 20);
            this.comb_Qty3.TabIndex = 28;
            this.comb_Qty3.Text = "0";
            // 
            // comb_Qty2
            // 
            this.comb_Qty2.FormattingEnabled = true;
            this.comb_Qty2.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comb_Qty2.Location = new System.Drawing.Point(138, 72);
            this.comb_Qty2.Name = "comb_Qty2";
            this.comb_Qty2.Size = new System.Drawing.Size(32, 20);
            this.comb_Qty2.TabIndex = 27;
            this.comb_Qty2.Text = "0";
            // 
            // comb_Qty1
            // 
            this.comb_Qty1.FormattingEnabled = true;
            this.comb_Qty1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comb_Qty1.Location = new System.Drawing.Point(99, 72);
            this.comb_Qty1.Name = "comb_Qty1";
            this.comb_Qty1.Size = new System.Drawing.Size(33, 20);
            this.comb_Qty1.TabIndex = 26;
            this.comb_Qty1.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 12);
            this.label11.TabIndex = 25;
            this.label11.Text = "Details :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 12);
            this.label9.TabIndex = 23;
            this.label9.Text = "Qty :";
            // 
            // txt_Details
            // 
            this.txt_Details.Location = new System.Drawing.Point(99, 103);
            this.txt_Details.Name = "txt_Details";
            this.txt_Details.Size = new System.Drawing.Size(615, 22);
            this.txt_Details.TabIndex = 22;
            this.txt_Details.Text = "Null";
            // 
            // comb_StockTakePID
            // 
            this.comb_StockTakePID.FormattingEnabled = true;
            this.comb_StockTakePID.Location = new System.Drawing.Point(99, 42);
            this.comb_StockTakePID.Name = "comb_StockTakePID";
            this.comb_StockTakePID.Size = new System.Drawing.Size(615, 20);
            this.comb_StockTakePID.TabIndex = 21;
            this.comb_StockTakePID.Text = "Select Product ID";
            this.comb_StockTakePID.Visible = false;
            this.comb_StockTakePID.SelectedIndexChanged += new System.EventHandler(this.comb_StockTakePID_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 12);
            this.label8.TabIndex = 20;
            this.label8.Text = "Stock Take ID :";
            // 
            // comb_SelectStockTakeNo
            // 
            this.comb_SelectStockTakeNo.FormattingEnabled = true;
            this.comb_SelectStockTakeNo.Location = new System.Drawing.Point(99, 20);
            this.comb_SelectStockTakeNo.Name = "comb_SelectStockTakeNo";
            this.comb_SelectStockTakeNo.Size = new System.Drawing.Size(615, 20);
            this.comb_SelectStockTakeNo.TabIndex = 19;
            this.comb_SelectStockTakeNo.Text = "Select Stock Take No";
            this.comb_SelectStockTakeNo.SelectedIndexChanged += new System.EventHandler(this.comb_SelectStockTakeNo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "Stock Take No.";
            // 
            // btn_Refash
            // 
            this.btn_Refash.Location = new System.Drawing.Point(128, 566);
            this.btn_Refash.Name = "btn_Refash";
            this.btn_Refash.Size = new System.Drawing.Size(128, 23);
            this.btn_Refash.TabIndex = 17;
            this.btn_Refash.Text = "Refash Data";
            this.btn_Refash.UseVisualStyleBackColor = true;
            this.btn_Refash.Click += new System.EventHandler(this.btn_Refash_Click);
            // 
            // comb_Qty7
            // 
            this.comb_Qty7.FormattingEnabled = true;
            this.comb_Qty7.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comb_Qty7.Location = new System.Drawing.Point(322, 72);
            this.comb_Qty7.Name = "comb_Qty7";
            this.comb_Qty7.Size = new System.Drawing.Size(31, 20);
            this.comb_Qty7.TabIndex = 32;
            this.comb_Qty7.Text = "0";
            // 
            // comb_Qty8
            // 
            this.comb_Qty8.FormattingEnabled = true;
            this.comb_Qty8.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comb_Qty8.Location = new System.Drawing.Point(359, 72);
            this.comb_Qty8.Name = "comb_Qty8";
            this.comb_Qty8.Size = new System.Drawing.Size(31, 20);
            this.comb_Qty8.TabIndex = 33;
            this.comb_Qty8.Text = "0";
            // 
            // sales_StockTake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 630);
            this.Controls.Add(this.btn_Refash);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "sales_StockTake";
            this.Text = "Stock Take";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comb_Location;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_CreateForm;
        private System.Windows.Forms.Button btn_UpdateStockTakeForm;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_SearchStockTake;
        private System.Windows.Forms.ComboBox comb_ProductID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comb_selectNum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_GenStockTakeNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comb_GenLocation;
        private System.Windows.Forms.ComboBox comb_Qty6;
        private System.Windows.Forms.ComboBox comb_Qty5;
        private System.Windows.Forms.ComboBox comb_Qty4;
        private System.Windows.Forms.ComboBox comb_Qty3;
        private System.Windows.Forms.ComboBox comb_Qty2;
        private System.Windows.Forms.ComboBox comb_Qty1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Details;
        private System.Windows.Forms.ComboBox comb_StockTakePID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comb_SelectStockTakeNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox_PN;
        private System.Windows.Forms.CheckBox checkBox_LN;
        private System.Windows.Forms.Button btn_Refash;
        private System.Windows.Forms.ComboBox comb_Qty8;
        private System.Windows.Forms.ComboBox comb_Qty7;
    }
}