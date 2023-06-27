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
    public partial class procurement_stock_take_form : Form
    {   //NG TSZ KIN
        string UI_mode;
        private MySqlConnection conn;
        private int resultSYS;
        procurement_manage_stock_take stock_Take;

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

        private void stock_take_num()
        {
            if (stock_take_form_no_txt.Text == "")
            {
                this.resultSYS = 0;
                this.resultSYS = checkConnection(this.UI_mode);

                if (this.resultSYS == 1)
                {

                    string SQL1 = "select count(stock_take_id) from procurement_stock_take;";
                    DataTable dt1 = new DataTable();
                    MySqlCommand cmd1 = new MySqlCommand(SQL1, conn);
                    MySqlDataReader myData1 = cmd1.ExecuteReader();
                    int x = 0;
                    while (myData1.Read())
                    {

                        x = Convert.ToInt32(myData1.GetValue(0));


                    }
                    conn.Close();
                    if (x == 0)
                    {


                        stock_take_form_no_txt.Text = 1.ToString();


                    }
                    else
                    {
                        this.resultSYS = 0;
                        this.resultSYS = checkConnection(this.UI_mode);

                        if (this.resultSYS == 1)
                        {


                            string SQL2 = "select stock_take_no from procurement_stock_take where stock_take_id =" + x + ";";
                            DataTable dt2 = new DataTable();
                            MySqlCommand cmd2 = new MySqlCommand(SQL2, conn);
                            MySqlDataReader myData2 = cmd2.ExecuteReader();

                            int data = 0;
                            string newdata = "";
                            while (myData2.Read())
                            {

                                data = Convert.ToInt32(myData2.GetValue(0).ToString());


                            }
                            conn.Close();

                            newdata = (data + 1).ToString();
                            stock_take_form_no_txt.Text = newdata;
                        }
                        else
                        {
                            MessageBox.Show("Connection Error !!");
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Connection Error !!");
                }
            }


        }

        private void company_info()
        {

            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1)
            {
                string SQL = "select comp_LocationID 'Location ID',comp_Name 'Company Name' from company;";
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

        private void company_location_id()
        {


            if (location_id_txt.Text == "")
            {
                this.resultSYS = 0;
                this.resultSYS = checkConnection(this.UI_mode);

                if (this.resultSYS == 1)
                {


                    string SQL1 = "select comp_LocationID from company";
                    DataTable dt1 = new DataTable();
                    MySqlCommand cmd1 = new MySqlCommand(SQL1, conn);
                    MySqlDataReader myData1 = cmd1.ExecuteReader();
                    string ref_data = "";

                    while (myData1.Read())
                    {

                        location_id_txt.Items.Add(myData1.GetString("comp_LocationID"));

                    }

                    conn.Close();
                }
            }
        }

        public procurement_stock_take_form(procurement_manage_stock_take manage_Stock_Take, string uIMode)
        {
            InitializeComponent();
            this.UI_mode = uIMode;
            this.stock_Take = manage_Stock_Take;
        }

        private void procurement_stock_take_form_Load(object sender, EventArgs e)
        {
            stock_take_num();
            company_location_id();
            company_info();
        }

        private void show_stock_take_form_btn_Click(object sender, EventArgs e)
        {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1)
            {    //display stock take list information
                string SQL = "select * from procurement_stock_take;";
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

        private void procurement_stock() {

            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1)
            {
                string SQL = "select procure_stock_id 'Stock ID', SNID,bookname 'Book Name',book_qty 'Qty',book_stockLv 'Stock Level', authors_name 'AuthorsName',language,category,detail ,book_date 'In Date',p.comp_LocationID 'Location ID',comp_Name 'Company Name' " +
                      "from procurementstock p, authors a,languages l,category c,company comp where p.comp_LocationID = comp.comp_LocationID and p.authors_id=a.authors_id and p.languages_id=l.languages_id and p.category_id = c.category_id ;";
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

        private void clean_value_txt_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            stock_take_form_no_txt.Clear();
            location_id_txt.ResetText();
            stock_take_num();
        }

      private void gen_form_btn_Click(object sender, EventArgs e)
        {
            if (location_id_txt.Text!="") { 
            int location_id = Convert.ToInt32(location_id_txt.Text);
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1)
            {
                string SQL2 = "select SNID,bookname,book_qty,book_date,bookDetails,comp_LocationID from procurementstock where comp_LocationID = "+location_id+";";
                DataTable dt2 = new DataTable();
                MySqlCommand cmd2 = new MySqlCommand(SQL2, conn);
                MySqlDataReader myData2 = cmd2.ExecuteReader();
                int total_data = 0;
                string date_data = "";
                DateTime convert_data;
                string sql_date = "";
                
                while (myData2.Read())
                {
                    date_data = myData2.GetValue(3).ToString();
                    convert_data = DateTime.Parse(date_data);
                    sql_date = convert_data.ToString("yyyy-MM-dd");

                    this.resultSYS = 0;
                    this.resultSYS = checkConnection(this.UI_mode);

                    if (this.resultSYS == 1)
                    {
                        //input item information
                        string SQL = "insert into procurement_stock_take values(" + "null," + Convert.ToInt32(stock_take_form_no_txt.Text) + "," + Convert.ToInt64(myData2.GetValue(0)) + ",'" + myData2.GetValue(1) + "'," + "null" + "," + "'1990-01-01'" + "," +
                                       "'NULL'"+ "," + Convert.ToInt64(myData2.GetValue(0)) + ",'" + myData2.GetValue(1) + "'," + myData2.GetValue(2) + ",'" +sql_date+ "','" + myData2.GetValue(4) + "'," + myData2.GetValue(5) +",'"+c_f_date_txt.Text+"');";
                        DataTable dt = new DataTable();
                        MySqlCommand cmd = new MySqlCommand(SQL, conn);
                        MySqlDataReader myData = cmd.ExecuteReader();
                        dt.Load(myData);
                        //display_list.DataSource = dt;
                        conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("Connection Error !!");
                    }
                }
                conn.Close();
            }
            else
            {
                MessageBox.Show("Connection Error !!");
            }

            MessageBox.Show("Stock Take Form Number "+stock_take_form_no_txt.Text+" Created");
            stock_take_form_no_txt.Clear();
            location_id_txt.ResetText();
            }
            else { 
                MessageBox.Show("Please select location ID !!"); 
            }
           
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            location_id_txt.Items.Clear();
            Close();
        }

        private void procure_stock_btn_Click(object sender, EventArgs e)
        {   //display procurement stock information
            procurement_stock();
        }
    }
}
