
namespace FYP_sale_book_system
{
    partial class FYP_Company
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
            this.staff_btn = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 36F);
            this.label1.Location = new System.Drawing.Point(244, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "FYP Company";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // staff_btn
            // 
            this.staff_btn.Font = new System.Drawing.Font("新細明體", 12F);
            this.staff_btn.Location = new System.Drawing.Point(349, 201);
            this.staff_btn.Name = "staff_btn";
            this.staff_btn.Size = new System.Drawing.Size(96, 23);
            this.staff_btn.TabIndex = 2;
            this.staff_btn.Text = "Staff";
            this.staff_btn.UseVisualStyleBackColor = true;
            this.staff_btn.Click += new System.EventHandler(this.staff_btn_Click);
            // 
            // close_btn
            // 
            this.close_btn.Font = new System.Drawing.Font("新細明體", 12F);
            this.close_btn.Location = new System.Drawing.Point(664, 31);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(75, 23);
            this.close_btn.TabIndex = 3;
            this.close_btn.Text = "Close";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // FYP_Company
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.staff_btn);
            this.Controls.Add(this.label1);
            this.Name = "FYP_Company";
            this.Text = "FYP_Company";
            this.Load += new System.EventHandler(this.FYP_Company_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button staff_btn;
        private System.Windows.Forms.Button close_btn;
    }
}

