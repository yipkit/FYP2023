using MySql.Data.MySqlClient;
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
    public partial class procurement_review_invoice : Form
    {   //NG TSZ KIN
        string UI_mode;
        int location_id = 0;
        string status = "";
        private MySqlConnection conn;
        private int resultSYS;
        procurement_review_record review_record;
        private int checkConnection(string mode)
        {
            if (mode == "Normal Mode")
            {
                this.conn = connectDB.connDByipkit0830();
                return 1;
            }
            else
            {
                this.conn = connectDB.connDBNGJACK();
                return 0;
            }

        }

        private void invoice_info()
        {

            if (invoice_no_txt.Text == "")
            {
                this.resultSYS = 0;
                this.resultSYS = checkConnection(this.UI_mode);

                if (this.resultSYS == 1)
                {


                    string SQL1 = "select invoice_no from invoice_record";
                    DataTable dt1 = new DataTable();
                    MySqlCommand cmd1 = new MySqlCommand(SQL1, conn);
                    MySqlDataReader myData1 = cmd1.ExecuteReader();
                    string ref_data = "";

                    while (myData1.Read())
                    {


                        invoice_no_txt.Items.Add(myData1.GetString("invoice_no"));




                    }

                   conn.Close();
                }

            }

        }
        public procurement_review_invoice(procurement_review_record record,string uIMode)
        {
            InitializeComponent();
            this.UI_mode = uIMode;
            this.review_record = record;
        }

        private void procurement_review_invoice_Load(object sender, EventArgs e)
        {
            invoice_info();
        }

        private void invoice_no_txt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void enter_btn_Click(object sender, EventArgs e)
        {
            if (invoice_no_txt.Text != "")
            {
                this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1)
                {     //display invoice information
                    int x = Convert.ToInt32(invoice_no_txt.Text);
                string SQL = "select comp_LocationID,supplier_name,supplier_address,invoice_date,remark from invoice_record where invoice_no = "+x+";";
                DataTable dt = new DataTable();
                MySqlCommand cmd = new MySqlCommand(SQL, conn);
                MySqlDataReader myData = cmd.ExecuteReader();
              
                while (myData.Read())
                {

                    this.location_id = Convert.ToInt32(myData.GetString(0).ToString());
                    supplier_name_txt.Text = myData.GetString(1).ToString();
                    supplier_address_txt.Text = myData.GetString(2).ToString();
                    r_date_txt.Text = myData.GetString(3).ToString();
                    remark_txt.Text = myData.GetString(4).ToString();


                }
                conn.Close();
            }
            else
            {
                MessageBox.Show("Connection Error !!");
            }

           this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1)
            {
                string SQL2 = "select comp_name,comp_Address,comp_PhoneNumber,comp_Status from company where comp_LocationID = " + this.location_id + ";";
                DataTable dt2 = new DataTable();
                MySqlCommand cmd2 = new MySqlCommand(SQL2, conn);
                MySqlDataReader myData2 = cmd2.ExecuteReader();
                
                while (myData2.Read())
                {

  
                     c_name_txt.Text = myData2.GetString(0).ToString();
                    c_address_txt.Text = myData2.GetString(1).ToString();
                    c_phone_txt.Text = myData2.GetString(2).ToString();
                    c_status_txt.Text = myData2.GetString(3).ToString();

                }
                conn.Close();
            }
            else
            {
                MessageBox.Show("Connection Error !!");
            }

            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1)
            {
                int x = Convert.ToInt32(invoice_no_txt.Text);
                string SQL4 = "select SNID,book_name 'Book Name',book_qty 'QTY' from invoice_record where invoice_no = " + x + ";";
                DataTable dt4 = new DataTable();
                MySqlCommand cmd4 = new MySqlCommand(SQL4, conn);
                MySqlDataReader myData4 = cmd4.ExecuteReader();
                dt4.Load(myData4);
                dataGridView1.DataSource = dt4;
                conn.Close();
            }
            else
            {
                MessageBox.Show("Connection Error !!");
            }
        }
            else
            {
                MessageBox.Show("Please select invoice number!!");
            }
}

        private void close_Click(object sender, EventArgs e)
        {
            invoice_no_txt.Items.Clear();
            Close();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {   //restart value
            invoice_no_txt.ResetText();
            r_date_txt.Clear();
            c_name_txt.Clear();
            c_phone_txt.Clear();
            c_address_txt.Clear();
            c_status_txt.Clear();
            supplier_name_txt.Clear();
            supplier_address_txt.Clear();
            remark_txt.Clear();
            dataGridView1.Columns.Clear();
        }
    }
}
