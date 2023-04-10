using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    public partial class procurement_UI : Form
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
        private void UpdateLogoutTime(string mode, string KEY)
        {


            this.resultSYS = 0;
            this.resultSYS = checkConnection(mode);
            if (this.resultSYS == 1)
            {
                this.sql = "update duty_record set off_datetime=current_timestamp() where staff_id = '" + this.UIStaffID + "' && duty_key = '" + KEY + "';";
            }
            else
            {
                this.sql = "update duty_record set off_datetime=current_timestamp() where staff_id = '" + this.UIStaffID + "' && duty_key = '" + KEY + "';";
            }
            runInsertOrUpdateSQL(this.sql);
            conn.Close();

        }
        public procurement_UI(string staffID, string Mode, string KEY)
        {
            InitializeComponent();
            this.UIStaffID = staffID;
            this.UIMode = Mode;
            this.UIKEY = KEY;
            this.UILevel = CUR.checkRight(staffID, Mode);
            this.UIPost = CUR.checkPost(staffID, Mode);
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            UpdateLogoutTime(this.UIMode, this.UIKEY);
            deleteKEY dKEY = new deleteKEY();
            dKEY.ModifyData(this.UIStaffID, this.UIKEY);
            Application.Exit();
        }

    

        private void procurement_UI_Load(object sender, EventArgs e)
        {

        }

        private void update_stock_btn_Click(object sender, EventArgs e)
        {
            procurement_update_stock Update_stock = new procurement_update_stock(this.UIMode);
            Update_stock.ShowDialog();
        }

        private void delivery_note_btn_Click(object sender, EventArgs e)
        {
            procurement_review_delivery_note delivery_note = new procurement_review_delivery_note(this.UIMode);
            delivery_note.ShowDialog();
        }

        private void invoice_btn_Click(object sender, EventArgs e)
        {
            procurement_review_invoice invoice = new procurement_review_invoice(this.UIMode);
            invoice.ShowDialog();
        }

        private void create_purchase_order_btn_Click(object sender, EventArgs e)
        {
            procurement_create_purchase_order create_purchase_order = new procurement_create_purchase_order(this.UIMode);
            create_purchase_order.ShowDialog();
        }

        private void check_purchase_order_btn_Click(object sender, EventArgs e)
        {
            procurement_check_purchase_order check_purchase_order = new procurement_check_purchase_order(this.UIMode);
            check_purchase_order.ShowDialog();
        }

        private void create_stock_take_form_btn_Click(object sender, EventArgs e)
        {
            procurement_stock_take_form stock_take_form = new procurement_stock_take_form(this.UIMode);
            stock_take_form.ShowDialog();
        }

        private void stock_take_btn_Click(object sender, EventArgs e)
        {
            procurement_stock_take stock_take = new procurement_stock_take(this.UIMode);
            stock_take.ShowDialog();
        }

        private void review_stock_btn_Click(object sender, EventArgs e)
        {
            procurement_review_stock review_stock = new procurement_review_stock(this.UIMode);
            review_stock.ShowDialog();
        }

        private void stock_book_btn_Click(object sender, EventArgs e)
        {
            procurement_stock_book stock_book = new procurement_stock_book(this.UIMode);
            stock_book.ShowDialog();
        }

        private void sale_re_order_btn_Click(object sender, EventArgs e)
        {
            procurement_check_sale_re_order re_order = new procurement_check_sale_re_order(this.UIMode);
            re_order.ShowDialog();
        }

        private void add_new_item_info_btn_Click(object sender, EventArgs e)
        {
            procurement_add_new_item_information add_info = new procurement_add_new_item_information(this.UIMode);
            add_info.ShowDialog();
        }

        private void add_new_item_btn_Click(object sender, EventArgs e)
        {
            procurement_add_new_item add_new_item = new procurement_add_new_item(this.UIMode);
            add_new_item.ShowDialog();
        }

        private void edit_Stock_Click(object sender, EventArgs e)
        {
            procurement_edit_stock edit_Stock = new procurement_edit_stock(this.UIMode);
            edit_Stock.ShowDialog();
        }
    }
}
