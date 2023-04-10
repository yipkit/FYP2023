using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYP_sale_book_system
{
    class CheckCreditCardNo
    {

        public Boolean TestingVisaCard(string CardNo)
        {
            Boolean testing = checking(CardNo);


            if (testing == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean TestingMasterCard(string CardNo)
        {
            Boolean testing = checking(CardNo);


            if (testing == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //check credit card number
        private Boolean checking(string CardNo)
        {
            int[] cardInt = new int[CardNo.Length];
            for (int x = 0; x < CardNo.Length; x++)
            {
                cardInt[x] = (int)(CardNo[x] - '0');
            }
            for (int x = cardInt.Length - 2; x >= 0; x = x - 2)
            {
                int tempValue = cardInt[x];
                tempValue = tempValue * 2;
                if (tempValue > 9)
                {
                    tempValue = tempValue % 10 + 1;
                }
                cardInt[x] = tempValue;
            }
            int total = 0;
            for (int x = 0; x < CardNo.Length; x++)
            {
                total += cardInt[x];

            }
            if (total % 10 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
