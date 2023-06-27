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
    public partial class procurement_stock_book : Form
    {   //NG TSZ KIN
        string UI_mode;
        private MySqlConnection conn;
        private int resultSYS;
        string stock_type = "";
        string stock_status = "";
        ErrorControl check = new ErrorControl();
        procurement_review_stock_function review_Stock;

      

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

        private void dept_gen(){


            dept_txt.Items.Add("Procurement");
            dept_txt.Items.Add("Purchase");

        }
        private void supp_inf()
        {

            if (supplier_txt.Text == "")
            {
                this.resultSYS = 0;
                this.resultSYS = checkConnection(this.UI_mode);

                if (this.resultSYS == 1)
                {


                    string SQL1 = "select distinct(supplier_name) from supplier";
                    DataTable dt1 = new DataTable();
                    MySqlCommand cmd1 = new MySqlCommand(SQL1, conn);
                    MySqlDataReader myData1 = cmd1.ExecuteReader();
                    string ref_data = "";

                    while (myData1.Read())
                    {


                        supplier_txt.Items.Add(myData1.GetString("supplier_name"));



                    }

                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Connection Error !!");
                }
            }

        }


        public procurement_stock_book(procurement_review_stock_function review_Stock_Function, string uIMode)
        {
            InitializeComponent();
            this.UI_mode = uIMode;
            this.review_Stock = review_Stock_Function;
        }

        private void procurement_stock_book_Load(object sender, EventArgs e)
        {
            if (time_txt.Text == "")
            {
                DateTime w = DateTime.Now;

                time_txt.Text = w.ToString("HH:mm");
            }
            supp_inf();
            dept_gen();
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1)
            {
                //display info
                string SQL1 = "select stock_book_no 'Stock Book No',comp_LocationID 'Location',invoice_no 'Invoice No',supplier_dept 'Supplier department',supplier_name 'Supplier Name',car_no 'Car No',stock_book_date 'Date',stock_book_time 'Time',stock_type 'Stock Type',SNID ,book_name 'Book Name',book_qty 'Qty',book_status 'Status' from procurement_stock_book;";
                DataTable dt1 = new DataTable();
                MySqlCommand cmd1 = new MySqlCommand(SQL1, conn);
                MySqlDataReader myData1 = cmd1.ExecuteReader();
                dt1.Load(myData1);
                display_list.DataSource = dt1;
                conn.Close();
            }
            else
            {
                MessageBox.Show("Connection Error !!");
            }
        }

        private void normal_radio_CheckedChanged(object sender, EventArgs e)
        {
            stock_type = "Normal";
        }

        private void defect_radio_CheckedChanged(object sender, EventArgs e)
        {
            stock_type = "Defect";
        }

        private void in_radiio_CheckedChanged(object sender, EventArgs e)
        {
            stock_status = "IN";
        }

        private void out_radio_CheckedChanged(object sender, EventArgs e)
        {
            stock_status = "OUT";
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            supplier_txt.Items.Clear();
            Close();
        }

        private void stock_book_no_txt_TextChanged(object sender, EventArgs e)
        {
           
           
            if (stock_book_no_txt.Text != "" && check.checkNUM(stock_book_no_txt.Text))
            {

                this.resultSYS = 0;
                this.resultSYS = checkConnection(this.UI_mode);

                if (this.resultSYS == 1)
                {


                    string SQL1 = "select invoice_no,SNID,book_name,book_qty from procurement_stock_book where stock_book_no =" + stock_book_no_txt.Text + ";";
                    DataTable dt1 = new DataTable();
                    MySqlCommand cmd1 = new MySqlCommand(SQL1, conn);
                    MySqlDataReader myData1 = cmd1.ExecuteReader();
                    string ref_data = "";

                    while (myData1.Read())
                    {


                        invoice_txt.Text = myData1.GetValue(0).ToString();
                        snid_txt.Text = myData1.GetValue(1).ToString();
                        book_name_txt.Text = myData1.GetValue(2).ToString();
                        Qty_txt.Text = myData1.GetValue(3).ToString();

                    }

                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Connection Error !!");
                }
            }
        }

        private void dept_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (stock_book_no_txt.Text!=""&&supplier_txt.Text!=""&&this.stock_type!=""&&this.stock_status!=""&&dept_txt.Text!=""&&car_no_txt.Text!="") { 
            string invoice_data = invoice_txt.Text;
            string cust_name_data = cust_name_txt.Text;
            string supplier_name_data = supplier_txt.Text;
            string car_no_data = car_no_txt.Text;
            string time_data = time_txt.Text;
            string date_data = date_txt.Text;
            Int64 snid_data = Convert.ToInt64(snid_txt.Text);
            string item_name_data = book_name_txt.Text;
            int qty_data = Convert.ToInt32(Qty_txt.Text);
            string dept_data = dept_txt.Text;



            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1)
            {
                //update stock book information
                string SQL = "insert into procurement_stock_book values(" + "null," + 1 + ",'" + invoice_data + "','" + dept_data + "','" + supplier_name_data + "','" + car_no_data + "','" +
                                                      date_data + "','" + time_data + "','" + stock_type + "','" + snid_data + "','" + item_name_data + "'," + qty_data + ",'" + stock_status + "');";
                DataTable dt = new DataTable();
                MySqlCommand cmd = new MySqlCommand(SQL, conn);
                MySqlDataReader myData = cmd.ExecuteReader();
                dt.Load(myData);
                display_list.DataSource = dt;
                conn.Close();
                MessageBox.Show("Stock Book Updated");
            }
            else
            {
                MessageBox.Show("Connection Error !!");
            }

            stock_book_no_txt.Clear();
            invoice_txt.Clear();
            cust_name_txt.Clear();

            car_no_txt.Clear();

            time_txt.Clear();
            snid_txt.ResetText();
            book_name_txt.Clear();
            Qty_txt.Clear();
            normal_radio.Checked = false;
            defect_radio.Checked = false;
            in_radiio.Checked = false;
            out_radio.Checked = false;
            cust_name_txt.Text = "N/A";
            }
            else {
                MessageBox.Show("Please enter stock book number!!"); 
            }
            
        }

        private void sh_supplier_btn_Click(object sender, EventArgs e)
        {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1)
            {   //display supplier information
                string SQL = "select * from supplier;";
                DataTable dt = new DataTable();
                MySqlCommand cmd = new MySqlCommand(SQL, conn);
                MySqlDataReader myData = cmd.ExecuteReader();
                dt.Load(myData);
                display_list.DataSource = dt;
                conn.Close();
            }
            else
            {
                MessageBox.Show("Connection Error !!");
            }
        }

        private void restart_btn_Click(object sender, EventArgs e)
        {     
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1)
            {
                //restart stock book information
                string SQL2 = "select * from procurement_stock_book;";
                DataTable dt2 = new DataTable();
                MySqlCommand cmd2 = new MySqlCommand(SQL2, conn);
                MySqlDataReader myData2 = cmd2.ExecuteReader();
                dt2.Load(myData2);
                display_list.DataSource = dt2;
                conn.Close();
            }
            else
            {
                MessageBox.Show("Connection Error !!");
            }
        }
    }
    
}
