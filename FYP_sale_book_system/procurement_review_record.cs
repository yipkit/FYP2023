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
    public partial class procurement_review_record : Form
    {   //NG TSZ KIN
        string uImode = "";
        procurement_review_delivery_note delivery_Note;
        procurement_review_invoice invoice;
        public procurement_review_record(string uimode)
        {
            InitializeComponent();
            this.uImode = uimode;
        }

        private void invoiceRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            invoice = new procurement_review_invoice(this, this.uImode);
            invoice.MdiParent = this;
            invoice.Dock = DockStyle.Fill;
            if (delivery_Note != null)
                delivery_Note.Close();
                invoice.Show();

        }

        private void deliveryNoteRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delivery_Note = new procurement_review_delivery_note(this, this.uImode);
            delivery_Note.MdiParent = this;
            delivery_Note.Dock = DockStyle.Fill;
            if (invoice != null)
                invoice.Close();
                delivery_Note.Show();
        }

        private void procurement_review_record_Load(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
