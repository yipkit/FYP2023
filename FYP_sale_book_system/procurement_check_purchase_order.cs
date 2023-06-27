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
    
    public partial class procurement_check_purchase_order : Form
    {   //NG TSZ KIN
        string UI_mode;
        private MySqlConnection conn;
        private int resultSYS;
        procurement_manage_purchase_order manage_Purchase_Order;

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

            if (po_txt.Text == "")
            {
                this.resultSYS = 0;
                this.resultSYS = checkConnection(this.UI_mode);

                if (this.resultSYS == 1)
                {

                    string SQL1 = "select distinct(purchase_order_no)  from purchase_order where POStatus ='Approval';";
                    DataTable dt1 = new DataTable();
                    MySqlCommand cmd1 = new MySqlCommand(SQL1, conn);
                    MySqlDataReader myData1 = cmd1.ExecuteReader();
                    string ref_data = "";

                    while (myData1.Read())
                    {


                        po_txt.Items.Add(myData1.GetString("purchase_order_no"));



                    }

                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Connection Error !!");
                }
            }


        }

        private void po_status() {

            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1)
            {
                string SQL = "select distinct(purchase_order_no) 'Purchase Order No',POStatus 'Purchase Order Status' from purchase_order;";
                DataTable dt = new DataTable();
                MySqlCommand cmd = new MySqlCommand(SQL, conn);
                MySqlDataReader myData = cmd.ExecuteReader();
                dt.Load(myData);
                dataGridView2.DataSource = dt;
                conn.Close();
            }
            else
            {
                MessageBox.Show("Connection Error !!");
            }
        }
        public procurement_check_purchase_order(procurement_manage_purchase_order manager_po, string uIMode)
        {
            InitializeComponent();
            this.UI_mode = uIMode;
            this.manage_Purchase_Order = manager_po;
        }

        private void procurement_check_purchase_order_Load(object sender, EventArgs e)
        {
            po_number();
            po_status();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            if (po_txt.Text != "")
            {
                this.resultSYS = 0;
                this.resultSYS = checkConnection(this.UI_mode);

                if (this.resultSYS == 1)
                {   // select purchase order information
                    string SQL2 = "select company_Name,company_Phone,company_Address,supplier_Name,supplier_Phone,supplier_Address,book_total_price from purchase_order where purchase_order_no = '" + po_txt.Text + "';";
                    DataTable dt2 = new DataTable();
                    MySqlCommand cmd2 = new MySqlCommand(SQL2, conn);
                    MySqlDataReader myData2 = cmd2.ExecuteReader();
                    int total_data = 0;

                    while (myData2.Read())
                    {
                        company_name_txt.Text = myData2.GetString(0);
                        c_phone_txt.Text = myData2.GetString(1);
                        c_address_txt.Text = myData2.GetString(2);
                        supplier_txt.Text = myData2.GetString(3);
                        s_phone_txt.Text = myData2.GetString(4);
                        s_address_txt.Text = myData2.GetString(5);
                        total_data += Convert.ToInt32(myData2.GetString(6));
                    }
                    conn.Close();
                    total_txt.Text = total_data.ToString();

                this.resultSYS = 0;
                this.resultSYS = checkConnection(this.UI_mode);

                if (this.resultSYS == 1)
                {
                    string SQL3 = "select SNID,book_name 'Book Name',book_qty 'Qty',book_unit_price 'Book Unit Price',book_total_price 'Book Total Price' from purchase_order where purchase_order_no = '" + po_txt.Text + "';";
                    DataTable dt3 = new DataTable();
                    MySqlCommand cmd3 = new MySqlCommand(SQL3, conn);
                    MySqlDataReader myData3 = cmd3.ExecuteReader();
                    dt3.Load(myData3);
                    dataGridView1.DataSource = dt3;
                    conn.Close();


                    }
                else
                {
                    MessageBox.Show("Connection Error !!");
                }
            }
            else
            {
                MessageBox.Show("Connection Error !!");
            }
            }
            else
            {
                MessageBox.Show("Please select purchase order number!!");
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            po_txt.ResetText();
            company_name_txt.Clear();
            c_phone_txt.Clear();
            c_address_txt.Clear();
            supplier_txt.Clear();
            s_phone_txt.Clear();
            s_address_txt.Clear();
            total_txt.Clear();
            dataGridView1.Columns.Clear();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            po_txt.Items.Clear();
            Close();
        }

        private void po_txt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
