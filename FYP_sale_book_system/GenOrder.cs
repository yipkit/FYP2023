using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYP_sale_book_system
{
    class GenOrder
    {
        public string genorder(string price,string location,string USERID) {
            string GenO ="";
            DateTime date = DateTime.Now;
            Random a = new Random();
            string Key = a.Next(1,99999).ToString();
            string Y = date.Year.ToString();
            string M = date.Month.ToString();
            string D = date.Day.ToString();
            string h = date.Hour.ToString();
            string m = date.Minute.ToString();
            string s = date.Second.ToString();
            GenO = Y + "/" + M + "/" + D + "//" + h + ":" + m + ":" + s + "=" + location + "=" + USERID + "=" + price +"//"+ Key;
            return GenO;

        }
    }
}
