
namespace FYP_sale_book_system
{
    partial class CustomerAccountManagement
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
            this.createCustomerAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyCustomerDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createCustomerAccountToolStripMenuItem,
            this.modifyCustomerDataToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // createCustomerAccountToolStripMenuItem
            // 
            this.createCustomerAccountToolStripMenuItem.Name = "createCustomerAccountToolStripMenuItem";
            this.createCustomerAccountToolStripMenuItem.Size = new System.Drawing.Size(162, 20);
            this.createCustomerAccountToolStripMenuItem.Text = "Create Customer Account";
            this.createCustomerAccountToolStripMenuItem.Click += new System.EventHandler(this.createCustomerAccountToolStripMenuItem_Click);
            // 
            // modifyCustomerDataToolStripMenuItem
            // 
            this.modifyCustomerDataToolStripMenuItem.Name = "modifyCustomerDataToolStripMenuItem";
            this.modifyCustomerDataToolStripMenuItem.Size = new System.Drawing.Size(147, 20);
            this.modifyCustomerDataToolStripMenuItem.Text = "Modify Customer Data";
            this.modifyCustomerDataToolStripMenuItem.Click += new System.EventHandler(this.modifyCustomerDataToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // CustomerAccountManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CustomerAccountManagement";
            this.Text = "Customer Account Management";
            this.Load += new System.EventHandler(this.CustomerAccountManagement_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem createCustomerAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyCustomerDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}