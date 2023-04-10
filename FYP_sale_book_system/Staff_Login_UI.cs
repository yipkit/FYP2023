using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace FYP_sale_book_system
{

    public partial class Staff_Login_UI : Form
    {

        

        GenKEY GenKEY = new GenKEY();
        CheckUserRight CUR = new CheckUserRight();
        private ErrorControl EC; // call ErrorControl
        private MySqlConnection conn; // call connDB
        //Private Value
        private int resultSYS;
        private string sql;
        private int countLoginError = 0;


        //use connectDB.cs Method
        private int checkConnection()
        {
            if (LoginMode.Text == "Normal Mode")
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

        private int runSQLCount(string sql)
        {
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();

            myData.Read();
            int num = Int32.Parse(myData.GetString(0));
            return num;
        }

        private int CheckLoginData()
        {

            string id = staff_id.Text;
            string pw = staff_password.Text;
            string dept = department.Text;
            this.resultSYS = 0;
            this.resultSYS = checkConnection();
            if (this.resultSYS == 1)
            {
                this.sql = "SELECT count(*) FROM staff where staff_ID = '" + id + "' && staffPassword = '" + pw + "' && Dept_Name = '" + dept + "' && staffStatus ='Normal';";
            }
            else
            {
                this.sql = "SELECT count(*) FROM staff where staff_ID = '" + id + "' && staffPassword = '" + pw + "' && Dept_Name = '" + dept + "' && staffStatus ='Normal';";
            }
            int result = runSQLCount(this.sql);
            conn.Close();
            if (result == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }
        private void CompData(int size)
        {
            this.resultSYS = 0;
            this.resultSYS = checkConnection();
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

            myData.Read();
            while (myData.Read())
            {
                Comp_Data = myData.GetString(0);
                Comp_Name[count] = Comp_Data;
                comboBox_location.Items.Add(Comp_Data);
                count++;

            }
        }


        private void CountCompData()
        {
            this.resultSYS = 0;
            this.resultSYS = checkConnection();
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
            conn.Close();
            CompData(size);

        }
        private int runCompDataCountSQL(String sql)
        {
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();

            myData.Read();
            int count = Int32.Parse(myData.GetString(0));
            return count;
        }



        private void CallAdmin()
        {

            if (this.countLoginError > 2)
            {
                MessageBox.Show("Please contact admin to reset account !");
                Application.Exit();
            }
        }

        private void clearTextboxData()
        {
            staff_id.Clear();
            staff_password.Clear();
            comboBox_location.Items.Clear();
            this.resultSYS = 0;
            this.sql = "";
        }

        private void UpdateDutyData(string KEY)
        {
            
            string id = staff_id.Text;
            string Location = comboBox_location.Text;
            this.resultSYS = 0;
            this.sql = "";
            this.resultSYS = checkConnection();
            

            if (this.resultSYS == 1)
            {
                this.sql = "insert into duty_record (duty_id,staff_id,off_datetime,duty_comp_Name,duty_key) values (NULL,'" + id + "',NULL,'" + Location + "','"+KEY+"'); ";
            }
            else
            {
                this.sql = "insert into duty_record (duty_id,staff_id,off_datetime,duty_comp_Name,duty_key) values (NULL,'" + id + "',NULL,'" + Location + "','" + KEY + "'); ";
            }
            try {
                runInsertOrUpdateSQL(this.sql);
                conn.Close();
            } catch (Exception e) { 
            
            }
            
        }

        private void runInsertOrUpdateSQL(String sql)
        {
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();

        }


        public Staff_Login_UI()
        {

            InitializeComponent();
            clearTextboxData();
            CountCompData();



        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Staff_Login_UI_Load(object sender, EventArgs e)
        {
            dept();
        }

        private void dept()
        {

            department.Items.Add("Sales");
            department.Items.Add("Procurement");
            department.Items.Add("Account");
            department.Items.Add("IT");

        }

        private int checkLoginDept(string staffID,string dept) {

            
            
            this.resultSYS = 0;
            this.resultSYS = checkConnection();
            if (this.resultSYS == 1)
            {
                this.sql = "SELECT count(*) FROM staff where staff_ID = '" + staffID +"' && Dept_Name = '"+dept+"';";
            }
            else
            {
                this.sql = "SELECT count(*) FROM staff where staff_ID = '" + staffID + "' && Dept_Name = '" + dept + "';";
            }
            int result = runSQLCount(this.sql);
            conn.Close();
            if (result == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }
        


        private void login_btn_Click(object sender, EventArgs e)
        {
            string staffID = staff_id.Text;
            string Mode = LoginMode.Text;
            string dept = department.Text;
            int LoginStatus = CheckLoginData();
            int DeptStatus = checkLoginDept(staffID, dept);

            
            //testing
            string KEY = GenKEY.GKEY();
            if ("Select LocationID" == comboBox_location.Text) {
                MessageBox.Show("Please select LocationID !!");
            }
            else {


                if (LoginMode.Text == "Normal Mode" || LoginMode.Text == "Development Mode")
                {
                    if (department.Text == "Sales")
                    {
                        if (LoginStatus == 1 && DeptStatus == 1)
                        {
                            string Location = comboBox_location.Text;
                            UpdateDutyData(KEY);
                            clearTextboxData();
                            sales_UI sale = new sales_UI(staffID, Mode,KEY,Location);

                            sale.ShowDialog();
                        }
                        else
                        {
                            this.countLoginError++;
                            CallAdmin();
                            MessageBox.Show("Please check your account and Department !");

                        }


                    }
                    else if (department.Text == "Procurement")
                    {


                        if (LoginStatus == 1 && DeptStatus == 1)
                        {
                            UpdateDutyData(KEY);
                            procurement_UI procurement = new procurement_UI(staffID, Mode,KEY);
                            clearTextboxData();
                            procurement.ShowDialog();
                        }
                        else
                        {
                            this.countLoginError++;
                            CallAdmin();
                            MessageBox.Show("Please check your account and Department !");

                        }


                    }
                    else if (department.Text == "Account")
                    {


                        if (LoginStatus == 1 && DeptStatus == 1)
                        {
                            UpdateDutyData(KEY);
                            Accounting_UI account = new Accounting_UI(staffID, Mode,KEY);

                            clearTextboxData();
                            account.ShowDialog();
                        }
                        else
                        {
                            this.countLoginError++;
                            CallAdmin();
                            MessageBox.Show("Please check your account and Department !");


                        }


                    }
                    else if (department.Text == "IT")
                    {


                        if (LoginStatus == 1 && DeptStatus == 1)
                        {
                            UpdateDutyData(KEY);
                            it_UI it = new it_UI(staffID, Mode,KEY);
                            clearTextboxData();
                            it.ShowDialog();
                        }
                        else
                        {
                            this.countLoginError++;
                            CallAdmin();
                            MessageBox.Show("Please check your account and Department !");


                        }

                    }
                    else
                    {
                        MessageBox.Show("Please select Department !");

                    }
                }
                else
                {
                    MessageBox.Show("Please select login mode !");
                }
            }




        }

        private void comboBox_location_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
