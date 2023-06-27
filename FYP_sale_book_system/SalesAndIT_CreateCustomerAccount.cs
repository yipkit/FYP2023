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
    public partial class SalesAndIT_CreateCustomerAccount : Form
    {
        ErrorControl EC = new ErrorControl();

        //Login Value
        CheckUserRight CUR = new CheckUserRight();
        PassPersonalData PPD = new PassPersonalData();
        private MySqlConnection conn; // call connDB
        private string UIStaffID;
        private string UIMode;

        CustomerAccountManagement CAM;

        private string UILevel;
        private string UIPost;
        private string UIdutyID;
        private string UIKEY;
        //SQL
        private int resultSYS;
        private string sql;
        //User Value
        private string UVName;
        private string UVPassword;
        private string UVCPassword;      
        private string UVRightLevel;
        private string UVANum;
        private string UVBNum;
        private string UVEmail;
        private string UVStatus;
        private string UVpoint;

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


        private void insertUserData(string mode)
        {


            this.resultSYS = 0;
            this.resultSYS = checkConnection(mode);
            if (this.resultSYS == 1)
            {
                this.sql = "insert into customer values(NULL,'"+this.UVName+"','"+this.UVPassword+"','"+this.UVANum+"','"+this.UVBNum+"','"+this.UVEmail+"','"+this.UVRightLevel+"','"+this.UVStatus+"','0');";
            }
            else
            {
                this.sql = "insert into customer values(NULL,'" + this.UVName + "','" + this.UVPassword + "','" + this.UVANum + "','" + this.UVBNum + "','" + this.UVEmail + "','" + this.UVRightLevel + "','" + this.UVStatus + "','0');";

            }

            runInsertOrUpdateSQL(this.sql);


        }

        private void runInsertOrUpdateSQL(String sql)
        {

            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            
            MySqlDataReader myData = cmd.ExecuteReader();
            MessageBox.Show("Create Account Successfully！");

        }

        public Boolean checkAccountData() {
            this.UVName = txt_CustomerName.Text;
            this.UVPassword = txt_Password.Text;
            this.UVCPassword = txt_CPassword.Text;
            this.UVANum = comb_SCN.Text;
            this.UVBNum = txt_Telephone.Text;
            this.UVEmail = txt_EmailPA.Text + "@" + txt_EmailPB.Text;
            this.UVRightLevel = comb_RightLevel.Text;
            this.UVStatus = comb_Status.Text;
            this.UVpoint = "0";

            if (EC.checkTextboxNULL(this.UVName) == true && EC.checkTextboxNULL(this.UVPassword) == true && EC.checkTextboxNULL(this.UVCPassword) == true && EC.checkTextboxNULL(this.UVANum) == true 
                && EC.checkTextboxNULL(this.UVBNum) == true && EC.checkTextboxNULL(txt_EmailPA.Text) == true && EC.checkTextboxNULL(txt_EmailPB.Text) == true && EC.checkTextboxNULL(comb_RightLevel.Text) == true
                && EC.checkTextboxNULL(comb_Status.Text) == true && EC.checkPWD(this.UVPassword,this.UVCPassword) == true && EC.checkRightLevel(this.UVRightLevel) && EC.checkStatus(this.UVStatus) ) {
                return true;
            }
            else{
                return false;
            }
        }

        public SalesAndIT_CreateCustomerAccount(string mode)
        {
            
            InitializeComponent();
            this.UIMode = mode;
            
        }

        private void SalesAndIT_CreateCustomerAccount_Load(object sender, EventArgs e)
        {

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkAccountData() == true) {
                insertUserData(this.UIMode);
            }
            
        }

        private void txt_CustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_CPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void comb_SCN_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_Telephone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_EmailPA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_EmailPB_TextChanged(object sender, EventArgs e)
        {

        }

        private void comb_RightLevel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comb_Status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_Point_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
