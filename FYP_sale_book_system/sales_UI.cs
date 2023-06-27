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
    public partial class sales_UI : Form
    {
        

        PassPersonalData PPD = new PassPersonalData();
        CheckUserRight CUR = new CheckUserRight();
        private MySqlConnection conn; // call connDB
        private string UIStaffID;
        private string UIMode;
        private string UILevel;
        private string UIPost;
        private string UIKEY;
        private string UILocation;
        private int resultSYS;
        private string sql;
        private string UIStatus;
        private string UIJOBTYPE;
        //sales_create_sales_order CSO = new sales_create_sales_order();

        private void checkHiddenGroupBox()
        {
            if ((this.UIPost == "Manager" || Convert.ToInt32(this.UILevel) >= 2) && this.UIStatus == "Normal")//Sales Order
            {
                groupBox3.Visible = true;
            }
            else
            {
                groupBox3.Visible = false;
            }
            if ((this.UIPost == "Manager" || Convert.ToInt32(this.UILevel) >= 2) && this.UIStatus == "Normal")//Stock Take
            {
                groupBox4.Visible = true;
            }
            else
            {
                groupBox4.Visible = false;
            }
            if ((this.UIPost == "Manager" || Convert.ToInt32(this.UILevel) >= 2) && this.UIStatus == "Normal")// Sales Stock
            {
                groupBox5.Visible = true;
            }
            else
            {
                groupBox5.Visible = false;
            }
            if ((this.UIPost == "Manager" || Convert.ToInt32(this.UILevel) >= 3) && this.UIStatus == "Normal")// Customer Setting
            {
                groupBox6.Visible = true;
            }
            else
            {
                groupBox6.Visible = false;
            }
            if ((this.UIPost == "Manager" || Convert.ToInt32(this.UILevel) >= 2) && this.UIStatus == "Normal")// E-Book
            {
                Ebook.Visible = true;
            }
            else
            {
                Ebook.Visible = false;
            }
            if ((this.UIPost == "Manager" || Convert.ToInt32(this.UILevel) >= 6) && this.UIStatus == "Normal")// Other Function
            {
                groupBox1.Visible = true;
            }
            else
            {
                groupBox1.Visible = false;
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
        private void runInsertOrUpdateSQL(String sql)
        {
            
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();
            this.conn.Close();


        }
        private void UpdateLogoutTime(string mode,string KEY)
        {

            
            this.resultSYS = 0;
            this.resultSYS = checkConnection(mode);
            if (this.resultSYS == 1)
            {
                this.sql = "update duty_record set off_datetime=current_timestamp() where staff_id = '"+this.UIStaffID+"' && duty_key = '"+ KEY +"';";
            }
            else
            {
                this.sql = "update duty_record set off_datetime=current_timestamp() where staff_id = '"+this.UIStaffID+"' && duty_key = '"+ KEY +"';";
            }
            runInsertOrUpdateSQL(this.sql);
            conn.Close();
            

        }
         
         

        public sales_UI(string staffID,string Mode,string KEY,string location)
        {
            
            InitializeComponent();
            this.UIStaffID = staffID;
            this.UIMode = Mode;
            this.UIKEY = KEY;
            this.UILevel = CUR.checkRight( staffID, Mode);
            this.UIPost = CUR.checkPost(staffID, Mode);
            this.UILocation = location;
            this.UIStatus = PPD.checkPersonStatus(staffID, Mode);
            this.UIJOBTYPE = PPD.checkPersonJobType(staffID, Mode);
            checkHiddenGroupBox();//Set Staff Right


        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            
            UpdateLogoutTime(this.UIMode, this.UIKEY);
            deleteKEY dKEY = new deleteKEY();
            dKEY.ModifyData(this.UIStaffID,this.UIKEY);
            Application.Exit();
        }

        

        private void sales_UI_Load(object sender, EventArgs e)
        {

        }

      

        private void borrow_book_btn_Click(object sender, EventArgs e)
        {
            sales_create_Ebook_order EbookAndGits  = new sales_create_Ebook_order(this.UIMode, this.UILocation, this.UIStaffID);
            EbookAndGits.ShowDialog();
        }

        private void btn_CreateSalesOrder_Click(object sender, EventArgs e)
        {
            sales_create_sales_order CSO = new sales_create_sales_order(this.UIMode,this.UILocation,this.UIStaffID);
            CSO.ShowDialog();
        }

        private void btn_EditSalesOrder_Click(object sender, EventArgs e)
        {

        }

        private void btn_CreateStockTake_Click(object sender, EventArgs e)
        {
            sales_StockTake sST = new sales_StockTake(this.UIStaffID,this.UIMode,this.UILocation);
            sST.ShowDialog();
        }

        private void btn_ReviewStockTake_Click(object sender, EventArgs e)
        {

        }

        private void btn_CreateSalesStock_Click(object sender, EventArgs e)
        {

        }

        private void btn_ReviewSalesStock_Click(object sender, EventArgs e)
        {
            sales_check_sales_stock CSS = new sales_check_sales_stock(this.UIMode);
            CSS.ShowDialog();
        }

        private void btn_CreateCustomerAccount_Click(object sender, EventArgs e)
        {
            SalesAndIT_CreateCustomerAccount SAICCA = new SalesAndIT_CreateCustomerAccount(this.UIMode);
            SAICCA.ShowDialog();
        }

      

        private void gen_ebook_link_btn_Click(object sender, EventArgs e)
        {
            sale_gen_Ebook_link gen_link = new sale_gen_Ebook_link(this.UIMode,"0","0");
            gen_link.ShowDialog();
        }

        private void ebook_edit_btn_Click(object sender, EventArgs e)
        {
            sale_edit_ebook_link edit_ebook = new sale_edit_ebook_link(this.UIMode);
            edit_ebook.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAnalysis DA = new DataAnalysis();
            DA.ShowDialog();
        }
    }
}
