
namespace FYP_sale_book_system
{
    partial class it_UI
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
            this.update_user_account_btn = new System.Windows.Forms.Button();
            this.review_user_account_btn = new System.Windows.Forms.Button();
            this.create_user_account_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_ResetDutyRecord = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_RefreshWeather = new System.Windows.Forms.Button();
            this.label9_HK = new System.Windows.Forms.Label();
            this.textBox_dec = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_WeatherStatus = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_wind_speed = new System.Windows.Forms.TextBox();
            this.txt_pessure = new System.Windows.Forms.TextBox();
            this.txt_humidity = new System.Windows.Forms.TextBox();
            this.txt_temp_max = new System.Windows.Forms.TextBox();
            this.txt_temp_min = new System.Windows.Forms.TextBox();
            this.txt_main_temp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_CreateCustomerData = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // logout_btn
            // 
            this.logout_btn.Location = new System.Drawing.Point(687, 54);
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
            this.label1.Location = new System.Drawing.Point(250, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "IT Department";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.update_user_account_btn);
            this.groupBox1.Controls.Add(this.review_user_account_btn);
            this.groupBox1.Controls.Add(this.create_user_account_btn);
            this.groupBox1.Location = new System.Drawing.Point(12, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 109);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Account Management";
            // 
            // update_user_account_btn
            // 
            this.update_user_account_btn.Location = new System.Drawing.Point(6, 79);
            this.update_user_account_btn.Name = "update_user_account_btn";
            this.update_user_account_btn.Size = new System.Drawing.Size(325, 23);
            this.update_user_account_btn.TabIndex = 7;
            this.update_user_account_btn.Text = "Modify User Account";
            this.update_user_account_btn.UseVisualStyleBackColor = true;
            this.update_user_account_btn.Click += new System.EventHandler(this.update_user_account_btn_Click);
            // 
            // review_user_account_btn
            // 
            this.review_user_account_btn.Location = new System.Drawing.Point(6, 50);
            this.review_user_account_btn.Name = "review_user_account_btn";
            this.review_user_account_btn.Size = new System.Drawing.Size(325, 23);
            this.review_user_account_btn.TabIndex = 6;
            this.review_user_account_btn.Text = "Review User Account";
            this.review_user_account_btn.UseVisualStyleBackColor = true;
            this.review_user_account_btn.Click += new System.EventHandler(this.review_user_account_btn_Click);
            // 
            // create_user_account_btn
            // 
            this.create_user_account_btn.Location = new System.Drawing.Point(6, 21);
            this.create_user_account_btn.Name = "create_user_account_btn";
            this.create_user_account_btn.Size = new System.Drawing.Size(325, 23);
            this.create_user_account_btn.TabIndex = 5;
            this.create_user_account_btn.Text = "Create User Account";
            this.create_user_account_btn.UseVisualStyleBackColor = true;
            this.create_user_account_btn.Click += new System.EventHandler(this.create_user_account_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_ResetDutyRecord);
            this.groupBox2.Location = new System.Drawing.Point(12, 370);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 57);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duty Management (Please make sure no our users use the system)";
            // 
            // btn_ResetDutyRecord
            // 
            this.btn_ResetDutyRecord.Location = new System.Drawing.Point(6, 21);
            this.btn_ResetDutyRecord.Name = "btn_ResetDutyRecord";
            this.btn_ResetDutyRecord.Size = new System.Drawing.Size(325, 23);
            this.btn_ResetDutyRecord.TabIndex = 0;
            this.btn_ResetDutyRecord.Text = "Logout System And Reset Duty Record";
            this.btn_ResetDutyRecord.UseVisualStyleBackColor = true;
            this.btn_ResetDutyRecord.Click += new System.EventHandler(this.btn_ResetDutyRecord_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_CreateCustomerData);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(12, 157);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(337, 92);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Customer Account Management";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(325, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Modify Customer Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "Weather Location :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_RefreshWeather);
            this.groupBox4.Controls.Add(this.label9_HK);
            this.groupBox4.Controls.Add(this.textBox_dec);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txt_WeatherStatus);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txt_wind_speed);
            this.groupBox4.Controls.Add(this.txt_pessure);
            this.groupBox4.Controls.Add(this.txt_humidity);
            this.groupBox4.Controls.Add(this.txt_temp_max);
            this.groupBox4.Controls.Add(this.txt_temp_min);
            this.groupBox4.Controls.Add(this.txt_main_temp);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(466, 83);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(322, 360);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Open Weather";
            // 
            // btn_RefreshWeather
            // 
            this.btn_RefreshWeather.Location = new System.Drawing.Point(139, 321);
            this.btn_RefreshWeather.Name = "btn_RefreshWeather";
            this.btn_RefreshWeather.Size = new System.Drawing.Size(157, 23);
            this.btn_RefreshWeather.TabIndex = 30;
            this.btn_RefreshWeather.Text = "Refresh Weather";
            this.btn_RefreshWeather.UseVisualStyleBackColor = true;
            this.btn_RefreshWeather.Click += new System.EventHandler(this.btn_RefreshWeather_Click);
            // 
            // label9_HK
            // 
            this.label9_HK.AutoSize = true;
            this.label9_HK.Location = new System.Drawing.Point(149, 32);
            this.label9_HK.Name = "label9_HK";
            this.label9_HK.Size = new System.Drawing.Size(82, 12);
            this.label9_HK.TabIndex = 29;
            this.label9_HK.Text = "CN, Hong Kong";
            // 
            // textBox_dec
            // 
            this.textBox_dec.Location = new System.Drawing.Point(139, 293);
            this.textBox_dec.Name = "textBox_dec";
            this.textBox_dec.ReadOnly = true;
            this.textBox_dec.Size = new System.Drawing.Size(157, 22);
            this.textBox_dec.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 296);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 12);
            this.label12.TabIndex = 27;
            this.label12.Text = "Weather Description :";
            // 
            // txt_WeatherStatus
            // 
            this.txt_WeatherStatus.Location = new System.Drawing.Point(139, 55);
            this.txt_WeatherStatus.Name = "txt_WeatherStatus";
            this.txt_WeatherStatus.ReadOnly = true;
            this.txt_WeatherStatus.Size = new System.Drawing.Size(157, 22);
            this.txt_WeatherStatus.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 12);
            this.label11.TabIndex = 25;
            this.label11.Text = "Weather status :";
            // 
            // txt_wind_speed
            // 
            this.txt_wind_speed.Location = new System.Drawing.Point(139, 263);
            this.txt_wind_speed.Name = "txt_wind_speed";
            this.txt_wind_speed.ReadOnly = true;
            this.txt_wind_speed.Size = new System.Drawing.Size(157, 22);
            this.txt_wind_speed.TabIndex = 22;
            // 
            // txt_pessure
            // 
            this.txt_pessure.Location = new System.Drawing.Point(139, 231);
            this.txt_pessure.Name = "txt_pessure";
            this.txt_pessure.ReadOnly = true;
            this.txt_pessure.Size = new System.Drawing.Size(157, 22);
            this.txt_pessure.TabIndex = 21;
            // 
            // txt_humidity
            // 
            this.txt_humidity.Location = new System.Drawing.Point(139, 194);
            this.txt_humidity.Name = "txt_humidity";
            this.txt_humidity.ReadOnly = true;
            this.txt_humidity.Size = new System.Drawing.Size(157, 22);
            this.txt_humidity.TabIndex = 20;
            // 
            // txt_temp_max
            // 
            this.txt_temp_max.Location = new System.Drawing.Point(139, 156);
            this.txt_temp_max.Name = "txt_temp_max";
            this.txt_temp_max.ReadOnly = true;
            this.txt_temp_max.Size = new System.Drawing.Size(157, 22);
            this.txt_temp_max.TabIndex = 19;
            // 
            // txt_temp_min
            // 
            this.txt_temp_min.Location = new System.Drawing.Point(139, 125);
            this.txt_temp_min.Name = "txt_temp_min";
            this.txt_temp_min.ReadOnly = true;
            this.txt_temp_min.Size = new System.Drawing.Size(157, 22);
            this.txt_temp_min.TabIndex = 18;
            // 
            // txt_main_temp
            // 
            this.txt_main_temp.Location = new System.Drawing.Point(139, 87);
            this.txt_main_temp.Name = "txt_main_temp";
            this.txt_main_temp.ReadOnly = true;
            this.txt_main_temp.Size = new System.Drawing.Size(157, 22);
            this.txt_main_temp.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "Wind speed :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "Pessure :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "Humidity :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "Temperature max :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "Temperature min :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "Now Temperature :";
            // 
            // btn_CreateCustomerData
            // 
            this.btn_CreateCustomerData.Location = new System.Drawing.Point(6, 51);
            this.btn_CreateCustomerData.Name = "btn_CreateCustomerData";
            this.btn_CreateCustomerData.Size = new System.Drawing.Size(325, 23);
            this.btn_CreateCustomerData.TabIndex = 1;
            this.btn_CreateCustomerData.Text = "Create Customer Data";
            this.btn_CreateCustomerData.UseVisualStyleBackColor = true;
            this.btn_CreateCustomerData.Click += new System.EventHandler(this.btn_CreateCustomerData_Click);
            // 
            // it_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.label1);
            this.Name = "it_UI";
            this.Text = "IT Department";
            this.Load += new System.EventHandler(this.it_UI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button review_user_account_btn;
        private System.Windows.Forms.Button create_user_account_btn;
        private System.Windows.Forms.Button update_user_account_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_ResetDutyRecord;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_wind_speed;
        private System.Windows.Forms.TextBox txt_pessure;
        private System.Windows.Forms.TextBox txt_humidity;
        private System.Windows.Forms.TextBox txt_temp_max;
        private System.Windows.Forms.TextBox txt_temp_min;
        private System.Windows.Forms.TextBox txt_main_temp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_WeatherStatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_dec;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9_HK;
        private System.Windows.Forms.Button btn_RefreshWeather;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_CreateCustomerData;
    }
}