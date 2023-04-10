using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYP_sale_book_system
{
    class apiKey
    {
        private string link = "https://api.openweathermap.org/data/2.5/weather?lat=";
        private string key = "d7b1131fa48b946c0415761477f96bc3";
        public string connectkey(string x, string y)
        {
            
            this.link += x + "&lon=";
            this.link += y + "&appid=";
            this.link += this.key;
            return this.link;

        }
    }
}
