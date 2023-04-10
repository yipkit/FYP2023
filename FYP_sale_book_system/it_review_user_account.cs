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
    public partial class it_review_user_account : Form
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
        private void runDataGV2(string sql)
        {
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(myData);
            dataGridView1.DataSource = dt;
        }

        private void searchStaffData()
        {
            string mode = this.UIMode;
            this.resultSYS = 0;
            this.resultSYS = checkConnection(mode);
            string Nsql;
            if (this.resultSYS == 1 || this.resultSYS == 0)
            {
                Nsql = "Select staff_ID'Staff ID',Dept_ID'Department ID',staffName'Name',staffPost'Post',staffRightLevel'Right Level',staffEmail'E-mail',staffLoginLocationID'Login LocationID', staffLoginTime'Login Time',staffLogoutTime'Logout Time',staffStatus'Status',Dept_Name'Department Name',staffJobType'Job Type',staff_Salary'Salary',Education_Level'Education Level' from staff where staff_ID = '"+this.UIStaffID+"' order by staff_ID DESC;";
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
                Nsql = "Select staff_ID'Staff ID',Dept_ID'Department ID',staffName'Name',staffPost'Post',staffRightLevel'Right Level',staffEmail'E-mail',staffLoginLocationID'Login LocationID', staffLoginTime'Login Time',staffLogoutTime'Logout Time',staffStatus'Status',Dept_Name'Department Name',staffJobType'Job Type',staff_Salary'Salary',Education_Level'Education Level' from staff  order by staff_ID DESC;";
                runDataGV2(Nsql);
            }



        }

        public it_review_user_account(string mode)
        {
            InitializeComponent();
            this.UIMode = mode;
            refreshStaffData();
        }

        private void it_review_user_account_Load(object sender, EventArgs e)
        {

        }

        private void SeachID_btn_Click(object sender, EventArgs e)
        {
            string data = UserID_txt.Text;
            ErrorControl EC = new ErrorControl();
            if (EC.checkNUM(data) == true && EC.checkTextboxNULL(data) == true) {
                this.UIStaffID = UserID_txt.Text;
                searchStaffData();
            }
           
        }

        private void SearchAll_btn_Click(object sender, EventArgs e)
        {
            refreshStaffData();
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
