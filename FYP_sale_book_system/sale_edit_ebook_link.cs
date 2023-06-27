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
    public partial class sale_edit_ebook_link : Form
    {   //NG TSZ KIN
        private MySqlConnection conn;//Location: connectDB.cs
        //private
        
        private int resultSYS;
        private int count = 0;
        string UI_mode = "";
        string select = "";

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

        private void e_book_status()
        {

            ebook_status_txt.Items.Add("Online");
            ebook_status_txt.Items.Add("Offline");


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
        public sale_edit_ebook_link(string uIMode)
        {
            InitializeComponent();
            this.UI_mode = uIMode;
        }

        private void sale_edit_ebook_link_Load(object sender, EventArgs e)
        {
            ebook_id();
            ebook_info();
            e_book_status();
        }

        private void update_link_btn_Click(object sender, EventArgs e)
        {
            if (select!="" && (ebook_link_txt.Text!="" || ebook_status_txt.Text!="") && ebook_id_txt.Text!="") {
            string ebook_link_data = "";
            int ebook_id_data = Convert.ToInt32(ebook_id_txt.Text);

                if (ebook_link_txt.Text != "")
                {
                    ebook_link_data = ebook_link_txt.Text;
                }
                else if (ebook_status_txt.Text != "")
                {

                    ebook_link_data = ebook_status_txt.Text;
                }
                else {
                    MessageBox.Show("Data is not complete!!");
                }

            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1 && ebook_link_data!="")
            {    //update e-book status or e-book link
                string SQL1 = "update e_book set " +this.select+" ='"+ebook_link_data+ "' where e_book_id ="+ebook_id_data+";";
                DataTable dt1 = new DataTable();
                MySqlCommand cmd1 = new MySqlCommand(SQL1, conn);
                MySqlDataReader myData1 = cmd1.ExecuteReader();
                conn.Close();
               MessageBox.Show("E-book ID "+ebook_id_txt.Text+" updated!!");
            }
            else
            {
                MessageBox.Show("Connection Error or data error!!");
            }
           
            ebook_id_txt.ResetText();
            ebook_link_txt.Clear();
            }
            else
            {
                MessageBox.Show("Please select E-book ID and enter E-book Link!! ");

            }
            
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            ebook_id_txt.Items.Clear();
            Close();
        }

        private void restart_btn_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            ebook_info();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            select = "e_book_link_status";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            select = "e_book_link";
        }
    }
}
