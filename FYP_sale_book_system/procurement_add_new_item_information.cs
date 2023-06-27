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
    public partial class procurement_add_new_item_information : Form
    {   //NG TSZ KIN
        string UI_mode;
        private MySqlConnection conn;
        private int resultSYS;
        ErrorControl check = new ErrorControl();
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

        private void anthors_info()
        {

            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1)
            {
                string SQL = "select authors_id 'Authors ID',authors_name 'Authors Name' from authors;";
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
                string SQL = "select category_id 'Category ID',category 'Category' ,detail 'Detail' from category;";
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
                string SQL = "select e_book_id 'E-Book ID',e_book_SNID 'E-Book SNID',e_book_name 'E-Book Name', e_book_status 'E-Book Status',e_book_link 'E-Book Link', e_book_link_status 'E-Book Link Status',e_book_Price 'E-Book Price' from e_book;";
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
                string SQL = "select languages_id 'Languages ID', language 'Language' from languages;";
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
                string SQL = "select supplier_id 'Supplier ID', supplier_name 'Supplier Name', supplier_address 'Supplier Address',supplier_phone 'Supplier Phone',supplier_dept 'Department',supplier_detail 'Detail' from supplier;";
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

        private void language() {

            language_txt.Items.Add("Chinese");
            language_txt.Items.Add("English");
          
        }

        private void ebook_status()
        {

            ebook_status_txt.Items.Add("Yes");
            ebook_status_txt.Items.Add("No");

        }

        private void ebook_link_status()
        {

            ebook_link_status_txt.Items.Add("Online");
            ebook_link_status_txt.Items.Add("Offline");

        }
        public procurement_add_new_item_information(procurement_edit_stock_function edit_Stock, string uIMode)
        {
            InitializeComponent();
            this.UI_mode = uIMode;
            this.edit_stock = edit_Stock;
        }

        private void procurement_add_new_item_information_Load(object sender, EventArgs e)
        {
            language();
            ebook_status();
            ebook_link_status();
        }

        private void author_info_btn_Click(object sender, EventArgs e)
        {   //display anthor information
            anthors_info();
        }

        private void category_info_btn_Click(object sender, EventArgs e)
        {   //display category information
            category_info();
        }

        private void e_book_info_btn_Click(object sender, EventArgs e)
        {   //display e-book information
            ebook_info();
        }

        private void language_info_btn_Click(object sender, EventArgs e)
        {   //display language information
            language_info();
        }

        private void supplier_info_btn_Click(object sender, EventArgs e)
        {    //display supplier information
            supplier_info();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (author_name_txt.Text!="") {
                this.resultSYS = 0;
                this.resultSYS = checkConnection(this.UI_mode);

                if (this.resultSYS == 1)
                {
                    //input author information
                    string SQL = "insert into authors values(" + "null, '" + author_name_txt.Text + "');";
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
                MessageBox.Show("Author Name " + author_name_txt.Text + " Updated!!");
                author_name_txt.Clear();
            }
            else {
                MessageBox.Show("Data is not complete!!");
            }
        }

        private void update_category_btn_Click(object sender, EventArgs e)
        {
            if (category_txt.Text!="" && category_detail_txt.Text!="") { 
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1)
            {
                //input category information
                string SQL = "insert into category values(" + "null, '" + category_txt.Text+"','"+category_detail_txt.Text+ "');";
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
            MessageBox.Show("Category " + category_txt.Text + " Updated!!");
            category_txt.Clear();
            category_detail_txt.Clear();
        }
            else {
                MessageBox.Show("Data is not complete!!");
            }
}

        private void update_ebook_btn_Click(object sender, EventArgs e)
        {
            if (check.checkNUM(ebook_snid_txt.Text)&& ebook_name_txt.Text!="" && ebook_status_txt.Text != "" && ebook_link_txt.Text != "" && ebook_link_status_txt.Text != ""&& check.checkNUM(ebook_price_txt.Text)) { 
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1)
            {
                //input e-book information
                string SQL = "insert into e_book values(" + "null, " + Convert.ToInt64(ebook_snid_txt.Text) + ",'" + ebook_name_txt.Text +"','"+ebook_status_txt.Text+"','"+ebook_link_txt.Text+"','"+ebook_link_status_txt.Text+"',"+Convert.ToInt32(ebook_price_txt.Text)+");";
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
            MessageBox.Show("Ebook " + ebook_name_txt.Text + " Updated!!");
            ebook_snid_txt.Clear();
            ebook_name_txt.Clear();
            ebook_status_txt.ResetText();
            ebook_link_txt.Clear();
            ebook_link_status_txt.ResetText();
            ebook_price_txt.Clear();
        }
            else {
                MessageBox.Show("Data is not complete!!");
            }
}

        private void update_language_btn_Click(object sender, EventArgs e)
        {
            if (language_txt.Text!="") { 
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1)
            {
                //input language information
                string SQL = "insert into languages values(" + "null, '" + language_txt.Text + "');";
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
            MessageBox.Show("Language " + language_txt.Text + " Updated!!");
            language_txt.ResetText();
        }
            else {
                MessageBox.Show("Data is not complete!!");
            }
}

        private void update_suppier_btn_Click(object sender, EventArgs e)
        {
            if (supplier_name_txt.Text!=""&& supplier_address_txt.Text!="" && check.checkNUM(supplier_phone_txt.Text) && supplier_dept_txt.Text != "" && supplier_detail_txt.Text != "") { 
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1)
            {
                //input supplier information
                string SQL = "insert into supplier values(" + "null, '" +supplier_name_txt.Text+ "','" + supplier_address_txt.Text + "'," + Convert.ToInt32(supplier_phone_txt.Text) + ",'" +supplier_dept_txt.Text + "','" + supplier_detail_txt.Text + "');";
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
            MessageBox.Show("Supplier " + supplier_name_txt.Text + " Updated!!");
            supplier_name_txt.Clear();
            supplier_address_txt.Clear();
            supplier_phone_txt.Clear();
            supplier_dept_txt.Clear();
            supplier_detail_txt.Clear();
        }
            else {
                MessageBox.Show("Data is not complete!!");
            }
}

        private void close_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
