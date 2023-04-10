using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace FYP_sale_book_system
{
    public partial class sale_gen_Ebook_link : Form
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
                    

                    while (myData1.Read())
                    {

                        ebook_id_txt.Items.Add(myData1.GetString("e_book_id"));

                    }

                    conn.Close();
                }
            }
        }
        public sale_gen_Ebook_link(string uIMode)
        {
            InitializeComponent();
            UI_mode = uIMode;
        }

        private void sale_gen_Ebook_link_Load(object sender, EventArgs e)
        {
            ebook_info();
            ebook_id();
        }

        private void gen_link_btn_Click(object sender, EventArgs e)
        {
            
            try
            {
                string snid = "";
                string ebook_name="";
                string ebook_link="";

                if (ebook_id_txt.Text != "")
                {

                    this.resultSYS = 0;
                    this.resultSYS = checkConnection(this.UI_mode);

                    if (this.resultSYS == 1)
                    {
                        string data = ebook_id_txt.Text;

                        string SQL4 = "select e_book_SNID,e_book_name,e_book_link from e_book where e_book_id = '" + data + "';";
                        DataTable dt4 = new DataTable();
                        MySqlCommand cmd4 = new MySqlCommand(SQL4, conn);

                        MySqlDataReader myData4 = cmd4.ExecuteReader();


                        while (myData4.Read())
                        {
                            snid = myData4.GetValue(0).ToString();
                            ebook_name = myData4.GetValue(1).ToString();
                            ebook_link = myData4.GetValue(2).ToString();
                        }
                        conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("Connection Error !!");
                    }


                }
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter(path_txt.Text+ ebook_name+".txt");
                //Write a line of text
                sw.WriteLine("SNID : "+snid+", Book Name :"+ebook_name);
                //Write a second line of text
                sw.WriteLine("E-book Link : "+ebook_link);
                //Close the file
                sw.Close();
                MessageBox.Show("E-book "+ebook_name+" Generated");
                ebook_id_txt.ResetText();
                path_txt.Clear();
            }
            catch (Exception a)
            {
                Console.WriteLine("Exception: " + a.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
                
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            ebook_id_txt.Items.Clear();
            Close();
        }
    }
}
