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
    public partial class procurement_check_sale_re_order : Form
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

        private void sale_re_order_info() {

            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1)
            {
                string SQL = "select * from sale_Re_order;";
                DataTable dt = new DataTable();
                MySqlCommand cmd = new MySqlCommand(SQL, conn);
                MySqlDataReader myData = cmd.ExecuteReader();
                dt.Load(myData);
                dataGridView2.DataSource = dt;
                conn.Close();
                note_txt.Clear();
            }
            else
            {
                MessageBox.Show("Connection Error !!");
            }


        }
 
        private void change_qty(Int64 ItemID)
        {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1)
            {
                string SQL = "update procurementstock set book_qty = 0 where SNID = '" + ItemID + "';";
                MySqlCommand cmd = new MySqlCommand(SQL, conn);
                MySqlDataReader MyData = cmd.ExecuteReader();
                conn.Close();
            }



        }

        private void sale_re_order_id()
        {

            if (re_order_txt.Text == "")
            {
                this.resultSYS = 0;
                this.resultSYS = checkConnection(this.UI_mode);

                if (this.resultSYS == 1)
                {

                    string SQL1 = "select distinct(sale_re_order_id)  from sale_Re_order;";
                    DataTable dt1 = new DataTable();
                    MySqlCommand cmd1 = new MySqlCommand(SQL1, conn);
                    MySqlDataReader myData1 = cmd1.ExecuteReader();
                    string ref_data = "";

                    while (myData1.Read())
                    {


                        re_order_txt.Items.Add(myData1.GetString("sale_re_order_id"));
                        re_order_id_txt.Items.Add(myData1.GetString("sale_re_order_id"));



                    }

                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Connection Error !!");
                }
            }


        }

        private void gen_time() {

            if (time_txt.Text == "")
            {
                DateTime w = DateTime.Now;

                time_txt.Text = w.ToString("HH:mm");
            }

        }

        private void snid_no()
        {


            if (snid_txt.Text == "")
            {
                this.resultSYS = 0;
                this.resultSYS = checkConnection(this.UI_mode);

                if (this.resultSYS == 1)
                {


                    string SQL1 = "select SNID from procurementstock";
                    DataTable dt1 = new DataTable();
                    MySqlCommand cmd1 = new MySqlCommand(SQL1, conn);
                    MySqlDataReader myData1 = cmd1.ExecuteReader();
                    string ref_data = "";

                    while (myData1.Read())
                    {


                       
                        snid1_txt.Items.Add(myData1.GetString("SNID"));



                    }

                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Connection Error !!");
                }
            }

        }
        public procurement_check_sale_re_order(string uIMode)
        {
            InitializeComponent();
            this.UI_mode = uIMode;
        }

       private void procurement_check_sale_re_order_Load(object sender, EventArgs e)
        {
            gen_time();
            snid_no();
            sale_re_order_id();
           
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
           try
            {

               
                    Int64 snid_data = Convert.ToInt64(snid_txt.Text);
                    int qty_data = Convert.ToInt32(qty_txt.Text);
                    string dept_data = location_id_txt.Text;
                    string date_data = date_txt.Text;
                    string time_data = time_txt.Text;
                    string invoice_data = re_order_no_txt.Text;
                    string item_name_data = "";


                    this.resultSYS = 0;
                    this.resultSYS = checkConnection(this.UI_mode);

                    if (this.resultSYS == 1)
                    {

                        string SQL3 = "select bookname from salestock where SNID = " + snid_data + ";";
                        DataTable dt3 = new DataTable();
                        MySqlCommand cmd3 = new MySqlCommand(SQL3, conn);
                      //  cmd3.Parameters.AddWithValue(snid_data, snid_txt.Text);
                        MySqlDataReader myData3 = cmd3.ExecuteReader();


                        while (myData3.Read())
                        {
                            item_name_data = myData3.GetValue(0).ToString();

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
                        string SQL = "update procurementstock set book_qty = book_qty-" + qty_data + " where SNID = " + snid_data + ";";
                        DataTable dt = new DataTable();
                        MySqlCommand cmd = new MySqlCommand(SQL, conn);
                        MySqlDataReader myData = cmd.ExecuteReader();
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
                        //string SQL2 = "insert into stockbook values(" + "null,'" + invoice_data + "','" + dept_data + "','" + "N/A" + "','" + "N/A" + "','" + "N/A" + "','" +
                                                                 //date_data + "','" + time_data + "','" + "Normal" + "','" + snid_data + "','" + item_name_data + "'," + qty_data + ",'" + "OUT" + "');";

                       string SQL2 = "insert into procurement_stock_book values(" + "null," + 1 + ",'" + invoice_data + "','" + dept_data + "','" + "NULL" + "','" + "NULL" + "','" +
                                                      date_data + "','" + time_data + "','" + "Normal" + "','" + snid_data + "','" + item_name_data + "'," + qty_data + ",'" + "OUT" + "');";
                    DataTable dt2 = new DataTable();
                        MySqlCommand cmd2 = new MySqlCommand(SQL2, conn);
                        MySqlDataReader myData2 = cmd2.ExecuteReader();
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
                        string SQL1 = "select book_qty,book_stockLV,bookname from procurementstock where SNID = '" + snid_data + "';";
                        DataTable dt1 = new DataTable();
                        MySqlCommand cmd1 = new MySqlCommand(SQL1, conn);

                        MySqlDataReader myData1 = cmd1.ExecuteReader();



                        int check_qty_data = 0;
                        int check_stock_lv_data = 0;
                        string check_item_name = "";

                        while (myData1.Read())
                        {

                            check_qty_data = Convert.ToInt32(myData1.GetValue(0));
                            check_stock_lv_data = Convert.ToInt32(myData1.GetValue(1));
                            check_item_name = (string)myData1.GetValue(2);




                        }
                    


                    //check inventory stock
                    if (check_qty_data < check_stock_lv_data)
                        {
                            if (check_qty_data < 0)
                            {
                                change_qty(snid_data);
                                note_txt.Text = check_item_name + " is low stock!!";
                            }
                            else
                            {
                                note_txt.Text = check_item_name + " is low stock!!";
                            }
                        }
                    conn.Close();
                }
                    else
                    {
                        MessageBox.Show("Connection Error !!");
                    }
                
                
            }

           catch (Exception c)
            {

                MessageBox.Show("Please check the data again !!");

           }
            MessageBox.Show("Sale Re Order no "+re_order_no_txt.Text+ " is completed");
            re_order_id_txt.ResetText();
            snid_txt.Clear();
            qty_txt.Clear();
            re_order_no_txt.Clear();

            time_txt.Clear();
            location_id_txt.Clear();
            gen_time();


        }

        private void re_order_id_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (re_order_id_txt.Text != "")
            {
               

                this.resultSYS = 0;
                this.resultSYS = checkConnection(this.UI_mode);

                if (this.resultSYS == 1)
                { 
                    int data = Convert.ToInt32(re_order_id_txt.Text);

                    string SQL6 = "select sale_re_order_no,SNID, book_qty,comp_LocationID from sale_Re_order where sale_re_order_id = " + data + ";";
                    DataTable dt6 = new DataTable();
                    MySqlCommand cmd6 = new MySqlCommand(SQL6, conn);

                    MySqlDataReader myData6 = cmd6.ExecuteReader();


                    while (myData6.Read())
                    {
                        re_order_no_txt.Text = myData6.GetValue(0).ToString();
                        snid_txt.Text = myData6.GetValue(1).ToString();
                        qty_txt.Text = myData6.GetValue(2).ToString();
                        location_id_txt.Text = "Sales (Location ID:" + Convert.ToString(myData6.GetValue(3)) + ")";
                    }
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Connection Error !!");
                }

            }
        }

        private void show_re_order_Click(object sender, EventArgs e)
        {
            sale_re_order_info();
        }

        private void show_inventory_stock_Click(object sender, EventArgs e)
        {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1)
            {
                string SQL = "select * from procurementstock;";
                DataTable dt = new DataTable();
                MySqlCommand cmd = new MySqlCommand(SQL, conn);
                MySqlDataReader myData = cmd.ExecuteReader();
                dt.Load(myData);
                dataGridView2.DataSource = dt;
                note_txt.Clear();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Connection Error !!");
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            re_order_id_txt.Items.Clear();
            re_order_txt.Items.Clear();
            Close();
        }

        private void complete_btn_Click(object sender, EventArgs e)
        {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1)
            {
                string SQL = "update sale_Re_order set re_order_status = '"+ "Complete" + "' where sale_re_order_id = "+Convert.ToInt32(re_order_txt.Text)+ ";";
                DataTable dt = new DataTable();
                MySqlCommand cmd = new MySqlCommand(SQL, conn);
                MySqlDataReader myData = cmd.ExecuteReader();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Connection Error !!");
            }
            re_order_txt.ResetText();
        }

        private void restart_btn_Click_1(object sender, EventArgs e)
        {
            re_order_id_txt.ResetText();
            snid_txt.Clear();
            qty_txt.Clear();
            re_order_no_txt.Clear();
            time_txt.Clear();
            location_id_txt.Clear();
            note_txt.Clear();
            gen_time();
            dataGridView2.Columns.Clear();
        }

        private void model_no_txt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1)
            {
                string SQL = "select * from procurementstock where SNID = " + Convert.ToInt64(snid1_txt.Text) + ";";
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
    }
}
