using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYP_sale_book_system
{
    class GenApprovalCode
    {
        public int GCode() {
            Random ran = new Random();
            int APIkey = ran.Next(1000000,9999999);
            return APIkey;
        }
    }
}
