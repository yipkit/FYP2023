using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    public partial class sales_StockTake : Form
    {
        //Public Value
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

        //Private Form value
        private Boolean Se1 = false;
        private Boolean Se2 = false;




        //Public method
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
        private void runInsertOrUpdateSQL(String sql)
        {

            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();


        }

        private void ReflashStockNUM() {
            comb_selectNum.Items.Clear();
            comb_SelectStockTakeNo.Items.Clear();
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UIMode);
            string sql = "";
            if (this.resultSYS == 1)
            {
                sql = "Select DISTINCT(stock_take_no) from sale_stock_take;";
            }
            else
            {
                sql = "Select DISTINCT(stock_take_no) from sale_stock_take;";
            }
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();


            while (myData.Read())
            {
                string Comp_Data = myData.GetString(0);
                comb_selectNum.Items.Add(Comp_Data);
                comb_SelectStockTakeNo.Items.Add(Comp_Data);
            }


            conn.Close();

        }

        private void getStockTakeID(string StockTakeNo) //NUM1
        {


            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UIMode);
            string sql = "";
            if (this.resultSYS == 1)
            {
                sql = "Select stock_take_id'Stock Take ID', stock_take_no'Stock Take No.', stock_take_SNID'SNID', stock_take_name'Name', stock_take_qty'Qty', stock_take_date'Finsih Date', stock_take_details'New Details', stockdb_SNID'SNID', stockdb_name'Name', stockdb_qty'Old Qty', stockdb_date'Old Date', stockdb_details'Old Details', location'Location', create_date'Create Date'" +
                    " from sale_stock_take where stock_take_no = '" + StockTakeNo + "';";
            }
            else
            {
                sql = "Select stock_take_id'Stock Take ID', stock_take_no'Stock Take No.', stock_take_SNID'SNID', stock_take_name'Name', stock_take_qty'Qty', stock_take_date'Finsih Date', stock_take_details'New Details', stockdb_SNID'SNID', stockdb_name'Name', stockdb_qty'Old Qty', stockdb_date'Old Date', stockdb_details'Old Details', location'Location', create_date'Create Date'" +
                    " from sale_stock_take where stock_take_no = '" + StockTakeNo + "';";
            }
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(myData);
            dataGridView1.DataSource = dt;
            conn.Close();



            conn.Close();

        }

        //stock_take_SNID
        private int getlocationNUM(string name) {

            Console.WriteLine(name);
            string save = "";
            for (int x = 0; x <= name.Length - 1; x++) {
                if (name[x] == '.')
                {
                    return Convert.ToInt32(save);
                }
                save += name[x];

            }
            return 0;
        }
        //Product ID

        private void CreatePIDsql() {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UIMode);
            string sql = "";
            if (this.resultSYS == 1)
            {
                sql = "Select sale_stock_id from salestock;";
            }
            else
            {
                sql = "Select sale_stock_id from salestock;";
            }
            runPIDsql(sql);
            conn.Close();
        }

        private void runPIDsql(string sql) {
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();

            while (myData.Read()) {
                comb_ProductID.Items.Add(myData.GetString(0));
                comb_StockTakePID.Items.Add(myData.GetString(0));
            }
            conn.Close();

        }

        //Location
        private void CountCompData()
        {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UIMode);
            string Csql;
            if (this.resultSYS == 1)
            {
                Csql = "Select Count(comp_Name) from company where comp_status = 'Open';";
            }
            else
            {
                Csql = "Select Count(comp_Name) from company where comp_status = 'Open';";
            }
            int size = runCompDataCountSQL(Csql);
            CompData(size);
            conn.Close();

        }
        private int runCompDataCountSQL(String sql)
        {
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();

            myData.Read();
            int count = Int32.Parse(myData.GetString(0));
            conn.Close();
            return count;
        }

        private void CompData(int size)
        {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UIMode);
            string Nsql;
            if (this.resultSYS == 1)
            {
                Nsql = "Select comp_Name from company where comp_status = 'Open';";
            }
            else
            {
                Nsql = "Select comp_Name from company where comp_status = 'Open';";
            }
            runCompDataSQL(Nsql, size);
            conn.Close();
        }

        private void runCompDataSQL(string sql, int size)
        {
            string Comp_Data;
            string[] Comp_Name = new string[size];
            int count = 0;
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();

            //myData.Read();
            while (myData.Read())
            {
                Comp_Data = myData.GetString(0);
                Comp_Name[count] = Comp_Data;
                comb_Location.Items.Add((count + 1) + "." + Comp_Data);
                comb_GenLocation.Items.Add((count + 1) + "." + Comp_Data);
                count++;

            }
            conn.Close();
        }






        //Search Sales Stock
        private void SelectSalesProduct()
        {


            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UIMode);
            if (this.Se1 == false && this.Se2 == false)
            {
                conn.Close();
            }
            else {
                if (this.resultSYS == 1)
                {
                    sql = point();
                }
                else
                {
                    sql = point();
                }


                runSelectDGSQL(sql);
                conn.Close();
            }




        }

        private string point()
        {

            sql = " Select sale_stock_id'Sale Stock ID', SNID, salestock.authors_id'Authors ID', salestock.languages_id'Languages ID', salestock.category_id'Category ID', supplier_id'Supplier ID', salestock.comp_LocationID'Location ID', e_book_id'E-book ID', bookname'Book Name', book_qty'QTY', book_stockLv'Stock Level', book_unit_price'Price', book_date'Date', bookDetails'Details', phasing_out_status'Phasing Out Status', company.comp_LocationID'LocationID', comp_Name'Name', comp_CountryNumber'Country Number', comp_PhoneNumber'Phone Number', comp_Address'Address', comp_Status'Company Status', comp_Type'Company Type', comp_HeadOffice_Branch'HeadOffice / Branch', category.category_id'Category ID', category, detail, authors.authors_id'Authors ID', authors_name'Authors Name', languages.languages_id'Languages ID', language'Language'"
                + "from salestock inner join company ON salestock.comp_LocationID = company.comp_LocationID inner join category ON category.category_id = salestock.category_id inner join authors ON authors.authors_id = salestock.authors_id inner join languages ON languages.languages_id = salestock.languages_id  where ";

            if (this.Se1 == true || this.Se2 == true)
            {
                if (this.Se1 == true && this.Se2 == true && comb_Location.Text != "Location" && comb_ProductID.Text != "Product ID")
                {

                    string LA = comb_Location.Text;
                    int LocationID = getlocationNUM(LA);
                    string PID = comb_ProductID.Text;




                    sql += "salestock.sale_stock_id = '" + PID + "' && salestock.comp_LocationID = '" + LocationID + "' ;";
                }
                else if (this.Se1 == true && this.Se2 == false && comb_Location.Text != "Location")
                {
                    string LA = comb_Location.Text;
                    int LocationID = getlocationNUM(LA);

                    sql += "salestock.comp_LocationID = '" + LocationID + "' ;";
                }
                else if (this.Se1 == false && this.Se2 == true && comb_ProductID.Text != "Product ID")
                {
                    string PID = comb_ProductID.Text;

                    sql += "salestock.sale_stock_id = '" + PID + "' ;";
                }
                else {
                    MessageBox.Show("Please check box and select search target !");
                    sql = "0";
                }

            }
            else
            {
                MessageBox.Show("Please check box and select search target !");
                sql = "0";
            }


            return sql;
        }

        private void runSelectDGSQL(String sql)
        {
            Console.WriteLine(sql);
            if (sql == "0") {
            }
            else {
                MySqlCommand cmd = new MySqlCommand(sql, this.conn);
                MySqlDataReader myData = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(myData);
                dataGridView1.DataSource = dt;
                conn.Close();
            }



        }

        // update Stock Take Form
        private void UpdateFrom()
        {
            ErrorControl EC = new ErrorControl();
            string sql="";
            string STNo = comb_SelectStockTakeNo.Text;
            string STID = comb_StockTakePID.Text;
            string QTY = comb_Qty1.Text + comb_Qty2.Text + comb_Qty3.Text + comb_Qty4.Text + comb_Qty5.Text + comb_Qty6.Text + comb_Qty7.Text + comb_Qty8.Text;
            string details = txt_Details.Text;

            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UIMode);
            if (EC.checkNUM(QTY) == true && EC.checkTextboxNULL(details) == true && STNo != "Select Stock Take No" && STID != "Select Product ID")
            {
                sql = "update sale_stock_take SET stock_take_qty = '"+ QTY + "', stock_take_date = CURRENT_TIMESTAMP(), stock_take_details= '" + details + "'where stock_take_no = '"+STNo+ "' && stock_take_SNID ='"+ STID + "'";
                try 
                {
                    MySqlCommand cmd = new MySqlCommand(sql, this.conn);
                    MySqlDataReader myData = cmd.ExecuteReader();

                }
                catch (Exception e){
                    MessageBox.Show("Please check input data");
                }
            }
            else {
                MessageBox.Show("Please check input data");
            }
        }

        //CreateForm
        private void CreateForm() {

            string fKey = GenStockTakeNo(this.UILocation, this.UIStaffID);
            string lKey = fKey + comb_GenLocation.Text;
            //stock_take_id, stock_take_no, stock_take_SNID, stock_take_name, stock_take_qty, stock_take_date, stock_take_details, stockdb_SNID, stockdb_name, stockdb_qty, stockdb_date, stockdb_details, location, create_date
            txt_GenStockTakeNo.Text = lKey;
            updateData(lKey, comb_GenLocation.Text);




            conn.Close();


        }
        


        // Search Sales Data(createForm)
        private void updateData( string key, string location)
        {
            
           
            
            string []SaleStockID = new string[1000]; ;
            string []Bookname = new string[1000]; ;
            string []Qty = new string[1000]; ;
            string []Book_Date = new string[1000]; ;
            string []BookDetails = new string[1000]; ;

            string sum = "";
            int count = 0;
            string LA = comb_GenLocation.Text;
            int LocationID = getlocationNUM(LA);
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UIMode);
            string sql = "Select sale_stock_id,bookname,book_qty, book_date, bookDetails from salestock where comp_LocationID = '" + LocationID + "';";
            string save = "insert into sale_stock_take ( stock_take_no, stock_take_SNID, stock_take_name,  stockdb_SNID, stockdb_name, stockdb_qty, stockdb_date, stockdb_details, location, create_date)values";
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();
                while (myData.Read())
                {
                
                    string newDate = "";
                    SaleStockID[count] = myData["sale_stock_id"].ToString();
                    Bookname[count] = myData["bookname"].ToString();
                    Qty[count] = myData["book_qty"].ToString();
                    BookDetails[count] = myData["bookDetails"].ToString();
                    string date = myData["book_date"].ToString();
                    
                    for (int y = 0; y <= Book_Date.Length - 1; y++)
                    {
                        if (date[y] == ' ')
                        {
                            Book_Date[count] = newDate;
                            break;
                        }
                        newDate += date[y];
                        
                    }



                    save += "('" + key + "', '" + SaleStockID[count] + "', '" + Bookname[count] + "', '" + SaleStockID[count] + "', '" + Bookname[count] + "', '" + Qty[count] + "', '" + Book_Date[count] + "', '" + BookDetails[count] + "', '" + location + "', CURRENT_TIMESTAMP()),";
               count++;

                }
            conn.Close();

            
            
            
            
            int su = save.Length;
            for (int x = 0; x <= su - 1; x++)
            {
                if (x != su - 1)
                {

                    sum += save[x];
                }
                else
                {
                    sum += ";";
                }

            }


            runCreateTake(sum);

        }
        private void runCreateTake(string sql) {

            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UIMode);
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();
            conn.Close();

        }


        


        //
        public sales_StockTake(string staffID,string Mode,string location)
        {
            InitializeComponent();
            this.UIStaffID = staffID;
            this.UIMode = Mode;
            this.UILocation = location;
            CountCompData();
            CreatePIDsql();
            ReflashStockNUM();
        }
        private  string GenStockTakeNo(string Location, string staffID) {
            DateTime Date = DateTime.Now;
            string dateY = Date.Year.ToString();
            string dateM = Date.Month.ToString();
            string dateD = Date.Day.ToString();
            string dateh = Date.Hour.ToString();
            string datem = Date.Minute.ToString();
            string dates = Date.Second.ToString();
            Random ran = new Random();
            string num = ran.Next(1,999999).ToString();
            return dateY + "/" + dateM + "/" + dateD + "-" + dateh + ":" + datem + ":" + dates + "-" + Location + "-" + staffID + "-" + num;
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            conn.Close();
            Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SelectSalesProduct();
            conn.Close();
        }

        private void checkBox_LN_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Se1 == false)
            {
                this.Se1 = true;
            }
            else {
                this.Se1 = false;
            }
            Console.WriteLine(Se1);

        }

        private void checkBox_PN_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Se2 == false)
            {
                this.Se2 = true;
            }
            else
            {
                this.Se2 = false;
            }
            Console.WriteLine(Se2);
        }

        private void btn_CreateForm_Click(object sender, EventArgs e)
        {
            if (stockISNULL() != 0)
            {
                if (comb_GenLocation.Text != "Location")
                {
                    CreateForm();
                    ReflashStockNUM();
                }
                else
                {
                    MessageBox.Show("Please select Location!");

                }
            }
            else {
                MessageBox.Show("This stock hasn't sales stock list !");
            }
            
            
        }


        private int stockISNULL() {

            string LA = comb_GenLocation.Text;
            int LocationID = getlocationNUM(LA);
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UIMode);
            string sql = "Select count(sale_stock_id) from salestock where comp_LocationID = '" + LocationID + "';";
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();
            myData.Read();
            int result =Convert.ToInt32( myData.GetString(0));
            conn.Close();
            return result;
        }

        private void comb_selectNum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_SearchStockTake_Click(object sender, EventArgs e)
        {
            getStockTakeID(comb_selectNum.Text);
        }

        private void btn_UpdateStockTakeForm_Click(object sender, EventArgs e)
        {
            //Part1
            UpdateFrom();
        }

        private void btn_Refash_Click(object sender, EventArgs e)
        {
            
            CountCompData();
            CreatePIDsql();
            ReflashStockNUM();
        }

        private void comb_Location_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comb_StockTakePID_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comb_SelectStockTakeNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            comb_StockTakePID.Visible = true;
            
        }

        private void comb_ProductID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
