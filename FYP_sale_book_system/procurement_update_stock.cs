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
    {   //NG TSZ KIN
        string UI_mode;
        private MySqlConnection conn;
        private int resultSYS;
        string stock_type = "";
        string stock_status = "";
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
        public procurement_update_stock(procurement_edit_stock_function edit_Stock,string UIMode)
        {
            InitializeComponent();
            this.UI_mode = UIMode;
            this.edit_stock = edit_Stock;
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
            {   //display procurement stock information

                string SQL = "select procure_stock_id 'Stock ID', SNID,bookname 'Book Name',book_qty 'Qty',book_stockLv 'Stock Level', authors_name 'Authors Name',language,category,detail ,book_date 'In Date',p.comp_LocationID 'Location ID',comp_Name 'Company Name' " +
                      "from procurementstock p, authors a,languages l,category c,company comp where p.comp_LocationID = comp.comp_LocationID and p.authors_id=a.authors_id and p.languages_id=l.languages_id and p.category_id = c.category_id;";
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
            {    //display supplier information
                string SQL = "select SNID,bookname,p.supplier_id 'Supplier ID', supplier_name 'Supplier Name', supplier_address 'Supplier Address',supplier_phone 'Supplier Phone',supplier_dept 'Department',supplier_detail 'Detail' from procurementstock p, supplier s where p.supplier_id = s.supplier_id;";
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
            {   //display author information
                string SQL = "select SNID,bookname,p.authors_id 'Authors ID',authors_name 'Authors Name' from procurementstock p,authors a where p.authors_id = a.authors_id;";
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
            if (invoice_txt.Text!=""&&supplier_txt.Text!=""&&car_no_txt.Text!=""&&snid_txt.Text!="" && check.checkNUM(Qty_txt.Text) && remark_txt.Text != "" && this.stock_type != "" && this.stock_status != "") {
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
            {   //update item Qty
                string SQL1 = "update procurementstock set book_qty = book_qty+" + qty_data + ", book_date ='" + date_data + "' where SNID = " + snid_data + ";";
                DataTable dt1 = new DataTable();
                MySqlCommand cmd1 = new MySqlCommand(SQL1, conn);
                MySqlDataReader myData1 = cmd1.ExecuteReader();
              
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
                //input item record
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
            supplier_txt.ResetText();
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
            else { 
                MessageBox.Show("Data is not complete !!"); 
            }
            
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
                //display stock book information
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
            if (snid1_txt.Text != "")
            {
                this.resultSYS = 0;
                this.resultSYS = checkConnection(this.UI_mode);

                if (this.resultSYS == 1)
                {
                    string SQL = "select procure_stock_id 'Stock ID', SNID,bookname 'Book Name',book_qty 'Qty',book_stockLv 'Stock Level', authors_name 'AuthorsName',language,category,detail ,book_date 'In Date',p.comp_LocationID 'Location ID',comp_Name 'Company Name' " +
                          "from procurementstock p, authors a,languages l,category c,company comp where p.comp_LocationID = comp.comp_LocationID and p.authors_id=a.authors_id and p.languages_id=l.languages_id and p.category_id = c.category_id and SNID = " + Convert.ToInt64(snid1_txt.Text) + ";";
                    DataTable dt = new DataTable();
                    MySqlCommand cmd = new MySqlCommand(SQL, conn);
                    MySqlDataReader myData = cmd.ExecuteReader();
                    dt.Load(myData);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                    snid1_txt.ResetText();
                }
                else
                {
                    MessageBox.Show("Connection Error !!");
                }
            }
            else { 
                MessageBox.Show("Please select SNID !!"); 
            }
           
        }
    }
}
