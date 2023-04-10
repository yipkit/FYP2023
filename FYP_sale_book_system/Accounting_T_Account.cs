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
    public partial class Accounting_T_Account : Form
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

        public Accounting_T_Account(string uIMode)
        {
            InitializeComponent();
            this.UI_mode = uIMode;
            ReviewFunction();
            this.conn.Close();
            ReviewTAccountD();
            this.conn.Close();
        }
        private void ReviewTAccountD()
        {
            
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);
            string sql = "Select T_Account_Name'T Account Name' from T_Account_Debit where T_Account_Status = 1;";

            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();
            while (myData.Read())
            {
                string data = myData.GetString(0);
                comb_TAccountNameD.Items.Add(data);
                
            }




            
        }

       

        private void ReviewTAccountListD()
        {
            comb_TAccountNameD.Items.Clear();
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);
            string sql = "Select T_Account_ID'ID', T_Account_Name'Name', T_Account_CreateDate'Create Date' from T_Account_Debit where T_Account_Status = '1';";
            
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(myData);
            dataGridView3.DataSource = dt;
            
        }

        private void ReviewTAccountListC()
        {
            comb_TAccountNameD.Items.Clear();
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);
            string sql = "Select T_Account_ID'ID', T_Account_Name'Name', T_Account_CreateDate'Create Date' from T_Account_Credit where T_Account_Status = '1';";
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();

            dt.Load(myData);
            dataGridView2.DataSource = dt;
            
        }

        private void ReviewFunction()
        {
            
            ReviewTAccountD();
            ReviewTAccountListD();
            ReviewTAccountListC();
            this.conn.Close();
        }


        private string switchName() {
            string Leger = comb_AccountType.Text;
            if (Leger == "Asset account_DebitAddCreditLess") {
                return"1";
            }
            else if (Leger == "Liability account_DebitLessCreditAdd")
            {
                return "2";
            }
            else if (Leger == "Capital account_DebitLessCreditAdd")
            {
                return "3";
            }
            else if (Leger == "Revenue account_DebitLessCreditAdd")
            {
                return "4";
            }
            else if (Leger == "Expense account_DebitAddCreditLess")
            {
                return "5";
            }
            else//Drawings account_DebitAddCreditLess
            {
                return "6";
            }
        }

       
        private void CreateTAccount()
        {
            string date = comb_Y.Text + comb_M.Text;
            string Title = txt_Title.Text;
            string LegerType = switchName();


            string name = Title + "_" + date + "_" + LegerType;

            CreateCredit(name);
            
            CreateDebit(name);
            
            AddCreditTAccount(name);
            
            AddDebitTAccount(name);
            
            ReviewFunction();
        }
        private void CreateCredit(string name)
        {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);
            string rename = name + "_C";
            string sql = "use database_version1; Create table " + rename + "" +
                "(T_ID int NOT NULL AUTO_INCREMENT PRIMARY KEY," +
                " T_Date VARCHAR(255) NOT NULL," +
                " T_Description varchar(255) NOT NULL," +
                " T_Amount Decimal(15,2) NOT NULL," +
                " T_UpdateDate DateTime DEFAULT CURRENT_TIMESTAMP NOT NULL);";
            
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();
            Console.WriteLine("PART A");
            this.conn.Close();
            

        }
        private void CreateDebit(string name)
        {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);
            string rename = name + "_D";
            string sql = "use database_version1; Create table " + rename + "" +
                "(T_ID int NOT NULL AUTO_INCREMENT PRIMARY KEY," +
                " T_Date VARCHAR(255) NOT NULL," +
                " T_Description varchar(255) NOT NULL," +
                " T_Amount Decimal(15,2) NOT NULL," +
                " T_UpdateDate DateTime DEFAULT CURRENT_TIMESTAMP NOT NULL);";
            
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();
            Console.WriteLine("PART B");
            this.conn.Close();




        }
        private void AddCreditTAccount(string name)
        {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);
            string rename = name + "_C";
            string sql = "insert into T_Account_Credit(T_Account_Name,T_Account_Status) values('" + rename + "','1'); ";

            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();
            Console.WriteLine("PART C");
            this.conn.Close();

        }
        private void AddDebitTAccount(string name)
        {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);
            string rename = name + "_D";
            string sql = "insert into T_Account_Debit(T_Account_Name,T_Account_Status) values('" + rename + "','1'); ";
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();
            Console.WriteLine("PART D");
            this.conn.Close();

        }

        private void DropTAccount(string name) {
            string name1;//Credit
            string name2;//Debit
            string save = "";
            int size = name.Length-1;
            for (int x = 0; x <= size-1 ;x++) {
                save += name[x];
            }
            name1 = save + "C";
            name2 = save + "D";
            
            DropStep1(name1);
            DropStep1(name2);
            DeleteCreditFormData(name1);
            DeleteDebitFormData(name2);

        }

        private void DropStep1(string name) {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);
            
            string sql1 = "Drop Table " + name + "; ";
            Console.WriteLine(sql1);
            MySqlCommand cmd = new MySqlCommand(sql1, this.conn);
            
            MySqlDataReader myData = cmd.ExecuteReader();
            this.conn.Close();
        }
        private void DeleteCreditFormData(string name) {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);
            string sql1 = "UPDATE  T_Account_Credit SET T_Account_Status = '0' where T_Account_Name = '" + name + "';";
            
            MySqlCommand cmd = new MySqlCommand(sql1, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();
            this.conn.Close();
        }
        private void DeleteDebitFormData(string name)
        {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UI_mode);
            string sql1 = "UPDATE  T_Account_Debit SET T_Account_Status = '0' where T_Account_Name = '" + name + "';";
            
            MySqlCommand cmd = new MySqlCommand(sql1, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();
            this.conn.Close();
        }




        private void Accounting_T_Account_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void create_debit_btn_Click(object sender, EventArgs e)
        {
            
        }



        private void create_credit_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void debit_and_credit_btn_Click_1(object sender, EventArgs e)
        {
            
        }

        private void credit_and_debit_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void restart_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        

        private void button2_Click_1(object sender, EventArgs e)//btn_RefashTAccountList
        {
            ReviewFunction();
        }
       
        private void button1_Click(object sender, EventArgs e)//Create T Account
        {
            CreateTAccount();
        }

        private void btn_DeleteTAccount_Click(object sender, EventArgs e)
        {
            string name = comb_TAccountNameD.Text;
            if (name != " T Account Name" || name.Length != 0)
            {
                DropTAccount(name);
            }
            else {
                MessageBox.Show("Please select T Account Name !");
            }
            

        }

        private void comb_AccountType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
