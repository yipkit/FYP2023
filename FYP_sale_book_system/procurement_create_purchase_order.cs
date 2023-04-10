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
    public partial class procurement_create_purchase_order : Form
    {
        string UI_mode;
        private MySqlConnection conn;
        private int resultSYS;
        int count=0;

        private void po_info() {

            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1)
            {
                string SQL = "select * from purchase_order;";
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
        private void po_num()
        {
            if (po_txt.Text == "")
            {
                this.resultSYS = 0;
                this.resultSYS = checkConnection(this.UI_mode);

                if (this.resultSYS == 1)
                {

                    string SQL1 = "select count(purchase_order_id) from purchase_order;";
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


                        po_txt.Text = "pur1000";


                    }
                    else
                    {
                        this.resultSYS = 0;
                        this.resultSYS = checkConnection(this.UI_mode);

                        if (this.resultSYS == 1)
                        {


                            string SQL2 = "select purchase_order_no from purchase_order where purchase_order_id =" + x + ";";
                            DataTable dt2 = new DataTable();
                            MySqlCommand cmd2 = new MySqlCommand(SQL2, conn);
                            MySqlDataReader myData2 = cmd2.ExecuteReader();

                            string data = "";
                            string newdata = "";
                            while (myData2.Read())
                            {

                                data = myData2.GetValue(0).ToString();


                            }

                            newdata = num(data);
                            po_txt.Text = newdata;
                            conn.Close();
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
        private string num(string str)
        {

            string x = "";
            int num = 0;
            string news = "";
            for (int i = 3; i < str.Length; i++)
            {

                x += str[i];

            }
            num = Convert.ToInt32(x) + 1;
            news = "pur" + num.ToString();



            return news;
        }

        private void supp_inf()
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
                else
                {
                    MessageBox.Show("Connection Error !!");
                }
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

                    string SQL2 = "select SNID,bookname,book_qty,book_stockLv,bookDetails from procurementstock where procure_stock_id=" + i + ";";
                    DataTable dt1 = new DataTable();
                    MySqlCommand cmd2 = new MySqlCommand(SQL2, conn);
                    MySqlDataReader myData2 = cmd2.ExecuteReader();
                    Int64 SNID_data = 0;
                    string item_name_data = "";
                    int qty = 0;
                    int qty_lv = 0;
                    string details = "";
                    while (myData2.Read())
                    {
                        SNID_data = Convert.ToInt64(myData2.GetValue(0).ToString());
                        item_name_data = myData2.GetValue(1).ToString();
                        qty = Convert.ToInt32(myData2.GetValue(2));
                        qty_lv = Convert.ToInt32(myData2.GetValue(3));
                        details = myData2.GetValue(4).ToString();

                    }

                    if (qty < qty_lv)
                    {

                        note.Items.Add("SNID : " + SNID_data + ", Item : " + item_name_data + ", Details : " + details.ToString() + ", Qty : " + qty + ", Stock Level : " + qty_lv + ", is low stock.");

                    }

                    conn.Close();
                }


            }
        }


        private void item_count()
        {

            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1)
            {
                //display
                //sales stock
                string SQL3 = "select count(procure_stock_id) from procurementstock;";
                DataTable dt = new DataTable();
                MySqlCommand cmd3 = new MySqlCommand(SQL3, conn);
                MySqlDataReader myData3 = cmd3.ExecuteReader();

                while (myData3.Read())
                {

                    this.count = Convert.ToInt32(myData3.GetValue(0));

                }

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
                   

                    while (myData1.Read())
                    {


                        snid_txt.Items.Add(myData1.GetString("SNID"));
                        



                    }

                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Connection Error !!");
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
        public procurement_create_purchase_order(string uIMode)
        {
            InitializeComponent();
            this.UI_mode = uIMode;
        }

        private void procurement_create_purchase_order_Load(object sender, EventArgs e)
        {
            supp_inf();
            company_location_id();
            check_stock_lv();
            snid_no();
            po_num();
            po_info();
        }

        private void company_name_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void supplier_id_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (supplier_id_txt.Text != "")
                {

                    this.resultSYS = 0;
                    this.resultSYS = checkConnection(this.UI_mode);

                    if (this.resultSYS == 1)
                    {
                        string data = supplier_id_txt.Text;

                        string SQL4 = "select supplier_name,supplier_phone,supplier_address from supplier where supplier_id = '" + data + "';";
                        DataTable dt4 = new DataTable();
                        MySqlCommand cmd4 = new MySqlCommand(SQL4, conn);

                        MySqlDataReader myData4 = cmd4.ExecuteReader();


                        while (myData4.Read())
                        {
                            supplier_txt.Text = myData4.GetValue(0).ToString();
                            s_phone_txt.Text = myData4.GetValue(1).ToString();
                            s_address_txt.Text = myData4.GetValue(2).ToString();
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

        private void location_id_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (location_id_txt.Text != "")
                {

                    this.resultSYS = 0;
                    this.resultSYS = checkConnection(this.UI_mode);

                    if (this.resultSYS == 1)
                    {
                        int data = Convert.ToInt32(location_id_txt.Text);

                        string SQL4 = "select comp_Name,comp_PhoneNumber,comp_Address from company where comp_LocationID = " + data + ";";
                        DataTable dt4 = new DataTable();
                        MySqlCommand cmd4 = new MySqlCommand(SQL4, conn);

                        MySqlDataReader myData4 = cmd4.ExecuteReader();


                        while (myData4.Read())
                        {
                            company_name_txt.Text = myData4.GetValue(0).ToString();
                            c_phone_txt.Text = myData4.GetValue(1).ToString();
                            c_address_txt.Text = myData4.GetValue(2).ToString();
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

        private void close_btn_Click(object sender, EventArgs e)
        {
            supplier_id_txt.Items.Clear();
            location_id_txt.Items.Clear();
            snid_txt.Items.Clear();
            Close();
        }

        private void snid_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (snid_txt.Text != "")
                {

                    this.resultSYS = 0;
                    this.resultSYS = checkConnection(this.UI_mode);

                    if (this.resultSYS == 1)
                    {
                        string data = snid_txt.Text;

                        string SQL4 = "select bookname,book_unit_price from procurementstock where SNID = '" + data + "';";
                        DataTable dt4 = new DataTable();
                        MySqlCommand cmd4 = new MySqlCommand(SQL4, conn);

                        MySqlDataReader myData4 = cmd4.ExecuteReader();


                        while (myData4.Read())
                        {
                            book_name_txt.Text = myData4.GetValue(0).ToString();
                            unit_price_txt.Text = myData4.GetValue(1).ToString();
                            
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

        private void item_total_price_txt_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void qty_txt_TextChanged(object sender, EventArgs e)
        {
            if (qty_txt.Text != "")
            {
                int qty = Convert.ToInt32(qty_txt.Text);
                int unit_price = Convert.ToInt32(unit_price_txt.Text);
                int total = unit_price * qty;
                item_total_price_txt.Text = Convert.ToString(total);

            }
        }

        private void create_Click(object sender, EventArgs e)
        {
            string po_number = po_txt.Text;
            int supplier_id = Convert.ToInt32(supplier_id_txt.Text);
            string supplier_name = supplier_txt.Text;
            string supplier_address = s_address_txt.Text;
            int supplier_phone = Convert.ToInt32(s_phone_txt.Text);
            int company_id = Convert.ToInt32(location_id_txt.Text);
            string company_name = company_name_txt.Text;
            string company_address = c_address_txt.Text;
            int company_phone = Convert.ToInt32(c_phone_txt.Text);
            Int64 snid = Convert.ToInt64(snid_txt.Text);
            string book_name = book_name_txt.Text;
            int qty = Convert.ToInt32(qty_txt.Text);
            int unit_price = Convert.ToInt32(unit_price_txt.Text);
            int total_price = Convert.ToInt32(item_total_price_txt.Text);
            string date = date_txt.Text;
            string remark = remark_txt.Text;
            string status = "pending";

            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);

            if (this.resultSYS == 1)
            {
                //input
                string SQL = "insert into purchase_order values(" + "null," + company_id + ",'" + company_name + "'," + company_phone + ",'" + company_address + "','" + po_number + "','" +
                               date+ "'," + snid + ",'" + book_name + "'," + qty + "," + unit_price + "," + total_price + "," + supplier_id+",'"+supplier_name+"',"+supplier_phone+",'"+supplier_address+"','"+remark+"','"+status+"');";
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

            supplier_id_txt.ResetText();
            location_id_txt.ResetText();
            supplier_txt.Clear();
            s_address_txt.Clear();
            s_phone_txt.Clear();
            company_name_txt.Clear();
            c_phone_txt.Clear();
            c_address_txt.Clear();
            remark_txt.Clear();
            unit_price_txt.Clear();
            item_total_price_txt.Clear();
            snid_txt.ResetText();
            book_name_txt.Clear();
            qty_txt.Clear();


        }

        private void restart_btn_Click(object sender, EventArgs e)
        {
            supplier_id_txt.ResetText();
            location_id_txt.ResetText();
            po_txt.Clear();
            supplier_txt.Clear();
            s_address_txt.Clear();
            s_phone_txt.Clear();
            company_name_txt.Clear();
            c_phone_txt.Clear();
            c_address_txt.Clear();
            remark_txt.Clear();
            unit_price_txt.Clear();
            item_total_price_txt.Clear();
            snid_txt.ResetText();
            book_name_txt.Clear();
            qty_txt.Clear();
            po_num();
            po_info();
        }

        private void show_supplier_btn_Click(object sender, EventArgs e)
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
    }
}
