
namespace FYP_sale_book_system
{
    partial class it_review_user_account
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
            this.Close_btn = new System.Windows.Forms.Button();
            this.View_UserAccount_label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SeachID_btn = new System.Windows.Forms.Button();
            this.UserID_txt = new System.Windows.Forms.TextBox();
            this.UserID_label = new System.Windows.Forms.Label();
            this.SearchAll_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Close_btn
            // 
            this.Close_btn.Location = new System.Drawing.Point(1004, 33);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(75, 23);
            this.Close_btn.TabIndex = 6;
            this.Close_btn.Text = "Close";
            this.Close_btn.UseVisualStyleBackColor = true;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // View_UserAccount_label
            // 
            this.View_UserAccount_label.AutoSize = true;
            this.View_UserAccount_label.Location = new System.Drawing.Point(11, 78);
            this.View_UserAccount_label.Name = "View_UserAccount_label";
            this.View_UserAccount_label.Size = new System.Drawing.Size(92, 12);
            this.View_UserAccount_label.TabIndex = 5;
            this.View_UserAccount_label.Text = "View UserAccount";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1079, 370);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SeachID_btn
            // 
            this.SeachID_btn.Location = new System.Drawing.Point(226, 30);
            this.SeachID_btn.Name = "SeachID_btn";
            this.SeachID_btn.Size = new System.Drawing.Size(75, 23);
            this.SeachID_btn.TabIndex = 10;
            this.SeachID_btn.Text = "Seach ID";
            this.SeachID_btn.UseVisualStyleBackColor = true;
            this.SeachID_btn.Click += new System.EventHandler(this.SeachID_btn_Click);
            // 
            // UserID_txt
            // 
            this.UserID_txt.Location = new System.Drawing.Point(67, 30);
            this.UserID_txt.Name = "UserID_txt";
            this.UserID_txt.Size = new System.Drawing.Size(153, 22);
            this.UserID_txt.TabIndex = 9;
            // 
            // UserID_label
            // 
            this.UserID_label.AutoSize = true;
            this.UserID_label.Location = new System.Drawing.Point(11, 33);
            this.UserID_label.Name = "UserID_label";
            this.UserID_label.Size = new System.Drawing.Size(50, 12);
            this.UserID_label.TabIndex = 8;
            this.UserID_label.Text = "User ID  :";
            // 
            // SearchAll_btn
            // 
            this.SearchAll_btn.Location = new System.Drawing.Point(317, 29);
            this.SearchAll_btn.Name = "SearchAll_btn";
            this.SearchAll_btn.Size = new System.Drawing.Size(75, 23);
            this.SearchAll_btn.TabIndex = 7;
            this.SearchAll_btn.Text = "Search All User";
            this.SearchAll_btn.UseVisualStyleBackColor = true;
            this.SearchAll_btn.Click += new System.EventHandler(this.SearchAll_btn_Click);
            // 
            // it_review_user_account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 489);
            this.Controls.Add(this.SeachID_btn);
            this.Controls.Add(this.UserID_txt);
            this.Controls.Add(this.UserID_label);
            this.Controls.Add(this.SearchAll_btn);
            this.Controls.Add(this.Close_btn);
            this.Controls.Add(this.View_UserAccount_label);
            this.Controls.Add(this.dataGridView1);
            this.Name = "it_review_user_account";
            this.Text = "Review User Account";
            this.Load += new System.EventHandler(this.it_review_user_account_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Close_btn;
        private System.Windows.Forms.Label View_UserAccount_label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SeachID_btn;
        private System.Windows.Forms.TextBox UserID_txt;
        private System.Windows.Forms.Label UserID_label;
        private System.Windows.Forms.Button SearchAll_btn;
    }
}