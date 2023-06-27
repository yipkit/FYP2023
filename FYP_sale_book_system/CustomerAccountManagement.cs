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
    public partial class CustomerAccountManagement : Form
    {
        it_ModifyCustomerData MCD;
        SalesAndIT_CreateCustomerAccount SAICCA;

        private string UIMode;
        public CustomerAccountManagement(string Mode)
        {
            InitializeComponent();
            this.UIMode = Mode;
        }

        private void CustomerAccountManagement_Load(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void createCustomerAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modifyCustomerDataToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
