
namespace FYP_sale_book_system
{
    partial class Staff_Login_UI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.staff_id = new System.Windows.Forms.TextBox();
            this.staff_password = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.department = new System.Windows.Forms.ComboBox();
            this.LoginMode = new System.Windows.Forms.ComboBox();
            this.label_LoginMode = new System.Windows.Forms.Label();
            this.comboBox_location = new System.Windows.Forms.ComboBox();
            this.label_Location = new System.Windows.Forms.Label();
            this.btn_Help = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 36F);
            this.label1.Location = new System.Drawing.Point(302, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F);
            this.label2.Location = new System.Drawing.Point(164, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Staff ID : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F);
            this.label3.Location = new System.Drawing.Point(164, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password : ";
            // 
            // staff_id
            // 
            this.staff_id.Font = new System.Drawing.Font("新細明體", 12F);
            this.staff_id.Location = new System.Drawing.Point(288, 131);
            this.staff_id.Name = "staff_id";
            this.staff_id.Size = new System.Drawing.Size(121, 27);
            this.staff_id.TabIndex = 3;
            // 
            // staff_password
            // 
            this.staff_password.Font = new System.Drawing.Font("新細明體", 12F);
            this.staff_password.Location = new System.Drawing.Point(288, 191);
            this.staff_password.Name = "staff_password";
            this.staff_password.PasswordChar = '*';
            this.staff_password.Size = new System.Drawing.Size(121, 27);
            this.staff_password.TabIndex = 4;
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(288, 294);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(121, 23);
            this.login_btn.TabIndex = 5;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // close_btn
            // 
            this.close_btn.Location = new System.Drawing.Point(612, 27);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(75, 23);
            this.close_btn.TabIndex = 6;
            this.close_btn.Text = "Close";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F);
            this.label4.Location = new System.Drawing.Point(455, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Department : ";
            // 
            // department
            // 
            this.department.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.department.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.department.Font = new System.Drawing.Font("新細明體", 12F);
            this.department.FormattingEnabled = true;
            this.department.Location = new System.Drawing.Point(566, 131);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(121, 24);
            this.department.TabIndex = 8;
            // 
            // LoginMode
            // 
            this.LoginMode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.LoginMode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.LoginMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LoginMode.Font = new System.Drawing.Font("新細明體", 12F);
            this.LoginMode.FormattingEnabled = true;
            this.LoginMode.Items.AddRange(new object[] {
            "Normal Mode",
            "Development Mode"});
            this.LoginMode.Location = new System.Drawing.Point(566, 191);
            this.LoginMode.Name = "LoginMode";
            this.LoginMode.Size = new System.Drawing.Size(121, 24);
            this.LoginMode.TabIndex = 9;
            // 
            // label_LoginMode
            // 
            this.label_LoginMode.AutoSize = true;
            this.label_LoginMode.Font = new System.Drawing.Font("新細明體", 12F);
            this.label_LoginMode.Location = new System.Drawing.Point(455, 194);
            this.label_LoginMode.Name = "label_LoginMode";
            this.label_LoginMode.Size = new System.Drawing.Size(93, 16);
            this.label_LoginMode.TabIndex = 10;
            this.label_LoginMode.Text = "Login Mode :";
            // 
            // comboBox_location
            // 
            this.comboBox_location.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_location.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_location.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_location.Font = new System.Drawing.Font("新細明體", 12F);
            this.comboBox_location.FormattingEnabled = true;
            this.comboBox_location.Location = new System.Drawing.Point(288, 246);
            this.comboBox_location.Name = "comboBox_location";
            this.comboBox_location.Size = new System.Drawing.Size(399, 24);
            this.comboBox_location.TabIndex = 11;
            this.comboBox_location.SelectedIndexChanged += new System.EventHandler(this.comboBox_location_SelectedIndexChanged);
            // 
            // label_Location
            // 
            this.label_Location.AutoSize = true;
            this.label_Location.Font = new System.Drawing.Font("新細明體", 12F);
            this.label_Location.Location = new System.Drawing.Point(164, 249);
            this.label_Location.Name = "label_Location";
            this.label_Location.Size = new System.Drawing.Size(71, 16);
            this.label_Location.TabIndex = 12;
            this.label_Location.Text = "Location :";
            // 
            // btn_Help
            // 
            this.btn_Help.Location = new System.Drawing.Point(566, 294);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(121, 23);
            this.btn_Help.TabIndex = 13;
            this.btn_Help.Text = "Help, I can\'t sign";
            this.btn_Help.UseVisualStyleBackColor = true;
            this.btn_Help.Click += new System.EventHandler(this.btn_Help_Click);
            // 
            // Staff_Login_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Help);
            this.Controls.Add(this.label_Location);
            this.Controls.Add(this.comboBox_location);
            this.Controls.Add(this.label_LoginMode);
            this.Controls.Add(this.LoginMode);
            this.Controls.Add(this.department);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.staff_password);
            this.Controls.Add(this.staff_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Staff_Login_UI";
            this.Text = "Staff Login";
            this.Load += new System.EventHandler(this.Staff_Login_UI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox staff_id;
        private System.Windows.Forms.TextBox staff_password;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox department;
        private System.Windows.Forms.ComboBox LoginMode;
        private System.Windows.Forms.Label label_LoginMode;
        private System.Windows.Forms.ComboBox comboBox_location;
        private System.Windows.Forms.Label label_Location;
        private System.Windows.Forms.Button btn_Help;
    }
}