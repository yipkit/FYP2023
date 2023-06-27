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
    public partial class procurement_edit_stock_function : Form
    {  //NG TSZ KIN
        procurement_update_stock Update_stock;
        procurement_check_sale_re_order re_order;
        procurement_add_new_item_information add_info;
        procurement_add_new_item add_new_item;
        procurement_edit_stock edit_Stock;
        string uimode = "";
        public procurement_edit_stock_function(string uiMode)
        {
            InitializeComponent();
            this.uimode = uiMode;
        }

        private void procurement_edit_stock_function_Load(object sender, EventArgs e)
        {
            
        }

        private void addNewItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_new_item = new procurement_add_new_item(this, this.uimode);
            add_new_item.MdiParent = this;
            add_new_item.Dock = DockStyle.Fill;
            if (Update_stock != null && re_order != null && add_info != null && edit_Stock != null)
            {
                Update_stock.Close();
                re_order.Close();
                add_info.Close();
                edit_Stock.Close();
            }
            else
            {
                add_new_item.Show();
            }
        }

        private void addNewItemInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_info = new procurement_add_new_item_information(this, this.uimode);
            add_info.MdiParent = this;
            add_info.Dock = DockStyle.Fill;
            if (Update_stock != null && re_order != null && add_new_item != null && edit_Stock != null)
            {
                Update_stock.Close();
                re_order.Close();
                add_new_item.Close();
                edit_Stock.Close();
            }
            else
            {
                add_info.Show();
            }
        }

        private void editStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edit_Stock = new procurement_edit_stock(this, this.uimode);
            edit_Stock.MdiParent = this;
            edit_Stock.Dock = DockStyle.Fill;
            if (Update_stock != null && re_order != null && add_info != null && add_new_item != null)
            {
                Update_stock.Close();
                re_order.Close();
                add_info.Close();
                add_new_item.Close();
            }
            else
            {
                edit_Stock.Show();
            }
        }

        private void managerSaleReOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            re_order = new procurement_check_sale_re_order(this, this.uimode);
            re_order.MdiParent = this;
            re_order.Dock = DockStyle.Fill;
            if (Update_stock != null && edit_Stock != null && add_info != null && add_new_item != null)
            {
                Update_stock.Close();
                edit_Stock.Close();
                add_info.Close();
                add_new_item.Close();
            }
            else
            {
                re_order.Show();
            }
        }

        private void updateStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update_stock = new procurement_update_stock(this, this.uimode);
            Update_stock.MdiParent = this;
            Update_stock.Dock = DockStyle.Fill;
            if (edit_Stock != null && re_order != null && add_info != null && add_new_item != null)
            {
                edit_Stock.Close();
                re_order.Close();
                add_info.Close();
                add_new_item.Close();
            }
            else
            {
                Update_stock.Show();
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
