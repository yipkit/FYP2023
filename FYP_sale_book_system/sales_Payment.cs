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


namespace FYP_sale_book_system
{
    public partial class sales_Payment : Form
    {

        PassPersonalData PPD = new PassPersonalData();
        CheckUserRight CUR = new CheckUserRight();
        private MySqlConnection conn; // call connDB
        private string UIStaffID;
        private string UIMode;
        private string UIOrderMode;
        private string UIKEY;
        private string UILocation;
        private int resultSYS;
        private string sql;

        int SearchProductPoint;
        private int SMode = 0;
        //Credit Card Value
        CheckCreditCardNo CCCN = new CheckCreditCardNo();
        private string CCN;
        private string EDM;
        private string EDY;
        private string CVV;
        private string CreditCardType;
        private string CreditCardDetails;
        private string ApprovalCode;
        private string GatewayCode;
        
        //Price
        string totalprice = "0";
        private string AmountNUM = "";
        

        
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

        

        private void UpdateCodeStatus(string GO, string DiscountCode)
        {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UIMode);
            string sql = "update discount_code set GenOrder ='" + GO + "', CodeStatus = '0' where DiscountCode = '" + DiscountCode + "';";
            UpdateSQL(sql);
        }

        private void UpdateSQL(string sql)
        {
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);

            MySqlDataReader myData = cmd.ExecuteReader();
        }

        private string CheckDiscountSQL(string sql)
        {
            string data;
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);

            MySqlDataReader myData = cmd.ExecuteReader();
            myData.Read();
            data = myData.GetString(0);
            return data;
        }
        public sales_Payment(string GO, string totalprice, string mode,string Location,string OrderMode)
        {
            InitializeComponent();
            txt_TotalPrice.Text = totalprice;
            this.UIMode = mode;
            this.UIKEY = GO;
            groupBox3.Visible = false;
            txt_Amount.Text = totalprice;
            this.UILocation = Location;
            this.UIOrderMode = OrderMode;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {


            comb_SDM.Items.Clear();
            // stop order function
            

            Close();
        }

        private void btn_Enter_Click(object sender, EventArgs e)//PartA
        {
            ErrorControl ec = new ErrorControl();
            string TotalP = txt_TotalPrice.Text;
            string TotalD = txt_DiscountNUM.Text;
            string TotalA = txt_Amount.Text;
            if (ec.checkTextboxNULL(txt_Return.Text) == true || this.SMode == 1)
            {
                if (ec.checkTextboxNULL(comb_CN.Text) == true && (combMF.Text == "M" || combMF.Text == "F"))
                {
                    if (this.SMode == 1)
                    {

                        int gatewaycode = CheckCCNandGenGateway();


                        if (gatewaycode != 0)
                        {
                            SMode1Payment(TotalP, TotalD, TotalA, gatewaycode);
                        }
                        else
                        {
                            MessageBox.Show("Please Check Data!");
                        }
                    }
                    if (this.SMode == 2)
                    {
                        SMode2Payment(TotalP, TotalD, TotalA);

                    }
                    string GOS = this.UIKEY;
                    if (this.UIOrderMode == "0")
                    {
                        Close();
                    }
                    else if (this.UIOrderMode == "1")
                    {



                        //call gen e book
                        getGC(GOS);
                        sale_gen_Ebook_link gen_link = new sale_gen_Ebook_link(this.UIMode, GOS, "1");
                        gen_link.ShowDialog();
                        Close();
                    }
                    else if (this.UIOrderMode == "2")
                    {
                        getGC(GOS);
                        Close();

                    }
                    else if (this.UIOrderMode == "3")
                    {

                        sale_gen_Ebook_link gen_link = new sale_gen_Ebook_link(this.UIMode, GOS, "1");
                        gen_link.ShowDialog();
                        Close();
                        //call gen e book
                    }
                    else if (this.UIOrderMode == "4")
                    {
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please check information");
                }
            }
            else {
                MessageBox.Show("Please input the amount into Calculator");
            }
            
            

            

        }

        private void AddGiftCardsPoint(string GO,string customerID, string point) {
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UIMode);
            string sql = "update customer set c_EPoint = c_EPoint +'" + point+"' where customer_ID = '"+customerID+"';";
            UpdateSQL(sql);
        }

        private void getGC(string GO) {
            int count = 0;
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UIMode);
            string sql = "Select GiftsCard, GiftsCard_Qty, GiftsCard_customerID from customerorder where GenOrder ='" + GO+ "' && GiftsCard != 'Null' ;";
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            MySqlDataReader myData = cmd.ExecuteReader();
            while(myData.Read()){
                int point = Convert.ToInt32( myData["GiftsCard"].ToString());
                int qty = Convert.ToInt32( myData["GiftsCard_Qty"].ToString());
                string totalpoint = (point* qty).ToString();
                string customerID = myData["GiftsCard_customerID"].ToString();

                AddGiftCardsPoint(GO, customerID, totalpoint);
                
            }
        }
        

        private void RA_CreditCardPayment_CheckedChanged(object sender, EventArgs e)
        {
            this.SMode = 1;
            groupBox3.Visible = true;
        }

        private void RA_Cash_CheckedChanged(object sender, EventArgs e)
        {
            this.SMode = 2;
            groupBox3.Visible = false;
        }

        private int CheckCCNandGenGateway()
        {
            string SCoupon = comb_SDM.Text;
            string CouponCode = txt_CouponCode.Text;
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UIMode);
            string sql = "SELECT count(CreditCardID) FROM database_version1.CreditCardINFO where CreditCardNum ='" + this.CCN+"' && CVV = '"+this.CVV+ "' && CreditCardStatus = '1' ;";
            string result = CheckDiscountSQL(sql);
            if (result == "1")
            {
                GenApprovalCode GAC = new GenApprovalCode();
                int GatewayCode = GAC.GCode();
                return GatewayCode;
            }
            else {
                MessageBox.Show("This card can't use");
                return 0;
                
            }
            
            
            
        }

        private void btn_checkCCode_Click(object sender, EventArgs e)
        {
            string SCoupon = comb_SDM.Text;
            string CouponCode= txt_CouponCode.Text;
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UIMode);
            string sql = "SELECT count(DiscountID) FROM database_version1.discount_code where LifeCycle >= current_timestamp() && CodeStatus = '1' && DiscountCode ='"+ CouponCode + "' && DiscountAmmount = '"+ SCoupon + "';";
            string result = CheckDiscountSQL(sql);
            if (result == "1")
            {
                UpdateCodeStatus(this.UIKEY, CouponCode);
                txt_DiscountNUM.Text = (Convert.ToDouble( txt_DiscountNUM.Text) + Convert.ToDouble(SCoupon)).ToString();
                txt_Amount.Text = (Convert.ToDouble(txt_TotalPrice.Text) - Convert.ToDouble(txt_DiscountNUM.Text)).ToString();
            }
            else {
                MessageBox.Show("This is fake Coupon");
            }
        }
        private Boolean collectData() {
            ErrorControl EC = new ErrorControl();
            DateTime date = DateTime.Now;
            string CCN = txt_CardNum.Text;
            string EDM = comb_MM.Text;
            string EDY = "20"+comb_YY.Text;
            string CVV = comb_CVV.Text;
            if (EC.checkNUM(CCN) == true && EC.checkNUM(CVV) == true && CVV != "Select CVV" && EDM !="MM" && EDY != "YY" && Convert.ToInt32( EDY) >= Convert.ToInt32(date.Year.ToString()) && Convert.ToInt32(EDM) >= Convert.ToInt32(date.Month.ToString())) {
                if (CCN[0] == '4')
                {
                    Boolean Cardresult = CCCN.TestingVisaCard(CCN);
                    if (Cardresult == true)
                    {
                        this.CreditCardType = "Visa";
                        txt_CCT.Text = this.CreditCardType;
                        MessageBox.Show("This card is Visa");
                        sendDataToG(CCN, EDM, EDY, CVV);
                        return true;

                    }
                    else
                    {
                        MessageBox.Show("This Visa card no data");
                        return false;
                    }
                }
                else if (CCN[0] == '2' || CCN[0] == '5')
                {
                    Boolean Cardresult = CCCN.TestingMasterCard(CCN);
                    if (Cardresult == true)
                    {
                        this.CreditCardType = "Mastercard";
                        txt_CCT.Text = this.CreditCardType;
                        MessageBox.Show("This card is Mastercard");
                        sendDataToG(CCN, EDM, EDY, CVV);
                        return true;

                    }
                    else
                    {
                        MessageBox.Show("This MasterCard no data");
                        return false;
                    }
                }
                else {
                    MessageBox.Show("ErrorCode 2 : This is fake Card");
                    return false;
                }
            }
            else {
                MessageBox.Show("ErrorCode 1 : This is fake Card !");
                return false;
            }
        }
        private void sendDataToG(string CCN , string EDM , string EDY ,string CVV) {
            this.CCN = CCN;
            this.EDM = EDM;
            this.EDY = EDY;
            this.CVV = CVV;

        }
        

        private void txt_DiscountNUM_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)// Check Credit Card Data
        {
            DateTime date = DateTime.Now;
            Boolean result = collectData();
            if (result == true)
            {
                txt_Remark.Text = "Success";
            }
            else 
            {
                txt_Remark.Text = "Fail";
            }
            txt_CCD.Text = this.EDM+"/"+EDY;



        }



        private void txt_CCT_TextChanged(object sender, EventArgs e)
        {

        }


        private void SMode1Payment(string TotalP,string TotalD,string TotalA,int gatewaycode) //PartC1
        {
            string rm = txt_Remark.Text;
            string CCD = txt_CCD.Text;
            string CN= comb_CN.Text;
            string MF = combMF.Text;
            string PhNum = text_PNUM.Text;
            string Location = this.UILocation;
            string CCN = this.CCN;
            string EDM = this.EDM;
            string EDY = this.EDY;
            string ED = EDM +"/"+EDY;
            string CVV = this.CVV;
            string CreditCardType = this.CreditCardType;
            string CreditCardDetails = this.CreditCardDetails;
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UIMode);
            string sql = "insert into sale_order(GenOrder,CurrentSalesPrice,Discount,totalAmount,PaymentMethod,SalesStoreLocation,credit_card_type,credit_card_no,cvv,payment_gate_code,credit_details,CustomerCountryNumber,CustomerPhoneNumber,Gender,remark) values" +
                "('"+this.UIKEY+"','"+TotalP+"','"+TotalD+"','"+TotalA+"','CreditCard','"+Location+"','"+ CreditCardType + "','"+CCN+"','"+CVV+"','"+ gatewaycode + "','"+ txt_CCD.Text+"','"+CN+"','"+ PhNum + "','"+MF+"','"+ CCD + "'); ";
            Console.WriteLine(">>>"+sql);
            if (combMF.Text != "M/F" && comb_CN.Text != "Country Number")
            {
                try
                {
                    UpdateSQL(sql);
                    comb_SDM.Items.Clear();
                    
                }
                catch (Exception e)
                {
                    MessageBox.Show("Connection time out !!");
                }
                
            }
            else {
                MessageBox.Show("Please enter Personal Info!");
            }
            
        }
        private void SMode2Payment(string TotalP, string TotalD, string TotalA)//PartC2
        {
            string CCD = txt_CCD.Text;
            string CN = comb_CN.Text;
            string MF = combMF.Text;
            string PhNum = text_PNUM.Text;
            string Location = this.UILocation;
            this.resultSYS = 0;
            this.resultSYS = checkConnection(this.UIMode);
            string sql = "insert into sale_order(GenOrder,CurrentSalesPrice,Discount,totalAmount,PaymentMethod,SalesStoreLocation,CustomerCountryNumber,CustomerPhoneNumber,Gender,remark) values" +
                "('" + this.UIKEY + "','" + TotalP + "','" + TotalD + "','" + TotalA + "','Cash','" + Location + "','" + CN + "','" + PhNum + "','" + MF + "','" + CCD + "'); ";
            Console.WriteLine(">>>" + sql);
            if (combMF.Text != "M/F" && comb_CN.Text != "Country Number")
            {

                try
                {
                    UpdateSQL(sql);
                    comb_SDM.Items.Clear();
                    
                }
                catch (Exception e)
                {
                    MessageBox.Show("Connection time out !!");
                }
                
            }
            else
            {
                MessageBox.Show("Please enter Personal Info!");
            }
        }

        private string calAmount() {
            if (Convert.ToDouble(txt_CustomerAmount.Text) >= Convert.ToDouble(txt_Amount.Text))
            {
                double calA = (Convert.ToDouble(txt_CustomerAmount.Text) - Convert.ToDouble(txt_Amount.Text));

                return calA.ToString();
            }
            else {
                return "Customer have not enough money";
            }
           
            
            


        }

        private void txt_CCD_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_result_Click(object sender, EventArgs e)
        {
            string result = calAmount();
            txt_Return.Text = result;
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            AmountNUM += "7";
            txt_CustomerAmount.Text = AmountNUM;
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            AmountNUM += "4";
            txt_CustomerAmount.Text = AmountNUM;
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            AmountNUM += "1";
            txt_CustomerAmount.Text = AmountNUM;
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            AmountNUM += "0";
            txt_CustomerAmount.Text = AmountNUM;
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            AmountNUM += "8";
            txt_CustomerAmount.Text = AmountNUM;
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            AmountNUM += "5";
            txt_CustomerAmount.Text = AmountNUM;
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            AmountNUM += "2";
            txt_CustomerAmount.Text = AmountNUM;
        }

        private void button1_point_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int x = 0; x<= AmountNUM.Length-1; x++) {
                if (AmountNUM[x] == '.')
                {
                    count++;
                }
            }
            if (count <=1) {
                AmountNUM += ".";
            }
            


        }

        private void button_9_Click(object sender, EventArgs e)
        {
            AmountNUM += "9";
            txt_CustomerAmount.Text = AmountNUM;
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            AmountNUM += "6";
            txt_CustomerAmount.Text = AmountNUM;
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            AmountNUM += "3";
            txt_CustomerAmount.Text = AmountNUM;
        }

        private void button_AC_Click(object sender, EventArgs e)
        {
            txt_CustomerAmount.Text = "";
            txt_Return.Text = "";
            AmountNUM = "";

        }

        private void comb_CN_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
