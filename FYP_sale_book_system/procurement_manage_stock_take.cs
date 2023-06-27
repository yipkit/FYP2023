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
    public partial class procurement_manage_stock_take : Form
    {   //NG TSZ KIN
        procurement_stock_take_form stock_Take_Form;
        procurement_stock_take stock_Take;
        string uimode = "";
        public procurement_manage_stock_take(string uiMode)
        {
            InitializeComponent();
            this.uimode = uiMode;
        }

        private void procurement_manage_stock_take_Load(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void createStockTakeFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stock_Take_Form = new procurement_stock_take_form(this, this.uimode);
            stock_Take_Form.MdiParent = this;
            stock_Take_Form.Dock = DockStyle.Fill;
            if (stock_Take != null)
            {
                stock_Take.Close();

            }
            else
            {
                stock_Take_Form.Show();
            }
        }

        private void stockTakeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stock_Take = new procurement_stock_take(this, this.uimode);
            stock_Take.MdiParent = this;
            stock_Take.Dock = DockStyle.Fill;
            if (stock_Take_Form != null)
            {
                stock_Take_Form.Close();

            }
            else
            {
                stock_Take.Show();
            }
        }
    }
}
