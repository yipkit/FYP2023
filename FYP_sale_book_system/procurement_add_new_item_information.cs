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
        public procurement_add_new_item_information(string uIMode)
        {
            InitializeComponent();
            this.UI_mode = uIMode;
        }

        private void procurement_add_new_item_information_Load(object sender, EventArgs e)
        {
            language();
            ebook_status();
            ebook_link_status();
        }

        private void author_info_btn_Click(object sender, EventArgs e)
        {
            anthors_info();
        }

        private void category_info_btn_Click(object sender, EventArgs e)
        {
            category_info();
        }

        private void e_book_info_btn_Click(object sender, EventArgs e)
        {
            ebook_info();
        }

        private void language_info_btn_Click(object sender, EventArgs e)
        {
            language_info();
        }

        private void supplier_info_btn_Click(object sender, EventArgs e)
        {
            supplier_info();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1)
            {
                //input
                string SQL = "insert into authors values(" + "null, '"+anthor_name_txt.Text+ "');";
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
            MessageBox.Show("Author Name "+anthor_name_txt.Text+" Updated!!");
            anthor_name_txt.Clear();
        }

        private void update_category_btn_Click(object sender, EventArgs e)
        {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1)
            {
                //input
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

        private void update_ebook_btn_Click(object sender, EventArgs e)
        {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1)
            {
                //input
                string SQL = "insert into e_book values(" + "null, " + Convert.ToInt64(ebook_snid_txt.Text) + ",'" + ebook_name_txt.Text +"','"+ebook_status_txt.Text+"','"+ebook_link_txt.Text+"','"+ebook_link_status_txt.Text+ "');";
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
        }

        private void update_language_btn_Click(object sender, EventArgs e)
        {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1)
            {
                //input
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
            language_txt.ResetText(); ;
        }

        private void update_suppier_btn_Click(object sender, EventArgs e)
        {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1)
            {
                //input
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

        private void close_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
