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
    public partial class Accounting_EditTAccount : Form
    {

        CheckUserRight CUR = new CheckUserRight();
        PassPersonalData PPD = new PassPersonalData();
        private MySqlConnection conn; // call connDB
        private string UIStaffID;
        private string UIMode;
        private string UILevel;
        private string UIPost;
        private string UIdutyID;
        private string UIKEY;
        private int resultSYS;
        private string sql;

        //private control Edit Account 
        Boolean MEDANDQ = false;
        

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
        // insert T Account
        private void collectAB()
        {
            ErrorControl EC = new ErrorControl();
            string TAN_A = comb_TNameA.Text;
            string TAN_B = comb_TNameB.Text;
            string DateA = dateTimePickerA.Text;
            string DateB = dateTimePickerB.Text;
            string DescA = txt_DescA.Text;
            string DescB = txt_DescB.Text;
            string Am_A = txt_AmountA.Text;
            string Am_B = txt_AmountB.Text;
            if (comb_TNameA.Text != "T Account" && comb_TNameB.Text != "T Account" && EC.checkMoney(txt_AmountA.Text) == true && EC.checkMoney(txt_AmountB.Text) == true && EC.checkTextboxNULL(txt_DescA.Text) == true && EC.checkTextboxNULL(txt_DescB.Text) == true)
            {
                UpdateTargetA(TAN_A, DateA, DescA, Am_A);
                UpdateTargetB(TAN_B, DateB, DescB, Am_B);
                ReviewTargetA(TAN_A);
                ReviewTargetB(TAN_B);
                txt_targetA.Text = TAN_A;
                txt_targetB.Text = TAN_B;
            }
            else
            {
                MessageBox.Show("Please check Modify/Add Target A or B information !!");
            }

        }

        private void UpdateTargetA(string TAN_A, string DateA, string DescA, string Am_A)
        {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UIMode);
            string sql1 = "Insert into " + TAN_A + " (T_Date,T_Description,T_Amount) values ('" + DateA + "','" + DescA + "','" + Am_A + "');";
            MySqlCommand cmd = new MySqlCommand(sql1, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();
            this.conn.Close();
        }
        private void UpdateTargetB(string TAN_B, string DateB, string DescB, string Am_B)
        {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UIMode);
            string sql1 = "Insert into " + TAN_B + " (T_Date,T_Description,T_Amount) values ('" + DateB + "','" + DescB + "','" + Am_B + "');";
            MySqlCommand cmd = new MySqlCommand(sql1, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();
            this.conn.Close();
        }

        private void ReviewTargetA(string TAN_A)
        {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UIMode);
            string sql1 = "Select T_ID'ID',T_Date'Date',T_Description'Description',T_Amount'$',T_UpdateDate from " + TAN_A + ";";
            MySqlCommand cmd = new MySqlCommand(sql1, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(myData);
            dataGridView2.DataSource = dt;
            this.conn.Close();
        }
        private void ReviewTargetB(string TAN_B)
        {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UIMode);
            string sql1 = "Select T_ID'ID',T_Date'Date',T_Description'Description',T_Amount'$',T_UpdateDate from " + TAN_B + ";";
            MySqlCommand cmd = new MySqlCommand(sql1, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(myData);
            dataGridView3.DataSource = dt;
            this.conn.Close();
        }
        // Modify Error Data
        private void collectA()
        {
            ErrorControl EC = new ErrorControl();
            string TID = Convert.ToInt32( comb_7.Text + comb_6.Text + comb_5.Text + comb_4.Text + comb_3.Text + comb_2.Text + comb_1.Text).ToString();
            string TAN_A = comb_TNameA.Text;
            string DateA = dateTimePickerA.Text;
            string DescA = txt_DescA.Text;
            string Am_A = txt_AmountA.Text;
            if (comb_TNameA.Text != "T Account" && EC.checkMoney(txt_AmountA.Text) == true && EC.checkTextboxNULL(txt_DescA.Text) == true && TID != "NUM")
            {
                EditTargetA(TAN_A, DateA, DescA, Am_A, TID);
                ReviewTargetA(TAN_A);
            }

        }

        private void EditTargetA(string TAN_A, string DateA, string DescA, string Am_A, string TID)
        {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UIMode);
            string sql1 = "update " + TAN_A + "  set T_Date = '" + DateA + "',T_Description = '" + DescA + "', T_Amount ='" + Am_A + "' where T_ID = '" + TID + "';";
            Console.WriteLine(sql1);
            MySqlCommand cmd = new MySqlCommand(sql1, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();
            this.conn.Close();
        }
        // Search T Account 
        private void ReViewData()
        {
            string name = comb_TAccountName.Text;
            string name1;//Credit
            string name2;//Debit
            string save = "";
            char num;
            int size = name.Length - 1;
            int Tag = size - 2;
            num = name[Tag];
            for (int x = 0; x <= size - 1; x++)
            {
                save += name[x];
            }
            name1 = save + "C";
            name2 = save + "D";
            if (num == '1' || num == '5' || num == '6')
            {
                ReViewA(name1);
                txt_targetA.Text = name1;
                ReViewB(name2);
                txt_targetB.Text = name2;
            }
            else
            {
                ReViewA(name2);
                txt_targetA.Text = name2;
                ReViewB(name1);
                txt_targetB.Text = name1;
            }
        }
        private void ReViewA(string name)
        {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UIMode);
            string sql1 = "Select T_ID'ID',T_Date'Date',T_Description'Description',T_Amount'$',T_UpdateDate from " + name + ";";
            MySqlCommand cmd = new MySqlCommand(sql1, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(myData);
            dataGridView2.DataSource = dt;
            this.conn.Close();
        }
        private void ReViewB(string name)
        {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UIMode);
            string sql1 = "Select T_ID'ID',T_Date'Date',T_Description'Description',T_Amount'$',T_UpdateDate from " + name + ";";
            MySqlCommand cmd = new MySqlCommand(sql1, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(myData);
            dataGridView3.DataSource = dt;
            this.conn.Close();
        }
        //Load Combox Data
        private void LoadTAccountCOMBOX_C() {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UIMode);
            string sql1 = "Select T_Account_Name from T_Account_Credit where T_Account_Status = 1;";
            MySqlCommand cmd = new MySqlCommand(sql1, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();
            comb_TAccountName.Items.Clear();
            comb_TNameA.Items.Clear();
            while (myData.Read()) {
                string data = myData.GetString(0);
                comb_TAccountName.Items.Add(data);
                comb_TNameA.Items.Add(data);
            }
            this.conn.Close();
        }
        private void LoadTAccountCOMBOX_D()
        {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UIMode);
            string sql1 = "Select T_Account_Name from T_Account_Debit where T_Account_Status = 1;";
            MySqlCommand cmd = new MySqlCommand(sql1, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader(); 
            comb_TAccountName.Items.Clear();
            comb_TNameB.Items.Clear();
            while (myData.Read())
            {
                string data =myData.GetString(0);
                comb_TAccountName.Items.Add(data);
                comb_TNameB.Items.Add(data);
            }
            this.conn.Close();
        }//Modify
        private void LoadTAccountCOMBOX_DModify()
        {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UIMode);
            string sql1 = "Select T_Account_Name from T_Account_Debit where T_Account_Status = 1;";
            MySqlCommand cmd = new MySqlCommand(sql1, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();
            comb_TNameA.Items.Clear();
            while (myData.Read())
            {
                string data = myData.GetString(0);
                
                comb_TNameA.Items.Add(data);
            }
            this.conn.Close();
        }
        private void LoadTAccountCOMBOX_CModify()
        {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UIMode);
            string sql1 = "Select T_Account_Name from T_Account_Credit where T_Account_Status = 1;";
            MySqlCommand cmd = new MySqlCommand(sql1, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();
            while (myData.Read())
            {
                string data = myData.GetString(0);
                
                comb_TNameA.Items.Add(data);
            }
            this.conn.Close();
        }
        // Menu
        public Accounting_EditTAccount(string mode)
        {
            InitializeComponent();
            this.UIMode = mode;
            LoadTAccountCOMBOX_C();
            LoadTAccountCOMBOX_D();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Accounting_EditTAccount_Load(object sender, EventArgs e)
        {

        }

        private void btn_SubmitTAccount_Click(object sender, EventArgs e)// T A
        {
            string TID = Convert.ToInt32(comb_7.Text + comb_6.Text + comb_5.Text + comb_4.Text + comb_3.Text + comb_2.Text + comb_1.Text).ToString();
            if (txt_DescA.Text == "Balance B/D" || txt_DescA.Text == "Balance C/D" && this.MEDANDQ == true && Convert.ToInt32(TID) == 0) {
                string TAN_A = comb_TNameA.Text;
                string DateA = dateTimePickerA.Text;
                string DescA = txt_DescA.Text;
                string Am_A = txt_AmountA.Text;
                UpdateTargetA(TAN_A,DateA,DescA,Am_A);
            }
            else {
                if (this.MEDANDQ == true)
                {
                    collectAB();
                }
                else
                {
                    collectA();
                }
            }
            
            
        }

        private void ModifyErrorData_CheckedChanged(object sender, EventArgs e)
        {
            this.MEDANDQ = false;
            groupBox3.Visible = false;
            
                
            LoadTAccountCOMBOX_DModify();
            LoadTAccountCOMBOX_CModify();
            
        }


        private void btn_AddNewData_CheckedChanged(object sender, EventArgs e)
        {
            this.MEDANDQ = true;
            groupBox3.Visible = true;
            LoadTAccountCOMBOX_C();
            LoadTAccountCOMBOX_D();



        }

        private void btn_SearchTAN_Click(object sender, EventArgs e)
        {
            ReViewData();
        }

        private void To_BalanceM_CheckedChanged(object sender, EventArgs e)// Balance C/D
        {
            this.MEDANDQ = false;
            groupBox3.Visible = false;
            txt_DescA.Text = "Balance C/D";
            LoadTAccountCOMBOX_C();
            LoadTAccountCOMBOX_D();
        }

        private void To_BalanceM_BD_CheckedChanged(object sender, EventArgs e)// Balance B/D
        {
            this.MEDANDQ = false;
            groupBox3.Visible = false;
            txt_DescA.Text = "Balance B/D";
            LoadTAccountCOMBOX_C();
            LoadTAccountCOMBOX_D();
        }

        private void btn_ReviewCompanyOrder_Click(object sender, EventArgs e)
        {
            string title = comb_Title.Text;
            string startDate = dateTimePicker_start.Text;
            string endDate = dateTimePicker_End.Text;
            if (title == "Staff Salary") 
            {
                ShowSalesOrder(1, startDate, endDate);
            } else if (title == "Sales Stock") 
            {
                ShowSalesOrder(2, startDate, endDate);
            }
            else if (title == "Sales Order")
            {
                ShowSalesOrder(3, startDate, endDate);
            }
            else if (title == "Purchase Order")
            {
                ShowSalesOrder(4, startDate, endDate);
            }
            else
            {
                ShowSalesOrder(5, startDate, endDate);
            }

        }

        private void ShowSalesOrder(int Ttype,string startDate, string endDate) {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UIMode);
            string sql1 = "";
            if (Ttype == 1)
            {
                sql1 = "SELECT staff_ID'staff ID',Dept_ID'Department ID',staffName'Staff Name',staff_Salary'Salary' FROM staff where staffStatus = 'Normal' or staffStatus = 'Locked';";
            } 
            else if (Ttype == 2) {
                sql1 = "SELECT * FROM salestock where book_date between '"+startDate+ "' and '" + endDate + "';";
            } 
            else if (Ttype == 3) {
                sql1 = "SELECT * FROM sale_order where sale_order_date between '" + startDate + "' and '" + endDate + "';";
            }
            else if (Ttype == 4) {
                sql1 = "SELECT * FROM purchase_order where purchase_order_date between '" + startDate + "' and '" + endDate + "';";
            }
            else if (Ttype == 5) {
                sql1 = "SELECT * FROM procurementstock where book_date between '" + startDate + "' and '" + endDate + "';";
            }
            Console.WriteLine(sql1);
            MySqlCommand cmd = new MySqlCommand(sql1, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(myData);
            dataGridView1.DataSource = dt;

            this.conn.Close();
        }
    }
}
