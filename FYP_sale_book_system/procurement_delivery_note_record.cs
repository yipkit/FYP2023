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
    public partial class procurement_delivery_note_record : Form
    {
        string UI_mode;
        string status = "";
        private MySqlConnection conn;
        private int resultSYS;
        private void supp_inf()
        {

            if (supplier_txt.Text == "")
            {
                this.resultSYS = 0;
                this.resultSYS = checkConnection(this.UI_mode);

                if (this.resultSYS == 1)
                {

                    string SQL5 = "select distinct(supplier_name) from supplier";
                    DataTable dt5 = new DataTable();
                    MySqlCommand cmd5 = new MySqlCommand(SQL5, conn);
                    MySqlDataReader myData5 = cmd5.ExecuteReader();
                    string ref_data = "";

                    while (myData5.Read())
                    {


                        supplier_txt.Items.Add(myData5.GetString("supplier_name"));



                    }

                    conn.Close();
                }
            }

        }

        private void supplier_info()
        {

            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1)
            {
                string SQL1 = "select * from supplier;";
                DataTable dt1 = new DataTable();
                MySqlCommand cmd1 = new MySqlCommand(SQL1, conn);
                MySqlDataReader myData1 = cmd1.ExecuteReader();
                dt1.Load(myData1);
                dataGridView2.DataSource = dt1;

                conn.Close();
            }
        }

        private void delivery_info()
        {

            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1)
            {
                string SQL = "select delivery_note_id 'Delivery Note ID',supplier_id 'Supplier ID',inv.comp_LocationID 'Company LocationID',comp_Name 'Company Name',delivery_note_no 'Delivery Note No',supplier_name 'Supplier Name',supplier_address 'Supplier Address',supplier_phone 'Supplier Phone',supplier_dept 'Supplier Department'," +
                               "delivery_note_date 'Delivery Note Date',SNID, book_name 'Book Name', book_qty 'Book Qty', receive_status 'Receive Status',remark 'Remark' from delivery_note_record inv,company c where inv.comp_LocationID=c.comp_LocationID;";
                DataTable dt = new DataTable();
                MySqlCommand cmd = new MySqlCommand(SQL, conn);
                MySqlDataReader myData = cmd.ExecuteReader();
                dt.Load(myData);
                dataGridView1.DataSource = dt;

                conn.Close();
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

        private void company_location_id()
        {


            if (snid_txt.Text == "")
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


                        company_id_txt.Items.Add(myData1.GetString("comp_LocationID"));




                    }

                    conn.Close();
                }
            }

        }

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
        public procurement_delivery_note_record(string uI_mode)
        {
            InitializeComponent();
            this.UI_mode = uI_mode;
        }

        private void procurement_delivery_record_Load(object sender, EventArgs e)
        {
            supplier_info();
            delivery_info();
            supp_inf();
            snid_no();
            company_location_id();
        }

        private void complete_radio_CheckedChanged(object sender, EventArgs e)
        {
            status = "complete";
        }

        private void non_complete_radio_CheckedChanged(object sender, EventArgs e)
        {
            status = "non-complete";
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            int delivery_data = Convert.ToInt32(delivery_note_no_txt.Text);
            string supplier_name_data = supplier_txt.Text;
            string date_data = r_date_txt.Text;
            Int64 snid_data = Convert.ToInt64(snid_txt.Text);
            string item_name_data = item_name_txt.Text;
            int qty_data = Convert.ToInt32(qty_txt.Text);
            string dept_data = s_dept_txt.Text;
            string remark_data = remark_txt.Text;
            string address_data = s_address_txt.Text;
            int phone_data = Convert.ToInt32(s_phone_txt.Text);
            int supplier_id = Convert.ToInt32(supplier_id_txt.Text);
            int company_id = Convert.ToInt32(company_id_txt.Text);

            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);
            if (this.resultSYS == 1)
            {
                //input
                string SQL2 = "insert into delivery_note_record values(" + "null," + supplier_id + "," + company_id + "," + delivery_data + ",'" + supplier_name_data + "','" + address_data + "'," + phone_data + ",'" +
                  dept_data + "','" + date_data + "'," + snid_data + ",'" + item_name_data + "'," + qty_data + ",'" + status + "','" + remark_data + "');";
                DataTable dt2 = new DataTable();
                MySqlCommand cmd = new MySqlCommand(SQL2, conn);
                MySqlDataReader myData2 = cmd.ExecuteReader();
                dt2.Load(myData2);
                dataGridView1.DataSource = dt2;
                conn.Close();
                MessageBox.Show("Saved");
            }
            else
            {
                MessageBox.Show("Connection Error !!");
            }
            delivery_note_no_txt.Clear();
            company_id_txt.ResetText();
            supplier_id_txt.ResetText();
            snid_txt.ResetText();
            item_name_txt.Clear();
            qty_txt.Clear();
            s_dept_txt.Clear();
            remark_txt.Clear();
            s_phone_txt.Clear();
            s_address_txt.Clear();
            complete_radio.Checked = false;
            non_complete_radio.Checked = false;
        }

        private void delivery_note_no_txt_TextChanged(object sender, EventArgs e)
        {

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

                        string SQL4 = "select supplier_id,supplier_phone,supplier_address,supplier_dept from supplier where supplier_name = '" + data + "';";
                        DataTable dt4 = new DataTable();
                        MySqlCommand cmd4 = new MySqlCommand(SQL4, conn);

                        MySqlDataReader myData4 = cmd4.ExecuteReader();


                        while (myData4.Read())
                        {
                            supplier_id_txt.Text = myData4.GetValue(0).ToString();
                            s_phone_txt.Text = myData4.GetValue(1).ToString();
                            s_address_txt.Text = myData4.GetValue(2).ToString();
                            s_dept_txt.Text = myData4.GetValue(3).ToString();
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

        private void restart_btn_Click(object sender, EventArgs e)
        {
            delivery_info();
        }

        private void company_id_txt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            company_id_txt.Items.Clear();
            snid_txt.Items.Clear();
            supplier_txt.Items.Clear();
            Close();
        }
    }
}
