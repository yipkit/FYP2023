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

    public partial class it_UI : Form
    {



        openWeather openAPI = new openWeather();
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
        private void checkHiddenGroupBox() {
            if ((this.UIPost == "Manager" || Convert.ToInt32(this.UILevel) >= 3) && this.UIStatus == "Normal")//User Account Management
            {
                groupBox1.Visible = true;
            }
            else
            {
                groupBox1.Visible = false;
            }
            if ((this.UIPost == "Manager" || Convert.ToInt32(this.UILevel) >= 8) && this.UIStatus == "Normal")//Logout System And Reset Duty Record
            {
                groupBox2.Visible = true;
            }
            else
            {
                groupBox2.Visible = false;
            }
            if ((this.UIPost == "Manager" || Convert.ToInt32(this.UILevel) >= 5) && this.UIStatus == "Normal")// Customer Account Management
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
            try {
                MySqlCommand cmd = new MySqlCommand(sql, this.conn);
                MySqlDataReader myData = cmd.ExecuteReader();
            }
            catch (Exception e) {
                MessageBox.Show("Please check your network quality !!");
            }
            

        }

        private void runSelectSQL(String sql)
        {

            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();
            myData.Read();
            string weather_main = myData.GetString(0);
            string main_temp = myData.GetString(1);
            string main_temp_min = myData.GetString(2);
            string main_temp_max = myData.GetString(3);
            string main_humidity = myData.GetString(4);
            string main_pessure = myData.GetString(5);
            string wind_deg = myData.GetString(6);
            string wind_speed = myData.GetString(7);
            string weather_description = myData.GetString(8);
            txt_WeatherStatus.Text = weather_main;
            txt_main_temp.Text = main_temp;
            txt_temp_min.Text = main_temp_min;
            txt_temp_max.Text = main_temp_max;
            txt_humidity.Text = main_humidity;
            txt_pessure.Text = main_pessure;
            txt_wind_speed.Text = wind_deg +"   "+ wind_speed;
            textBox_dec.Text = weather_description;


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


        }


        private void getWeather(string mode) {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(mode);
            
            this.sql = "Select weather_main,main_temp,main_temp_min,main_temp_max,main_humidity,main_pessure,wind_deg,wind_speed,weather_description,DateofTime from weather_forecast ORDER BY weather_ID DESC LIMIT 1;";

            runSelectSQL(this.sql);

        }
        private void deleteDutyStep1(string mode)
        {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(mode);

            this.sql = "Delete From duty_record;";

            runInsertOrUpdateSQL(this.sql);

        }
        private void deleteDutyStep2(string mode)
        {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(mode);

            this.sql = "ALTER TABLE duty_record AUTO_INCREMENT = 1;";

            runInsertOrUpdateSQL(this.sql);

        }

        public it_UI(string staffID, string Mode,string KEY)
        {

            InitializeComponent();
            this.UIStaffID = staffID;
            this.UIMode = Mode;
            this.UIKEY = KEY;
            this.UILevel = CUR.checkRight(staffID, Mode);
            this.UIPost = CUR.checkPost(staffID, Mode);
            this.UIStatus = PPD.checkPersonStatus(staffID, Mode);
            this.UIJOBTYPE= PPD.checkPersonJobType(staffID,Mode);
            getWeather(this.UIMode);
            Console.WriteLine("StaffID : "+staffID);
            Console.WriteLine("Mode : " + this.UIMode);
            Console.WriteLine("KEY : " + this.UIKEY);
            Console.WriteLine("Level : " + this.UILevel);
            Console.WriteLine("Post : " + this.UIPost);
            Console.WriteLine("Status : " + this.UIStatus);
            Console.WriteLine("JOB TYPE : " + this.UIJOBTYPE);
            checkHiddenGroupBox();//Set Staff Right
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            UpdateLogoutTime(this.UIMode, this.UIKEY);
            deleteKEY dKEY = new deleteKEY();
            dKEY.ModifyData(this.UIStaffID, this.UIKEY);
            Application.Exit();
        }

        private void update_user_account_btn_Click(object sender, EventArgs e)
        {
            it_update_user_account update_user_account = new it_update_user_account(this.UIMode);
            update_user_account.Show();
        }

        private void create_user_account_btn_Click(object sender, EventArgs e)
        {
            it_create_user_account create_user_account = new it_create_user_account(this.UIMode);
            create_user_account.Show();
        }

        private void review_user_account_btn_Click(object sender, EventArgs e)
        {
            it_review_user_account review_user_account = new it_review_user_account(this.UIMode);
            review_user_account.Show();
        }

        private void it_UI_Load(object sender, EventArgs e)
        {

        }

        private void combo_weatherlocation_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           
            



        }

        private void btn_RefreshWeather_Click(object sender, EventArgs e)
        {
            openAPI.selectLocation();
            getWeather(this.UIMode);
        }

        private void btn_ResetDutyRecord_Click(object sender, EventArgs e)
        {
            //ALTER TABLE tablename AUTO_INCREMENT = 1
            UpdateLogoutTime(this.UIMode, this.UIKEY);
            deleteKEY dKEY = new deleteKEY();
            dKEY.ModifyData(this.UIStaffID, this.UIKEY);
            deleteDutyStep1(this.UIMode);
            deleteDutyStep2(this.UIMode);
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        it_ModifyCustomerData MCD = new it_ModifyCustomerData(this.UIMode);
        MCD.Show();
            
            
        }

        private void btn_CreateCustomerData_Click(object sender, EventArgs e)
        {
            SalesAndIT_CreateCustomerAccount SAICCA = new SalesAndIT_CreateCustomerAccount(this.UIMode);
            SAICCA.ShowDialog();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

           
        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {
            
        }

        

        
    }
}
