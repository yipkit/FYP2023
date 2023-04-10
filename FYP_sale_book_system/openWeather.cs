using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http.Json;
using System.Net.Http;
using Newtonsoft.Json;
using Microsoft.Graph;
using System.Data;
using Newtonsoft.Json.Linq;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.ComponentModel;
using System.Drawing;
using System.Threading;

namespace FYP_sale_book_system
{
    class openWeather
    {
        CheckUserRight CUR = new CheckUserRight();
        PassPersonalData PPD = new PassPersonalData();
        private MySqlConnection conn; // call connDB
        private string UIStaffID;
        private string UIMode;
        private string UILevel;
        private string UIPost;
        private string UIdutyID;
        private string UIKEY;
        private int resultSYS;
        private string sql;


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
        private void runInsertOrUpdateSQL(String sql)
        {

            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();

        }
        

        public void selectLocation() {
           
            

                openweather("22.302711", "114.177216");
                



        }
        public async Task openweather(string x, string y)
        {
            apiKey api = new apiKey();
            
            string openlink = api.connectkey(x, y);
            string url = "https://my-json-server.typicode.com/typicode/demo/posts";
            HttpClient httpClient = new HttpClient();
            try
            {
                var httpResponseMessage = await httpClient.GetAsync(openlink);
                string jsonResponse = await httpResponseMessage.Content.ReadAsStringAsync();


                string Data = jsonResponse.ToString();

                JObject dataSet = (JObject)JsonConvert.DeserializeObject(Data);



                string weather_main = dataSet["weather"][0]["main"].ToString();
                
                string weather_description = dataSet["weather"][0]["description"].ToString();
                double calTemp1 = Convert.ToDouble(dataSet["main"]["temp"].ToString()) - 273.15;
                string main_temp = calTemp1.ToString() + "( °C )";

                double calTemp2 = Convert.ToDouble(dataSet["main"]["temp_min"].ToString()) - 273.15;
                string main_temp_min = calTemp2.ToString() + "( °C )";

                double calTemp3 = Convert.ToDouble(dataSet["main"]["temp_max"].ToString()) - 273.15;
                string main_temp_max = calTemp3.ToString() + "( °C )";

                string main_humidity = dataSet["main"]["humidity"].ToString() + "( % )";
                string main_pessure = dataSet["main"]["pressure"].ToString() + "( Hpa )";
                string wind_deg = dataSet["wind"]["deg"].ToString();
                string wind_speed = " ( " + dataSet["wind"]["speed"].ToString() + " meter/sec ) ";
                string sys_sunries = dataSet["sys"]["sunrise"].ToString();
                string sys_sunset = dataSet["sys"]["sunset"].ToString();
                string sys_country = dataSet["sys"]["country"].ToString();
                string city_name = dataSet["name"].ToString();

                this.resultSYS = 0;
                this.resultSYS = checkConnection("Normal Mode");
                if (this.resultSYS == 1)
                {
                    this.sql = "Insert into weather_forecast values(NULL,'"+weather_main+ "','"+weather_description+ "','"+main_temp+ "','"+main_temp_min+ "','"+main_temp_max+ "','"+main_humidity+"'" +
                        ",'"+wind_deg+ "','"+wind_speed+ "','"+sys_sunries+ "','"+sys_sunset+ "','"+sys_country+ "','"+city_name+ "',current_timestamp(),'"+main_pessure+"');";
                }
                else
                {
                    this.sql = "Insert into weather_forecast values(NULL,'" + weather_main + "','" + weather_description + "','" + main_temp + "','" + main_temp_min + "','" + main_temp_max + "','" + main_humidity + "'" +
                                ",'" + wind_deg + "','" + wind_speed + "','" + sys_sunries + "','" + sys_sunset + "','" + sys_country + "','" + city_name + "',current_timestamp(),'" + main_pessure + "');";

                }
                runInsertOrUpdateSQL(this.sql);




            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
