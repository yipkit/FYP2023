
namespace FYP_sale_book_system
{
    partial class procurement_UI
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
            this.logout_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.manage_purchase_order = new System.Windows.Forms.Button();
            this.review_stock_btn = new System.Windows.Forms.Button();
            this.edit_stock_btn = new System.Windows.Forms.GroupBox();
            this.manage_stock_btn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.record_btn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.manage_stock_take_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.edit_stock_btn.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 36F);
            this.label1.Location = new System.Drawing.Point(133, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Procurement Department";
            // 
            // logout_btn
            // 
            this.logout_btn.Location = new System.Drawing.Point(648, 39);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(75, 23);
            this.logout_btn.TabIndex = 1;
            this.logout_btn.Text = "Exit";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.manage_purchase_order);
            this.groupBox1.Location = new System.Drawing.Point(12, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 54);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Purchase Order Function";
            // 
            // manage_purchase_order
            // 
            this.manage_purchase_order.Location = new System.Drawing.Point(0, 21);
            this.manage_purchase_order.Name = "manage_purchase_order";
            this.manage_purchase_order.Size = new System.Drawing.Size(226, 23);
            this.manage_purchase_order.TabIndex = 6;
            this.manage_purchase_order.Text = "Manage Purchase Order";
            this.manage_purchase_order.UseVisualStyleBackColor = true;
            this.manage_purchase_order.Click += new System.EventHandler(this.manage_purchase_order_Click);
            // 
            // review_stock_btn
            // 
            this.review_stock_btn.Location = new System.Drawing.Point(6, 50);
            this.review_stock_btn.Name = "review_stock_btn";
            this.review_stock_btn.Size = new System.Drawing.Size(220, 23);
            this.review_stock_btn.TabIndex = 7;
            this.review_stock_btn.Text = "Review Stock";
            this.review_stock_btn.UseVisualStyleBackColor = true;
            this.review_stock_btn.Click += new System.EventHandler(this.review_stock_btn_Click);
            // 
            // edit_stock_btn
            // 
            this.edit_stock_btn.Controls.Add(this.manage_stock_btn);
            this.edit_stock_btn.Controls.Add(this.review_stock_btn);
            this.edit_stock_btn.Location = new System.Drawing.Point(12, 86);
            this.edit_stock_btn.Name = "edit_stock_btn";
            this.edit_stock_btn.Size = new System.Drawing.Size(232, 84);
            this.edit_stock_btn.TabIndex = 3;
            this.edit_stock_btn.TabStop = false;
            this.edit_stock_btn.Text = "Manage Procurement Stock";
            this.edit_stock_btn.Enter += new System.EventHandler(this.edit_stock_btn_Enter);
            // 
            // manage_stock_btn
            // 
            this.manage_stock_btn.Location = new System.Drawing.Point(6, 21);
            this.manage_stock_btn.Name = "manage_stock_btn";
            this.manage_stock_btn.Size = new System.Drawing.Size(220, 23);
            this.manage_stock_btn.TabIndex = 6;
            this.manage_stock_btn.Text = "Manage Stock";
            this.manage_stock_btn.UseVisualStyleBackColor = true;
            this.manage_stock_btn.Click += new System.EventHandler(this.manage_stock_btn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.record_btn);
            this.groupBox3.Location = new System.Drawing.Point(12, 236);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(232, 54);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Procurement Record";
            // 
            // record_btn
            // 
            this.record_btn.Location = new System.Drawing.Point(6, 21);
            this.record_btn.Name = "record_btn";
            this.record_btn.Size = new System.Drawing.Size(220, 23);
            this.record_btn.TabIndex = 3;
            this.record_btn.Text = "Procurement Record";
            this.record_btn.UseVisualStyleBackColor = true;
            this.record_btn.Click += new System.EventHandler(this.record_btn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.manage_stock_take_btn);
            this.groupBox4.Location = new System.Drawing.Point(10, 296);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(234, 54);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Stock Take Function";
            // 
            // manage_stock_take_btn
            // 
            this.manage_stock_take_btn.Location = new System.Drawing.Point(9, 21);
            this.manage_stock_take_btn.Name = "manage_stock_take_btn";
            this.manage_stock_take_btn.Size = new System.Drawing.Size(219, 23);
            this.manage_stock_take_btn.TabIndex = 6;
            this.manage_stock_take_btn.Text = "Manage Stock Take";
            this.manage_stock_take_btn.UseVisualStyleBackColor = true;
            this.manage_stock_take_btn.Click += new System.EventHandler(this.manage_stock_take_btn_Click);
            // 
            // procurement_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.edit_stock_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.label1);
            this.Name = "procurement_UI";
            this.Text = "Procurement Department";
            this.Load += new System.EventHandler(this.procurement_UI_Load);
            this.groupBox1.ResumeLayout(false);
            this.edit_stock_btn.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button update_stock;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button review_stock_btn;
        private System.Windows.Forms.GroupBox edit_stock_btn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button record_btn;
        private System.Windows.Forms.Button manage_stock_btn;
        private System.Windows.Forms.Button manage_purchase_order;
        private System.Windows.Forms.Button manage_stock_take_btn;
    }
}