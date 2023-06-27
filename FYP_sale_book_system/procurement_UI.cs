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
    public partial class procurement_UI : Form
    {   //NG TSZ KIN        

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
            if ((this.UIPost == "Manager" || Convert.ToInt32(this.UILevel) >= 3) && this.UIStatus == "Normal")// Management Procurement Stock
            {
                edit_stock_btn.Visible = true;
            }
            else
            {
                edit_stock_btn.Visible = false;
            }
            if ((this.UIPost == "Manager" || Convert.ToInt32(this.UILevel) >= 3) && this.UIStatus == "Normal")//Purchase Order Function
            {
                groupBox1.Visible = true;
            }
            else
            {
                groupBox1.Visible = false;
            }
            if ((this.UIPost == "Manager" || Convert.ToInt32(this.UILevel) >= 5) && this.UIStatus == "Normal")// Procurement Record
            {
                groupBox3.Visible = true;
            }
            else
            {
                groupBox3.Visible = false;
            }
            if ((this.UIPost == "Manager" || Convert.ToInt32(this.UILevel) >= 5) && this.UIStatus == "Normal")// Stock Take Function
            {
                groupBox4.Visible = true;
            }
            else
            {
                groupBox4.Visible = false;
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
        public procurement_UI(string staffID, string Mode, string KEY)
        {
            InitializeComponent();
            this.UIStaffID = staffID;
            this.UIMode = Mode;
            this.UIKEY = KEY;
            this.UILevel = CUR.checkRight(staffID, Mode);
            this.UIPost = CUR.checkPost(staffID, Mode);
            this.UIStatus = PPD.checkPersonStatus(staffID, Mode);
            this.UIJOBTYPE = PPD.checkPersonJobType(staffID, Mode);
            checkHiddenGroupBox();//Set Staff Right
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            UpdateLogoutTime(this.UIMode, this.UIKEY);
            deleteKEY dKEY = new deleteKEY();
            dKEY.ModifyData(this.UIStaffID, this.UIKEY);
            Application.Exit();
        }

    

        private void procurement_UI_Load(object sender, EventArgs e)
        {

        }

        private void review_stock_btn_Click(object sender, EventArgs e)
        {
            procurement_review_stock_function review = new procurement_review_stock_function(this.UIMode);
            review.ShowDialog();
        }


        private void record_btn_Click(object sender, EventArgs e)
        {
            procurement_review_record record = new procurement_review_record(this.UIMode);
            record.ShowDialog();
        }

        private void manage_stock_btn_Click(object sender, EventArgs e)
        {
            procurement_edit_stock_function edit = new procurement_edit_stock_function(this.UIMode);
            edit.ShowDialog();
        }

        private void edit_stock_btn_Enter(object sender, EventArgs e)
        {

        }

        private void manage_purchase_order_Click(object sender, EventArgs e)
        {
            procurement_manage_purchase_order manager_po = new procurement_manage_purchase_order(this.UIMode);
            manager_po.ShowDialog();
        }

        private void manage_stock_take_btn_Click(object sender, EventArgs e)
        {
            procurement_manage_stock_take stock_Take = new procurement_manage_stock_take(this.UIMode);
            stock_Take.ShowDialog();
        }
    }
}
