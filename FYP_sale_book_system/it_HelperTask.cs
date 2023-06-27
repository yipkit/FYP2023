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
    public partial class it_HelperTask : Form
    {
        //Login Value
        ErrorControl ec = new ErrorControl();
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

        
        private void sendTaskCustomer()
        {
            this.resultSYS = 0;
            this.resultSYS = checkConnection("Normal Mode");

            string Nsql = "insert into HelperTask values(null,'0','" + txt_Email.Text + "','" + comb_Customer.Text + "','1','"+ txtRe1.Text+ "');";

            MySqlCommand cmd = new MySqlCommand(Nsql, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();
            MessageBox.Show("Please wait 24 hours and check your Email ! ");
        }
        private void sendTaskStaff()
        {
            this.resultSYS = 0;
            this.resultSYS = checkConnection("Normal Mode");

            string Nsql = "insert into HelperTask values(null,'0','" + txt_Email1.Text + "','" + comb_Staff.Text + "','0','" + txtRe2.Text + "');";

            MySqlCommand cmd = new MySqlCommand(Nsql, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();
            MessageBox.Show("Please wait 24 hours and check your Email ! ");
        }
        public it_HelperTask()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (ec.checkTextboxNULL(txt_Email.Text) == true && comb_Customer.Text != "Help List" && ec.checkTextboxNULL(comb_Customer.Text) == true) {
                sendTaskCustomer();
            }
            
        }

        private void btn_Submit1_Click(object sender, EventArgs e)
        {
            if (ec.checkTextboxNULL(txt_Email1.Text) == true &&  comb_Staff.Text != "Help List" && ec.checkTextboxNULL(comb_Staff.Text) == true) { 
                sendTaskStaff();
            }
            
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
