
namespace FYP_sale_book_system
{
    partial class it_HelperTask
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
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comb_Customer = new System.Windows.Forms.ComboBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Email1 = new System.Windows.Forms.TextBox();
            this.comb_Staff = new System.Windows.Forms.ComboBox();
            this.btn_Submit1 = new System.Windows.Forms.Button();
            this.txtRe1 = new System.Windows.Forms.TextBox();
            this.txtRe2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(87, 21);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(252, 22);
            this.txt_Email.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "E-mail :";
            // 
            // comb_Customer
            // 
            this.comb_Customer.FormattingEnabled = true;
            this.comb_Customer.Items.AddRange(new object[] {
            "Staff Name",
            "Password",
            "Telephone Country Number",
            "Telephone Number",
            "E-mail",
            "Right Level",
            "Status",
            "Point"});
            this.comb_Customer.Location = new System.Drawing.Point(87, 49);
            this.comb_Customer.Name = "comb_Customer";
            this.comb_Customer.Size = new System.Drawing.Size(252, 20);
            this.comb_Customer.TabIndex = 2;
            this.comb_Customer.Text = "Help List";
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(360, 47);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit.TabIndex = 3;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(713, 415);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 4;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRe1);
            this.groupBox1.Controls.Add(this.txt_Email);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_Submit);
            this.groupBox1.Controls.Add(this.comb_Customer);
            this.groupBox1.Location = new System.Drawing.Point(150, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtRe2);
            this.groupBox2.Controls.Add(this.btn_Submit1);
            this.groupBox2.Controls.Add(this.comb_Staff);
            this.groupBox2.Controls.Add(this.txt_Email1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(150, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(458, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Staff";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Staff Email :";
            // 
            // txt_Email1
            // 
            this.txt_Email1.Location = new System.Drawing.Point(87, 19);
            this.txt_Email1.Name = "txt_Email1";
            this.txt_Email1.Size = new System.Drawing.Size(252, 22);
            this.txt_Email1.TabIndex = 1;
            // 
            // comb_Staff
            // 
            this.comb_Staff.FormattingEnabled = true;
            this.comb_Staff.Items.AddRange(new object[] {
            "Staff Name",
            "Password",
            "Telephone Country Number",
            "Telephone Number",
            "E-mail",
            "Status"});
            this.comb_Staff.Location = new System.Drawing.Point(87, 47);
            this.comb_Staff.Name = "comb_Staff";
            this.comb_Staff.Size = new System.Drawing.Size(252, 20);
            this.comb_Staff.TabIndex = 2;
            this.comb_Staff.Text = "Help List";
            // 
            // btn_Submit1
            // 
            this.btn_Submit1.Location = new System.Drawing.Point(360, 44);
            this.btn_Submit1.Name = "btn_Submit1";
            this.btn_Submit1.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit1.TabIndex = 3;
            this.btn_Submit1.Text = "Submit";
            this.btn_Submit1.UseVisualStyleBackColor = true;
            this.btn_Submit1.Click += new System.EventHandler(this.btn_Submit1_Click);
            // 
            // txtRe1
            // 
            this.txtRe1.Location = new System.Drawing.Point(87, 72);
            this.txtRe1.Name = "txtRe1";
            this.txtRe1.Size = new System.Drawing.Size(252, 22);
            this.txtRe1.TabIndex = 4;
            this.txtRe1.Text = "Remark";
            // 
            // txtRe2
            // 
            this.txtRe2.Location = new System.Drawing.Point(87, 72);
            this.txtRe2.Name = "txtRe2";
            this.txtRe2.Size = new System.Drawing.Size(252, 22);
            this.txtRe2.TabIndex = 5;
            this.txtRe2.Text = "Remark";
            // 
            // it_HelperTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Close);
            this.Name = "it_HelperTask";
            this.Text = "Helper Task";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comb_Customer;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Submit1;
        private System.Windows.Forms.ComboBox comb_Staff;
        private System.Windows.Forms.TextBox txt_Email1;
        private System.Windows.Forms.TextBox txtRe1;
        private System.Windows.Forms.TextBox txtRe2;
    }
}