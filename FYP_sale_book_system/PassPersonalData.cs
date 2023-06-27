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
    class PassPersonalData
    {
        CheckUserRight CUR = new CheckUserRight();
        
        private MySqlConnection conn; // call connDB
        private string UIStaffID;
        private string UIMode;
        private string UILevel;
        private string UIPost;
        private string UIdutyID;
        private string UIKEY;
        private int resultSYS;
        private string sql;
        public int checkConnection(string mode)
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

        public string checkPersonJobType(string UIStaffID, string ConnMode)
        {
            this.resultSYS = 0;
            this.sql = "";
            this.resultSYS = checkConnection(ConnMode);


            if (this.resultSYS == 1)
            {
                this.sql = "select staffJobType from staff where staff_ID = '" + UIStaffID + "'";
            }
            else
            {
                this.sql = "select staffJobType from staff where staff_ID = '" + UIStaffID + "'";
            }

            string staffPost = runSQLCount(this.sql, UIStaffID, ConnMode);
            return staffPost;
        }

        public string checkPersonStatus(string UIStaffID, string ConnMode)
        {
            this.resultSYS = 0;
            this.sql = "";
            this.resultSYS = checkConnection(ConnMode);


            if (this.resultSYS == 1)
            {
                this.sql = "select staffStatus from staff where staff_ID = '" + UIStaffID + "'";
            }
            else
            {
                this.sql = "select staffStatus from staff where staff_ID = '" + UIStaffID + "'";
            }

            string result = runSQLCount(this.sql, UIStaffID, ConnMode);
            return result;
        }


        private string runSQLCount(string sql, string staffid, string mode)
        {

            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();
            myData.Read();
            string result = myData.GetString(0);
            this.conn.Close();
            return result;

        }


    }
}
