using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FYP_sale_book_system
{
    public partial class procurement_manage_purchase_order : Form
    {   //NG TSZ KIN
        procurement_create_purchase_order create_purchase_order;
        procurement_check_purchase_order check_purchase_order;
        string uimode = "";
        public procurement_manage_purchase_order(string UImode)
        {
            InitializeComponent();
            this.uimode = UImode;
        }

        private void createPurchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            create_purchase_order = new procurement_create_purchase_order(this, this.uimode);
            create_purchase_order.MdiParent = this;
            create_purchase_order.Dock = DockStyle.Fill;
            if (check_purchase_order != null )
            {
                check_purchase_order.Close();
              
            }
            else
            {
                create_purchase_order.Show();
            }
        }

        private void reviewPurchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            check_purchase_order = new procurement_check_purchase_order(this, this.uimode);
            check_purchase_order.MdiParent = this;
            check_purchase_order.Dock = DockStyle.Fill;
            if (create_purchase_order != null)
            {
                create_purchase_order.Close();

            }
            else
            {
                check_purchase_order.Show();
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void procurement_manage_purchase_order_Load(object sender, EventArgs e)
        {

        }
    }
}
