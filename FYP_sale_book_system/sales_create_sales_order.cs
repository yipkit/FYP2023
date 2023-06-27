using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace FYP_sale_book_system
{

   

    
    public partial class sales_create_sales_order : Form
    {
        PassPersonalData PPD = new PassPersonalData();
        CheckUserRight CUR = new CheckUserRight();
        private MySqlConnection conn; // call connDB
        private string UIStaffID;
        private string UIMode;
        private string UILevel;
        private string UIPost;
        private string UIdutyID;
        private string UIKEY;
        private string UILocation;
        private int resultSYS;
        private string sql;

        int SearchProductPoint;
        private Boolean PN = false;
        private Boolean Ca = false;
        private Boolean SL = false;
        //Price
        string totalprice = "0";
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
        private void UpdateSQL(string sql)
        {
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);

            MySqlDataReader myData = cmd.ExecuteReader();
        }
        private string point() {
           
            sql = " Select sale_stock_id'Sale Stock ID', SNID, salestock.authors_id'Authors ID', salestock.languages_id'Languages ID', salestock.category_id'Category ID', supplier_id'Supplier ID', salestock.comp_LocationID'Location ID', e_book_id'E-book ID', bookname'Book Name', book_qty'QTY', book_stockLv'Stock Level', book_unit_price'Price', book_date'Date', bookDetails'Details', phasing_out_status'Phasing Out Status', company.comp_LocationID'LocationID', comp_Name'Name', comp_CountryNumber'Country Number', comp_PhoneNumber'Phone Number', comp_Address'Address', comp_Status'Company Status', comp_Type'Company Type', comp_HeadOffice_Branch'HeadOffice / Branch', category.category_id'Category ID', category, detail, authors.authors_id'Authors ID', authors_name'Authors Name', languages.languages_id'Languages ID', language'Language'"
                +"from salestock inner join company ON salestock.comp_LocationID = company.comp_LocationID inner join category ON category.category_id = salestock.category_id inner join authors ON authors.authors_id = salestock.authors_id inner join languages ON languages.languages_id = salestock.languages_id  where ";

            if (this.PN == true || this.Ca == true )
            {
                if (this.PN == true && this.Ca == true) {
                    string ca = getNUM(comboBox_Ca.Text);
                    string pn = comboBox_PN.Text;
                    sql += "salestock.bookname = '" + pn+ "' && salestock.Category_id = '" + ca+"' ;";
                }
                else if (this.Ca == true || this.PN == false)
                {
                    string ca2 = getNUM(comboBox_Ca.Text);
                    sql += "salestock.Category_id = '" + ca2+"' ;";
                }
                else if (this.Ca == false || this.PN == true)
                {
                    string pn2 = comboBox_PN.Text;
                    sql += "salestock.bookname = '" + pn2+"';";
                }
            }
            else { 
                MessageBox.Show("Please check box and select search target !");
            }

            
            return sql;
        }
        private void SelectSalesProduct()
        {

            
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UIMode);
            if (this.resultSYS == 1)
            {
                sql = point();
            }
            else
            {
                sql = point();
            }
            

            runSelectDGSQL(sql);


        }

        private void SelectSalesStock()// Search ALL
        {


            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UIMode);
            if (this.resultSYS == 1)
            {
                sql = "Select sale_stock_id'Sales Stock ID', SNID, authors_id'Authors ID', languages_id'Language ID', category_id'Category ID', supplier_id'Supplier ID', comp_LocationID'Location ID', e_book_id'E-book ID', bookname'Book Name', book_qty'QTY', book_stockLv'Stock Level', book_unit_price'Price', book_date'Date', bookDetails'Details', phasing_out_status'Phasing out Status' from salestock;";            
            }
            else
            {
                sql = "Select sale_stock_id'Sales Stock ID', SNID, authors_id'Authors ID', languages_id'Language ID', category_id'Category ID', supplier_id'Supplier ID', comp_LocationID'Location ID', e_book_id'E-book ID', bookname'Book Name', book_qty'QTY', book_stockLv'Stock Level', book_unit_price'Price', book_date'Date', bookDetails'Details', phasing_out_status'Phasing out Status' from salestock;";
            }
            runSelectDGSQL(sql);


        }
        private void SelectProductID()
        {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UIMode);
            if (this.resultSYS == 1)
            {
                sql = "Select MAX(sale_stock_id) from salestock;";
            }
            else
            {
                sql = "Select MAX(sale_stock_id) from salestock;";
            }
            
            runSelectComIDSQL(sql);
        }
        
       private void SelectProductName()
        {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UIMode);
            if (this.resultSYS == 1)
            {
                sql = "Select bookname from salestock;";
            }
            else
            {
                sql = "Select bookname from salestock;";
            }
            runSelectComPNSQL(sql);
        }
        private void SelectCa()
        {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UIMode);
            if (this.resultSYS == 1)
            {
                sql = "Select category from category;";
            }
            else
            {
                sql = "Select category from category;";
            }
            
            runSelectCaSQL(sql);
        }
        private void runSelectComIDSQL(String sql)
        {
            string data;
            
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();
            myData.Read();
            data = myData.GetString(0);
            int Size = Convert.ToInt32(data);
            int count = 0;
            for (int x = 0;  x <= Size - 1;x++) {
                comb_PID.Items.Add(count + 1);
                count++;
            }
           


        }

        private void runSelectComPNSQL(String sql)
        {
            string data;
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();

            
            while (myData.Read())
            {
                data = myData.GetString(0);
                comboBox_PN.Items.Add(data);
            }


        }
        private void runSelectCaSQL(String sql)
        {
            string data;
            int count = 1;
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();

           
            while (myData.Read())
            {
                data = myData.GetString(0);
               
                comboBox_Ca.Items.Add(count + "." + data);
                count++;
            }


        }

        private void runSelectDGSQL(String sql)
        {
            
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(myData);
            dataGridView1.DataSource = dt;


        }
        private string getNUM(string data) //Get Cat Number
        {
            int x = 0;
            string save = "";
            while (true)
            {

                char a = data[x];

                if (a == '.')
                {
                    return save;
                }
                else
                {
                    save += a;
                    x++;
                }

            }
        }
        
        private void ClearOrder()
        {

        }
        private void SQLSearchAll()
        {

        }

        private void SQLSearch()
        {

        }

        private void SQLSendOrder()
        {

        }
        public sales_create_sales_order(string mode,string location,string staffid )
        {
            InitializeComponent();
            this.UIMode = mode;
            this.UIStaffID = staffid;
            this.UILocation = location;
            
            SelectProductID();
           
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            clearData();
            Close();
        }

        private void sales_create_sales_order_Load(object sender, EventArgs e)
        {
            
            
        }
        private void UpdateStockAdd(string ID, string qty)
        {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UIMode);
            if (this.resultSYS == 1)
            {
                sql = "update salestock set book_qty = (book_qty + " + qty + " )  where sale_stock_id = '" + ID + "'; ";
            }
            else
            {
                sql = "update salestock set book_qty = (book_qty + " + qty + " )  where sale_stock_id = '" + ID + "'; ";
            }
            try {
                UpdateSQL(sql);

            }
            catch (Exception e) {
                MessageBox.Show("Connect time out !!");
            }
            
        }




        private void UpdateStockLess(string ID, string qty)
        {

            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UIMode);
            if (this.resultSYS == 1)
            {
                sql = "update salestock set book_qty = (book_qty - " + qty + " )  where sale_stock_id = '" + ID + "'; ";
            }
            else
            {
                sql = "update salestock set book_qty = (book_qty - " + qty + " )  where sale_stock_id = '" + ID + "'; ";
            }
            try
            {
                UpdateSQL(sql);
            }
            catch (Exception e)
            {
                MessageBox.Show("Connect time out !!");
            }
            

        }

        private void SetOrderSQL(String sql, string qty)
        {
            string data_PID;
            string data_PN;
            string data_QTY;
            string data_P;

            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();
            myData.Read();
            try
            {
                data_PID = myData["sale_stock_id"].ToString();
                data_PN = myData["bookname"].ToString();
                data_QTY = qty;
                data_P = myData["book_unit_price"].ToString();
                listBox1.Items.Add(data_PID);
                listBox2.Items.Add(data_PN);
                listBox3.Items.Add(data_QTY);
                listBox4.Items.Add(data_P);
                this.totalprice = (Convert.ToDouble(this.totalprice) + (Convert.ToDouble(data_P) * Convert.ToDouble(data_QTY))).ToString();
                txt_TotalPrice.Text = this.totalprice;
                UpdateStockLess(data_PID, qty);
            }
            catch (Exception e)
            {
                MessageBox.Show("Connect time out");
            }

        }

        private void SetOrder(string ID, string qty)
        {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UIMode);
            if (this.resultSYS == 1)
            {
                sql = "Select sale_stock_id,bookname,book_qty,book_unit_price from salestock where book_qty >= '" + qty + "' && sale_stock_id ='" + ID + "';";
            }
            else
            {
                sql = "Select sale_stock_id,bookname,book_qty,book_unit_price from salestock where book_qty >= '" + qty + "' && sale_stock_id ='" + ID + "';";
            }

            SetOrderSQL(sql, qty);
        }
        private void checkBox_Name_CheckedChanged(object sender, EventArgs e)
        {
            if (this.PN == false)
            {
                this.PN = true;
                SelectProductName();
            }
            else
            {
                this.PN = false;
                comboBox_PN.Items.Clear();
            }
        }

        private void checkBox_Category_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Ca == false)
            {
                this.Ca = true;
                SelectCa();
            }
            else
            {
                this.Ca = false;
                comboBox_Ca.Items.Clear();
            }
        }

        private void checkBox_Location_CheckedChanged(object sender, EventArgs e)
        {
            if (this.SL == false)
            {
                this.SL = true;
            }
            else 
            {
                this.SL = false;
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (comboBox_PN.Text == "Product Name" && this.PN == true || comboBox_Ca.Text == "Category" && this.Ca == true)
            {
                MessageBox.Show("Search Error!!");
            }
            else {
                if (this.PN == true || this.Ca == true) {
                    SelectSalesProduct();
                    conn.Close();
                }
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SelectSalesStock();
        }

        

        private void btn_ClearData_Click(object sender, EventArgs e)
        {
            clearData();

        }

        

        private void comboBox_Ca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_PN_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        private void btn_Enter_Click(object sender, EventArgs e)
        {
            if (comb_PID.Text == "ID" || comb_Qty.Text == "QTY")
            {
                MessageBox.Show("Please select your product and qty !");
            }
            else
            {
                string ID = comb_PID.Text;
                string qty = comb_Qty.Text;
                
                SetOrder(ID,qty);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenOrder gen = new GenOrder();
            string GO = gen.genorder(txt_TotalPrice.Text, this.UILocation, this.UIStaffID);
            
            sales_Payment SP = new sales_Payment(GO,this.totalprice,this.UIMode, this.UILocation, "0");

            //Create Customer Order
            NCCO(GO);
            SP.ShowDialog();

        }

        private void NCCO(string GO) {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UIMode);
            int size = listBox1.Items.Count;
            string sql = "insert into customerorder(co_BookID,co_BookName,co_BookQty,co_Price,GenOrder) values ";
            for (int x = 0;x <= size-1 ; x++) {
                string PID = listBox1.Items[x].ToString();
                string PN = listBox2.Items[x].ToString();
                string QTY = listBox3.Items[x].ToString();
                string P = listBox4.Items[x].ToString();
                if ((size-1) != x) {
                    sql += "('"+PID+ "','"+PN+ "','"+QTY+ "','"+P+ "','"+GO+"'),";
                }
                else {
                    sql += "('" + PID + "','" + PN + "','" + QTY + "','" + P + "','" + GO + "');";
                }
            }
            try
            {
                UpdateSQL(sql);
            }
            catch (Exception e)
            {
                MessageBox.Show("Connection time out !!");
            }
            
            Close();


        }

        private void clearData() {
            string PID;
            string QTY;
            int size = listBox1.Items.Count;
            for (int x = 0; x <= size - 1; x++)
            {
                PID = listBox1.Items[x].ToString();
                QTY = listBox3.Items[x].ToString();
                UpdateStockAdd(PID, QTY);
            }
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            txt_TotalPrice.Text = "0";
            this.totalprice = "0";
        }











    }
}
