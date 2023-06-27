using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace FYP_sale_book_system
{
    class CheckUserRight
    {
        private int resultSYS;
        private string sql;
        private MySqlConnection conn;
        
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

        private string runSQLCount(string sql,string staffid, string mode)
        {

            PassPersonalData PPD = new PassPersonalData();
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();
            myData.Read();
            string result = myData.GetString(0);
            return result;

        }

        public string checkRight(string staffid, string ConnMode) {

          

            this.resultSYS = 0;
            this.sql = "";
            this.resultSYS = checkConnection(ConnMode);
            

            if (this.resultSYS == 1)
            {
                this.sql = "select staffRightLevel from staff where staff_ID = '"+staffid+"'";
            }
            else
            {
                this.sql = "select staffRightLevel from staff where staff_ID = '" + staffid + "'";
            }
            string staffLevel = runSQLCount(this.sql, staffid,ConnMode);
            return staffLevel;
            
        }

        public string checkPost(string staffid, string ConnMode)
        {



            this.resultSYS = 0;
            this.sql = "";
            this.resultSYS = checkConnection(ConnMode);


            if (this.resultSYS == 1)
            {
                this.sql = "select staffPost from staff where staff_ID = '" + staffid + "'";
            }
            else
            {
                this.sql = "select staffPost from staff where staff_ID = '" + staffid + "'";
            }
            
            string staffPost = runSQLCount(this.sql, staffid, ConnMode);
            return staffPost;

        }



    }
}
