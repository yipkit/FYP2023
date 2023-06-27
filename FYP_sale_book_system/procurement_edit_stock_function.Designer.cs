
namespace FYP_sale_book_system
{
    partial class procurement_edit_stock_function
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
            this.addNewItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewItemInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managerSaleReOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewItemToolStripMenuItem,
            this.addNewItemInformationToolStripMenuItem,
            this.editStockToolStripMenuItem,
            this.managerSaleReOrderToolStripMenuItem,
            this.updateStockToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1397, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // addNewItemToolStripMenuItem
            // 
            this.addNewItemToolStripMenuItem.Name = "addNewItemToolStripMenuItem";
            this.addNewItemToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.addNewItemToolStripMenuItem.Text = "Add New Item";
            this.addNewItemToolStripMenuItem.Click += new System.EventHandler(this.addNewItemToolStripMenuItem_Click);
            // 
            // addNewItemInformationToolStripMenuItem
            // 
            this.addNewItemInformationToolStripMenuItem.Name = "addNewItemInformationToolStripMenuItem";
            this.addNewItemInformationToolStripMenuItem.Size = new System.Drawing.Size(169, 20);
            this.addNewItemInformationToolStripMenuItem.Text = "Add New Item Information";
            this.addNewItemInformationToolStripMenuItem.Click += new System.EventHandler(this.addNewItemInformationToolStripMenuItem_Click);
            // 
            // editStockToolStripMenuItem
            // 
            this.editStockToolStripMenuItem.Name = "editStockToolStripMenuItem";
            this.editStockToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.editStockToolStripMenuItem.Text = "Edit Stock";
            this.editStockToolStripMenuItem.Click += new System.EventHandler(this.editStockToolStripMenuItem_Click);
            // 
            // managerSaleReOrderToolStripMenuItem
            // 
            this.managerSaleReOrderToolStripMenuItem.Name = "managerSaleReOrderToolStripMenuItem";
            this.managerSaleReOrderToolStripMenuItem.Size = new System.Drawing.Size(154, 20);
            this.managerSaleReOrderToolStripMenuItem.Text = "Manager Sale Re-Order";
            this.managerSaleReOrderToolStripMenuItem.Click += new System.EventHandler(this.managerSaleReOrderToolStripMenuItem_Click);
            // 
            // updateStockToolStripMenuItem
            // 
            this.updateStockToolStripMenuItem.Name = "updateStockToolStripMenuItem";
            this.updateStockToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.updateStockToolStripMenuItem.Text = "Update Stock";
            this.updateStockToolStripMenuItem.Click += new System.EventHandler(this.updateStockToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // procurement_edit_stock_function
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 651);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "procurement_edit_stock_function";
            this.Text = "Procurement Edit Stock Function";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.procurement_edit_stock_function_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addNewItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewItemInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managerSaleReOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}