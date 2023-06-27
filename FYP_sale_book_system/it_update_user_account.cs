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
    public partial class it_update_user_account : Form
    {

        //Login Value
        ErrorControl EC = new ErrorControl();
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

        //Selection
        int Selection = 0;
        private string staffid;
        
        

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

        private void switchTask(string mode)
        {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(mode);
            string helperID = "";
            string st = "";

            int a = TaskInfo.SelectedIndex;
            if (a != -1)
            {
                Tag1.Text = TaskInfo.Items[a].ToString();
            }
            st = Tag1.Text;
            for (int x = 5; x <= st.Length - 1; x++)
            {

                if (st[x] == '|')
                {

                    break;
                }
                else
                {
                    helperID += st[x];
                }
            }

            string Nsql = "update  HelperTask set TaskStatus = 1 where HelperID = '" + helperID + "';";
            Console.WriteLine(Nsql);
            MySqlCommand cmd = new MySqlCommand(Nsql, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();
        }

        private void checkTask(string mode)
        {

            this.resultSYS = 0;
            this.resultSYS = checkConnection(mode);
            string Nsql;
            if (this.resultSYS == 1)//TaskStatus: 1 is finished 0 is non-finish  UserType: 1 is customer 0 is staff
            {
                Nsql = "SELECT * FROM HelperTask where UserType = 0 && TaskStatus = 0;";
            }
            else
            {
                Nsql = "SELECT * FROM HelperTask where UserType = 0 && TaskStatus = 0;";
            }

            MySqlCommand cmd = new MySqlCommand(Nsql, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();
            TaskInfo.Items.Clear();
            while (myData.Read())
            {

                string ID = myData["HelperID"].ToString();
                string status = myData["TaskStatus"].ToString();
                string TType = myData["TaskType"].ToString();
                string EM = myData["Email"].ToString();
                string UT = myData["UserType"].ToString();
                string RM = myData["Remark"].ToString();
                string MessageData = "ID : " + ID + "| E mail : " + EM + " Status(1 = finished 0 = non-finish) " + status + " Task Type : " + TType + " | Remark : " + RM;
                TaskInfo.Items.Add(MessageData);



            }

        }
        private void runDataGV2(string sql)
        {
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(myData);
            dataGridView1.DataSource = dt;
            
        }

        private void updateData(string sql)
        {
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();
            

        }

        private void searchStaffData()
        {
            string mode = this.UIMode;
            this.resultSYS = 0;
            this.resultSYS = checkConnection(mode);
            string Nsql;
            if (this.resultSYS == 1 || this.resultSYS == 0)
            {
                Nsql = "Select staff_ID'Staff ID',staffPassword'Staff Password',Dept_ID'Department ID',staffName'Name',staffPost'Post',staffRightLevel'Right Level',staffEmail'E-mail',staffLoginLocationID'Login LocationID', staffLoginTime'Login Time',staffLogoutTime'Logout Time',staffStatus'Status',Dept_Name'Department Name',staffJobType'Job Type',staff_Salary'Salary',Education_Level'Education Level' from staff where staff_ID = '" + this.staffid + "'  ORDER BY staff_ID DESC LIMIT 1;";
                runDataGV2(Nsql);
            }



        }

        private void refreshStaffData()
        {
            string mode = this.UIMode;
            this.resultSYS = 0;
            this.resultSYS = checkConnection(mode);
            string Nsql;
            if (this.resultSYS == 1 || this.resultSYS == 0)
            {
                Nsql = "Select staff_ID'Staff ID',staffPassword'Staff Password',Dept_ID'Department ID',staffName'Name',staffPost'Post',staffRightLevel'Right Level',staffEmail'E-mail',staffLoginLocationID'Login LocationID', staffLoginTime'Login Time',staffLogoutTime'Logout Time',staffStatus'Status',Dept_Name'Department Name',staffJobType'Job Type',staff_Salary'Salary',Education_Level'Education Level' from staff  order by staff_ID DESC;";
                runDataGV2(Nsql);
            }
            
        }

        private void CountCompData()
        {
            string mode = this.UIMode;
            this.resultSYS = 0;
            this.resultSYS = checkConnection(mode);
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

        }
        private int runCompDataCountSQL(String sql)
        {
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();

            myData.Read();
            int count = Int32.Parse(myData.GetString(0));
            return count;
        }

        private void CompData(int size)
        {
            string mode = this.UIMode;
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
            runCompDataSQL(Nsql, size);

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
               
                comb_LocationName.Items.Add(Comp_Data);
                textBox_LocationID.Items.Add(count+1);
                count++;

            }
        }
        public it_update_user_account(string mode)
        {
            InitializeComponent();
            this.UIMode = mode;
            CountCompData();
            checkTask(this.UIMode);
        }

        private void it_update_user_account_Load(object sender, EventArgs e)
        {

        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void btn_Clear_Click(object sender, EventArgs e)
        {

        }
        //RadioButton
        private void StaffName_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.Selection = 1;
        }

        private void Post_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.Selection = 2;
        }

        private void Salary_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.Selection = 3;
        }

        private void RightLevel_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.Selection = 4;
        }

        private void Email_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.Selection = 5;
        }

        private void btn_UpdateLoginTime_CheckedChanged(object sender, EventArgs e)
        {
            this.Selection = 6;
        }

        private void btn_UpdateLogoutTime_CheckedChanged(object sender, EventArgs e)
        {
            this.Selection = 7;
        }

        private void LocationName_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.Selection = 8;
        }

        private void radioButton_StaffStatus_CheckedChanged(object sender, EventArgs e)
        {
            this.Selection = 9;
        }

        private void radioButton_EducationLevel_CheckedChanged(object sender, EventArgs e)
        {
            this.Selection = 10;
        }

        private void DeptName_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.Selection = 11;
        }

        private void StaffPassword_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            
            this.Selection = 12;
            
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.Selection = 13;
        }

        private void btn_ShowAll_Click(object sender, EventArgs e)
        {
            refreshStaffData();
        }

        private void btn_SearchID_Click(object sender, EventArgs e)
        {
            this.staffid = UStaffID_txt.Text;
            searchStaffData();
            this.staffid = "";
            
        }

        private void Update_UserAccount_button_Click(object sender, EventArgs e)
        {
            string mode = this.UIMode;
            this.resultSYS = 0;
            this.resultSYS = checkConnection(mode);
            string Nsql;
            if (this.resultSYS == 1 || this.resultSYS == 0)
            {
               this.sql  = UpdateInformation();
                updateData(this.sql);
                this.staffid = UStaffID_txt.Text;
                searchStaffData();
                this.staffid = "";
            }
            switchTask(this.UIMode);
            checkTask(this.UIMode);
        }

        private string UpdateInformation() {
            Boolean check = true;
            this.UVStaffID = UStaffID_txt.Text;
            this.UVStaffName = StaffName_txt.Text;
            this.UVPassword = StaffPassword_txt.Text;
            this.UVCPassword = confirm_textBox.Text;
            this.UVPost = Post_txt.Text;
            this.UVRightLevel = comb_RightLevel.Text;
            this.UVEmail = Email_txt.Text + "@" + textBox_EmailB.Text;
            this.UVLocationName = comb_LocationName.Text;
            this.UVLocationID = textBox_LocationID.Text;
            this.UVDepartmentName = comb_DeptName.Text;
            this.UVDepartmentID = text_DepartmentID.Text;
            this.UVLoginTime = comboBox_LoginTimeH.Text + ":" + comboBox_LoginTimeM.Text;
            this.UVLogoutTime = comboBox_LogoutTimeH.Text + ":" + comboBox_LogoutTimeM.Text;
            this.UVStaffStatus = comb_status.Text;
            this.UVSalary = Salary_txt.Text;
            this.UVJobType = comboBox_JobType.Text;
            this.UVEducationLevel = comboBox_Edu.Text;
            sql = "update staff set";           
            if (this.Selection == 1) {
                Boolean re1 = EC.checkTextboxNULL(this.UVStaffName);

                if (re1 == true)
                {
                    sql += " staffName = '"+this.UVStaffName + "'";
                    check = true;
                }
                else
                {
                    check = false;
                }
            }
            if (this.Selection == 2)
            {
                Boolean re1 = EC.checkTextboxNULL(this.UVPost);
              
                if (re1 == true )
                {
                    sql += " staffPost = '"+this.UVPost + "'";
                    check = true;
                }
                else
                {
                    check = false;
                }
            }
            if (this.Selection == 3)
            {
                Boolean re = EC.checkNUM(this.UVSalary);
                if (re == true)
                {
                    sql += " staff_Salary = '"+this.UVSalary + "'";
                    check = true;
                }
                else
                {
                    check = false;
                }
            }
            if (this.Selection == 4)
            {
                Boolean re = EC.checkRightLevel(this.UVRightLevel);
                if (re == true)
                {
                    sql += " staffRightLevel = '"+this.UVRightLevel + "'";
                    check = true;
                }
                else
                {
                    check = false;
                }

            }
            if (this.Selection == 5)
            {
                Boolean re1 = EC.checkTextboxNULL(Email_txt.Text);
                Boolean re2 = EC.checkTextboxNULL(textBox_EmailB.Text);
                if (re1 == true && re2 == true)
                {
                    sql += " staffEmail = '"+this.UVEmail + "'";
                    check = true;
                }
                else
                {
                    check = false;
                }
            }
            if (this.Selection == 6)
            {
                Boolean re = EC.checkTimeIN(comboBox_LoginTimeH.Text, comboBox_LoginTimeM.Text);
                if (re == true)
                {
                    sql += " staffLoginTime = '"+this.UVLoginTime + "'";
                    check = true;
                }
                else
                {
                    check = false;
                }
            }
            if (this.Selection == 7)
            {
                Boolean re = EC.checkTimeOUT(comboBox_LogoutTimeH.Text, comboBox_LogoutTimeM.Text);
                if (re == true)
                {
                    sql += " staffLogoutTime = '"+this.UVLogoutTime + "'";
                    check = true;
                }
                else
                {
                    check = false;
                }
            }
            if (this.Selection == 8)
            {
                Boolean re = EC.checkLocationName(this.UVLocationID);
                if (re == true)
                {
                    sql += " staffLoginLocationID = '"+this.UVLocationID + "'";
                    check = true;
                }
                else
                {
                    check = false;
                }
            }
            if (this.Selection == 9)
            {
                Boolean re = EC.checkStatus(this.UVStaffStatus);
                if (re == true)
                {
                    sql += " staffStatus = '"+this.UVStaffStatus + "'";
                    check = true;
                }
                else
                {
                    check = false;
                }

            }
            if (this.Selection == 10)
            {
                Boolean re = EC.checkEducation(this.UVEducationLevel);
                if (re == true)
                {

                    sql += " Education_Level = '"+this.UVEducationLevel + "'";
                    check = true;
                }
                else
                {
                    check = false;
                }
            }
            if (this.Selection == 11)
            {
                Boolean re = EC.checkDepartment(this.UVDepartmentID);
                if (re == true)
                {
                    sql += " Dept_ID = '"+this.UVDepartmentID + "'";
                
                    sql += ", Dept_Name = '"+this.UVDepartmentName + "'";
                    check = true;
                }
                else
                {
                    check = false;
                }
            }
            if (this.Selection == 12)
            {
                Boolean re = EC.checkPWD(this.UVCPassword,this.UVPassword);
                if (re == true)
                {
                    sql += " staffPassword = '" + this.UVCPassword + "'";
                    check = true;
                }
                else {
                    check = false;
                }
                
              
            }
            if (this.Selection == 13)
            {
                Boolean re = EC.checkFPtime(this.UVJobType);
                if (re == true)
                {
                    sql += " staffJobType = '"+this.UVJobType +"'";
                    check = true;
                }
                else
                {
                    check = false;
                }

            }


            if (check == false)
            {
                sql = "update staff set";
                return "";
            }
             else {
                sql += "where staff_ID = '" + this.UVStaffID + "';";
                return sql;
            }


            
        }

        private void comb_LocationName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comb_DeptName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comb_DeptName.Text == "Sales") {
                text_DepartmentID.Text = "1";
            }
            if (comb_DeptName.Text == "Procurement")
            {
                text_DepartmentID.Text = "2";
            }
            if (comb_DeptName.Text == "Account")
            {
                text_DepartmentID.Text = "3";
            }
            if (comb_DeptName.Text == "IT")
            {
                text_DepartmentID.Text = "4";
            }
            




        }

        private void btn_RefreshData_Click(object sender, EventArgs e)
        {
            checkTask(this.UIMode);
        }
    }
}
