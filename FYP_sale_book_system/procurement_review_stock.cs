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
    public partial class procurement_review_stock : Form
    {
        string UI_mode;
        private MySqlConnection conn;//Location: connectDB.cs
        //private
        private int selection;
        private int resultSYS;
        private int count = 0;


       /* public static MySqlConnection connDB2()
        {

            string host = "localhost";
            string user = "root";
            string pwd = "exia0721";
            string databaseName = "database_version1";

            string connStr = "server=" + host + ";uid=" + user + ";pwd=" + pwd + ";database=" + databaseName;
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("無法連線到資料庫.");
                        break;
                    case 1045:
                        Console.WriteLine("使用者帳號或密碼錯誤,請再試一次.");
                        break;
                }
            }
            return conn;
        }*/

   

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

                    string SQL2 = "select SNID,bookname,book_qty,book_stockLv,bookDetails from procurementstock where procure_stock_id=" + i + ";";
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
                //display
                //sales stock
                string SQL3 = "select count(procure_stock_id) from procurementstock;";
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

   
       
            public procurement_review_stock(string uIMode)
            {
                InitializeComponent();
               this.UI_mode = uIMode;
        }

            private void procurement_review_stock_Load(object sender, EventArgs e)
            {
              check_stock_lv();
                snid_no();
          
            }

            private void search_btn_Click(object sender, EventArgs e)
            {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1)
            {

                Int64 data1 = Convert.ToInt64(snid_txt.Text);


           
                    string SQL = "select * from procurementstock where SNID=" + data1 + ";";
                    DataTable dt = new DataTable();
                    MySqlCommand cmd = new MySqlCommand(SQL, conn);
                    MySqlDataReader myData = cmd.ExecuteReader();
                    dt.Load(myData);
                    dataGridView1.DataSource = dt;
                conn.Close();
                snid_txt.ResetText();
                }
                else
                {
                    MessageBox.Show("Connection Error !!");
                }
            }

        private void restart_btn_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            snid_txt.Items.Clear();
            Close();
        }
    }
    } 
