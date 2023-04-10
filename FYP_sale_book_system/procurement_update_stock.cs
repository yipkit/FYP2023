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
    public partial class procurement_update_stock : Form
    {
        string UI_mode;
        private MySqlConnection conn;
        private int resultSYS;
        string stock_type = "";
        string stock_status = "";

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
        public procurement_update_stock(string UIMode)
        {
            InitializeComponent();
            this.UI_mode = UIMode;
        }

        public bool UseVisualStyleBackColor { get; internal set; }

        public static implicit operator procurement_update_stock(Button v) => throw new NotImplementedException();

        private void delivery_note_btn_Click(object sender, EventArgs e)
        {
            procurement_delivery_note_record delivery_note = new procurement_delivery_note_record(this.UI_mode);
            delivery_note.ShowDialog();
        }

        private void invoice_btn_Click(object sender, EventArgs e)
        {
            procurement_invoice_record invoice = new procurement_invoice_record(this.UI_mode);
            invoice.ShowDialog();
        }

        private void procurement_update_stock_Load(object sender, EventArgs e)
        {
            cust_name_txt.Text = "N/A";
            cust_name_txt.Visible = false;
            label7.Visible = false;
            if (time_txt.Text == "")
            {
                DateTime w = DateTime.Now;

                time_txt.Text = w.ToString("HH:mm");
            }
            snid_no();
            supp_inf();
            
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

        private void sh_procure_stoc_Click(object sender, EventArgs e)
        {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1)
            {
                string SQL = "select procure_stock_id, SNID,bookname,book_qty,book_stockLv, authors_name as AuthorsName,language,category,detail ,book_date " +
                          "from procurementstock p, authors a,languages l,category c where p.authors_id=a.authors_id and p.languages_id=l.languages_id and p.category_id = c.category_id;";
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

        private void close_btn_Click(object sender, EventArgs e)
        {
            snid_txt.Items.Clear();
            snid1_txt.Items.Clear();
            supplier_txt.Items.Clear();
            Close();
        }

        private void show_supplier_Click(object sender, EventArgs e)
        {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1)
            {
                string SQL = "select * from supplier;";
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

        private void show_authors_Click(object sender, EventArgs e)
        {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1)
            {
                string SQL = "select * from authors;";
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

        private void update_btn_Click(object sender, EventArgs e)
        {
            string invoice_data = invoice_txt.Text;
            string cust_name_data = cust_name_txt.Text;
            string supplier_name_data = supplier_txt.Text;
            string car_no_data = car_no_txt.Text;
            
            string time_data = time_txt.Text;
            string date_data = date_txt.Text;
            Int64 snid_data = Convert.ToInt64(snid_txt.Text);
            string item_name_data = item_name_txt.Text;
            int qty_data = Convert.ToInt32(Qty_txt.Text);
            string dept_data = dept_txt.Text;
            string remark_data = remark_txt.Text;
            string address_data = address_txt.Text;
            int phone_data = Convert.ToInt32(phone_txt.Text);

            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1)
            {
                string SQL1 = "update procurementstock set book_qty = book_qty+" + qty_data + ", book_date ='" + date_data + "' where SNID = " + snid_data + ";";
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

            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1)
            {
                //input
                string SQL = "insert into procurement_stock_book values(" + "null,"+1+",'"+ invoice_data + "','" + dept_data + "','" + supplier_name_data + "','" + car_no_data + "','" +
                                                      date_data + "','" + time_data + "','" + stock_type + "','" + snid_data + "','" + item_name_data + "'," + qty_data + ",'" + stock_status + "');";
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

            MessageBox.Show("Updated");
            invoice_txt.Clear();
            cust_name_txt.Clear();

            car_no_txt.Clear();

            time_txt.Clear();
             snid_txt.ResetText();
            item_name_txt.Clear();
            Qty_txt.Clear();
            dept_txt.Clear();
            remark_txt.Clear();
            phone_txt.Clear();
            address_txt.Clear();
            normal_radio.Checked = false;
            defect_radio.Checked = false;
            in_radiio.Checked = false;
            out_radio.Checked = false;
            cust_name_txt.Text = "N/A";
        }

        private void restart_btn_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
        }

        private void supplier_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (supplier_txt.Text != "")
                {

                    this.resultSYS = 0;
                    this.resultSYS = checkConnection(this.UI_mode);

                    if (this.resultSYS == 1)
                    {
                        string data = supplier_txt.Text;

                        string SQL4 = "select supplier_phone,supplier_address,supplier_dept from supplier where supplier_name = '" + data + "';";
                        DataTable dt4 = new DataTable();
                        MySqlCommand cmd4 = new MySqlCommand(SQL4, conn);

                        MySqlDataReader myData4 = cmd4.ExecuteReader();


                        while (myData4.Read())
                        {
                            phone_txt.Text = myData4.GetValue(0).ToString();
                            address_txt.Text = myData4.GetValue(1).ToString();
                            dept_txt.Text = myData4.GetValue(2).ToString();
                        }
                        conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("Connection Error !!");
                    }


                }
            }
            catch (Exception c)
            {

                MessageBox.Show("Please check the data again !!");
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

        private void snid_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (snid_txt.Text != "")
                {
                    Int64 data = Convert.ToInt64(snid_txt.Text);

                    this.resultSYS = 0;
                    this.resultSYS = checkConnection(this.UI_mode);

                    if (this.resultSYS == 1)
                    {

                        string SQL = "select bookname from procurementstock where SNID = " + data + ";";
                        DataTable dt = new DataTable();
                        MySqlCommand cmd = new MySqlCommand(SQL, conn);

                        MySqlDataReader myData = cmd.ExecuteReader();


                        while (myData.Read())
                        {
                            item_name_txt.Text = myData.GetValue(0).ToString();


                        }
                        conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("Connection Error !!");
                    }

                }
            }
            catch (Exception c)
            {

                MessageBox.Show("Please check the data again !!");
            }
        }

        private void show_stock_bk_Click(object sender, EventArgs e)
        {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1)
            {
                //display info
                string SQL1 = "select * from procurement_stock_book;";
                DataTable dt1 = new DataTable();
                MySqlCommand cmd1 = new MySqlCommand(SQL1, conn);
                MySqlDataReader myData1 = cmd1.ExecuteReader();
                dt1.Load(myData1);
                dataGridView1.DataSource = dt1;
                conn.Close();
            }
            else
            {
                MessageBox.Show("Connection Error !!");
            }
        }

        private void search_Click(object sender, EventArgs e)
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
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            else
            {
                MessageBox.Show("Connection Error !!");
            }
        }
    }
}
