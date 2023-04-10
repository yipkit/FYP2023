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
    public partial class Accounting_Purchase_Order_Approval : Form
    {
        string UI_mode;
        private MySqlConnection conn;
        private int resultSYS;

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

        private void po_number()
        {

            if (pur_number_txt.Text == "")
            {
                this.resultSYS = 0;
                this.resultSYS = checkConnection(this.UI_mode);

                if (this.resultSYS == 1)
                {

                    string SQL1 = "select distinct(purchase_order_no)  from purchase_order;";
                    DataTable dt1 = new DataTable();
                    MySqlCommand cmd1 = new MySqlCommand(SQL1, conn);
                    MySqlDataReader myData1 = cmd1.ExecuteReader();
                    string ref_data = "";

                    while (myData1.Read())
                    {

                        pur_number_txt.Items.Add(myData1.GetString("purchase_order_no"));

                    }

                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Connection Error !!");
                }
            }


        }

        private void po_info()
        {

            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1)
            {
                string SQL = "select * from purchase_order;";
                DataTable dt = new DataTable();
                MySqlCommand cmd = new MySqlCommand(SQL, conn);
                MySqlDataReader myData = cmd.ExecuteReader();
                dt.Load(myData);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            else
            {
                MessageBox.Show("Connection Error !!");
            }
        }
        public Accounting_Purchase_Order_Approval(string uIMode)
        {
            InitializeComponent();
            this.UI_mode = uIMode;

        }

        private void Accounting_Purchase_Order_Approval_Load(object sender, EventArgs e)
        {
            po_number();
            po_info();
        }

        private void pur_number_txt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void approval_btn_Click(object sender, EventArgs e)
        {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1)
            {
                string status = "Approval";
                string SQL1 = "update purchase_order set POstatus ='" +status+"' where purchase_order_no = '" + pur_number_txt.Text + "';";
                DataTable dt1 = new DataTable();
                MySqlCommand cmd1 = new MySqlCommand(SQL1, conn);
                MySqlDataReader myData1 = cmd1.ExecuteReader();
                conn.Close();

            }
            else
            {
                MessageBox.Show("Connection Error !!");
            }
            MessageBox.Show("Purchase Order Number "+pur_number_txt.Text+" status updated");
            pur_number_txt.ResetText();
            dataGridView1.Columns.Clear();
        }

        private void reject_btn_Click(object sender, EventArgs e)
        {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1)
            {
                string Status = "Reject"; 
                string SQL2 = "update purchase_order set POstatus ='" + Status + "' where purchase_order_no = '" + pur_number_txt.Text + "';";
                DataTable dt2 = new DataTable();
                MySqlCommand cmd2 = new MySqlCommand(SQL2, conn);
                MySqlDataReader myData2 = cmd2.ExecuteReader();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Connection Error !!");
            }
            MessageBox.Show("Purchase Order Number " + pur_number_txt.Text + " status updated");
            pur_number_txt.ResetText();
            dataGridView1.Columns.Clear();
        }

        private void restart_btn_Click(object sender, EventArgs e)
        {
            po_info();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            pur_number_txt.Items.Clear();
            Close();
        }
    }
}
