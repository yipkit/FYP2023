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
    public partial class Customer_UI : Form
    {
        customer_payment payment = new customer_payment();
        customer_borrow_e_book_and_book borrow_eBook_and_book = new customer_borrow_e_book_and_book();
        customer_return_book return_book = new customer_return_book();
        customer_search_book search_book = new customer_search_book();
        public Customer_UI()
        {
            InitializeComponent();
        }

        private void Customer_UI_Load(object sender, EventArgs e)
        {

        }

        private void payment_btn_Click(object sender, EventArgs e)
        {
            payment.Show();
        }

        private void borrow_e_book_and_book_btn_Click(object sender, EventArgs e)
        {
            borrow_eBook_and_book.Show();
        }

        private void return_book_btn_Click(object sender, EventArgs e)
        {
            return_book.Show();
        }

        private void search_book_btn_Click(object sender, EventArgs e)
        {
            search_book.Show();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
