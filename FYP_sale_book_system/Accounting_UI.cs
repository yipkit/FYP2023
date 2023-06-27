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
    public partial class Accounting_UI : Form
    {
        CheckUserRight CUR = new CheckUserRight();
        PassPersonalData PPD = new PassPersonalData();
        private MySqlConnection conn; // call connDB
        private string UIStaffID;
        private string UIMode;
        private string UILevel;
        private string UIPost;
        private string UIStatus;
        private string UIJOBTYPE;
        private string UIKEY;
        private int resultSYS;
        private string sql;

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

        private void checkHiddenGroupBox()
        {
            if ((this.UIPost == "Manager" || Convert.ToInt32(this.UILevel) >= 3) && this.UIStatus == "Normal")//Decision Function
            {
                groupBox1.Visible = true;
            }
            else
            {
                groupBox1.Visible = false;
            }
            if ((this.UIPost == "Manager" || Convert.ToInt32(this.UILevel) >= 5) && this.UIStatus == "Normal")//Account management
            {
                groupBox2.Visible = true;
            }
            else
            {
                groupBox2.Visible = false;
            }
            if ((this.UIPost == "Manager" || Convert.ToInt32(this.UILevel) >= 8) && this.UIStatus == "Normal")// Data Analysis
            {
                groupBox3.Visible = true;
            }
            else
            {
                groupBox3.Visible = false;
            }
        }
        private void runInsertOrUpdateSQL(String sql)
        {

            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();

        }
        private void UpdateLogoutTime(string mode, string KEY)
        {


            this.resultSYS = 0;
            this.resultSYS = checkConnection(mode);
            if (this.resultSYS == 1)
            {
                this.sql = "update duty_record set off_datetime=current_timestamp() where staff_id = '" + this.UIStaffID + "' && duty_key = '" + KEY + "';";
            }
            else
            {
                this.sql = "update duty_record set off_datetime=current_timestamp() where staff_id = '" + this.UIStaffID + "' && duty_key = '" + KEY + "';";
            }
            runInsertOrUpdateSQL(this.sql);
            conn.Close();


        }
        public Accounting_UI(string staffID, string Mode,string KEY)
        {
            InitializeComponent();
            this.UIStaffID = staffID;
            this.UIMode = Mode;
            this.UIKEY = KEY;
            this.UILevel = CUR.checkRight(staffID, Mode);
            this.UIPost = CUR.checkPost(staffID, Mode);
            this.UIStatus = PPD.checkPersonStatus(staffID, Mode);
            this.UIJOBTYPE = PPD.checkPersonJobType(staffID, Mode);
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            UpdateLogoutTime(this.UIMode, this.UIKEY);
            deleteKEY dKEY = new deleteKEY();
            dKEY.ModifyData(this.UIStaffID, this.UIKEY);
            Application.Exit();
        }

        private void Accounting_UI_Load(object sender, EventArgs e)
        {

        }

        private void pur_order_approval_btn_Click(object sender, EventArgs e)
        {
            Accounting_Purchase_Order_Approval order_approval = new Accounting_Purchase_Order_Approval(this.UIMode);
            order_approval.ShowDialog();
        }

        private void create_t_account_btn_Click(object sender, EventArgs e)
        {
            Accounting_T_Account t_account = new Accounting_T_Account(this.UIMode);
            t_account.ShowDialog();
        }

        private void btn_EditTAccount_Click(object sender, EventArgs e)
        {
            Accounting_EditTAccount ETA = new Accounting_EditTAccount(this.UIMode);
            ETA.ShowDialog();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_DataAnalysis_Click(object sender, EventArgs e)
        {
            DataAnalysis DA = new DataAnalysis();
            DA.ShowDialog();
        }
    }
}
