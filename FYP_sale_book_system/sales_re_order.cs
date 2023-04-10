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
    public partial class sales_re_order : Form
    {
        string UI_mode;
        private MySqlConnection conn;
        private int resultSYS;

        private int count = 0;

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
        private void item_count()
        {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1)
            {
                string SQL = "select count(sale_stock_id) from salestock;";
                DataTable dt = new DataTable();
                MySqlCommand cmd = new MySqlCommand(SQL, conn);
                MySqlDataReader myData = cmd.ExecuteReader();

                while (myData.Read())
                {

                    this.count = Convert.ToInt32(myData.GetValue(0));

                }
                conn.Close();
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

                    string SQL1 = "select SNID,bookname,book_qty,book_stockLV,comp_LocationID from salestock where sale_stock_id=" + i + ";";
                    DataTable dt1 = new DataTable();
                    MySqlCommand cmd1 = new MySqlCommand(SQL1, conn);
                    MySqlDataReader myData1 = cmd1.ExecuteReader();
                    Int64 model_no_data = 0;
                    string item_name_data = "";
                    int qty = 0;
                    int qty_lv = 0;
                    int location = 0;
                    while (myData1.Read())
                    {

                        model_no_data = Convert.ToInt64(myData1.GetValue(0));
                        item_name_data = myData1.GetValue(1).ToString();
                        qty = Convert.ToInt32(myData1.GetValue(2));
                        qty_lv = Convert.ToInt32(myData1.GetValue(3));
                        location = Convert.ToInt32(myData1.GetValue(4));

                    }


                    if (qty < qty_lv)
                    {

                        note.Items.Add("Model no : " + model_no_data + ", Item : " + item_name_data + ", LocationID : " + location.ToString() + ", Qty : " + qty + ", Stock Level : " + qty_lv + ", is low stock.");

                    }
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

                string SQL1 = "select distinct(comp_LocationID) from salestock";
                DataTable dt1 = new DataTable();
                MySqlCommand cmd1 = new MySqlCommand(SQL1, conn);
                MySqlDataReader myData1 = cmd1.ExecuteReader();
                string ref_data = "";

                while (myData1.Read())
                {


                    location_id_txt.Items.Add(myData1.GetString("comp_LocationID"));
                    location_txt.Items.Add(myData1.GetString("comp_LocationID"));


                }
                conn.Close();

            }

            else
            {
                MessageBox.Show("Connection Error !!");
            }


        }


        //-----------------------------model_no---------------------------------------------------------

        private void snID()
        {

            if (snid_txt.Text == "")
            {

                this.resultSYS = 0;
                this.resultSYS = checkConnection(this.UI_mode);

                if (this.resultSYS == 1)
                {

                    string SQL1 = "select SNID from salestock";
                    DataTable dt1 = new DataTable();
                    MySqlCommand cmd1 = new MySqlCommand(SQL1, conn);
                    MySqlDataReader myData1 = cmd1.ExecuteReader();
                    string ref_data = "";

                    while (myData1.Read())
                    {


                        snid_txt.Items.Add(myData1.GetString("SNID"));
                        snid1_txt.Items.Add(myData1.GetString("SNID"));


                    }
                }

                conn.Close();
            }

        }
        private void gen_num()
        {
            if (re_order_no_txt.Text == "")
            {
                this.resultSYS = 0;
                this.resultSYS = checkConnection(this.UI_mode);

                if (this.resultSYS == 1)
                {

                    string SQL1 = "select count(sale_re_order_id) from sale_Re_order;";
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


                        re_order_no_txt.Text = "1000";


                    }
                    else
                    {
                         this.resultSYS = 0;
                        this.resultSYS = checkConnection(this.UI_mode);

                        if (this.resultSYS == 1)
                        {


                            string SQL2 = "select sale_re_order_no from sale_Re_order where  sale_re_order_id=" + x + ";";
                            DataTable dt2 = new DataTable();
                            MySqlCommand cmd2 = new MySqlCommand(SQL2, conn);
                            MySqlDataReader myData2 = cmd2.ExecuteReader();

                            int data = 0;

                            while (myData2.Read())
                            {

                                data = Convert.ToInt32(myData2.GetValue(0)) + 1;


                            }
                            conn.Close();

                            re_order_no_txt.Text = data.ToString();
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
 
        public sales_re_order(string uI_mode)
        {
            InitializeComponent();
            this.UI_mode = uI_mode;
        }

        private void sales_re_order_Load(object sender, EventArgs e)
        {
            if (date_txt.Text == "")
            {
                DateTime w = DateTime.Now;
                date_txt.Text = w.ToString("yy-MM-dd");
            }
            snID();
            item_count();
            gen_num();
            location_no();
            check_stock_lv();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1)
            {
                Int64 data1 = Convert.ToInt64(snid_txt.Text);
                int data2 = Convert.ToInt32(location_id_txt.Text);

                //display re-order info
                string SQL = "select * from salestock where SNID='" + data1 + "' and comp_LocationID=" + data2 + ";";
                DataTable dt = new DataTable();
                MySqlCommand cmd = new MySqlCommand(SQL, conn);
                MySqlDataReader myData = cmd.ExecuteReader();
                dt.Load(myData);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            else
            {
                MessageBox.Show("Please select Ref No. and Location ID!!");
            }
            snid_txt.ResetText();
            location_id_txt.ResetText();
        }

        private void close_Click(object sender, EventArgs e)
        {
            snid_txt.Items.Clear();
            snid1_txt.Items.Clear();
            location_id_txt.Items.Clear();
            location_txt.Items.Clear();
            Close();
        }

        private void add_item_Click(object sender, EventArgs e)
        {
            try
            {
                this.resultSYS = 0;
                this.resultSYS = checkConnection(this.UI_mode);

                if (this.resultSYS == 1)
                {
                    //add data to re-order list
                    Int64 snid_data = Convert.ToInt64(snid1_txt.Text);
                    string item_name = item_name_txt.Text;
                    int qty_data = Convert.ToInt32(item_qty_txt.Text);
                    string date_data = date_txt.Text;
                    int location = Convert.ToInt32(location_txt.Text);
                    int order_data = Convert.ToInt32(re_order_no_txt.Text);

                    //add data to database
                    string info_data = "SNID : " + snid1_txt.Text + ", Book name : " + item_name +
                                   ", Qty : " + item_qty_txt.Text + ", Date : " + date_data + ",\n Location : " + location_txt.Text;

                    re_order_list.Items.Add(info_data);

                    string SQL2 = "insert into sale_Re_order values(" + "null," + order_data + "," + location + "," + snid_data + ",'" +
                                                                item_name + "'," + qty_data + ",'" +date_data+ "','pending');";
                    DataTable dt1 = new DataTable();
                    MySqlCommand cmd2 = new MySqlCommand(SQL2, conn);
                    MySqlDataReader myData2 = cmd2.ExecuteReader();
                    conn.Close();
                    item_name_txt.Clear();

                    item_qty_txt.Clear();
                    snid1_txt.ResetText();
                    location_txt.ResetText();
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
        }

        private void snid1_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (snid1_txt.Text != "")
            {
                this.resultSYS = 0;
                this.resultSYS = checkConnection(this.UI_mode);

                if (this.resultSYS == 1)
                {
                    string SQL4 = "select bookname from salestock where SNID = " + Convert.ToInt64(snid1_txt.Text) + ";";
                    DataTable dt4 = new DataTable();
                    MySqlCommand cmd4 = new MySqlCommand(SQL4, conn);
                    // cmd.Parameters.AddWithValue(data, ref_number_txt.Text);
                    MySqlDataReader myData4 = cmd4.ExecuteReader();


                    while (myData4.Read())
                    {
                        item_name_txt.Text = myData4.GetValue(0).ToString();

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
            dataGridView1.Columns.Clear();
        }
    }
}
