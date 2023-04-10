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
    public partial class procurement_stock_take : Form
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

        private void old_info() {

            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1)
            {
                string SQL = "select stock_take_id 'Stock Take ID',stock_take_no 'Stock Take No',stockdb_SNID 'SNID',stockdb_name 'Book Name',stockdb_qty 'Stock Qty',stockdb_date 'In Date',stockdb_details 'Remark',location 'Location ID',create_date 'Create Date' from procurement_stock_take;";
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

        private void new_info() {


            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1)
            {
                string SQL = "select stock_take_id 'Stock Take ID', stock_take_no 'Stock Take No',stock_take_SNID 'SNID',stock_take_name 'Book Name',stock_take_qty 'Stock Take Qty',stock_take_date 'Stock Take Date',stock_take_details 'Remark',location 'Location ID' from procurement_stock_take;";
                DataTable dt = new DataTable();
                MySqlCommand cmd = new MySqlCommand(SQL, conn);
                MySqlDataReader myData = cmd.ExecuteReader();
                dt.Load(myData);
                stock_take_data.DataSource = dt;
                conn.Close();
            }
            else
            {
                MessageBox.Show("Connection Error !!");
            }


        }
        public procurement_stock_take(string uIMode)
        {
            InitializeComponent();
            this.UI_mode = uIMode;
        }

        private void procurement_stock_take_Load(object sender, EventArgs e)
        {
            old_info();
            new_info();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int stock_take_qty = Convert.ToInt32(qty_txt.Text);
                string date_data = date_txt.Text;
                string remark = remark_txt.Text;

                this.resultSYS = 0;
                this.resultSYS = checkConnection(this.UI_mode);

                if (this.resultSYS == 1)
                {
                    string SQL1 = "update procurement_stock_take set stock_take_qty =" + stock_take_qty + ", stock_take_date ='" + date_data + "', stock_take_details='" + remark + "' where stock_take_id = " + Convert.ToInt32(stocktake_id_txt.Text) + ";";
                    DataTable dt1 = new DataTable();
                    MySqlCommand cmd1 = new MySqlCommand(SQL1, conn);
                    MySqlDataReader myData1 = cmd1.ExecuteReader();
                    //insert into stockbook values(null,'abc1234','jack','N/A','N/A','22-06-01','21:20','defect','wf1000','sony tv',1,'IN');
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Connection Error !!");
                }
                MessageBox.Show("Stock Take ID " + stocktake_id_txt.Text + " Updated!!");
                stocktake_id_txt.Clear();
                snid_txt.Clear();
                book_name_txt.Clear();
                qty_txt.Clear();
                remark_txt.Clear();
            }
            catch (Exception a) {


                MessageBox.Show("Please check your data");
            
            }
        }
       

        private void stocktake_id_txt_TextChanged(object sender, EventArgs e)
        {
            if (stocktake_id_txt.Text !="") {
                this.resultSYS = 0;
                this.resultSYS = checkConnection(this.UI_mode);

                if (this.resultSYS == 1)
                {
                    int data = Convert.ToInt32(stocktake_id_txt.Text);
                    string SQL2 = "select stock_take_SNID,stock_take_name from procurement_stock_take where stock_take_id =" + data + ";";
                    DataTable dt2 = new DataTable();
                    MySqlCommand cmd2 = new MySqlCommand(SQL2, conn);
                    MySqlDataReader myData2 = cmd2.ExecuteReader();


                    while (myData2.Read())
                    {
                        snid_txt.Text = myData2.GetValue(0).ToString();
                        book_name_txt.Text = myData2.GetValue(1).ToString();
                    }
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Connection Error !!");
                } 
            }
        }

        private void restart_btn_Click(object sender, EventArgs e)
        {
            old_info();
            new_info();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            if (stocktake_id_txt.Text != " ")
            {
                this.resultSYS = 0;
                this.resultSYS = checkConnection(this.UI_mode);

                if (this.resultSYS == 1)
                {
                    string SQL2 = "select stock_take_id 'Stock Take ID', stock_take_no 'Stock Take No', stock_take_SNID 'SNID',stock_take_name 'Book Name',stock_take_qty 'Stock Take Qty',stock_take_date 'Stock Take Date',stock_take_details 'Remark',location 'Location ID' from procurement_stock_take where stock_take_id =" + Convert.ToInt32(search_txt.Text) + ";";
                    DataTable dt2 = new DataTable();
                    MySqlCommand cmd2 = new MySqlCommand(SQL2, conn);
                    MySqlDataReader myData2 = cmd2.ExecuteReader();
                    dt2.Load(myData2);
                    stock_take_data.DataSource = dt2;
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
                    string SQL2 = "select stock_take_id 'Stock Take ID', stock_take_no 'Stock Take No', stockdb_SNID 'SNID',stockdb_name 'Book Name',stockdb_qty 'Stock Qty',stockdb_date 'In Date',stockdb_details 'Remark',location 'Location ID',create_date 'Create Date' from procurement_stock_take where stock_take_id =" + Convert.ToInt32(search_txt.Text) + ";";
                    DataTable dt2 = new DataTable();
                    MySqlCommand cmd2 = new MySqlCommand(SQL2, conn);
                    MySqlDataReader myData2 = cmd2.ExecuteReader();
                    dt2.Load(myData2);
                    dataGridView2.DataSource = dt2;
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Connection Error !!");
                }
                search_txt.Clear();
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
