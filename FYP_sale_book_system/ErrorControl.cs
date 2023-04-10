using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FYP_sale_book_system
{
    class ErrorControl
    {
        public void CallAdmin(int x)
        {

            if (x > 2)
            {
                MessageBox.Show("Please contact admin to reset account !");
                Application.Exit();
            }
        }
        public Boolean checkTime(string hours_in, string hours_out, string mins_in, string mins_out)
        {
            if (hours_in == "Hours" || hours_out == "Hours" || mins_in == "Mins" || mins_out == "Mins")
            {
                MessageBox.Show("Please check Login Time or Logout Time !! ");
                return false;
            }
            else
            {
                return true;
            }
        }


        public Boolean checkTimeIN(string hours_in, string mins_in)
        {
            if (hours_in == "Hours" || mins_in == "Mins")
            {
                MessageBox.Show("Please check Login Time or Logout Time !! ");
                return false;
            }
            else
            {
                return true;
            }
        }

        public Boolean checkTimeOUT( string hours_out,  string mins_out)
        {
            if ( hours_out == "Hours" ||  mins_out == "Mins")
            {
                MessageBox.Show("Please check Login Time or Logout Time !! ");
                return false;
            }
            else
            {
                return true;
            }
        }
        public Boolean checkPWD(string pwd1, string pwd2)
        {
            if (pwd1 == pwd2)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Please check Password !! ");
                return false;
            }
        }

        public Boolean checkRightLevel(string Level)
        {
            if (Level == "Right Level" )
            {
                MessageBox.Show("Please select Right Level !! ");
                return false;
            }
            else
            {
                return true;
            }
        }
        public Boolean checkMoney(string data) {
            int size = data.Length-1;
            int errorD = 0;
          
            for (int x = 0; x <= size;x++) {
                char Data1 = Convert.ToChar(data[x]);
                int Data = Data1;
                if (Data >= 48 && Data <= 57 || Data == 45 || Data == 46)
                {
                    if (Data == 46 && x > 0)
                    {
                        errorD++;
                        if (errorD > 1)
                        {
                            MessageBox.Show("Please check Money !! ");
                            return false;
                        }
                    }
                    else if (Data1 == 45 && x > 0)
                    {
                        MessageBox.Show("Please check Money !! ");
                        return false;
                    }
                }else
                {
                    MessageBox.Show("Please check Money !! ");
                    return false;
                }
            }
            return true;
        }

        public Boolean checkNUM(string data)
        {
            int size = data.Length-1;
            int errorD = 0;

            for (int x = 0; x <= size; x++)
            {
                char Data1 = Convert.ToChar(data[x]);
                int Data = Data1;
                if (Data >= 48 && Data <= 57)
                {
                    
                }
                else
                {
                    MessageBox.Show("Please check Number !! ");
                    return false;
                }
            }
            return true;
        }

        public Boolean checkDepartment(string DeptNUM) {

            
            if (DeptNUM != "0")
            {
                return true;
            }
            else {
                MessageBox.Show("Please check Department !! ");
                return false;
            }
        }

        public Boolean checkEducation(string edu) {

            if (edu == "Select Level")
            {
                MessageBox.Show("Please check Education !! ");
                return false;
            }
            else {
                return true;
            }

        }
        public Boolean checkStatus(string status) {
            if (status == "Select Status") {
                MessageBox.Show("Please check Status !! ");
                return false;
            }
            else {
                return true;
            }
        }

        public Boolean checkSalary(string data)
        {
            int size = data.Length-1;
            int errorD = 0;

            for (int x = 0; x <= size; x++)
            {
                int Data = Convert.ToChar(data[x]);
                if (Data >= 48 && Data <= 57  || Data == 46)
                {
                    if (Data == 46 && x > 0)
                    {
                        errorD++;
                        if (errorD > 1)
                        {
                            MessageBox.Show("Please check Salary !! ");
                            return false;
                        }
                    }
                    
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public Boolean checkLocationName (string LocationName) {
            if (LocationName == "Select Location")
            {
                MessageBox.Show("Please check Location Name !! ");
                return false;
            }
            else
            {
                return true;
            }
        }

        public Boolean checkFPtime(string Name)
        {
            if (Name == "Full Time / Part Time")
            {
                MessageBox.Show("Please check Job Type !! ");
                return false;
            }
            else
            {
                return true;
            }
        }

        public Boolean checkTextboxNULL(string text) {
            int size = text.Length;
            if (size == 0)
            {
                MessageBox.Show("Please check input data(Textbox) !! ");
                return false;
            }
            else {
                return true;
            }
        }
    }
}
