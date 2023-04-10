
namespace FYP_sale_book_system
{
    partial class Accounting_UI
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
            this.pur_order_approval_btn = new System.Windows.Forms.Button();
            this.create_t_account_btn = new System.Windows.Forms.Button();
            this.btn_EditTAccount = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // logout_btn
            // 
            this.logout_btn.Location = new System.Drawing.Point(650, 47);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(75, 23);
            this.logout_btn.TabIndex = 3;
            this.logout_btn.Text = "Exit";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 36F);
            this.label1.Location = new System.Drawing.Point(151, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "Accounting Department";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pur_order_approval_btn);
            this.groupBox1.Location = new System.Drawing.Point(61, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 298);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Function";
            // 
            // pur_order_approval_btn
            // 
            this.pur_order_approval_btn.Location = new System.Drawing.Point(6, 21);
            this.pur_order_approval_btn.Name = "pur_order_approval_btn";
            this.pur_order_approval_btn.Size = new System.Drawing.Size(150, 23);
            this.pur_order_approval_btn.TabIndex = 0;
            this.pur_order_approval_btn.Text = "Purchase Order Approval";
            this.pur_order_approval_btn.UseVisualStyleBackColor = true;
            this.pur_order_approval_btn.Click += new System.EventHandler(this.pur_order_approval_btn_Click);
            // 
            // create_t_account_btn
            // 
            this.create_t_account_btn.Location = new System.Drawing.Point(14, 21);
            this.create_t_account_btn.Name = "create_t_account_btn";
            this.create_t_account_btn.Size = new System.Drawing.Size(150, 23);
            this.create_t_account_btn.TabIndex = 1;
            this.create_t_account_btn.Text = "Create And DeleteT Account";
            this.create_t_account_btn.UseVisualStyleBackColor = true;
            this.create_t_account_btn.Click += new System.EventHandler(this.create_t_account_btn_Click);
            // 
            // btn_EditTAccount
            // 
            this.btn_EditTAccount.Location = new System.Drawing.Point(14, 50);
            this.btn_EditTAccount.Name = "btn_EditTAccount";
            this.btn_EditTAccount.Size = new System.Drawing.Size(150, 23);
            this.btn_EditTAccount.TabIndex = 2;
            this.btn_EditTAccount.Text = "Edit T Account";
            this.btn_EditTAccount.UseVisualStyleBackColor = true;
            this.btn_EditTAccount.Click += new System.EventHandler(this.btn_EditTAccount_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.create_t_account_btn);
            this.groupBox2.Controls.Add(this.btn_EditTAccount);
            this.groupBox2.Location = new System.Drawing.Point(391, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 112);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Account Management";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(391, 274);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(170, 100);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data Analysis";
            // 
            // Accounting_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.label1);
            this.Name = "Accounting_UI";
            this.Text = "Accounting Department";
            this.Load += new System.EventHandler(this.Accounting_UI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button pur_order_approval_btn;
        private System.Windows.Forms.Button create_t_account_btn;
        private System.Windows.Forms.Button btn_EditTAccount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}