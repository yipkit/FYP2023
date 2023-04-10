
namespace FYP_sale_book_system
{
    partial class Customer_UI
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
            this.logout_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.payment_btn = new System.Windows.Forms.Button();
            this.search_book_btn = new System.Windows.Forms.Button();
            this.borrow_e_book_and_book_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logout_btn
            // 
            this.logout_btn.Location = new System.Drawing.Point(590, 43);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(75, 23);
            this.logout_btn.TabIndex = 5;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 36F);
            this.label1.Location = new System.Drawing.Point(252, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 48);
            this.label1.TabIndex = 4;
            this.label1.Text = "Customer";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.payment_btn);
            this.groupBox1.Controls.Add(this.search_book_btn);
            this.groupBox1.Controls.Add(this.borrow_e_book_and_book_btn);
            this.groupBox1.Location = new System.Drawing.Point(61, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 149);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Service";
            // 
            // payment_btn
            // 
            this.payment_btn.Location = new System.Drawing.Point(6, 21);
            this.payment_btn.Name = "payment_btn";
            this.payment_btn.Size = new System.Drawing.Size(142, 23);
            this.payment_btn.TabIndex = 11;
            this.payment_btn.Text = "Payment";
            this.payment_btn.UseVisualStyleBackColor = true;
            this.payment_btn.Click += new System.EventHandler(this.payment_btn_Click);
            // 
            // search_book_btn
            // 
            this.search_book_btn.Location = new System.Drawing.Point(6, 108);
            this.search_book_btn.Name = "search_book_btn";
            this.search_book_btn.Size = new System.Drawing.Size(142, 23);
            this.search_book_btn.TabIndex = 10;
            this.search_book_btn.Text = "Search Book";
            this.search_book_btn.UseVisualStyleBackColor = true;
            this.search_book_btn.Click += new System.EventHandler(this.search_book_btn_Click);
            // 
            // borrow_e_book_and_book_btn
            // 
            this.borrow_e_book_and_book_btn.Location = new System.Drawing.Point(6, 62);
            this.borrow_e_book_and_book_btn.Name = "borrow_e_book_and_book_btn";
            this.borrow_e_book_and_book_btn.Size = new System.Drawing.Size(142, 23);
            this.borrow_e_book_and_book_btn.TabIndex = 8;
            this.borrow_e_book_and_book_btn.Text = "Borrow E-Book";
            this.borrow_e_book_and_book_btn.UseVisualStyleBackColor = true;
            this.borrow_e_book_and_book_btn.Click += new System.EventHandler(this.borrow_e_book_and_book_btn_Click);
            // 
            // Customer_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 491);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.label1);
            this.Name = "Customer_UI";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_UI_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button search_book_btn;
        private System.Windows.Forms.Button borrow_e_book_and_book_btn;
        private System.Windows.Forms.Button payment_btn;
    }
}