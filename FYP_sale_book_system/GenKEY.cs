using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FYP_sale_book_system
{
    class GenKEY
    {
        public string GKEY() {
            DateTime now = DateTime.Now;
            var rand = new Random();
            long key = rand.Next(0, 999999999);
            int T = rand.Next(0, 12);
            string key2;
            int key3;
            int partY = Convert.ToInt32(now.ToString("yyyy"));
            int partM = Convert.ToInt32(now.ToString("MM"));
            int partdd = Convert.ToInt32(now.ToString("dd"));
            int partA = Convert.ToInt32(now.ToString("HH"));
            int partB = Convert.ToInt32(now.ToString("mm"));
            int partC = Convert.ToInt32(now.ToString("ss"));
            if (T >= 0 && T <= 2)
            {
                key2 = "A/" + T;
                key3 = rand.Next(partB, partY) + partC;
            }
            else if (T >= 3 && T <= 5)
            {
                key2 = "B@" + T;
                key3 = rand.Next(partA, partY) - partC;
            }
            else if (T >= 6 && T <= 8)
            {
                key2 = "C!" + T;
                key3 = rand.Next(partdd, partY) * partC;
            }
            else
            {
                key2 = "D%" + T;
                key3 = rand.Next(partM, partY) + partC;

            }
            string Key1 = key.ToString();
            string TheLast = partC + Key1 + key2 + key3;
            int size = TheLast.Length;
            int enm = 25 - size;
            string zz = "";
            for (int y = 0; y <= enm; y++)
            {
                zz += "0";
            }
            
            long keyl = rand.Next(0, 999999999);
            string key4 = keyl.ToString()+ now.ToString("ss");
            string superKey = zz + "<<" + TheLast + ">>" + enm + key4;
            return superKey;
        }


        




    }
}
