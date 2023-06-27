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
//using System.Diagnostics;

namespace FYP_sale_book_system
{
    public partial class DataAnalysis : Form
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

        List<DateTime> XName1D = new List<DateTime>();
        List<DateTime> XName2D = new List<DateTime>();

        List<int> TableNum1 = new List<int>();
        List<int> TableNum2 = new List<int>();
        List<int> TableID = new List<int>();


        List<double> CTx = new List<double>(); // Convert To double X
        List<double> CTy = new List<double>(); // Convert To doube Y
        LinkedList<String> FSDatetimeH = new LinkedList<String>();

        string[] t1;
        string[] t2;
        string[] xa;
        private double Xrange = 0;







        private int collectionDate(int tableNum) {

            DateTime dtS = new DateTime();
            DateTime dtE = new DateTime();

            if (tableNum == 1) {
                dtS = Convert.ToDateTime(DTP_SD1.Value);
                dtE = Convert.ToDateTime(DTP_ED1.Value);

            }
            if (tableNum == 2)
            {
                dtS = Convert.ToDateTime(DTP_SD12.Value);
                dtE = Convert.ToDateTime(DTP_ED12.Value);

            }

            //datetime //time  //date


            if (dtS == dtE)
            {
                FSDatetimeH.AddLast(dtS.ToString("yyyy-MM-dd HH:mm:ss"));
                
                return 0;
                
            }
            else
            {
                AddDateTime(dtS, dtE, tableNum);
                return 1;
            }
        }
        
        private void AddDateTime(DateTime DS, DateTime DE,int TC) {
            
            
            while (true)
            {
                if (TC == 1)
                {
                    DS = DS.AddDays(1);
                }
                else
                {
                    DS = DS.AddMinutes(1);
                }
                FSDatetimeH.AddLast(DS.ToString());
                if (DS == DE)
                {
                    break;
                }
            }
        }


        private string collectionTableDataP1(string TableName, string FieldNum, string Target, string TargetS, string combo_FFN, string combo_SFN, string combo_TFN, string FFNstatus, string SFNstatus, string TFNstatus, string SP1, string SP2, string SP3, string AO1, string AO2, int count, string Target2, string TargetS2)
        {
            string part1 = "Select ";
            if (TargetS == "MAX" || TargetS == "MIN" || TargetS == "COUNT" || TargetS == "SUM" || TargetS == "AVG" || TargetS == "DISTINCT" || TargetS == "DATE" || TargetS == "TIME")
            {
                part1 += TargetS + "( " + Target + " ) 'X'";
            }
            else
            {
                part1 += Target + " 'X' ";
            }
            part1 += " , ";
            if (TargetS2 == "MAX" || TargetS2 == "MIN" || TargetS2 == "COUNT" || TargetS2 == "SUM" || TargetS2 == "AVG" || TargetS2 == "DISTINCT" || TargetS2 == "DATE" || TargetS2 == "TIME")
            {
                part1 += TargetS2 + "( " + Target2 + " ) 'Y'";
            }
            else
            {
                part1 += Target2 + " 'Y' ";
            }
            part1 += " From database_version1." + TableName + " ";
            part1 += collectionConditionData(FieldNum, combo_FFN, combo_SFN, combo_TFN, SP1, SP2, SP3, AO1, AO2, count);
            if (cmb_XName.Text == "Date" || cmb_XName.Text == "Time") {
                if (TargetS == "DATE" || TargetS == "TIME")
                {
                    part1 += " Group by " + TargetS + "( " + Target + " ) ";
                }
                else
                {
                    part1 += " Group by " + Target;
                }
            }
            
            part1 += ";";

            return part1;
        }

        private void collectionTableDataP2(string sql, string title, string Target1, string Target2, string Target1S, string Target2S, int count, string dataType)
        {
            Console.WriteLine("sql >>> "+sql);
            try
            {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UIMode);
            int datasize = 0;
            string TargetX = "";
            string TargetY = "";
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();
            


                while (myData.Read())
                {
                    string data1 = myData["X"].ToString();
                    string data2 = myData["Y"].ToString();
                     if (dataType == "datetime" || dataType == "date" || dataType == "time")
                    {

                        DateTime date = DateTime.Parse(data1);
                        
                        
                        if (count == 1)
                        {
                            this.XName1D.Add(date);
                            this.YName1.Add(data2);
                            this.TableNum1.Add(1);
                        }
                        else
                        {
                            this.XName2D.Add(date);
                            this.YName2.Add(data2);
                            this.TableNum2.Add(2);
                        }


                    }
                    else {
                        chart1.Series[title].Points.AddXY(data1, data2);//X title ,Y high 
                        
                        if (count == 1)
                        {
                            this.XName1.Add(data1);
                            this.YName1.Add(data2);

                        }
                        else
                        {
                            this.XName2.Add(data1);
                            this.YName2.Add(data2);
                        }
                    }



                   

                }
              



            }
            catch (Exception ex)
            {
                MessageBox.Show("Your options logic have problems ! " + sql);
            }

        }

        private string collectionConditionData(string FieldNum, string combo_FFN, string combo_SFN, string combo_TFN, string SP1, string SP2, string SP3, string AO1, string AO2, int count)
        {
            string sql = "";
            string FFNstatus = "";
            string SFNstatus = "";
            string TFNstatus = "";
            if (count == 2)
            {
                FFNstatus = comboBox4.Text;
                SFNstatus = comboBox5.Text;
                TFNstatus = comboBox6.Text;
            }
            else
            {
                FFNstatus = comboBox1.Text;
                SFNstatus = comboBox2.Text;
                TFNstatus = comboBox3.Text;
            }

            if (Convert.ToInt32(FieldNum) >= 1 || T1_Date.Visible == true && count == 1 || T2_Date.Visible == true && count == 2)
            {
                sql += "where ";
            }
            if (T1_Date.Visible == true && count == 1)// ???
            {
                sql += combo_DateRange1.Text + " >= '" + DTP_SD1.Text + "' && " + combo_DateRange1.Text + " <= '" + DTP_ED1.Text + "' ";
                if (Convert.ToInt32(combo_SField1.Text) != 0)
                {
                    sql += " && ";
                }

            }
            if (T2_Date.Visible == true && count == 2)
            {
                sql += combo_DateRange2.Text + " >= '" + DTP_SD12.Text + "' && " + combo_DateRange2.Text + " <= '" + DTP_ED12.Text + "' ";
                if (Convert.ToInt32(combo_SField1.Text) != 0)
                {
                    sql += " && ";
                }
            }
           
            if (Convert.ToInt32(FieldNum) >= 1)
            {
                if (FFNstatus == "=" || FFNstatus == ">" || FFNstatus == "<" || FFNstatus == ">=" || FFNstatus == "<=")
                {
                    sql += combo_FFN + " " + FFNstatus + " '" + SP1 + "' ";
                }
                else
                {
                    sql += combo_FFN + " like '%" + SP1 + "%' ";
                }

                if (Convert.ToInt32(FieldNum) > 1)
                {
                    sql += " " + AO1 + " ";
                }

            }
            if (Convert.ToInt32(FieldNum) >= 2)
            {

                if (SFNstatus == "=" || SFNstatus == ">" || SFNstatus == "<" || SFNstatus == ">=" || SFNstatus == "<=")
                {
                    sql += combo_SFN + " " + SFNstatus + " '" + SP2 + "' ";
                }
                else
                {
                    sql += combo_SFN + " like '%" + SP2 + "%' ";
                }
                if (Convert.ToInt32(FieldNum) > 2)
                {
                    sql += " " + AO2 + " ";
                }

            }
            if (Convert.ToInt32(FieldNum) >= 3)
            {
                if (TFNstatus == "=" || TFNstatus == ">" || TFNstatus == "<" || TFNstatus == ">=" || TFNstatus == "<=")
                {
                    sql += combo_TFN + " " + TFNstatus + " '" + SP3 + "' ";
                }
                else
                {
                    sql += combo_TFN + " like '%" + SP3 + "%' ";
                }

            }
            return sql;
        }







        private void checkDateTimeMode(string conditionSetting, int tableNum)
        {
            if (tableNum == 1)
            {
                if (conditionSetting == "datetime" || conditionSetting == "date" || conditionSetting == "time")
                {
                    T1_Date.Visible = true;
                    
                    table1DateStatus = true;
                }
                else
                {
                    T1_Date.Visible = false;
                    
                    table1DateStatus = false;
                }
            }
            else
            {
                if (conditionSetting == "datetime" || conditionSetting == "date" || conditionSetting == "time")
                {
                    T2_Date.Visible = true;
                    
                    table2DateStatus = true;
                }
                else
                {

                    T2_Date.Visible = false;
                    
                    table2DateStatus = false;
                }
            }

        }


        private int checkConnection(string mode)
        {
            
            if (mode == "Normal Mode")
            {
                this.conn = connectDB.connDByipkit0830();
                return 1;
            }
            else
            {
                this.conn = connectDB.connDBNGJACK();
                return 0;
            }
        }

        private void runColNameV3(string TableName,int type)
        {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UIMode);
            if (this.resultSYS == 1)
            {
                sql = "use database_version1; SHOW COLUMNS FROM " + TableName + "; ";
            }
            else
            {
                sql = "use database_version1; SHOW COLUMNS FROM " + TableName + "; ";
            }
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();

            if (type == 1) {
                combo_DateRange1.Items.Clear();
                combo_FFN1.Items.Clear();
                combo_SFN1.Items.Clear();
                combo_TFN1.Items.Clear();
                Target1.Items.Clear();
                Target3.Items.Clear();
            }
            if (type == 2) {
                combo_DateRange2.Items.Clear();
                combo_FFN2.Items.Clear();
                combo_SFN2.Items.Clear();
                combo_TFN2.Items.Clear();
                Target2.Items.Clear();
                Target4.Items.Clear();
            }
            
            
            while (myData.Read())
            {
                string data = myData["Field"].ToString();
                if (type == 1)
                {
                    combo_DateRange1.Items.Add(data);
                    combo_FFN1.Items.Add(data);
                    combo_SFN1.Items.Add(data);
                    combo_TFN1.Items.Add(data);
                    Target1.Items.Add(data);
                    Target3.Items.Add(data);
                }
                if (type == 2) {
                    combo_DateRange2.Items.Add(data);
                    combo_FFN2.Items.Add(data);
                    combo_SFN2.Items.Add(data);
                    combo_TFN2.Items.Add(data);
                    Target2.Items.Add(data);
                    Target4.Items.Add(data);
                }
            }
        }

        private void runlist() {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UIMode);
            if (this.resultSYS == 1)
            {
                sql = "use database_version1; show tables; ";
            }
            else
            {
                sql = "use database_version1; show tables; ";
            }
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();
            comboBox_TableName1.Items.Clear();
            comboBox_TableName2.Items.Clear();
            
            while (myData.Read())
            {
                string data = myData.GetString(0);
                comboBox_TableName1.Items.Add(data);
                comboBox_TableName2.Items.Add(data);
            }

        }

        private string checkDataTypeV3(string TN, string FieldName, int SType)
        {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UIMode);
            if (this.resultSYS == 1)
            {
                sql = "use database_version1; SHOW COLUMNS FROM " + TN + " where Field = '" + FieldName + "'; ";
            }
            else
            {
                sql = "use database_version1; SHOW COLUMNS FROM " + TN + " where Field = '" + FieldName + "'; ";
            }
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();
            while (myData.Read())
            {
                string data = myData["Type"].ToString();
                if (SType == 1)
                {
                    DT1.Text = data;
                    return data;
                }
                if ( SType == 2)
                {
                    DT2.Text = data;
                    return data;
                }
            }
            return "";
        }

        

        private void updateStatus(string TN, string FData, int combNum) {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UIMode);


            if (combNum == 1)
            {
                status1.Items.Clear();
            }
            if (combNum == 2)
            {
                status2.Items.Clear();
            }
            if (combNum == 3)
            {
                status3.Items.Clear();
            }
            if (combNum == 4)
            {
                status4.Items.Clear();
            }
            if (combNum == 5)
            {
                status5.Items.Clear();
            }
            if (combNum == 6)
            {
                status6.Items.Clear();
            }
            if (this.resultSYS == 1)
            {
                sql = "use database_version1; Select distinct(" + FData + ") FROM " + TN + "; ";
            }
            else
            {
                sql = "use database_version1; Select distinct(" + FData + ") FROM " + TN + "; ";
            }
            sqlComb(sql, combNum);
        }


        private void sqlComb(string sql, int combNum) {

            try {
                MySqlCommand cmd = new MySqlCommand(sql, this.conn);
                MySqlDataReader myData = cmd.ExecuteReader();

                while (myData.Read())
                {
                    string data = myData.GetString(0);
                    if (combNum == 1)
                    {
                        status1.Items.Add(data);
                    }
                    if (combNum == 2)
                    {
                        status2.Items.Add(data);
                    }
                    if (combNum == 3)
                    {
                        status3.Items.Add(data);
                    }
                    if (combNum == 4)
                    {
                        status4.Items.Add(data);
                    }
                    if (combNum == 5) {
                        status5.Items.Add(data);
                    }
                    if (combNum == 6)
                    {
                        status6.Items.Add(data);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The Data is Null !");
            }
        }

        private void selectAnalysisField(string AnalysisField, int table) {
            chart1.Titles.Clear();
            chart1.Series.Clear();
            chart1.Titles.Add(txt_Title.Text + " ( " + AnalysisField + " ) ");
          
            string TypeName = DisplayType1.Text;
            if (table == 1 && Name1.Text.Length > 0)
            {
                chart1.Series.Add(Name1.Text);
                
                switchChartType(TypeName, Name1.Text);
                selectColor(Name1.Text, combo_color1.Text);

            }
            else if (table == 2 && Name2.Text.Length > 0 && Name1.Text.Length > 0)
            {
                chart1.Series.Add(Name1.Text);
                chart1.Series.Add(Name2.Text);
              
                switchChartType(TypeName, Name1.Text);
                switchChartType(TypeName, Name2.Text);
                selectColor(Name1.Text, combo_color1.Text);
                selectColor(Name2.Text, combo_color2.Text);
            }
            else {
                MessageBox.Show("Please fill the name!");
            }

        }


        private void selectColor(string name, string color) {

            if (color == "Red")
            {
                chart1.Series[name].Color = Color.Red;
               
            }
            if (color == "Yellow")
            {
                chart1.Series[name].Color = Color.Yellow;
               
            }
            if (color == "Green")
            {
                chart1.Series[name].Color = Color.Green;
               
            }

            
        }
       
        private void switchChartType(string TypeName, string title) {
                if (TypeName == "Point") { 
                    chart1.Series[title].ChartType = SeriesChartType.Point;
                    
                }
                if (TypeName == "Line") { 
                    chart1.Series[title].ChartType = SeriesChartType.Line;
                    
                }
                if (TypeName == "Column") { 
                    chart1.Series[title].ChartType = SeriesChartType.Column;
                    
                }
        }
       
      

        private void btn_GenChart_Click(object sender, EventArgs e)
        {
            try {
                this.XName1.Clear();
                this.XName2.Clear();

                this.YName1.Clear();
                this.YName2.Clear();

                this.XName1D.Clear();
                this.XName2D.Clear();

                this.TableNum1.Clear();
                this.TableNum2.Clear();
                this.TableID.Clear();


                this.CTx.Clear(); // Convert To double X
                this.CTy.Clear(); // Convert To doube Y
                this.FSDatetimeH.Clear();
                LB_XDate.Items.Clear();
                string dataType1 = "";
                string dataType2 = "";

                if (DisplayType1.Text == "Column" || DisplayType1.Text == "Point" || DisplayType1.Text == "Line")
            {
                int XAXIS1 = 0;
                chart1.ChartAreas[0].AxisX.Title = cmb_XName.Text;
                chart1.ChartAreas[0].AxisY.Title = cmb_YName.Text;
               
                selectAnalysisField(combo_DataField.Text, Convert.ToInt32(combo_Table.Text));
                if (Convert.ToInt32(combo_Table.Text) > 0)
                {
                    dataType1 = checkDataTypeV3(comboBox_TableName1.Text, Target1.Text, 1);
                    string sql1 = collectionTableDataP1(comboBox_TableName1.Text, combo_SField1.Text, Target1.Text, Target1S.Text, combo_FFN1.Text, combo_SFN1.Text, combo_TFN1.Text, comboBox1.Text, comboBox2.Text, comboBox3.Text, status1.Text, status2.Text, status3.Text, AO1.Text, AO2.Text, 1, Target3.Text, Target3S.Text);
                    collectionTableDataP2(sql1, Name1.Text, Target1.Text, Target3.Text, Target1S.Text, Target3S.Text, 1, dataType1);
                    if ( (dataType1 == "datetime" || dataType1 == "date" || dataType1 == "time") && combo_Table.Text == "1")// Only Table 1
                    {        
                        SetTid();
                    }
                    
                }
                if (Convert.ToInt32(combo_Table.Text) > 1)
                {
                    dataType2 = checkDataTypeV3(comboBox_TableName1.Text, Target1.Text, 1);

                    string sql2 = collectionTableDataP1(comboBox_TableName2.Text, combo_SField2.Text, Target2.Text, Target2S.Text, combo_FFN2.Text, combo_SFN2.Text, combo_TFN2.Text, comboBox3.Text, comboBox4.Text, comboBox5.Text, status4.Text, status5.Text, status6.Text, AO3.Text, AO4.Text, 2, Target4.Text, Target4S.Text);
                    collectionTableDataP2(sql2, Name2.Text, Target2.Text, Target4.Text, Target2S.Text, Target4S.Text, 2, dataType2);
                    int sizeF1 = XName1D.Count()+1;
                    if (dataType2 == "datetime" || dataType2 == "date" || dataType2 == "time" && combo_Table.Text == "2")// Table 1 and Table 2
                    {
                        //Keep data id
                        
                        int size = XName2D.Count();
                        for (int x = 0; x < size; x++)
                        {
                            this.XName1D.Add(XName2D[x]);
                            this.YName1.Add(YName2[x]);
                            this.TableNum1.Add(TableNum2[x]);
                        }
                            //keep date
                            DateTime dateA;
                            DateTime dateB;
                            //keep String
                            string dataA;
                            string dataB;
                            //keep tableNum
                            int TNum1;
                            int TNum2;

                            for (int x = 0; x < this.XName1D.Count; x++)
                            {

                                for (int y = 0; y < this.XName1D.Count; y++)
                                {
                                    if (x != y)
                                    {
                                        int result = DateTime.Compare(XName1D[x], XName1D[y]);
                                        if (result < 0) //date1 x < date1 y
                                        {
                                            //Control Date
                                            dateA = this.XName1D[x];
                                            dateB = this.XName1D[y];
                                            this.XName1D[x] = dateB;
                                            this.XName1D[y] = dateA;
                                            //Control Data
                                            dataA = this.YName1[x];
                                            dataB = this.YName1[y];
                                            this.YName1[x] = dataB;
                                            this.YName1[y] = dataA;

                                            //Constol TNum
                                            TNum1 = this.TableNum1[x];
                                            TNum2 = this.TableNum1[y];
                                            this.TableNum1[x] = TNum2;
                                            this.TableNum1[y] = TNum1;
                                        }
                                    }

                                }
                            }
                            SetTid();
                        }
                        
                    }
                    for (int x = 0; x < this.XName1D.Count; x++)
                    {
                        if (this.TableNum1[x] == 1)
                        {
                            chart1.Series[Name1.Text].Points.AddXY(this.TableID[x], this.YName1[x]);
                        }
                        else
                        {
                            chart1.Series[Name2.Text].Points.AddXY(this.TableID[x], this.YName1[x]);
                        }

                    }
                    if (combo_DataField.Text == "迴歸分析(Regression)")
                    {
                        Console.WriteLine("Part1");
                        if ((dataType1 == "datetime" || dataType1 == "date" || dataType1 == "time") && (combo_Table.Text == "1" || combo_Table.Text == "2"))// Only Table 1
                        {
                            Console.WriteLine("PartA");
                            this.CTx.Clear();
                            this.CTy.Clear();
                            Console.WriteLine("Start "+ YName1.Count);
                            for (int z = 0; z < YName1.Count; z++)
                            {

                                //Console.WriteLine("@@Loop :" + z + " data1 " + TableID[z] + " data2 " + YName1[z]);
                                if (this.TableNum1[z] == 1) {
                                    this.CTx.Add(Convert.ToDouble(TableID[z]));
                                    this.CTy.Add(double.Parse(YName1[z]));
                                }
                                

                            }
                            chart1.Series.Add(Name1.Text + " Linear Regression ");
                            switchChartType("Line", Name1.Text + " Linear Regression ");
                            selectColor(Name1.Text + " Linear Regression ", combo_color1.Text);
                            double[] startpoint = LPR.OutPutMaxLocationXY(this.CTx, this.CTy);// LocationXY[0] = OutputX; LocationXY[1] = OutputY;
                            double[] Endpoint = LPR.OutPutMinLocationXY(this.CTx, this.CTy);// LocationXY[0] = OutputX; LocationXY[1] = OutputY;
                            chart1.Series[Name1.Text + " Linear Regression "].Points.AddXY(startpoint[0], startpoint[1]);
                            chart1.Series[Name1.Text + " Linear Regression "].Points.AddXY(Endpoint[0], Endpoint[1]);
                        }
                        if ((dataType1 != "datetime" || dataType1 != "date" || dataType1 != "time") && (combo_Table.Text == "1" || combo_Table.Text == "2"))// Only Table 1
                        {
                            Console.WriteLine("PartB");
                            this.CTx.Clear();
                            this.CTy.Clear();
                            //Console.WriteLine("Start "+ XName1.Count);
                            for (int z = 0; z <= XName1.Count - 1; z++)
                            {

                                Console.WriteLine("@@Loop :" + z + " data1 " + XName1[z] + " data2 " + YName1[z]);

                                this.CTx.Add(double.Parse(XName1[z]));
                                this.CTy.Add(double.Parse(YName1[z]));

                            }
                            chart1.Series.Add(Name1.Text + " Linear Regression ");
                            switchChartType("Line", Name1.Text + " Linear Regression ");
                            selectColor(Name1.Text + " Linear Regression ", combo_color1.Text);
                            double[] startpoint = LPR.OutPutMaxLocationXY(this.CTx, this.CTy);// LocationXY[0] = OutputX; LocationXY[1] = OutputY;
                            double[] Endpoint = LPR.OutPutMinLocationXY(this.CTx, this.CTy);// LocationXY[0] = OutputX; LocationXY[1] = OutputY;
                            chart1.Series[Name1.Text + " Linear Regression "].Points.AddXY(startpoint[0], startpoint[1]);
                            chart1.Series[Name1.Text + " Linear Regression "].Points.AddXY(Endpoint[0], Endpoint[1]);
                        }

                        if ((dataType1 == "datetime" || dataType1 == "date" || dataType1 == "time") && combo_Table.Text == "2")// Only Table 2
                        {
                            Console.WriteLine("PartC");
                            this.CTx.Clear();
                            this.CTy.Clear();
                            for (int z = 0; z <= XName2.Count - 1; z++)
                            {

                                Console.WriteLine("@@Loop :" + z + " data1 " + TableID[z] + " data2 " + YName1[z]);

                                

                                if (this.TableNum1[z] == 2)
                                {
                                    this.CTx.Add(Convert.ToDouble(TableID[z]));
                                    this.CTy.Add(double.Parse(YName1[z]));
                                }

                            }

                            chart1.Series.Add(Name2.Text + " Linear Regression ");
                            switchChartType("Line", Name2.Text + " Linear Regression ");
                            selectColor(Name2.Text + " Linear Regression ", combo_color2.Text);
                            double[] startpoint2 = LPR.OutPutMaxLocationXY(this.CTx, this.CTy);// LocationXY[0] = OutputX; LocationXY[1] = OutputY;
                            double[] Endpoint2 = LPR.OutPutMinLocationXY(this.CTx, this.CTy);// LocationXY[0] = OutputX; LocationXY[1] = OutputY;
                            chart1.Series[Name2.Text + " Linear Regression "].Points.AddXY(startpoint2[0], startpoint2[1]);
                            chart1.Series[Name2.Text + " Linear Regression "].Points.AddXY(Endpoint2[0], Endpoint2[1]);
                        }
                        
                        if ((dataType1 != "datetime" || dataType1 != "date" || dataType1 != "time") && combo_Table.Text == "2")// Only Table 2
                        {
                            Console.WriteLine("PartD");
                            this.CTx.Clear();
                            this.CTy.Clear();
                            for (int z = 0; z <= XName2.Count - 1; z++)
                            {

                                Console.WriteLine("@@Loop :" + z + " data1 " + XName1[z] + " data2 " + YName1[z]);

                                this.CTx.Add(double.Parse(XName2[z]));
                                this.CTy.Add(double.Parse(YName2[z]));

                            }

                            chart1.Series.Add(Name2.Text + " Linear Regression ");
                            switchChartType("Line", Name2.Text + " Linear Regression ");
                            selectColor(Name2.Text + " Linear Regression ", combo_color2.Text);
                            double[] startpoint2 = LPR.OutPutMaxLocationXY(this.CTx, this.CTy);// LocationXY[0] = OutputX; LocationXY[1] = OutputY;
                            double[] Endpoint2 = LPR.OutPutMinLocationXY(this.CTx, this.CTy);// LocationXY[0] = OutputX; LocationXY[1] = OutputY;
                            chart1.Series[Name2.Text + " Linear Regression "].Points.AddXY(startpoint2[0], startpoint2[1]);
                            chart1.Series[Name2.Text + " Linear Regression "].Points.AddXY(Endpoint2[0], Endpoint2[1]);
                        }
                    }



                } else {
                MessageBox.Show("Please select chart type! ");
            }

            }
            catch (Exception x)
            {
                Console.WriteLine("@@ Error : "+x);
            }

        }

        private void SetTid() {

            //Compare Tid
            DateTime KDate = DateTime.Now;
            int ce = 0;
            for (int x = 0; x < this.XName1D.Count; x++)
            {
                if (x == 0)
                {
                    this.TableID.Add(ce);
                    KDate = this.XName1D[x];
                }
                else
                {
                    int result = DateTime.Compare(this.XName1D[x], KDate);
                    //Console.WriteLine(x + " != " + y+" : " + XName1D[x]+ " VS "+ this.XName1D[y] + " @@@ " + result);
                    if (result == 0)
                    {
                        this.TableID.Add(ce);
                    }
                    else
                    {
                        KDate = this.XName1D[x];
                        this.TableID.Add(ce++);
                    }
                    //Console.WriteLine( XName1D[x] + " VS " + KDate + " @@@ " + ce);
                }

            }//sort id Number

            for (int x = 0; x < this.XName1D.Count; x++)
            {
                this.LB_XDate.Items.Add(" X Axis Number : " + this.TableID[x] + " Table Number : " + this.TableNum1[x] + " X : "  + this.XName1D[x] + " Y : " + this.YName1[x] );
            }
        }
        

        public DataAnalysis()
        {
            InitializeComponent();
            runlist();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        

        

        private void DataAnalysis_Load(object sender, EventArgs e)
        {

        }

        private void combo_Table_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (combo_Table.Text == "1") {
                groupBox1.Visible = true;
                groupBox2.Visible = false;
                btn_GenChart.Visible = true;
            }
            if (combo_Table.Text == "2") {
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                btn_GenChart.Visible = true;
            }
        }

        private void combo_SField1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_SField1.Text == "1")
            {
                combo_FFN1.Visible = true;
                combo_SFN1.Visible = false;
                combo_TFN1.Visible = false;
                label5.Visible = true;
                label6.Visible = false;
                label7.Visible = false;
                comboBox1.Visible = true;
                comboBox2.Visible = false;
                comboBox3.Visible = false;
                status1.Visible = true;
                status2.Visible = false;
                status3.Visible = false;
                AO1.Visible = false;
                AO2.Visible = false;

            }
            else if (combo_SField1.Text == "2")
            {
                combo_FFN1.Visible = true;
                combo_SFN1.Visible = true;
                combo_TFN1.Visible = false;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = false;
                comboBox1.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = false;
                status1.Visible = true;
                status2.Visible = true;
                status3.Visible = false;
                AO1.Visible = true;
                AO2.Visible = false;
            }
            else if (combo_SField1.Text == "3")
            {
                combo_FFN1.Visible = true;
                combo_SFN1.Visible = true;
                combo_TFN1.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                comboBox1.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                status1.Visible = true;
                status2.Visible = true;
                status3.Visible = true;
                AO1.Visible = true;
                AO2.Visible = true;
            }
            else {
                combo_FFN1.Visible = false;
                combo_SFN1.Visible = false;
                combo_TFN1.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                comboBox1.Visible = false;
                comboBox2.Visible = false;
                comboBox3.Visible = false;
                status1.Visible = false;
                status2.Visible = false;
                status3.Visible = false;
                AO1.Visible = false;
                AO2.Visible = false;
            }
        }

        private void combo_SField2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_SField2.Text == "1")
            {
                combo_FFN2.Visible = true;
                combo_SFN2.Visible = false;
                combo_TFN2.Visible = false;
                label15.Visible = true;
                label14.Visible = false;
                label13.Visible = false;
                comboBox4.Visible = true;
                comboBox5.Visible = false;
                comboBox6.Visible = false;
                status4.Visible = true;
                status5.Visible = false;
                status6.Visible = false;
                AO3.Visible = false;
                AO4.Visible = false;
            }
            else if (combo_SField2.Text == "2")
            {
                combo_FFN2.Visible = true;
                combo_SFN2.Visible = true;
                combo_TFN2.Visible = false;
                label15.Visible = true;
                label14.Visible = true;
                label13.Visible = false;
                comboBox4.Visible = true;
                comboBox5.Visible = true;
                comboBox6.Visible = false;
                status4.Visible = true;
                status5.Visible = true;
                status6.Visible = false;
                AO3.Visible = true;
                AO4.Visible = false;
            }
            else if (combo_SField2.Text == "3")
            {
                combo_FFN2.Visible = true;
                combo_SFN2.Visible = true;
                combo_TFN2.Visible = true;
                label15.Visible = true;
                label14.Visible = true;
                label13.Visible = true;
                comboBox4.Visible = true;
                comboBox5.Visible = true;
                comboBox6.Visible = true;
                status4.Visible = true;
                status5.Visible = true;
                status6.Visible = true;
                AO3.Visible = true;
                AO4.Visible = true;
            }
            else { 
                combo_FFN2.Visible = false;
                combo_SFN2.Visible = false;
                combo_TFN2.Visible = false;
                label15.Visible = false;
                label14.Visible = false;
                label13.Visible = false;
                comboBox4.Visible = false;
                comboBox5.Visible = false;
                comboBox6.Visible = false;
                status4.Visible = false;
                status5.Visible = false;
                status6.Visible = false;
                AO3.Visible = false;
                AO4.Visible = false;
            }
        }

        private void combo_SField3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox_TableName1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            runColNameV3(comboBox_TableName1.Text, 1);
        }

        private void comboBox_TableName2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            runColNameV3(comboBox_TableName2.Text, 2);
        }

        private void comboBox_TableName3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void combo_FFN1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            checkDataTypeV3(comboBox_TableName1.Text, combo_FFN1.Text, 1);
            updateStatus(comboBox_TableName1.Text, combo_FFN1.Text, 1);
            
            
        }

        private void combo_SFN1_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkDataTypeV3(comboBox_TableName1.Text, combo_SFN1.Text, 1);
            updateStatus(comboBox_TableName1.Text, combo_SFN1.Text, 2);
            
        }

        private void combo_TFN1_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkDataTypeV3(comboBox_TableName1.Text, combo_TFN1.Text, 1);
            updateStatus(comboBox_TableName1.Text, combo_TFN1.Text, 3);
            
        }

        private void combo_FFN2_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkDataTypeV3(comboBox_TableName2.Text, combo_FFN2.Text, 2);
            updateStatus(comboBox_TableName2.Text, combo_FFN2.Text, 4);
            
        }

        private void combo_SFN2_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkDataTypeV3(comboBox_TableName2.Text, combo_SFN2.Text, 2);
            updateStatus(comboBox_TableName2.Text, combo_SFN2.Text, 5);
            
        }

        private void combo_TFN2_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkDataTypeV3(comboBox_TableName2.Text, combo_TFN2.Text, 2);
            updateStatus(comboBox_TableName2.Text, combo_TFN2.Text, 6);
           
        }

        private void combo_FFN3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void combo_SFN3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void combo_TFN3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DisplayType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Target1_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkDataTypeV3(comboBox_TableName1.Text, Target1.Text, 2);
            
        }

        private void Target2_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkDataTypeV3(comboBox_TableName2.Text, Target2.Text, 2);
            
        }

        private void Target3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Target1S_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Target2S_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_SaveChart_Click(object sender, EventArgs e)
        {

           

        }

        private void YAXIS_TName_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_ST_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void RaBtn_AXISDB_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void RaBtn_AXISOther_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void btn_Test_Click(object sender, EventArgs e)
        {
            
        }

        private void Target3_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            checkDataTypeV3(comboBox_TableName1.Text, Target3.Text, 1);
            
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkDataTypeV3(comboBox_TableName2.Text, Target4.Text, 2);
            
        }

        private void Btn_ClearAllSelect_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void combo_DateRange1_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkDataTypeV3(comboBox_TableName1.Text, combo_DateRange1.Text, 1);
            checkDateTimeMode(DT1.Text, 1);
        }

        private void combo_DateRange2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            checkDataTypeV3(comboBox_TableName2.Text, combo_DateRange2.Text, 2);
            checkDateTimeMode(DT2.Text, 2);
        }

        private void btn_SaveChart_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "PNG files (*.png)|*.png";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {

                chart1.SaveImage(saveDialog.FileName, ChartImageFormat.Png);
            }
        }

        private void cmb_XName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_XName.Text == "Date" || cmb_XName.Text == "Time")
            {
                Xtheme.Text = "X Theme";
            }
            else {
                Xtheme.Text = "X Theme";
            }
        }

        private void combo_DataField_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
