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
    public partial class sales_check_sales_stock : Form
    {
        //private
        private MySqlConnection conn;//Location: connectDB.cs
        private int selection;
        private int resultSYS;
        private int count = 0;
        string UI_mode = "";
        
        

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


                        snid_txt.Items.Add(myData1.GetString("SNID"));



                    }

                    conn.Close();
                }
            }

        }

        private void check_stock_lv()
        {


            item_count();

            //sales stock

            for (int i = 1; i <= count; i++)
            {
                    this.resultSYS = 0;
                    this.resultSYS = checkConnection(this.UI_mode);

                if (this.resultSYS == 1)
                {

                    string SQL2 = "select SNID,bookname,book_qty,book_stockLv,bookDetails from salestock where sale_stock_id=" + i + ";";
                    DataTable dt1 = new DataTable();
                    MySqlCommand cmd2 = new MySqlCommand(SQL2, conn);
                    MySqlDataReader myData2 = cmd2.ExecuteReader();
                    Int64 SNID_data = 0;
                    string item_name_data = "";
                    int qty = 0;
                    int qty_lv = 0;
                    string details = "";
                    while (myData2.Read())
                    {
                        SNID_data = Convert.ToInt64(myData2.GetValue(0).ToString());
                        item_name_data = myData2.GetValue(1).ToString();
                        qty = Convert.ToInt32(myData2.GetValue(2));
                        qty_lv = Convert.ToInt32(myData2.GetValue(3));
                        details = myData2.GetValue(4).ToString();

                    }

                    if (qty < qty_lv)
                    {

                        note.Items.Add("SNID : " + SNID_data + ", Item : " + item_name_data + ", Details : " + details.ToString() + ", Qty : " + qty + ", Stock Level : " + qty_lv + ", is low stock.");

                    }

                    conn.Close();
                }


            }
        }


        private void item_count()
        {

            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1)
            {
                string SQL3 = "select count(sale_stock_id) from salestock;";
                DataTable dt = new DataTable();
                MySqlCommand cmd3 = new MySqlCommand(SQL3, conn);
                MySqlDataReader myData3 = cmd3.ExecuteReader();

                while (myData3.Read())
                {

                    this.count = Convert.ToInt32(myData3.GetValue(0));

                }

                conn.Close();
            }

        }

        //-----------------------------location------------------------------------------------------------

        private void location_no()
        {


            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1)
            {

                string SQL1 = "select distinct(comp_LocationID) from company";
                DataTable dt1 = new DataTable();
                MySqlCommand cmd1 = new MySqlCommand(SQL1, conn);
                MySqlDataReader myData1 = cmd1.ExecuteReader();
             

                while (myData1.Read())
                {


                    location_id_txt.Items.Add(myData1.GetString("comp_LocationID"));
                  

                }
                conn.Close();

            }

            else
            {
                MessageBox.Show("Connection Error !!");
            }


        }

        private void sale_stock() {

            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1)
            {

                //display stock info
                string SQL = "select * from salestock;";
                DataTable dt = new DataTable();
                MySqlCommand cmd = new MySqlCommand(SQL, conn);
                MySqlDataReader myData = cmd.ExecuteReader();
                dt.Load(myData);
                sale_stock_data.DataSource = dt;
                conn.Close();
                snid_txt.ResetText();
            }
            else
            {
                MessageBox.Show("Connection Error !!");
            }
        }
     
        public sales_check_sales_stock(string uIMode)
        {
            InitializeComponent();
            UI_mode = uIMode;
            
        }

        private void close_Click(object sender, EventArgs e)
        {
            snid_txt.Items.Clear();
            location_id_txt.Items.Clear();
            note.Items.Clear();
            Close();
        }

        private void reorder_Click(object sender, EventArgs e)
        {
            sales_re_order re_order = new sales_re_order(this.UI_mode);
            re_order.ShowDialog();
        }

        private void sales_check_sales_stock_Load(object sender, EventArgs e)
        {
            check_stock_lv();
            snid_no();
            location_no();
        
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.resultSYS = 0;
                this.resultSYS = checkConnection(this.UI_mode);

                if (this.resultSYS == 1)
                {
                    int item_qty = Convert.ToInt32(qty_txt.Text);
                    Int64 ref_data = Convert.ToInt64(snid_txt.Text);
                    string date_data = date_txt.Text;
                    int location_data = Convert.ToInt32(location_id_txt.Text);
                    string SQL2 = "update salestock set book_qty = book_qty+" + item_qty + ", book_date = '" + date_data + "' where SNID = " + ref_data + " and comp_LocationID =" + location_data + ";";
                    DataTable dt1 = new DataTable();
                    MySqlCommand cmd2 = new MySqlCommand(SQL2, conn);
                    MySqlDataReader myData2 = cmd2.ExecuteReader();

                    MessageBox.Show("SNID : "+snid_txt.Text+", Location ID :"+location_id_txt.Text+" updated");
                    conn.Close();
                    qty_txt.Clear();
                    snid_txt.ResetText();
                    location_id_txt.ResetText();


                }
                else
                {
                    MessageBox.Show("Please check the data again !!");
                }
            }
            catch (Exception c)
            {

                MessageBox.Show("Please check the data again !!");
            }
        }

        private void sort_btn_Click(object sender, EventArgs e)
        {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1)
            {

                Int64 data1 = Convert.ToInt64(snid_txt.Text);


                //display re-order info
                string SQL = "select * from salestock where SNID=" + data1 + ";";
                DataTable dt = new DataTable();
                MySqlCommand cmd = new MySqlCommand(SQL, conn);
                MySqlDataReader myData = cmd.ExecuteReader();
                dt.Load(myData);
                sale_stock_data.DataSource = dt;
                conn.Close();
                snid_txt.ResetText();
            }
            else
            {
                MessageBox.Show("Connection Error !!");
            }
        }

        private void show_stock_btn_Click(object sender, EventArgs e)
        {
            sale_stock();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            note.Items.Clear();
            check_stock_lv();
            sale_stock();
        }
    }
}
