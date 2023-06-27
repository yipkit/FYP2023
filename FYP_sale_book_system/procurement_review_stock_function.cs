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
    public partial class procurement_review_stock_function : Form
    {   //NG TSZ KIN
        procurement_review_stock review_Stock;
        procurement_stock_book stock_Book;
        string UImode = "";
        public procurement_review_stock_function(string uimode)
        {
            InitializeComponent();
            this.UImode = uimode;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            review_Stock = new procurement_review_stock(this, this.UImode);
            review_Stock.MdiParent = this;
            review_Stock.Dock = DockStyle.Fill;
            if (stock_Book != null)
                stock_Book.Close();
                review_Stock.Show();
        }

        private void stockBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stock_Book = new procurement_stock_book(this, this.UImode);
            stock_Book.MdiParent = this;
            stock_Book.Dock = DockStyle.Fill;
            if (review_Stock != null)
                review_Stock.Close();
                 stock_Book.Show();
        }

        private void procurement_review_stock_function_Load(object sender, EventArgs e)
        {

        }
    }
}
