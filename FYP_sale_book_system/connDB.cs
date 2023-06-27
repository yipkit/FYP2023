using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYP_sale_book_system
{
    public class connectDB
    {

        public static int checkConnection(string mode)
        {
            if (mode == "Normal Mode")
            {
                connectDB.connDByipkit0830();
                return 1;
            }
            else
            {
                connectDB.connDBNGJACK();
                return 0;
            }



        }
        public static MySqlConnection connDBLAMFUNG()
        {
            string host = "alicelycorisrecoil.asuscomm.com";
            string user = "FYP2023";
            string pwd = "R0306qaz";
            string databaseName = "database_version1";

            string connStr = "server=" + host + ";uid=" + user + ";pwd=" + pwd + ";database=" + databaseName;
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("無法連線到資料庫.");
                        break;
                    case 1045:
                        Console.WriteLine("使用者帳號或密碼錯誤,請再試一次.");
                        break;
                }
            }
            return conn;
        }

        public static MySqlConnection connDBNGJACK()
        {
            string host = "alicelycorisrecoil.asuscomm.com";
            string user = "FYP2023";
            string pwd = "R0306qaz";
            string databaseName = "database_version1";

            string connStr = "server=" + host + ";uid=" + user + ";pwd=" + pwd + ";database=" + databaseName;
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("無法連線到資料庫.");
                        break;
                    case 1045:
                        Console.WriteLine("使用者帳號或密碼錯誤,請再試一次.");
                        break;
                }
            }
            return conn;
        }

        public static MySqlConnection connDByipkit0830()
        {
            string host = "alicelycorisrecoil.asuscomm.com";
            string user = "FYP2023";
            string pwd = "R0306qaz";
            string databaseName = "database_version1";

            string connStr = "server=" + host + ";uid=" + user + ";pwd=" + pwd + ";database=" + databaseName;
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("無法連線到資料庫.");
                        break;
                    case 1045:
                        Console.WriteLine("使用者帳號或密碼錯誤,請再試一次.");
                        break;
                }
            }
            return conn;
        }

        public static MySqlConnection connDBuser(string user, string pwd)
        {
            string host = "alicelycorisrecoil.asuscomm.com";
            string databaseName = "database_version1";

            string connStr = "server=" + host + ";uid=" + user + ";pwd=" + pwd + ";database=" + databaseName;
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("無法連線到資料庫.");
                        break;
                    case 1045:
                        Console.WriteLine("使用者帳號或密碼錯誤,請再試一次.");
                        break;
                }
            }
            return conn;
        }
    }

}
