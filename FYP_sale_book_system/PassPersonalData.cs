using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYP_sale_book_system
{
    class PassPersonalData
    {









        //
        private string staffID;
        private string custID;
        private string ConnMode;
        private string StaffRight;
        private string StaffPost;
        //For Staff
        public string StaffID
        {
            get
            {
                return staffID;
            }
            set
            {
               staffID = value;
            }
        }

        //

        
        

        
        public string connMode {
            get {
                return ConnMode;

            }
            set {
                ConnMode = value;
            }
        }

        public string staffRight
        {
            get
            {
                return StaffRight;

            }
            set
            {
                StaffRight = value;
            }
        }
        public string staffPost
        {
            get
            {
                return StaffPost;

            }
            set
            {
                StaffPost = value;
            }
        }
       
       

    }
}
