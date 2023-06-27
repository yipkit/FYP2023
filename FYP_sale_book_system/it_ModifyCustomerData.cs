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
    public partial class it_ModifyCustomerData : Form
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
        //Customer Value



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

        private void switchTask(string mode) {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(mode);
            string helperID = "";
            string st = "";

            int a = TaskInfo.SelectedIndex;
            if (a != -1) {
                Tag1.Text = TaskInfo.Items[a].ToString();
            }
            st = Tag1.Text;
            for (int x = 5;x <= st.Length-1 ; x++) {
                
                if (st[x] == '|')
                {
                    
                    break;
                }
                else {
                    helperID += st[x];
                }
            }
            
            string Nsql = "update  HelperTask set TaskStatus = 1 where HelperID = '" + helperID+"';";
            Console.WriteLine(Nsql);
            MySqlCommand cmd = new MySqlCommand(Nsql, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();
        }
        private void checkTask(string mode) {
            
            this.resultSYS = 0;
            this.resultSYS = checkConnection(mode);
            string Nsql;
            if (this.resultSYS == 1)//TaskStatus: 1 is finished 0 is non-finish  UserType: 1 is customer 0 is staff
            {
                Nsql = "SELECT * FROM HelperTask where UserType = 1 && TaskStatus = 0;";
            }
            else
            {
                Nsql = "SELECT * FROM HelperTask where UserType = 1 && TaskStatus = 0;";
            }

            MySqlCommand cmd = new MySqlCommand(Nsql, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();
            TaskInfo.Items.Clear();
            while (myData.Read()) {
                
                string ID = myData["HelperID"].ToString();
                string status = myData["TaskStatus"].ToString();
                string TType = myData["TaskType"].ToString();
                string EM = myData["Email"].ToString();
                string UT = myData["UserType"].ToString();
                string RM = myData["Remark"].ToString();
                string MessageData = "ID : "+ ID + "| E mail : "+ EM + " Status(1 = finished 0 = non-finish) "+ status + " Task Type : " + TType +" | Remark : "+RM ;
                TaskInfo.Items.Add(MessageData);
                
                

            }
            
        }

        private void CheckEmail(string mode)
        {
            string EmailAdd = EmailName.Text + "@" + EmailAddress.Text;
            this.resultSYS = 0;
            this.resultSYS = checkConnection(mode);
            string Nsql;
            if (this.resultSYS == 1)
            {
                Nsql = "SELECT Customer_ID'Customer ID', c_Name'Name', c_Password'Password', c_CountryNumber'CountryNumber', c_PhoneNumber'PhoneNumber', c_Email'Email', c_Right'Right', c_Status'Status', c_EPoint'Point' FROM customer where c_Email like '%" + EmailAdd+"%';";
            }
            else
            {
                Nsql = "SELECT Customer_ID'Customer ID', c_Name'Name', c_Password'Password', c_CountryNumber'CountryNumber', c_PhoneNumber'PhoneNumber', c_Email'Email', c_Right'Right', c_Status'Status', c_EPoint'Point' FROM customer where c_Email like '%" + EmailAdd + "%';";
            }
            
            MySqlCommand cmd = new MySqlCommand(Nsql, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(myData);
            dataGridView2.DataSource = dt;

        }

        private void updatePersonalData(string mode) {
            ErrorControl er = new ErrorControl();
            string EmailAdd = EmailName.Text + "@" + EmailAddress.Text;
            this.resultSYS = 0;
            this.resultSYS = checkConnection(mode);
            string Nsql = "update customer set ";
            if (combo_SelectType.Text == "Customer Name" && er.checkTextboxNULL(txt1.Text) == true) {
                Nsql += "c_Name = '" + txt1.Text + "'  ";
            }
            else if (combo_SelectType.Text == "Password" && er.checkTextboxNULL(txt1.Text) == true ) {
                Nsql += "c_Password = '"+ txt1.Text + "' ";
            }
            else if (combo_SelectType.Text == "Telephone Country Number" && er.checkTextboxNULL(txt1.Text) == true)
            {
                Nsql += "c_CountryNumber = '"+txt4.Text+"' ";
            }
            else if (combo_SelectType.Text == "Telephone Number" && er.checkTextboxNULL(txt1.Text) == true)
            {
                Nsql += "c_PhoneNumber = '"+ txt1.Text + "' ";
            }
            else if (combo_SelectType.Text == "E-mail" && er.checkTextboxNULL(txt1.Text) == true && er.checkTextboxNULL(txt3.Text) == true)
            {
                string pEmail= txt1.Text + "@" + txt3.Text;
                Nsql += "c_Email = '"+pEmail+"' ";
            }
            else if (combo_SelectType.Text == "Right Level" && 
                (txt2.Text == "1" || txt2.Text == "2" || txt2.Text == "3" || txt2.Text == "4" || txt2.Text == "5" || 
                txt2.Text == "6" || txt2.Text == "7" || txt2.Text == "8" || txt2.Text == "9" || txt2.Text == "10"))
            {
                Nsql += "c_Right = '"+ txt2 .Text+ "' ";
            }
            else if (combo_SelectType.Text == "Status" && (txt2.Text == "Open" || txt2.Text == "Close" || txt2.Text == "Lock"))
            {
                Nsql += "c_Status = '"+ txt2 .Text+ "' ";
            }
            else if (combo_SelectType.Text == "Point" && er.checkNUM(txt1.Text) ==true)
            {
                Nsql += "c_EPoint = '"+ txt1 .Text+ "' ";
            }
            Nsql += " where Customer_ID ='" + txt_TID.Text + "' ;";
            MySqlCommand cmd = new MySqlCommand(Nsql, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();
            this.conn.Close();
        }

        private void checkResult(string mode,string TID) {
            string EmailAdd = EmailName.Text + "@" + EmailAddress.Text;
            this.resultSYS = 0;
            this.resultSYS = checkConnection(mode);
            string Nsql = "select * from customer where Customer_ID = '"+TID+"'";

            MySqlCommand cmd = new MySqlCommand(Nsql, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(myData);
            dataGridView1.DataSource = dt;
            this.conn.Close();
        }


        public it_ModifyCustomerData(string mode)
        {
            InitializeComponent();
            this.UIMode = mode;
            checkTask(this.UIMode);

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void combo_SelectType_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            string Mdata = combo_SelectType.Text;
            if (Mdata == "Customer Name") {
                txt1.Visible = true;
                txt2.Visible = false;
                txt3.Visible = false;
                txt4.Visible = false;
                lab.Visible = false;
            }
            else if (Mdata == "Password") {
                txt1.Visible = true;
                txt2.Visible = false;
                txt3.Visible = false;
                txt4.Visible = false;
                lab.Visible = false;
                
            }
            else if (Mdata == "Telephone Country Number")
            {
                txt1.Visible = false;
                txt2.Visible = false;
                txt3.Visible = false;
                txt4.Visible = true;
                lab.Visible = false;
                
                
            }
            else if (Mdata == "Telephone Number")
            {
                txt1.Visible = true;
                txt2.Visible = false;
                txt3.Visible = false;
                txt4.Visible = false;
                lab.Visible = false;
            }
            else if (Mdata == "E-mail")
            {
                txt1.Visible = true;
                txt2.Visible = false;
                txt3.Visible = true;
                txt4.Visible = false;
                lab.Visible = true;
            }
            else if (Mdata == "Right Level")
            {
                txt1.Visible = false;
                txt2.Visible = true;
                txt3.Visible = false;
                txt4.Visible = false;
                lab.Visible = false;
                txt2.Items.Clear();
                txt2.Text = "Right Level";
                for (int x = 1;x <= 10 ;x++) {
                    txt2.Items.Add(x);
                }
            }
            else if (Mdata == "Status")
            {
                txt1.Visible = false;
                txt2.Visible = true;
                txt3.Visible = false;
                txt4.Visible = false;
                lab.Visible = false;
                txt2.Items.Clear();
                txt2.Text = "Status";
                txt2.Items.Add("Open");
                txt2.Items.Add("Close");
                txt2.Items.Add("Lock");

            }
            else if (Mdata == "Point")
            {
                txt1.Visible = true;
                txt2.Visible = false;
                txt3.Visible = false;
                txt4.Visible = false;
                lab.Visible = false;
            }
        }

        private void txt2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Modify_Click(object sender, EventArgs e)
        {
            
            
            ErrorControl er = new ErrorControl();
            
            int count = TaskInfo.CheckedItems.Count;
           
            
            if (er.checkNUM(txt_TID.Text) == true && count == 1)
            {
                updatePersonalData(this.UIMode);
                checkResult(this.UIMode, txt_TID.Text);
                switchTask(this.UIMode);
                checkTask(this.UIMode);


                this.conn.Close();
            }
            else {
                MessageBox.Show("Please check Target ID and clink task amount !(just only select one task)");
            }
            
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            CheckEmail(this.UIMode);
        }
    }
}
