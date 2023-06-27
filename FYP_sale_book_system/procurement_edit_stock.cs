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
    public partial class procurement_edit_stock : Form
    {    //NG TSZ KIN
        string UI_mode;
        string select = "";
        private MySqlConnection conn;
        private int resultSYS;
        private string dept_data = "";
        ErrorControl check = new ErrorControl();
        Boolean data1 = false;
        Boolean data2 = false;
        Boolean data3 = false;
        Boolean data4 = false;
        procurement_edit_stock_function edit_stock;

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

        private void change_item_status()
        {
            book_status_txt.Items.Add("Yes");
            book_status_txt.Items.Add("No");
        }
        private void procurement_stock() {

            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1)
            {
                string SQL = "select procure_stock_id, SNID,bookname,book_qty,book_stockLv, authors_name as AuthorsName,language,category,detail ,book_date, phasing_out_status,p.comp_LocationID,comp_Name " +
                          "from procurementstock p, authors a,languages l,category c,company comp where p.comp_LocationID = comp.comp_LocationID and p.authors_id=a.authors_id and p.languages_id=l.languages_id and p.category_id = c.category_id and phasing_out_status = 'No';";
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

        private void sale_stock()
        {

            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1)
            {
                string SQL = "sale_stock_id, SNID,bookname,book_qty,book_stockLv, authors_name as AuthorsName,language,category,detail ,book_date, phasing_out_status,comp_LocationID, comp_Name " +
                                "from salestock p, authors a,languages l,category c,company comp where p.comp_LocationID = comp.comp_LocationID and p.authors_id=a.authors_id and p.languages_id=l.languages_id and p.category_id = c.category_id and phasing_out_status = 'No';";
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
                   

                    while (myData1.Read())
                    {

                        location_id_txt.Items.Add(myData1.GetString("comp_LocationID"));

                    }

                    conn.Close();
                }
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


                    string SQL1 = "select SNID from procurementstock where phasing_out_status = 'No';";
                    DataTable dt1 = new DataTable();
                    MySqlCommand cmd1 = new MySqlCommand(SQL1, conn);
                    MySqlDataReader myData1 = cmd1.ExecuteReader();
                    string ref_data = "";

                    while (myData1.Read())
                    {

                       snid_txt.Items.Add(myData1.GetString("SNID"));
                       snid_status_txt.Items.Add(myData1.GetString("SNID"));

                    }

                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Connection Error !!");
                }
            }

        }
        public procurement_edit_stock(procurement_edit_stock_function edit_Stock, string uIMode)
        {
            InitializeComponent();
            this.UI_mode = uIMode;
            this.edit_stock = edit_Stock;
        }

        private void procurement_edit_stock_Load(object sender, EventArgs e)
        {
            snid_no();
            company_location_id();
            change_item_status();
         
        }

        private void sale_radioBtn_CheckedChanged(object sender, EventArgs e)
        {
            data1 = true;
            this.dept_data = "salestock";
        }

        private void procure_radioBtn_CheckedChanged(object sender, EventArgs e)
        {
            data2 = true;
            this.dept_data = "procurementstock";
        }

        private void stock_lv_radioBtn_CheckedChanged(object sender, EventArgs e)
        {
            data3 = true;
            this.select = "book_stockLv";
        }

        private void unit_price_radioBtn_CheckedChanged(object sender, EventArgs e)
        {
            data4 = true;
              this.select = "book_unit_price";
        }

        private void restart_btn_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (snid_txt.Text!=""&&location_id_txt.Text!=""&&this.select!="") {
                Int64 snid_data = Convert.ToInt64(snid_txt.Text);
            int location_id = Convert.ToInt32(location_id_txt.Text);
            int data = 0;

                if (stock_lv_txt.Text != "" && check.checkNUM(stock_lv_txt.Text))
                {

                    data = Convert.ToInt32(stock_lv_txt.Text);

                }
                else if (unit_price_txt.Text != "" && check.checkNUM(unit_price_txt.Text))
                {

                    data = Convert.ToInt32(unit_price_txt.Text);

                }
                else {
                    MessageBox.Show("Wrong Data!!");
                    Close();
                }

            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1 && data !=0)
            {    //update sale/procurement stock's stock level or unit price
                string SQL1 = "update "+this.dept_data+" set "+select+" = "+data+ " where SNID = " + snid_data +" and comp_LocationID = "+location_id+";";
                DataTable dt1 = new DataTable();
                MySqlCommand cmd1 = new MySqlCommand(SQL1, conn);
                MySqlDataReader myData1 = cmd1.ExecuteReader();
             
                conn.Close();

            MessageBox.Show(dept_data+" updated");
            snid_txt.ResetText();
            location_id_txt.ResetText();
            stock_lv_txt.Clear();
            unit_price_txt.Clear();
            stock_lv_radioBtn.Checked = false;
            unit_price_radioBtn.Checked = false;
            sale_radioBtn.Checked = false;
            procure_radioBtn.Checked = false;
            }
            else
            {
                MessageBox.Show("Connection Error or Wrong Data!!");
            }
            
            }
            else
            {
                MessageBox.Show("Data is not complete!!");
            }

        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            snid_txt.Items.Clear();
            location_id_txt.Items.Clear();
            Close();
        }

        private void show_sale_stock_btn_Click(object sender, EventArgs e)
        {   //display sale stock information
            sale_stock();
        }

        private void button1_Click(object sender, EventArgs e)
        {   //display procurement stock information
            procurement_stock();
        }

        private void update_status_btn_Click(object sender, EventArgs e)
        {
            if (snid_status_txt.Text != "" && book_status_txt.Text != "")
            {

                string book_status_data = book_status_txt.Text;
                Int64 snid_data = Convert.ToInt64(snid_status_txt.Text);

                this.resultSYS = 0;
                this.resultSYS = checkConnection(this.UI_mode);

                if (this.resultSYS == 1)
                {   //change item phasing out status
                    string SQL1 = "update procurementstock set phasing_out_status = '" + book_status_data + "' where SNID = " + snid_data + ";";
                    DataTable dt1 = new DataTable();
                    MySqlCommand cmd1 = new MySqlCommand(SQL1, conn);
                    MySqlDataReader myData1 = cmd1.ExecuteReader();
                  
                    conn.Close();

                }
                else
                {
                    MessageBox.Show("Connection Error or Wrong Data!!");
                }

                this.resultSYS = 0;
                this.resultSYS = checkConnection(this.UI_mode);

                if (this.resultSYS == 1)
                {
                    string SQL1 = "update salestock set phasing_out_status = '" + book_status_data + "' where SNID = " + snid_data + ";";
                    DataTable dt1 = new DataTable();
                    MySqlCommand cmd1 = new MySqlCommand(SQL1, conn);
                    MySqlDataReader myData1 = cmd1.ExecuteReader();
                    //insert into stockbook values(null,'abc1234','jack','N/A','N/A','22-06-01','21:20','defect','wf1000','sony tv',1,'IN');
                    conn.Close();

                }
                else
                {
                    MessageBox.Show("Connection Error or Wrong Data!!");
                }
                MessageBox.Show("SNID　：　" + snid_status_txt.Text + "'s status  updated!!");
                book_status_txt.ResetText();
                snid_status_txt.ResetText();

            }
            else
            {

                MessageBox.Show("Please select SNID and Status!!");

            }
        }
    }
}
