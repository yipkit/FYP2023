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
    class deleteKEY
    {
        
        
        private MySqlConnection conn; // call connDB
        //Private Value
        private int resultSYS;
        private string sql;

        private int checkConnection()
        {            
                this.conn = connectDB.connDByipkit0830();
                return 1;
        }
        
        private void runSQL(string sql)
        {
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();
            
        }


        
        public void ModifyData(string UIStaffID, string KEY)
        {

            
            this.resultSYS = 0;
            this.resultSYS = checkConnection();
            if (this.resultSYS == 1)
            {
                this.sql = "update duty_record set duty_key = duty_id where staff_id = '" + UIStaffID + "' && duty_key = '" + KEY + "';";
            }
            
            runSQL(this.sql);
            conn.Close();


        }



    }
}
