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
    public partial class procurement_add_new_item : Form
    {
        string UI_mode;
        private MySqlConnection conn;
        private int resultSYS;
        private string dept_data = "";

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

        private void anthors_info()
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

        private void category_info()
        {

            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1)
            {
                string SQL = "select * from category;";
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

        private void ebook_info()
        {

            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1)
            {
                string SQL = "select * from e_book;";
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

        private void language_info()
        {

            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1)
            {
                string SQL = "select * from languages;";
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

        private void supplier_info()
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

        private void location_info()
        {

            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1)
            {
                string SQL = "select * from company;";
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
                    string ref_data = "";

                    while (myData1.Read())
                    {

                        location_id_txt.Items.Add(myData1.GetString("comp_LocationID"));

                    }

                    conn.Close();
                }
            }
        }

        private void author_id()
        {


            if (author_id_txt.Text == "")
            {
                this.resultSYS = 0;
                this.resultSYS = checkConnection(this.UI_mode);

                if (this.resultSYS == 1)
                {


                    string SQL1 = "select authors_id from authors";
                    DataTable dt1 = new DataTable();
                    MySqlCommand cmd1 = new MySqlCommand(SQL1, conn);
                    MySqlDataReader myData1 = cmd1.ExecuteReader();
                    string ref_data = "";

                    while (myData1.Read())
                    {

                        author_id_txt.Items.Add(myData1.GetString("authors_id"));

                    }

                    conn.Close();
                }
            }
        }

        private void category_id()
        {


            if (category_id_txt.Text == "")
            {
                this.resultSYS = 0;
                this.resultSYS = checkConnection(this.UI_mode);

                if (this.resultSYS == 1)
                {


                    string SQL1 = "select category_id from category";
                    DataTable dt1 = new DataTable();
                    MySqlCommand cmd1 = new MySqlCommand(SQL1, conn);
                    MySqlDataReader myData1 = cmd1.ExecuteReader();
                    string ref_data = "";

                    while (myData1.Read())
                    {

                        category_id_txt.Items.Add(myData1.GetString("category_id"));

                    }

                    conn.Close();
                }
            }
        }
        private void langauge_id()
        {


            if (language_id_txt.Text == "")
            {
                this.resultSYS = 0;
                this.resultSYS = checkConnection(this.UI_mode);

                if (this.resultSYS == 1)
                {


                    string SQL1 = "select languages_id from languages";
                    DataTable dt1 = new DataTable();
                    MySqlCommand cmd1 = new MySqlCommand(SQL1, conn);
                    MySqlDataReader myData1 = cmd1.ExecuteReader();
                    string ref_data = "";

                    while (myData1.Read())
                    {

                        language_id_txt.Items.Add(myData1.GetString("languages_id"));

                    }

                    conn.Close();
                }
            }
        }

        private void ebook_id()
        {


            if (ebook_id_txt.Text == "")
            {
                this.resultSYS = 0;
                this.resultSYS = checkConnection(this.UI_mode);

                if (this.resultSYS == 1)
                {


                    string SQL1 = "select e_book_id from e_book";
                    DataTable dt1 = new DataTable();
                    MySqlCommand cmd1 = new MySqlCommand(SQL1, conn);
                    MySqlDataReader myData1 = cmd1.ExecuteReader();
                    string ref_data = "";

                    while (myData1.Read())
                    {

                        ebook_id_txt.Items.Add(myData1.GetString("e_book_id"));

                    }

                    conn.Close();
                }
            }
        }

        private void supplier_id()
        {


            if (supplier_id_txt.Text == "")
            {
                this.resultSYS = 0;
                this.resultSYS = checkConnection(this.UI_mode);

                if (this.resultSYS == 1)
                {


                    string SQL1 = "select supplier_id from supplier";
                    DataTable dt1 = new DataTable();
                    MySqlCommand cmd1 = new MySqlCommand(SQL1, conn);
                    MySqlDataReader myData1 = cmd1.ExecuteReader();
                    string ref_data = "";

                    while (myData1.Read())
                    {

                        supplier_id_txt.Items.Add(myData1.GetString("supplier_id"));

                    }

                    conn.Close();
                }
            }
        }

        private void book_status() {

            status_txt.Items.Add("Yes");
            status_txt.Items.Add("No");

        }
        public procurement_add_new_item(string uIMode)
        {
            InitializeComponent();
            this.UI_mode = uIMode;
        }
       private void procurement_add_new_item_Load(object sender, EventArgs e)
        {
            author_id();
            category_id();
            company_location_id();
            ebook_id();
            supplier_id();
            langauge_id();
            book_status();
        }
        private void author_info_btn_Click(object sender, EventArgs e)
        {
            anthors_info();
        }

        private void location_id_btn_Click(object sender, EventArgs e)
        {
            location_info();
        }

        private void category_info_btn_Click(object sender, EventArgs e)
        {
            category_info();
        }

        private void language_info_btn_Click(object sender, EventArgs e)
        {
            language_info();
        }

        private void supplier_info_btn_Click(object sender, EventArgs e)
        {
            supplier_info();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void e_book_info_btn_Click(object sender, EventArgs e)
        {
            ebook_info();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            author_id_txt.Items.Clear();
            language_id_txt.Items.Clear();
            location_id_txt.Items.Clear();
            category_id_txt.Items.Clear();
            supplier_id_txt.Items.Clear();
            ebook_id_txt.Items.Clear();
            Close();
        }

        private void sale_radio_Btn_CheckedChanged(object sender, EventArgs e)
        {
            this.dept_data = "salestock";
        }

        private void procure_radio_Btn_CheckedChanged(object sender, EventArgs e)
        {
            this.dept_data = "procurementstock";
        }

        private void add_item_btn_Click(object sender, EventArgs e)
        {
            Int64 snid_data = Convert.ToInt64(snid_txt.Text);
            int anthor_data = Convert.ToInt32(author_id_txt.Text);
            int language_data = Convert.ToInt32(language_id_txt.Text);
            int category_data = Convert.ToInt32(category_id_txt.Text);
            int supplier_data = Convert.ToInt32(supplier_id_txt.Text);
            int location_data = Convert.ToInt32(location_id_txt.Text);
            int ebook_data = Convert.ToInt32(ebook_id_txt.Text);
            string book_name_data = book_name_txt.Text;
            int qty_data = Convert.ToInt32(qty_txt.Text);
            int stock_lv_data = Convert.ToInt32(stock_lv_txt.Text);
            int unit_price_data = Convert.ToInt32(unit_price_txt.Text);
            string date_data = in_date_txt.Text;
            string detail_data = detail_txt.Text;
            string book_status = status_txt.Text;

            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1)
            {
                //input
                string SQL = "insert into "+this.dept_data+" values(" + "null," + snid_data + "," + anthor_data + "," + language_data + "," + category_data + "," + supplier_data + "," +
                                                      location_data + "," + ebook_data + ",'" + book_name_data + "'," + qty_data + "," + stock_lv_data + "," + unit_price_data + ",'" + date_data +"','"+detail_data+"','"+book_status+ "');";
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
            MessageBox.Show(this.dept_data+"Updated");
            location_id_txt.ResetText();
            sale_radio_Btn.Checked = false;
            procure_radio_Btn.Checked = false;
            
        }

        private void clean_value_btn_Click(object sender, EventArgs e)
        {
            snid_txt.Clear();
            author_id_txt.ResetText();
            language_id_txt.ResetText();
            category_id_txt.ResetText();
            supplier_id_txt.ResetText();
            location_id_txt.ResetText();
            ebook_id_txt.ResetText();
            book_name_txt.Clear();
            qty_txt.Clear();
            stock_lv_txt.Clear();
            unit_price_txt.Clear();
            detail_txt.Clear();
            status_txt.ResetText();
            sale_radio_Btn.Checked = false;
            procure_radio_Btn.Checked = false;
            dataGridView1.Columns.Clear();
            this.dept_data = "";
        }
    }
}
