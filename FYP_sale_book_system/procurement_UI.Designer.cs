
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
            this.add_new_item_btn = new System.Windows.Forms.Button();
            this.add_new_item_info_btn = new System.Windows.Forms.Button();
            this.sale_re_order_btn = new System.Windows.Forms.Button();
            this.stock_book_btn = new System.Windows.Forms.Button();
            this.review_stock_btn = new System.Windows.Forms.Button();
            this.stock_take_btn = new System.Windows.Forms.Button();
            this.create_stock_take_form_btn = new System.Windows.Forms.Button();
            this.check_purchase_order_btn = new System.Windows.Forms.Button();
            this.create_purchase_order_btn = new System.Windows.Forms.Button();
            this.invoice_btn = new System.Windows.Forms.Button();
            this.delivery_note_btn = new System.Windows.Forms.Button();
            this.update_stock_btn = new System.Windows.Forms.Button();
            this.edit_stock_btn = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.edit_Stock = new System.Windows.Forms.Button();
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
            this.groupBox1.Controls.Add(this.check_purchase_order_btn);
            this.groupBox1.Controls.Add(this.create_purchase_order_btn);
            this.groupBox1.Location = new System.Drawing.Point(18, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Purchase Order Function";
            // 
            // add_new_item_btn
            // 
            this.add_new_item_btn.Location = new System.Drawing.Point(142, 48);
            this.add_new_item_btn.Name = "add_new_item_btn";
            this.add_new_item_btn.Size = new System.Drawing.Size(144, 23);
            this.add_new_item_btn.TabIndex = 11;
            this.add_new_item_btn.Text = "Add New Item";
            this.add_new_item_btn.UseVisualStyleBackColor = true;
            this.add_new_item_btn.Click += new System.EventHandler(this.add_new_item_btn_Click);
            // 
            // add_new_item_info_btn
            // 
            this.add_new_item_info_btn.Location = new System.Drawing.Point(142, 21);
            this.add_new_item_info_btn.Name = "add_new_item_info_btn";
            this.add_new_item_info_btn.Size = new System.Drawing.Size(144, 23);
            this.add_new_item_info_btn.TabIndex = 10;
            this.add_new_item_info_btn.Text = "Add New Item Information";
            this.add_new_item_info_btn.UseVisualStyleBackColor = true;
            this.add_new_item_info_btn.Click += new System.EventHandler(this.add_new_item_info_btn_Click);
            // 
            // sale_re_order_btn
            // 
            this.sale_re_order_btn.Location = new System.Drawing.Point(142, 77);
            this.sale_re_order_btn.Name = "sale_re_order_btn";
            this.sale_re_order_btn.Size = new System.Drawing.Size(144, 23);
            this.sale_re_order_btn.TabIndex = 9;
            this.sale_re_order_btn.Text = "Check Sale Re-order";
            this.sale_re_order_btn.UseVisualStyleBackColor = true;
            this.sale_re_order_btn.Click += new System.EventHandler(this.sale_re_order_btn_Click);
            // 
            // stock_book_btn
            // 
            this.stock_book_btn.Location = new System.Drawing.Point(6, 48);
            this.stock_book_btn.Name = "stock_book_btn";
            this.stock_book_btn.Size = new System.Drawing.Size(130, 23);
            this.stock_book_btn.TabIndex = 8;
            this.stock_book_btn.Text = "Stock Book";
            this.stock_book_btn.UseVisualStyleBackColor = true;
            this.stock_book_btn.Click += new System.EventHandler(this.stock_book_btn_Click);
            // 
            // review_stock_btn
            // 
            this.review_stock_btn.Location = new System.Drawing.Point(6, 77);
            this.review_stock_btn.Name = "review_stock_btn";
            this.review_stock_btn.Size = new System.Drawing.Size(130, 23);
            this.review_stock_btn.TabIndex = 7;
            this.review_stock_btn.Text = "Review Stock";
            this.review_stock_btn.UseVisualStyleBackColor = true;
            this.review_stock_btn.Click += new System.EventHandler(this.review_stock_btn_Click);
            // 
            // stock_take_btn
            // 
            this.stock_take_btn.Location = new System.Drawing.Point(6, 50);
            this.stock_take_btn.Name = "stock_take_btn";
            this.stock_take_btn.Size = new System.Drawing.Size(130, 23);
            this.stock_take_btn.TabIndex = 6;
            this.stock_take_btn.Text = "Stock Take";
            this.stock_take_btn.UseVisualStyleBackColor = true;
            this.stock_take_btn.Click += new System.EventHandler(this.stock_take_btn_Click);
            // 
            // create_stock_take_form_btn
            // 
            this.create_stock_take_form_btn.Location = new System.Drawing.Point(6, 21);
            this.create_stock_take_form_btn.Name = "create_stock_take_form_btn";
            this.create_stock_take_form_btn.Size = new System.Drawing.Size(130, 23);
            this.create_stock_take_form_btn.TabIndex = 5;
            this.create_stock_take_form_btn.Text = "Create Stock Take Form";
            this.create_stock_take_form_btn.UseVisualStyleBackColor = true;
            this.create_stock_take_form_btn.Click += new System.EventHandler(this.create_stock_take_form_btn_Click);
            // 
            // check_purchase_order_btn
            // 
            this.check_purchase_order_btn.Location = new System.Drawing.Point(6, 50);
            this.check_purchase_order_btn.Name = "check_purchase_order_btn";
            this.check_purchase_order_btn.Size = new System.Drawing.Size(130, 23);
            this.check_purchase_order_btn.TabIndex = 4;
            this.check_purchase_order_btn.Text = "Check Purchase Order";
            this.check_purchase_order_btn.UseVisualStyleBackColor = true;
            this.check_purchase_order_btn.Click += new System.EventHandler(this.check_purchase_order_btn_Click);
            // 
            // create_purchase_order_btn
            // 
            this.create_purchase_order_btn.Location = new System.Drawing.Point(6, 21);
            this.create_purchase_order_btn.Name = "create_purchase_order_btn";
            this.create_purchase_order_btn.Size = new System.Drawing.Size(130, 23);
            this.create_purchase_order_btn.TabIndex = 3;
            this.create_purchase_order_btn.Text = "Create Purchase Order";
            this.create_purchase_order_btn.UseVisualStyleBackColor = true;
            this.create_purchase_order_btn.Click += new System.EventHandler(this.create_purchase_order_btn_Click);
            // 
            // invoice_btn
            // 
            this.invoice_btn.Location = new System.Drawing.Point(6, 19);
            this.invoice_btn.Name = "invoice_btn";
            this.invoice_btn.Size = new System.Drawing.Size(130, 23);
            this.invoice_btn.TabIndex = 2;
            this.invoice_btn.Text = "Invoice";
            this.invoice_btn.UseVisualStyleBackColor = true;
            this.invoice_btn.Click += new System.EventHandler(this.invoice_btn_Click);
            // 
            // delivery_note_btn
            // 
            this.delivery_note_btn.Location = new System.Drawing.Point(6, 48);
            this.delivery_note_btn.Name = "delivery_note_btn";
            this.delivery_note_btn.Size = new System.Drawing.Size(130, 23);
            this.delivery_note_btn.TabIndex = 1;
            this.delivery_note_btn.Text = "Delivery Note";
            this.delivery_note_btn.UseVisualStyleBackColor = true;
            this.delivery_note_btn.Click += new System.EventHandler(this.delivery_note_btn_Click);
            // 
            // update_stock_btn
            // 
            this.update_stock_btn.Location = new System.Drawing.Point(6, 19);
            this.update_stock_btn.Name = "update_stock_btn";
            this.update_stock_btn.Size = new System.Drawing.Size(130, 23);
            this.update_stock_btn.TabIndex = 0;
            this.update_stock_btn.Text = "Update Stock";
            this.update_stock_btn.UseVisualStyleBackColor = true;
            this.update_stock_btn.Click += new System.EventHandler(this.update_stock_btn_Click);
            // 
            // edit_stock_btn
            // 
            this.edit_stock_btn.Controls.Add(this.edit_Stock);
            this.edit_stock_btn.Controls.Add(this.sale_re_order_btn);
            this.edit_stock_btn.Controls.Add(this.add_new_item_btn);
            this.edit_stock_btn.Controls.Add(this.update_stock_btn);
            this.edit_stock_btn.Controls.Add(this.add_new_item_info_btn);
            this.edit_stock_btn.Controls.Add(this.stock_book_btn);
            this.edit_stock_btn.Controls.Add(this.review_stock_btn);
            this.edit_stock_btn.Location = new System.Drawing.Point(12, 86);
            this.edit_stock_btn.Name = "edit_stock_btn";
            this.edit_stock_btn.Size = new System.Drawing.Size(377, 115);
            this.edit_stock_btn.TabIndex = 3;
            this.edit_stock_btn.TabStop = false;
            this.edit_stock_btn.Text = "Stock Function";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.delivery_note_btn);
            this.groupBox3.Controls.Add(this.invoice_btn);
            this.groupBox3.Location = new System.Drawing.Point(326, 207);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(141, 100);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delivery Record";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.stock_take_btn);
            this.groupBox4.Controls.Add(this.create_stock_take_form_btn);
            this.groupBox4.Location = new System.Drawing.Point(173, 207);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(147, 100);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Stock Take Function";
            // 
            // edit_Stock
            // 
            this.edit_Stock.Location = new System.Drawing.Point(292, 21);
            this.edit_Stock.Name = "edit_Stock";
            this.edit_Stock.Size = new System.Drawing.Size(75, 23);
            this.edit_Stock.TabIndex = 12;
            this.edit_Stock.Text = "Edit Stock";
            this.edit_Stock.UseVisualStyleBackColor = true;
            this.edit_Stock.Click += new System.EventHandler(this.edit_Stock_Click);
            // 
            // procurement_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private System.Windows.Forms.Button invoice_btn;
        private System.Windows.Forms.Button delivery_note_btn;
        private System.Windows.Forms.Button update_stock_btn;
        private System.Windows.Forms.Button check_purchase_order_btn;
        private System.Windows.Forms.Button create_purchase_order_btn;
        private System.Windows.Forms.Button stock_take_btn;
        private System.Windows.Forms.Button create_stock_take_form_btn;
        private System.Windows.Forms.Button review_stock_btn;
        private System.Windows.Forms.Button stock_book_btn;
        private System.Windows.Forms.Button sale_re_order_btn;
        private System.Windows.Forms.Button add_new_item_info_btn;
        private System.Windows.Forms.Button add_new_item_btn;
        private System.Windows.Forms.GroupBox edit_stock_btn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button edit_Stock;
    }
}