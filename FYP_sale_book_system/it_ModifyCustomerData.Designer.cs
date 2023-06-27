
namespace FYP_sale_book_system
{
    partial class it_ModifyCustomerData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.combo_SelectType = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_Modify = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btn_submit = new System.Windows.Forms.Button();
            this.EmailAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EmailName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.lab = new System.Windows.Forms.Label();
            this.txt4 = new System.Windows.Forms.ComboBox();
            this.txt_TID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TaskInfo = new System.Windows.Forms.CheckedListBox();
            this.Tag1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // combo_SelectType
            // 
            this.combo_SelectType.FormattingEnabled = true;
            this.combo_SelectType.Items.AddRange(new object[] {
            "Customer Name",
            "Password",
            "Telephone Country Number",
            "Telephone Number",
            "E-mail",
            "Right Level",
            "Status",
            "Point"});
            this.combo_SelectType.Location = new System.Drawing.Point(6, 21);
            this.combo_SelectType.Name = "combo_SelectType";
            this.combo_SelectType.Size = new System.Drawing.Size(139, 20);
            this.combo_SelectType.TabIndex = 0;
            this.combo_SelectType.Text = "Select Modify";
            this.combo_SelectType.SelectedIndexChanged += new System.EventHandler(this.combo_SelectType_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(766, 62);
            this.dataGridView1.TabIndex = 1;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(713, 365);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_Modify
            // 
            this.btn_Modify.Location = new System.Drawing.Point(699, 317);
            this.btn_Modify.Name = "btn_Modify";
            this.btn_Modify.Size = new System.Drawing.Size(75, 23);
            this.btn_Modify.TabIndex = 3;
            this.btn_Modify.Text = "Submit";
            this.btn_Modify.UseVisualStyleBackColor = true;
            this.btn_Modify.Click += new System.EventHandler(this.btn_Modify_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(263, 47);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(155, 22);
            this.txt1.TabIndex = 4;
            this.txt1.Visible = false;
            // 
            // txt2
            // 
            this.txt2.FormattingEnabled = true;
            this.txt2.Location = new System.Drawing.Point(7, 49);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(138, 20);
            this.txt2.TabIndex = 5;
            this.txt2.Visible = false;
            this.txt2.SelectedIndexChanged += new System.EventHandler(this.txt2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Result";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Tag1);
            this.groupBox1.Controls.Add(this.TaskInfo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_TID);
            this.groupBox1.Controls.Add(this.txt4);
            this.groupBox1.Controls.Add(this.lab);
            this.groupBox1.Controls.Add(this.txt3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.combo_SelectType);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_Modify);
            this.groupBox1.Controls.Add(this.txt2);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.txt1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(786, 347);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modify Customer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "Task :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.btn_submit);
            this.groupBox2.Controls.Add(this.EmailAddress);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.EmailName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 394);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(786, 232);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Check Customer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "Details :";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(5, 71);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(770, 154);
            this.dataGridView2.TabIndex = 5;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(689, 21);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(82, 23);
            this.btn_submit.TabIndex = 4;
            this.btn_submit.Text = "Check Email";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // EmailAddress
            // 
            this.EmailAddress.Location = new System.Drawing.Point(253, 23);
            this.EmailAddress.Name = "EmailAddress";
            this.EmailAddress.Size = new System.Drawing.Size(165, 22);
            this.EmailAddress.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "@";
            // 
            // EmailName
            // 
            this.EmailName.Location = new System.Drawing.Point(57, 23);
            this.EmailName.Name = "EmailName";
            this.EmailName.Size = new System.Drawing.Size(156, 22);
            this.EmailName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "E-mail :";
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(445, 47);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(154, 22);
            this.txt3.TabIndex = 11;
            this.txt3.Visible = false;
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Location = new System.Drawing.Point(424, 52);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(15, 12);
            this.lab.TabIndex = 12;
            this.lab.Text = "@";
            this.lab.Visible = false;
            // 
            // txt4
            // 
            this.txt4.FormattingEnabled = true;
            this.txt4.Items.AddRange(new object[] {
            "+86",
            "+852",
            "+886",
            "+853",
            "+65",
            "+81",
            "+66",
            "+60",
            "+63",
            "+61",
            "+53",
            "-830",
            "+1",
            "+44",
            "+1",
            "+244",
            "+93",
            "+355",
            "+213",
            "+376",
            "-263",
            "-267",
            "+54",
            "+374",
            "+247",
            "+43",
            "+994",
            "+241",
            "+973",
            "+880",
            "+245",
            "+375",
            "+7",
            "+501",
            "+229",
            "+440",
            "+591",
            "+267",
            "+55",
            "+673",
            "+359",
            "+226",
            "+95",
            "+257",
            "+237",
            "+344",
            "+236",
            "+235",
            "+56",
            "+57",
            "+242",
            "+682",
            "+506",
            "+53",
            "+357",
            "+420",
            "+45",
            "+253",
            "+808",
            "+828",
            "+848",
            "+593",
            "+20",
            "+503",
            "+372",
            "+251",
            "+679",
            "+358",
            "+33",
            "+594",
            "+241",
            "+220",
            "+995",
            "+49",
            "+233",
            "+350",
            "+30",
            "+472",
            "+670",
            "+502",
            "+224",
            "+592",
            "+509",
            "+504",
            "+36",
            "+354",
            "+91",
            "+62",
            "+98",
            "+964",
            "+353",
            "+972",
            "+39",
            "+225",
            "+875",
            "+962",
            "+855",
            "+7",
            "+254",
            "+82",
            "+850",
            "+47",
            "+968",
            "+92",
            "+507",
            "+675",
            "+595",
            "+51",
            "+48",
            "+689",
            "+351",
            "+786",
            "+938",
            "+974",
            "+262",
            "+40",
            "+32",
            "+965",
            "+996",
            "+856",
            "+371",
            "+961",
            "+266",
            "+231",
            "+218",
            "+423",
            "+370",
            "+352",
            "+261",
            "+265",
            "+960",
            "+223",
            "+356",
            "+669",
            "+596",
            "+230",
            "+52",
            "+373",
            "+377",
            "+212",
            "+976",
            "+663",
            "+258",
            "+264",
            "+674",
            "+977",
            "+599",
            "+31",
            "+64",
            "+505",
            "+227",
            "+234",
            "+757",
            "+783",
            "+683",
            "+685",
            "+378",
            "+239",
            "+966",
            "+221",
            "+248",
            "+232",
            "+421",
            "+386",
            "+677",
            "+252",
            "+27",
            "+34",
            "+94",
            "+249",
            "+597",
            "+268",
            "+46",
            "+41",
            "+963",
            "+992",
            "+255",
            "+228",
            "+676",
            "+867",
            "+216",
            "+90",
            "+993",
            "+256",
            "+380",
            "+971",
            "+598",
            "+998",
            "+58",
            "+84",
            "+967",
            "+38",
            "+263",
            "+243",
            "+243",
            "+260",
            "+44",
            "+1437",
            "+1580",
            "+358",
            "+47",
            "+262",
            "+766",
            "+382",
            "+283",
            "+720",
            "+868",
            "+648",
            "+339",
            "+211",
            "+222",
            "+238",
            "+240",
            "+245",
            "+269",
            "+290",
            "+291",
            "+297",
            "+298",
            "+299",
            "+385",
            "+387",
            "+389",
            "+508",
            "+590",
            "+596",
            "+595",
            "+592",
            "+590",
            "+670",
            "+680",
            "+681",
            "+683",
            "+686",
            "+687",
            "+688",
            "+690",
            "+691",
            "+692",
            "+975",
            "+381",
            "+678",
            "+500",
            "+250",
            "+379"});
            this.txt4.Location = new System.Drawing.Point(7, 75);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(138, 20);
            this.txt4.TabIndex = 13;
            this.txt4.Text = "Country Number";
            this.txt4.Visible = false;
            // 
            // txt_TID
            // 
            this.txt_TID.Location = new System.Drawing.Point(264, 19);
            this.txt_TID.Name = "txt_TID";
            this.txt_TID.Size = new System.Drawing.Size(154, 22);
            this.txt_TID.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(199, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "Target ID :";
            // 
            // TaskInfo
            // 
            this.TaskInfo.FormattingEnabled = true;
            this.TaskInfo.Location = new System.Drawing.Point(9, 202);
            this.TaskInfo.Name = "TaskInfo";
            this.TaskInfo.Size = new System.Drawing.Size(766, 89);
            this.TaskInfo.TabIndex = 16;
            // 
            // Tag1
            // 
            this.Tag1.Location = new System.Drawing.Point(8, 319);
            this.Tag1.Name = "Tag1";
            this.Tag1.Size = new System.Drawing.Size(685, 22);
            this.Tag1.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "Target Task :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(195, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 12);
            this.label8.TabIndex = 19;
            this.label8.Text = "Input Data :";
            // 
            // it_ModifyCustomerData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 638);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_close);
            this.Name = "it_ModifyCustomerData";
            this.Text = "Modify Customer Data";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_SelectType;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_Modify;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.ComboBox txt2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.TextBox EmailAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EmailName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.ComboBox txt4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_TID;
        private System.Windows.Forms.CheckedListBox TaskInfo;
        private System.Windows.Forms.TextBox Tag1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}