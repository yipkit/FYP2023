using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace FYP_sale_book_system
{
    public partial class MD_DataAnalysis : Form
    {

        LinearRegression LPR = new LinearRegression();
        ErrorControl ec = new ErrorControl();
        PassPersonalData PPD = new PassPersonalData();
        CheckUserRight CUR = new CheckUserRight();

        private MySqlConnection conn; // call connDB
        private string UIStaffID;
        private string UIMode;
        private string UILevel;
        private string UIPost;
        private string UIdutyID;
        private string UIKEY;
        private string UILocation;
        private int resultSYS;
        private string sql;
        private Boolean table1DateStatus = false;
        private Boolean table2DateStatus = false;

        // LinkedList
        List<String> XName1 = new List<String>();
        List<String> XName2 = new List<String>();
        List<String> YName1 = new List<String>();
        List<String> YName2 = new List<String>();

        List<double> CTx = new List<double>(); // Convert To double X
        List<double> CTy = new List<double>(); // Convert To doube Y
        LinkedList<String> FSDatetimeH = new LinkedList<String>();

        string[] t1;
        string[] t2;
        string[] xa;
        private double Xrange = 0;

        public MD_DataAnalysis()
        {
            InitializeComponent();
        }

        private void MD_DataAnalysis_Load(object sender, EventArgs e)
        {
           
        }
    }
}
