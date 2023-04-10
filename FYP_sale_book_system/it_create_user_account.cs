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
    public partial class it_create_user_account : Form
    {
        //Login Value
        CheckUserRight CUR = new CheckUserRight();
        PassPersonalData PPD = new PassPersonalData();
        private MySqlConnection conn; // call connDB
        private string UIStaffID;
        private string UIMode;
        private string UILevel;
        private string UIPost;
        private string UIdutyID;
        private string UIKEY;
        //SQL
        private int resultSYS;
        private string sql;
        //User Value
        private string UVStaffID;
        private string UVStaffName;
        private string UVPassword;
        private string UVCPassword;
        private string UVPost;
        private string UVRightLevel;
        private string UVEmail;
        private string UVLocationName;
        private string UVLocationID;
        private string UVDepartmentName;
        private string UVDepartmentID;
        private string UVLoginTime;
        private string UVLogoutTime;
        private string UVStaffStatus;
        private string UVSalary;
        private string UVJobType;
        private string UVEducationLevel;
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

        private void runCompDataSQL(string sql)
        {
            string Comp_Data;

            int count = 0;
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();

            myData.Read();
            while (myData.Read())
            {
                int newid = count + 1;
                Comp_Data = myData.GetString(0);

                comboBox_LocationName.Items.Add(Comp_Data);
                comboBox_LocationID.Items.Add(newid);
                count++;

            }
            comboBox_LocationID.Visible = true;
        }
        private void runInsertOrUpdateSQL(String sql)
        {

            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();

        }

        private void runDataGV1(string sql) {
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(myData);
            dataGridView_company.DataSource = dt;
        }

        private void runDataGV2(string sql)
        {
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(myData);
            dataGridView_user.DataSource = dt;
        }

        private void refreshData(string mode) {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(mode);
            string Nsql;
            if (this.resultSYS == 1)
            {
                Nsql = "select comp_LocationID 'LocationID',comp_Name'Company Name',comp_Type'Store Type',comp_HeadOffice_Branch'Type' from company;";
            }
            else
            {
                Nsql = "select comp_LocationID 'LocationID',comp_Name'Company Name',comp_Type'Store Type',comp_HeadOffice_Branch'Type' from company;";
            }
            runDataGV1(Nsql);
        }

        private void insertUserData(string mode)
        {


            this.resultSYS = 0;
            this.resultSYS = checkConnection(mode);
            if (this.resultSYS == 1)
            {
                this.sql = "insert into staff (Dept_ID,staffName,staffPassword,staffPost,staffRightLevel,staffEmail,staffLoginLocationID,staffLogoutTime,staffLoginTime,staffStatus,Dept_Name,staffJobType,staff_Salary,Education_Level) values(" +
                     "'" + this.UVDepartmentID + "','" + this.UVStaffName + "','" + this.UVPassword + "','" + this.UVPost + "','" + this.UVRightLevel + "','" + this.UVEmail + "','" + this.UVLocationID + "','" + this.UVLogoutTime + "','" + this.UVLoginTime + "'" +
                    ",'" + this.UVStaffStatus + "','" + this.UVDepartmentName + "','" + this.UVJobType + "','" + this.UVSalary + "','" + this.UVEducationLevel + "')";
            }
            else
            {
                this.sql = "insert into staff (Dept_ID,staffName,staffPassword,staffPost,staffRightLevel,staffEmail,staffLoginLocationID,staffLogoutTime,staffLoginTime,staffStatus,Dept_Name,staffJobType,staff_Salary,Education_Level) values(" +
                     "'"+ this.UVDepartmentID + "','" + this.UVStaffName + "','" + this.UVPassword + "','" + this.UVPost + "','" + this.UVRightLevel + "','" + this.UVEmail + "','" + this.UVLocationID + "','" + this.UVLogoutTime + "','" + this.UVLoginTime + "'" +
                    ",'" + this.UVStaffStatus + "','" + this.UVDepartmentName + "','" + this.UVJobType + "','" + this.UVSalary + "','" + this.UVEducationLevel + "')";

            }
            
            runInsertOrUpdateSQL(this.sql);


        }


        private void CompData(string mode)
        {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(mode);
            string Nsql;
            if (this.resultSYS == 1)
            {
                Nsql = "Select comp_Name from company where comp_status = 'Open';";
            }
            else
            {
                Nsql = "Select comp_Name from company where comp_status = 'Open';";
            }
            runCompDataSQL(Nsql);

        }

        private void refreshStaffData()
        {
            string mode = this.UIMode;
            this.resultSYS = 0;
            this.resultSYS = checkConnection(mode);
            string Nsql;
            if (this.resultSYS == 1 || this.resultSYS == 0)
            {
                Nsql = "Select staff_ID'Staff ID',Dept_ID'Department ID',staffName'Name',staffPost'Post',staffRightLevel'Right Level',staffEmail'E-mail',staffLoginLocationID'Login LocationID', staffLoginTime'Login Time',staffLogoutTime'Logout Time',staffStatus'Status',Dept_Name'Department Name',staffJobType'Job Type',staff_Salary'Salary',Education_Level'Education Level' from staff order by staff_ID DESC;";
                runDataGV2(Nsql);
            }
            
            

        }







        private void submitData() {
            string TimeIN = comboBox_hours_in.Text + ":" + comboBox_mins_in.Text + ":00";
            string TimeOUT = comboBox_hours_out.Text + ":" + comboBox_mins_out.Text + ":00";
            this.UVLoginTime = TimeIN;
            this.UVLogoutTime = TimeOUT;
            this.UVPassword = CStaffPassword_txt.Text;
            this.UVRightLevel = comboBox_CRightLevel.Text;
            this.UVEducationLevel = comboBox_EDU.Text;
            this.UVStaffStatus = comboBox_StaffStatus.Text;
            this.UVSalary = CSalary_txt.Text;
            this.UVJobType = comboBox_JobType.Text;
            this.UVPost = CPost_txt.Text;
            this.UVEmail = CEmail_txt.Text+"@"+ textBox_lastEmail.Text;
            this.UVStaffName = CStaffName_txt.Text;
            this.UVDepartmentName = comboBox_DeptName.Text;
            this.UVLocationName = comboBox_LocationName.Text;
            this.UVLocationID = comboBox_LocationID.Text;
            this.UVDepartmentID = textBox_DeptID.Text;
            this.UVCPassword = CConfirmPassword_txt.Text;
            insertUserData(this.UIMode);

        }

        

        public it_create_user_account(string mode)
        {
            InitializeComponent();
            CompData(mode);
            refreshData(mode);
            this.UIMode = mode;
            refreshStaffData();


        }

        private void EditHolidays_btn_Click(object sender, EventArgs e)
        {

        }

        private void it_create_user_account_Load(object sender, EventArgs e)
        {

        }

        private void CLocationID_label_Click(object sender, EventArgs e)
        {

        }

        private void CreateUserAccount_btn_Click(object sender, EventArgs e)
        {
            
            

            ErrorControl EC = new ErrorControl();
            Boolean PartA = EC.checkPWD(CStaffPassword_txt.Text, CConfirmPassword_txt.Text);
            Boolean PartB = EC.checkRightLevel(comboBox_CRightLevel.Text);
            Boolean PartC = EC.checkTime(comboBox_hours_in.Text, comboBox_hours_out.Text, comboBox_mins_in.Text, comboBox_mins_out.Text);
            Boolean PartD = EC.checkEducation(comboBox_EDU.Text);
            Boolean PartE = EC.checkStatus(comboBox_StaffStatus.Text);
            Boolean PartF = EC.checkSalary(CSalary_txt.Text);
            Boolean PartG = EC.checkFPtime(comboBox_JobType.Text);
            Boolean PartH = EC.checkTextboxNULL(CStaffName_txt.Text);
            Boolean PartI = EC.checkTextboxNULL(CPost_txt.Text);
            Boolean PartJ = EC.checkTextboxNULL(CStaffPassword_txt.Text);
            Boolean PartK = EC.checkTextboxNULL(CEmail_txt.Text);
            Boolean PartM = EC.checkTextboxNULL(textBox_lastEmail.Text);
            if (PartA == true && PartB == true && PartC == true && PartD == true && PartE == true && PartF == true && PartG == true && PartH == true && PartI == true && PartJ == true && PartK == true && PartM == true) {
                submitData();
                MessageBox.Show("Submit data successful !");
                refreshStaffData();
            }
            
        }

        private void CSalary_txt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox_DeptName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_DeptName.Text == "Sales")
            {
                this.UVDepartmentID = "1";
                
            }
            else if (comboBox_DeptName.Text == "Procurement")
            {
                this.UVDepartmentID = "2";
            }
            else if (comboBox_DeptName.Text == "Account")
            {
                this.UVDepartmentID = "3";
            }
            else if (comboBox_DeptName.Text == "IT")
            {
                this.UVDepartmentID = "4";
            }
            else {
                this.UVDepartmentID = "0";
            }
            textBox_DeptID.Text = this.UVDepartmentID;
        }

        private void comboBox_LocationName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
           
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox_LocationID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


