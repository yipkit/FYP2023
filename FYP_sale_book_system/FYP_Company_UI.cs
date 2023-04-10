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
    public partial class FYP_Company : Form
    {
        Staff_Login_UI staff = new Staff_Login_UI();
        Customer_Login_UI cust = new Customer_Login_UI();
        public FYP_Company()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FYP_Company_Load(object sender, EventArgs e)
        {

        }

        private void staff_btn_Click(object sender, EventArgs e)
        {
            staff.ShowDialog();
        }

        private void cust_btn_Click(object sender, EventArgs e)
        {
            cust.ShowDialog();
        }
    }
}
