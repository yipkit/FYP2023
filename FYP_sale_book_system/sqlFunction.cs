using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYP_sale_book_system
{
    class sqlFunction
    {
        private string sql = "";
        private void insertSql(string[]data1,string[]data2, string mode) 
        {
            this.sql = "";
        }
        private void updateSql(string[] data1, string[] data2, string mode)
        {
            this.sql = "";
        }
        private void selectSql(string[] data1, string[] data2, string mode)
        {
            int size1 = data1.Length - 1;
            int size2 = data2.Length - 1;
            this.sql = "Select";
            for (int x = 0; x <= size1 ;x++) {
                this.sql += data1[x]; 
            }
            this.sql = "from";
            for (int y = 0; y <= size2 ;y++) {
                this.sql += data1[y];
            }
        }
    }
}
