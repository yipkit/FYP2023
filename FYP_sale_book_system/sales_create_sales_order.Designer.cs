
namespace FYP_sale_book_system
{
    partial class sales_create_sales_order
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
            this.close_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comb_Qty = new System.Windows.Forms.ComboBox();
            this.comb_PID = new System.Windows.Forms.ComboBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_PN = new System.Windows.Forms.ComboBox();
            this.comboBox_Ca = new System.Windows.Forms.ComboBox();
            this.checkBox_Category = new System.Windows.Forms.CheckBox();
            this.checkBox_Name = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ClearData = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_TotalPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // close_btn
            // 
            this.close_btn.Location = new System.Drawing.Point(931, 12);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(75, 23);
            this.close_btn.TabIndex = 0;
            this.close_btn.Text = "Close";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1004, 236);
            this.dataGridView1.TabIndex = 1;
            // 
            // comb_Qty
            // 
            this.comb_Qty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comb_Qty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comb_Qty.FormattingEnabled = true;
            this.comb_Qty.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100",
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "109",
            "110",
            "111",
            "112",
            "113",
            "114",
            "115",
            "116",
            "117",
            "118",
            "119",
            "120",
            "121",
            "122",
            "123",
            "124",
            "125",
            "126",
            "127",
            "128",
            "129",
            "130",
            "131",
            "132",
            "133",
            "134",
            "135",
            "136",
            "137",
            "138",
            "139",
            "140",
            "141",
            "142",
            "143",
            "144",
            "145",
            "146",
            "147",
            "148",
            "149",
            "150",
            "151",
            "152",
            "153",
            "154",
            "155",
            "156",
            "157",
            "158",
            "159",
            "160",
            "161",
            "162",
            "163",
            "164",
            "165",
            "166",
            "167",
            "168",
            "169",
            "170",
            "171",
            "172",
            "173",
            "174",
            "175",
            "176",
            "177",
            "178",
            "179",
            "180",
            "181",
            "182",
            "183",
            "184",
            "185",
            "186",
            "187",
            "188",
            "189",
            "190",
            "191",
            "192",
            "193",
            "194",
            "195",
            "196",
            "197",
            "198",
            "199",
            "200",
            "201",
            "202",
            "203",
            "204",
            "205",
            "206",
            "207",
            "208",
            "209",
            "210",
            "211",
            "212",
            "213",
            "214",
            "215",
            "216",
            "217",
            "218",
            "219",
            "220",
            "221",
            "222",
            "223",
            "224",
            "225",
            "226",
            "227",
            "228",
            "229",
            "230",
            "231",
            "232",
            "233",
            "234",
            "235",
            "236",
            "237",
            "238",
            "239",
            "240",
            "241",
            "242",
            "243",
            "244",
            "245",
            "246",
            "247",
            "248",
            "249",
            "250",
            "251",
            "252",
            "253",
            "254",
            "255",
            "256",
            "257",
            "258",
            "259",
            "260",
            "261",
            "262",
            "263",
            "264",
            "265",
            "266",
            "267",
            "268",
            "269",
            "270",
            "271",
            "272",
            "273",
            "274",
            "275",
            "276",
            "277",
            "278",
            "279",
            "280",
            "281",
            "282",
            "283",
            "284",
            "285",
            "286",
            "287",
            "288",
            "289",
            "290",
            "291",
            "292",
            "293",
            "294",
            "295",
            "296",
            "297",
            "298",
            "299",
            "300",
            "301",
            "302",
            "303",
            "304",
            "305",
            "306",
            "307",
            "308",
            "309",
            "310",
            "311",
            "312",
            "313",
            "314",
            "315",
            "316",
            "317",
            "318",
            "319",
            "320",
            "321",
            "322",
            "323",
            "324",
            "325",
            "326",
            "327",
            "328",
            "329",
            "330",
            "331",
            "332",
            "333",
            "334",
            "335",
            "336",
            "337",
            "338",
            "339",
            "340",
            "341",
            "342",
            "343",
            "344",
            "345",
            "346",
            "347",
            "348",
            "349",
            "350",
            "351",
            "352",
            "353",
            "354",
            "355",
            "356",
            "357",
            "358",
            "359",
            "360",
            "361",
            "362",
            "363",
            "364",
            "365",
            "366",
            "367",
            "368",
            "369",
            "370",
            "371",
            "372",
            "373",
            "374",
            "375",
            "376",
            "377",
            "378",
            "379",
            "380",
            "381",
            "382",
            "383",
            "384",
            "385",
            "386",
            "387",
            "388",
            "389",
            "390",
            "391",
            "392",
            "393",
            "394",
            "395",
            "396",
            "397",
            "398",
            "399",
            "400",
            "401",
            "402",
            "403",
            "404",
            "405",
            "406",
            "407",
            "408",
            "409",
            "410",
            "411",
            "412",
            "413",
            "414",
            "415",
            "416",
            "417",
            "418",
            "419",
            "420",
            "421",
            "422",
            "423",
            "424",
            "425",
            "426",
            "427",
            "428",
            "429",
            "430",
            "431",
            "432",
            "433",
            "434",
            "435",
            "436",
            "437",
            "438",
            "439",
            "440",
            "441",
            "442",
            "443",
            "444",
            "445",
            "446",
            "447",
            "448",
            "449",
            "450",
            "451",
            "452",
            "453",
            "454",
            "455",
            "456",
            "457",
            "458",
            "459",
            "460",
            "461",
            "462",
            "463",
            "464",
            "465",
            "466",
            "467",
            "468",
            "469",
            "470",
            "471",
            "472",
            "473",
            "474",
            "475",
            "476",
            "477",
            "478",
            "479",
            "480",
            "481",
            "482",
            "483",
            "484",
            "485",
            "486",
            "487",
            "488",
            "489",
            "490",
            "491",
            "492",
            "493",
            "494",
            "495",
            "496",
            "497",
            "498",
            "499",
            "500",
            "501",
            "502",
            "503",
            "504",
            "505",
            "506",
            "507",
            "508",
            "509",
            "510",
            "511",
            "512",
            "513",
            "514",
            "515",
            "516",
            "517",
            "518",
            "519",
            "520",
            "521",
            "522",
            "523",
            "524",
            "525",
            "526",
            "527",
            "528",
            "529",
            "530",
            "531",
            "532",
            "533",
            "534",
            "535",
            "536",
            "537",
            "538",
            "539",
            "540",
            "541",
            "542",
            "543",
            "544",
            "545",
            "546",
            "547",
            "548",
            "549",
            "550",
            "551",
            "552",
            "553",
            "554",
            "555",
            "556",
            "557",
            "558",
            "559",
            "560",
            "561",
            "562",
            "563",
            "564",
            "565",
            "566",
            "567",
            "568",
            "569",
            "570",
            "571",
            "572",
            "573",
            "574",
            "575",
            "576",
            "577",
            "578",
            "579",
            "580",
            "581",
            "582",
            "583",
            "584",
            "585",
            "586",
            "587",
            "588",
            "589",
            "590",
            "591",
            "592",
            "593",
            "594",
            "595",
            "596",
            "597",
            "598",
            "599",
            "600",
            "601",
            "602",
            "603",
            "604",
            "605",
            "606",
            "607",
            "608",
            "609",
            "610",
            "611",
            "612",
            "613",
            "614",
            "615",
            "616",
            "617",
            "618",
            "619",
            "620",
            "621",
            "622",
            "623",
            "624",
            "625",
            "626",
            "627",
            "628",
            "629",
            "630",
            "631",
            "632",
            "633",
            "634",
            "635",
            "636",
            "637",
            "638",
            "639",
            "640",
            "641",
            "642",
            "643",
            "644",
            "645",
            "646",
            "647",
            "648",
            "649",
            "650",
            "651",
            "652",
            "653",
            "654",
            "655",
            "656",
            "657",
            "658",
            "659",
            "660",
            "661",
            "662",
            "663",
            "664",
            "665",
            "666",
            "667",
            "668",
            "669",
            "670",
            "671",
            "672",
            "673",
            "674",
            "675",
            "676",
            "677",
            "678",
            "679",
            "680",
            "681",
            "682",
            "683",
            "684",
            "685",
            "686",
            "687",
            "688",
            "689",
            "690",
            "691",
            "692",
            "693",
            "694",
            "695",
            "696",
            "697",
            "698",
            "699",
            "700",
            "701",
            "702",
            "703",
            "704",
            "705",
            "706",
            "707",
            "708",
            "709",
            "710",
            "711",
            "712",
            "713",
            "714",
            "715",
            "716",
            "717",
            "718",
            "719",
            "720",
            "721",
            "722",
            "723",
            "724",
            "725",
            "726",
            "727",
            "728",
            "729",
            "730",
            "731",
            "732",
            "733",
            "734",
            "735",
            "736",
            "737",
            "738",
            "739",
            "740",
            "741",
            "742",
            "743",
            "744",
            "745",
            "746",
            "747",
            "748",
            "749",
            "750",
            "751",
            "752",
            "753",
            "754",
            "755",
            "756",
            "757",
            "758",
            "759",
            "760",
            "761",
            "762",
            "763",
            "764",
            "765",
            "766",
            "767",
            "768",
            "769",
            "770",
            "771",
            "772",
            "773",
            "774",
            "775",
            "776",
            "777",
            "778",
            "779",
            "780",
            "781",
            "782",
            "783",
            "784",
            "785",
            "786",
            "787",
            "788",
            "789",
            "790",
            "791",
            "792",
            "793",
            "794",
            "795",
            "796",
            "797",
            "798",
            "799",
            "800",
            "801",
            "802",
            "803",
            "804",
            "805",
            "806",
            "807",
            "808",
            "809",
            "810",
            "811",
            "812",
            "813",
            "814",
            "815",
            "816",
            "817",
            "818",
            "819",
            "820",
            "821",
            "822",
            "823",
            "824",
            "825",
            "826",
            "827",
            "828",
            "829",
            "830",
            "831",
            "832",
            "833",
            "834",
            "835",
            "836",
            "837",
            "838",
            "839",
            "840",
            "841",
            "842",
            "843",
            "844",
            "845",
            "846",
            "847",
            "848",
            "849",
            "850",
            "851",
            "852",
            "853",
            "854",
            "855",
            "856",
            "857",
            "858",
            "859",
            "860",
            "861",
            "862",
            "863",
            "864",
            "865",
            "866",
            "867",
            "868",
            "869",
            "870",
            "871",
            "872",
            "873",
            "874",
            "875",
            "876",
            "877",
            "878",
            "879",
            "880",
            "881",
            "882",
            "883",
            "884",
            "885",
            "886",
            "887",
            "888",
            "889",
            "890",
            "891",
            "892",
            "893",
            "894",
            "895",
            "896",
            "897",
            "898",
            "899",
            "900",
            "901",
            "902",
            "903",
            "904",
            "905",
            "906",
            "907",
            "908",
            "909",
            "910",
            "911",
            "912",
            "913",
            "914",
            "915",
            "916",
            "917",
            "918",
            "919",
            "920",
            "921",
            "922",
            "923",
            "924",
            "925",
            "926",
            "927",
            "928",
            "929",
            "930",
            "931",
            "932",
            "933",
            "934",
            "935",
            "936",
            "937",
            "938",
            "939",
            "940",
            "941",
            "942",
            "943",
            "944",
            "945",
            "946",
            "947",
            "948",
            "949",
            "950",
            "951",
            "952",
            "953",
            "954",
            "955",
            "956",
            "957",
            "958",
            "959",
            "960",
            "961",
            "962",
            "963",
            "964",
            "965",
            "966",
            "967",
            "968",
            "969",
            "970",
            "971",
            "972",
            "973",
            "974",
            "975",
            "976",
            "977",
            "978",
            "979",
            "980",
            "981",
            "982",
            "983",
            "984",
            "985",
            "986",
            "987",
            "988",
            "989",
            "990",
            "991",
            "992",
            "993",
            "994",
            "995",
            "996",
            "997",
            "998",
            "999",
            "1000"});
            this.comb_Qty.Location = new System.Drawing.Point(277, 308);
            this.comb_Qty.Name = "comb_Qty";
            this.comb_Qty.Size = new System.Drawing.Size(121, 20);
            this.comb_Qty.TabIndex = 2;
            this.comb_Qty.Text = "QTY";
            // 
            // comb_PID
            // 
            this.comb_PID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comb_PID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comb_PID.FormattingEnabled = true;
            this.comb_PID.Location = new System.Drawing.Point(79, 308);
            this.comb_PID.Name = "comb_PID";
            this.comb_PID.Size = new System.Drawing.Size(121, 20);
            this.comb_PID.TabIndex = 3;
            this.comb_PID.Text = "ID";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(355, 76);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(138, 23);
            this.btn_Search.TabIndex = 4;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(850, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Search All";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "QTY : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "Product ID :";
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_PN);
            this.groupBox1.Controls.Add(this.comboBox_Ca);
            this.groupBox1.Controls.Add(this.checkBox_Category);
            this.groupBox1.Controls.Add(this.checkBox_Name);
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Location = new System.Drawing.Point(449, 303);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 105);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Product";
            // 
            // comboBox_PN
            // 
            this.comboBox_PN.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_PN.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_PN.FormattingEnabled = true;
            this.comboBox_PN.Location = new System.Drawing.Point(107, 21);
            this.comboBox_PN.Name = "comboBox_PN";
            this.comboBox_PN.Size = new System.Drawing.Size(138, 20);
            this.comboBox_PN.TabIndex = 17;
            this.comboBox_PN.Text = "Product Name";
            this.comboBox_PN.SelectedIndexChanged += new System.EventHandler(this.comboBox_PN_SelectedIndexChanged);
            // 
            // comboBox_Ca
            // 
            this.comboBox_Ca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_Ca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_Ca.FormattingEnabled = true;
            this.comboBox_Ca.Location = new System.Drawing.Point(355, 21);
            this.comboBox_Ca.Name = "comboBox_Ca";
            this.comboBox_Ca.Size = new System.Drawing.Size(138, 20);
            this.comboBox_Ca.TabIndex = 15;
            this.comboBox_Ca.Text = "Category";
            this.comboBox_Ca.SelectedIndexChanged += new System.EventHandler(this.comboBox_Ca_SelectedIndexChanged);
            // 
            // checkBox_Category
            // 
            this.checkBox_Category.AutoSize = true;
            this.checkBox_Category.Location = new System.Drawing.Point(272, 23);
            this.checkBox_Category.Name = "checkBox_Category";
            this.checkBox_Category.Size = new System.Drawing.Size(73, 16);
            this.checkBox_Category.TabIndex = 12;
            this.checkBox_Category.Text = "Category :";
            this.checkBox_Category.UseVisualStyleBackColor = true;
            this.checkBox_Category.CheckedChanged += new System.EventHandler(this.checkBox_Category_CheckedChanged);
            // 
            // checkBox_Name
            // 
            this.checkBox_Name.AutoSize = true;
            this.checkBox_Name.Location = new System.Drawing.Point(24, 23);
            this.checkBox_Name.Name = "checkBox_Name";
            this.checkBox_Name.Size = new System.Drawing.Size(60, 16);
            this.checkBox_Name.TabIndex = 10;
            this.checkBox_Name.Text = " Name :";
            this.checkBox_Name.UseVisualStyleBackColor = true;
            this.checkBox_Name.CheckedChanged += new System.EventHandler(this.checkBox_Name_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "Review Stock Data :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "Create Sale Order :";
            // 
            // btn_ClearData
            // 
            this.btn_ClearData.Location = new System.Drawing.Point(944, 673);
            this.btn_ClearData.Name = "btn_ClearData";
            this.btn_ClearData.Size = new System.Drawing.Size(75, 23);
            this.btn_ClearData.TabIndex = 13;
            this.btn_ClearData.Text = "Clear Order";
            this.btn_ClearData.UseVisualStyleBackColor = true;
            this.btn_ClearData.Click += new System.EventHandler(this.btn_ClearData_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(850, 673);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Submit Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Enter
            // 
            this.btn_Enter.Location = new System.Drawing.Point(79, 352);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(121, 23);
            this.btn_Enter.TabIndex = 15;
            this.btn_Enter.Text = "Enter";
            this.btn_Enter.UseVisualStyleBackColor = true;
            this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(6, 42);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 184);
            this.listBox1.TabIndex = 16;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 12;
            this.listBox2.Location = new System.Drawing.Point(132, 42);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(401, 184);
            this.listBox2.TabIndex = 17;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 12;
            this.listBox3.Location = new System.Drawing.Point(544, 42);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(120, 184);
            this.listBox3.TabIndex = 18;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 12;
            this.listBox4.Location = new System.Drawing.Point(670, 42);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(120, 184);
            this.listBox4.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 20;
            this.label5.Text = "Product ID ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 12);
            this.label6.TabIndex = 21;
            this.label6.Text = "Product Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(581, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 12);
            this.label7.TabIndex = 22;
            this.label7.Text = "QTY";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(704, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 12);
            this.label8.TabIndex = 23;
            this.label8.Text = "Price";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.listBox2);
            this.groupBox2.Controls.Add(this.listBox3);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 425);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(799, 232);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New Order";
            // 
            // txt_TotalPrice
            // 
            this.txt_TotalPrice.Location = new System.Drawing.Point(850, 629);
            this.txt_TotalPrice.Name = "txt_TotalPrice";
            this.txt_TotalPrice.ReadOnly = true;
            this.txt_TotalPrice.Size = new System.Drawing.Size(166, 22);
            this.txt_TotalPrice.TabIndex = 25;
            this.txt_TotalPrice.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(848, 614);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 12);
            this.label9.TabIndex = 26;
            this.label9.Text = "Total Price :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(833, 632);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 12);
            this.label10.TabIndex = 27;
            this.label10.Text = "$";
            // 
            // sales_create_sales_order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 706);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_TotalPrice);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_Enter);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_ClearData);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comb_PID);
            this.Controls.Add(this.comb_Qty);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.close_btn);
            this.Name = "sales_create_sales_order";
            this.Text = "Create Sales Order";
            this.Load += new System.EventHandler(this.sales_create_sales_order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comb_Qty;
        private System.Windows.Forms.ComboBox comb_PID;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_PN;
        private System.Windows.Forms.ComboBox comboBox_Ca;
        private System.Windows.Forms.CheckBox checkBox_Category;
        private System.Windows.Forms.CheckBox checkBox_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_ClearData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Enter;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_TotalPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}