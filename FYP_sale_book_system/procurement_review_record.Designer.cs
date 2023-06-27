
namespace FYP_sale_book_system
{
    partial class procurement_review_record
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.invoiceRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveryNoteRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.invoiceRecordToolStripMenuItem,
            this.deliveryNoteRecordToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // invoiceRecordToolStripMenuItem
            // 
            this.invoiceRecordToolStripMenuItem.Name = "invoiceRecordToolStripMenuItem";
            this.invoiceRecordToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.invoiceRecordToolStripMenuItem.Text = "Invoice Record";
            this.invoiceRecordToolStripMenuItem.Click += new System.EventHandler(this.invoiceRecordToolStripMenuItem_Click);
            // 
            // deliveryNoteRecordToolStripMenuItem
            // 
            this.deliveryNoteRecordToolStripMenuItem.Name = "deliveryNoteRecordToolStripMenuItem";
            this.deliveryNoteRecordToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.deliveryNoteRecordToolStripMenuItem.Text = "Delivery Note Record";
            this.deliveryNoteRecordToolStripMenuItem.Click += new System.EventHandler(this.deliveryNoteRecordToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // procurement_review_record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 732);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "procurement_review_record";
            this.Text = "Procurement Review Record";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.procurement_review_record_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem invoiceRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deliveryNoteRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}