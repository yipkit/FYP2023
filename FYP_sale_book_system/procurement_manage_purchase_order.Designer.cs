
namespace FYP_sale_book_system
{
    partial class procurement_manage_purchase_order
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
            this.createPurchaseOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reviewPurchaseOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createPurchaseOrderToolStripMenuItem,
            this.reviewPurchaseOrderToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1357, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // createPurchaseOrderToolStripMenuItem
            // 
            this.createPurchaseOrderToolStripMenuItem.Name = "createPurchaseOrderToolStripMenuItem";
            this.createPurchaseOrderToolStripMenuItem.Size = new System.Drawing.Size(145, 20);
            this.createPurchaseOrderToolStripMenuItem.Text = "Create Purchase Order";
            this.createPurchaseOrderToolStripMenuItem.Click += new System.EventHandler(this.createPurchaseOrderToolStripMenuItem_Click);
            // 
            // reviewPurchaseOrderToolStripMenuItem
            // 
            this.reviewPurchaseOrderToolStripMenuItem.Name = "reviewPurchaseOrderToolStripMenuItem";
            this.reviewPurchaseOrderToolStripMenuItem.Size = new System.Drawing.Size(148, 20);
            this.reviewPurchaseOrderToolStripMenuItem.Text = "Review Purchase Order";
            this.reviewPurchaseOrderToolStripMenuItem.Click += new System.EventHandler(this.reviewPurchaseOrderToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // procurement_manage_purchase_order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 788);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "procurement_manage_purchase_order";
            this.Text = "Procurement Manage Purchase_order";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.procurement_manage_purchase_order_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem createPurchaseOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reviewPurchaseOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}