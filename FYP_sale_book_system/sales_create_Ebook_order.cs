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
    public partial class sales_create_Ebook_order : Form
    {
        ErrorControl ec = new ErrorControl();
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
        private int totalNUMCC = 0;
        private int totalNUMEB = 0;
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
        private void runEbookList()
        {
            
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UIMode);
            if (this.resultSYS == 1)
            {
                sql = "Select e_book_id from e_book where e_book_status = 'Yes' && e_book_link_status = 'Online';";
            }
            else
            {
                sql = "Select e_book_id from e_book where e_book_status = 'Yes' && e_book_link_status = 'Online';";
            }
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();
            comboBox_EbookID.Items.Clear();
            comboBox_EbookID.Text = "ID";
            while (myData.Read())
            {
               string data = myData.GetString(0);
               comboBox_EbookID.Items.Add(data);
            }
        }

        private void runGPointList()
        {

            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UIMode);
            if (this.resultSYS == 1)
            {
                sql = "Select gitsCardPrice from gitsCardProduct where gitsCardStatus ='1' ;";
            }
            else
            {
                sql = "Select gitsCardPrice from gitsCardProduct where gitsCardStatus ='1' ;";
            }
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();
            comboBox_Gits.Items.Clear();
            comboBox_Gits.Text = "Point";
            while (myData.Read())
            {
                string data = myData.GetString(0);
                comboBox_Gits.Items.Add(data);
            }
        }

        private void SearchEBook()// Search E-Book
        {


            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UIMode);
            if (this.resultSYS == 1)
            {
                sql = "Select e_book_id'E Book ID', e_book_SNID'E Book SNID', e_book_name'E Book Name', e_book_status'E Book Status' from e_book where e_book_name like '%" + text_searchEbook.Text + "%';";
            }
            else
            {
                sql = "Select e_book_id'E Book ID', e_book_SNID'E Book SNID', e_book_name'E Book Name', e_book_status'E Book Status' from e_book where e_book_name like '%" + text_searchEbook.Text + "%';";
            }
            runSelectDGSQL(sql);


        }
        private void UpdateEBook()// Search ALL
        {


            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UIMode);
            if (this.resultSYS == 1)
            {
                sql = "Select e_book_id'E Book ID', e_book_SNID'E Book SNID', e_book_name'E Book Name', e_book_status'E Book Status' from e_book;";
            }
            else
            {
                sql = "Select e_book_id'E Book ID', e_book_SNID'E Book SNID', e_book_name'E Book Name', e_book_status'E Book Status' from e_book;";
            }
            runSelectDGSQL(sql);


        }
        private void checkGPrice(string qty) {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UIMode);
            if (this.resultSYS == 1)
            {
                sql = "Select gitsCardPrice from gitsCardProduct where gitsCardName = '" + comboBox_Gits.Text + "';";
            }
            else
            {
                sql = "Select gitsCardPrice from gitsCardProduct where gitsCardName = '" + comboBox_Gits.Text + "';";
            }
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();
            myData.Read();
            string Gprice= myData["gitsCardPrice"].ToString();
            listBox_GPrice.Items.Add(Gprice);
            this.conn.Close();
            txt_price.Text = (Convert.ToDouble(txt_price.Text) + (Convert.ToDouble(Gprice)*Convert.ToDouble(qty))).ToString();
        }
        private void checkEPrice()
        {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UIMode);
            if (this.resultSYS == 1)
            {
                sql = "Select e_book_Price from e_book where e_book_id = '" + comboBox_EbookID.Text + "';";
            }
            else
            {
                sql = "Select e_book_Price from e_book where e_book_id = '" + comboBox_EbookID.Text + "';";
                
            }
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();
            myData.Read();
            string Eprice = myData["e_book_Price"].ToString();
            listBox_EPrice.Items.Add(Eprice);
            this.conn.Close();
            txt_price.Text = (Convert.ToDouble(txt_price.Text) + (Convert.ToDouble(Eprice))).ToString();
        }
        private void runSelectDGSQL(String sql)
        {

            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(myData);
            dataGridView1.DataSource = dt;


        }
        public sales_create_Ebook_order(string Mode, string Location, string StaffID)
        {
            InitializeComponent();
            this.UIMode = Mode;
            this.UILocation = Location;
            this.UIStaffID = StaffID;
            runEbookList();
            runGPointList();
        }

        private void sales_borrow_book_Load(object sender, EventArgs e)
        {

        }

        private void btn_searchEbook_Click(object sender, EventArgs e)
        {
            SearchEBook();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            UpdateEBook();
        }

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            
            if (ec.checkTextboxNULL(txt_EMail.Text) == true && ec.checkEmail(txt_EMail.Text) ==true && comboBox_EbookID.Text != "ID" && ec.checkTextboxNULL(comboBox_EbookID.Text)==true && ec.checkNUM(comboBox_EbookID.Text) ==true ) {
                listBox_EBook.Items.Add(comboBox_EbookID.Text);
                listBox_EMailAddress.Items.Add(txt_EMail.Text);
                checkEPrice();
                listNumberEB.Items.Add(totalNUMEB);
                combo_cancelEBook.Items.Add(totalNUMEB);
                totalNUMEB++;
                runEbookList();
            }
            else
            {
                MessageBox.Show("Please check E mail Address!");
            }


        }

        private void btn_AddGitsCard_Click(object sender, EventArgs e)
        {
            if (ec.checkNUM(txt_CustomerID.Text) == true && ec.checkTextboxNULL(txt_CustomerID.Text) == true)
            {
                listBox_GiftCards.Items.Add(comboBox_Gits.Text);
                listBox_Qty.Items.Add(comboBox_QTY.Text);
                listBox_CustomerID.Items.Add(txt_CustomerID.Text);
                listNumberCC.Items.Add(totalNUMCC);
                combo_cancelGPoint.Items.Add(totalNUMCC);
                totalNUMCC++;
                checkGPrice(comboBox_QTY.Text);
            }
            else {
                MessageBox.Show("Please check customer ID!");
            }
            
        }

        private void txt_price_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            listBox_GiftCards.Items.Clear();
            listBox_Qty.Items.Clear();
            listBox_CustomerID.Items.Clear();
            listBox_GPrice.Items.Clear();
            listBox_EBook.Items.Clear();
            listBox_EMailAddress.Items.Clear();
            listBox_EPrice.Items.Clear(); 
            listNumberCC.Items.Clear();
            listNumberEB.Items.Clear();
            txt_price.Text = "0";
            totalNUMCC = 0;
            totalNUMEB = 0;
            txt_EMail.Text = "";
            txt_CustomerID.Text = "";
            runGPointList();
            runEbookList();
            combo_cancelEBook.Items.Clear();
            combo_cancelGPoint.Items.Clear();
            combo_cancelEBook.Text = "List Number";
            combo_cancelGPoint.Text = "List Number";
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//btn_DeleteGCards
        {

            int indexNum = Convert.ToInt32(combo_cancelGPoint.Text);
            string qty = listBox_Qty.Items[indexNum].ToString();
            string price = listBox_GPrice.Items[indexNum].ToString();
            txt_price.Text = (Convert.ToDouble(txt_price.Text) - (Convert.ToDouble(price) * Convert.ToDouble(qty))).ToString();
            listNumberCC.Items.RemoveAt(indexNum);
            listBox_GiftCards.Items.RemoveAt(indexNum);
            listBox_CustomerID.Items.RemoveAt(indexNum);
            listBox_Qty.Items.RemoveAt(indexNum);
            listBox_GPrice.Items.RemoveAt(indexNum);
            combo_cancelGPoint.Items.RemoveAt(Convert.ToInt32(combo_cancelGPoint.Items.Count-1));
            combo_cancelGPoint.Text = "List Number";
            totalNUMCC--;

        }

        private void btn_DeleteEBook_Click(object sender, EventArgs e)
        {
            int indexNum = Convert.ToInt32(combo_cancelEBook.Text);
            string price = listBox_EPrice.Items[indexNum].ToString();
            txt_price.Text = (Convert.ToDouble(txt_price.Text) - (Convert.ToDouble(price) )).ToString();
            listNumberEB.Items.RemoveAt(indexNum);
            listBox_EBook.Items.RemoveAt(indexNum);
            listBox_EMailAddress.Items.RemoveAt(indexNum);
            listBox_EPrice.Items.RemoveAt(indexNum);
            combo_cancelEBook.Items.RemoveAt(Convert.ToInt32(combo_cancelEBook.Items.Count - 1));
            combo_cancelEBook.Text = "List Number";
            totalNUMEB--;


        }

        private void btn_Enter_Click(object sender, EventArgs e)// Send Order
        {
            this.totalprice = txt_price.Text;
             GenOrder gen = new GenOrder();

            string GO = gen.genorder(txt_price.Text, this.UILocation, this.UIStaffID);
            

            //Create Customer Order
            string OrderMode= NCCO(GO);
            sales_Payment SP = new sales_Payment(GO, this.totalprice, this.UIMode, this.UILocation,OrderMode);
            SP.ShowDialog();
            Close();
        }

        private string gcOrder(string GO,int size) {
            string sql = "insert into customerorder(GiftsCard, GiftsCard_Qty, GiftsCard_customerID, co_Price,GenOrder) values ";
            for (int x = 0; x <= size - 1; x++)
            {
                string customerID = listBox_CustomerID.Items[x].ToString();
                string GC = listBox_GiftCards.Items[x].ToString();
                string QTY = listBox_Qty.Items[x].ToString();
                string Price = listBox_GPrice.Items[x].ToString();
                if ((size - 1) != x)
                {
                    sql += "('" + GC + "','" + QTY + "','" + customerID + "','" + Price + "','" + GO + "'),";
                }
                else
                {
                    sql += "('" + GC + "','" + QTY + "','" + customerID + "','" + Price + "','" + GO + "');";
                }
                
            }
            return sql;
        }

        private string ebOrder(string GO,int size) {
            string sql = "insert into customerorder(e_bookID,e_book_Email,co_Price,GenOrder) values ";
            for (int x = 0; x <= size - 1; x++)
            {
                string PID = listBox_EBook.Items[x].ToString(); 
                string Email = listBox_EMailAddress.Items[x].ToString();
                string P = listBox_EPrice.Items[x].ToString();
                if ((size - 1) != x)
                {
                    sql += "('" + PID + "','" +Email+ "','" + P + "','" + GO + "'),";
                }
                else
                {
                    sql += "('" + PID + "','" + Email + "','" + P + "','" + GO + "');";

                }
                
            }
            return sql;
        }

        private string NCCO(string GO)
        {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UIMode);
            string sql1 = "";
            string sql2 = "";
            string sql3 = "";
            int gc = listNumberCC.Items.Count;
            int eb = listNumberEB.Items.Count;
            if (gc != 0 && eb != 0)
            {
                sql1 = gcOrder(GO,gc);
                sql2 = ebOrder(GO,eb);
                sql3 = sql1 + sql2;
                
                UpdateSQL(sql3);
                return "1";
            }
            else if (gc != 0 && eb == 0)
            {
                sql1 = gcOrder(GO,gc);
                sql3 = sql1 + sql2;
                
                UpdateSQL(sql3);
                return "2";
            }
            else if (gc == 0 && eb != 0)
            {
                sql2 = ebOrder(GO,eb);
                sql3 = sql1 + sql2;
                Console.WriteLine(sql3);
                UpdateSQL(sql3);
                return "3";

            }
            else {
                MessageBox.Show("Please select your product on the Gift card or Ebook!");
                return "4";
            }




            this.conn.Close();
            Close();


        }
        private void UpdateSQL(string sql)
        {
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);

            MySqlDataReader myData = cmd.ExecuteReader();
        }

        private void txt_EMail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
