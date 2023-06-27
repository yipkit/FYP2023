
namespace FYP_sale_book_system
{
    partial class sales_create_Ebook_order
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
            this.btn_searchEbook = new System.Windows.Forms.Button();
            this.text_searchEbook = new System.Windows.Forms.TextBox();
            this.label_searchEbook = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_SendOrder = new System.Windows.Forms.Button();
            this.comboBox_EbookID = new System.Windows.Forms.ComboBox();
            this.label_EBookID = new System.Windows.Forms.Label();
            this.label_Price = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label_Rearch = new System.Windows.Forms.Label();
            this.btn_AddProduct = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.label_Order = new System.Windows.Forms.Label();
            this.comboBox_Gits = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.comboBox_QTY = new System.Windows.Forms.ComboBox();
            this.btn_AddGitsCard = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.listNumberCC = new System.Windows.Forms.ListBox();
            this.btn_DeleteGCards = new System.Windows.Forms.Button();
            this.combo_cancelGPoint = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.listBox_GPrice = new System.Windows.Forms.ListBox();
            this.listBox_CustomerID = new System.Windows.Forms.ListBox();
            this.listBox_Qty = new System.Windows.Forms.ListBox();
            this.listBox_GiftCards = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_CustomerID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.listNumberEB = new System.Windows.Forms.ListBox();
            this.btn_DeleteEBook = new System.Windows.Forms.Button();
            this.combo_cancelEBook = new System.Windows.Forms.ComboBox();
            this.lab_EPrice = new System.Windows.Forms.Label();
            this.listBox_EPrice = new System.Windows.Forms.ListBox();
            this.listBox_EMailAddress = new System.Windows.Forms.ListBox();
            this.listBox_EBook = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_EMail = new System.Windows.Forms.TextBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_searchEbook
            // 
            this.btn_searchEbook.Location = new System.Drawing.Point(209, 624);
            this.btn_searchEbook.Name = "btn_searchEbook";
            this.btn_searchEbook.Size = new System.Drawing.Size(83, 23);
            this.btn_searchEbook.TabIndex = 0;
            this.btn_searchEbook.Text = "Search E-book";
            this.btn_searchEbook.UseVisualStyleBackColor = true;
            this.btn_searchEbook.Click += new System.EventHandler(this.btn_searchEbook_Click);
            // 
            // text_searchEbook
            // 
            this.text_searchEbook.Location = new System.Drawing.Point(26, 625);
            this.text_searchEbook.Name = "text_searchEbook";
            this.text_searchEbook.Size = new System.Drawing.Size(177, 22);
            this.text_searchEbook.TabIndex = 1;
            // 
            // label_searchEbook
            // 
            this.label_searchEbook.AutoSize = true;
            this.label_searchEbook.Location = new System.Drawing.Point(484, 21);
            this.label_searchEbook.Name = "label_searchEbook";
            this.label_searchEbook.Size = new System.Drawing.Size(75, 12);
            this.label_searchEbook.TabIndex = 2;
            this.label_searchEbook.Text = "E book Name :";
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(862, 739);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(218, 23);
            this.btn_Close.TabIndex = 3;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 653);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(812, 259);
            this.dataGridView1.TabIndex = 4;
            // 
            // btn_SendOrder
            // 
            this.btn_SendOrder.Location = new System.Drawing.Point(862, 710);
            this.btn_SendOrder.Name = "btn_SendOrder";
            this.btn_SendOrder.Size = new System.Drawing.Size(218, 23);
            this.btn_SendOrder.TabIndex = 5;
            this.btn_SendOrder.Text = "Send Order";
            this.btn_SendOrder.UseVisualStyleBackColor = true;
            this.btn_SendOrder.Click += new System.EventHandler(this.btn_Enter_Click);
            // 
            // comboBox_EbookID
            // 
            this.comboBox_EbookID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_EbookID.FormattingEnabled = true;
            this.comboBox_EbookID.Location = new System.Drawing.Point(369, 21);
            this.comboBox_EbookID.Name = "comboBox_EbookID";
            this.comboBox_EbookID.Size = new System.Drawing.Size(311, 20);
            this.comboBox_EbookID.TabIndex = 6;
            // 
            // label_EBookID
            // 
            this.label_EBookID.AutoSize = true;
            this.label_EBookID.Location = new System.Drawing.Point(294, 24);
            this.label_EBookID.Name = "label_EBookID";
            this.label_EBookID.Size = new System.Drawing.Size(62, 12);
            this.label_EBookID.TabIndex = 7;
            this.label_EBookID.Text = "E Book ID :";
            // 
            // label_Price
            // 
            this.label_Price.AutoSize = true;
            this.label_Price.Location = new System.Drawing.Point(868, 656);
            this.label_Price.Name = "label_Price";
            this.label_Price.Size = new System.Drawing.Size(64, 12);
            this.label_Price.TabIndex = 8;
            this.label_Price.Text = "Total Price : ";
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(944, 653);
            this.txt_price.Name = "txt_price";
            this.txt_price.ReadOnly = true;
            this.txt_price.Size = new System.Drawing.Size(136, 22);
            this.txt_price.TabIndex = 9;
            this.txt_price.Text = "0";
            this.txt_price.TextChanged += new System.EventHandler(this.txt_price_TextChanged);
            // 
            // label_Rearch
            // 
            this.label_Rearch.AutoSize = true;
            this.label_Rearch.Location = new System.Drawing.Point(484, 55);
            this.label_Rearch.Name = "label_Rearch";
            this.label_Rearch.Size = new System.Drawing.Size(67, 12);
            this.label_Rearch.TabIndex = 10;
            this.label_Rearch.Text = "Search result ";
            // 
            // btn_AddProduct
            // 
            this.btn_AddProduct.Location = new System.Drawing.Point(550, 77);
            this.btn_AddProduct.Name = "btn_AddProduct";
            this.btn_AddProduct.Size = new System.Drawing.Size(130, 23);
            this.btn_AddProduct.TabIndex = 11;
            this.btn_AddProduct.Text = "Add E-Book";
            this.btn_AddProduct.UseVisualStyleBackColor = true;
            this.btn_AddProduct.Click += new System.EventHandler(this.btn_AddProduct_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(862, 681);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(218, 23);
            this.btn_Delete.TabIndex = 13;
            this.btn_Delete.Text = "Delete All Product";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // label_Order
            // 
            this.label_Order.AutoSize = true;
            this.label_Order.Location = new System.Drawing.Point(125, 131);
            this.label_Order.Name = "label_Order";
            this.label_Order.Size = new System.Drawing.Size(80, 12);
            this.label_Order.TabIndex = 14;
            this.label_Order.Text = "Buy E-Book ID";
            // 
            // comboBox_Gits
            // 
            this.comboBox_Gits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Gits.FormattingEnabled = true;
            this.comboBox_Gits.Location = new System.Drawing.Point(369, 37);
            this.comboBox_Gits.Name = "comboBox_Gits";
            this.comboBox_Gits.Size = new System.Drawing.Size(302, 20);
            this.comboBox_Gits.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "Gift Card Point :";
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // comboBox_QTY
            // 
            this.comboBox_QTY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_QTY.FormattingEnabled = true;
            this.comboBox_QTY.Items.AddRange(new object[] {
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
            this.comboBox_QTY.Location = new System.Drawing.Point(369, 63);
            this.comboBox_QTY.Name = "comboBox_QTY";
            this.comboBox_QTY.Size = new System.Drawing.Size(302, 20);
            this.comboBox_QTY.TabIndex = 17;
            // 
            // btn_AddGitsCard
            // 
            this.btn_AddGitsCard.Location = new System.Drawing.Point(550, 121);
            this.btn_AddGitsCard.Name = "btn_AddGitsCard";
            this.btn_AddGitsCard.Size = new System.Drawing.Size(121, 23);
            this.btn_AddGitsCard.TabIndex = 18;
            this.btn_AddGitsCard.Text = "Add Gits Card";
            this.btn_AddGitsCard.UseVisualStyleBackColor = true;
            this.btn_AddGitsCard.Click += new System.EventHandler(this.btn_AddGitsCard_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.listNumberCC);
            this.groupBox1.Controls.Add(this.btn_DeleteGCards);
            this.groupBox1.Controls.Add(this.combo_cancelGPoint);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.listBox_GPrice);
            this.groupBox1.Controls.Add(this.listBox_CustomerID);
            this.groupBox1.Controls.Add(this.listBox_Qty);
            this.groupBox1.Controls.Add(this.listBox_GiftCards);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_CustomerID);
            this.groupBox1.Controls.Add(this.btn_AddGitsCard);
            this.groupBox1.Controls.Add(this.comboBox_Gits);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBox_QTY);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1078, 306);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GitsCards";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 12);
            this.label10.TabIndex = 35;
            this.label10.Text = "List Number";
            // 
            // listNumberCC
            // 
            this.listNumberCC.FormattingEnabled = true;
            this.listNumberCC.ItemHeight = 12;
            this.listNumberCC.Location = new System.Drawing.Point(6, 169);
            this.listNumberCC.Name = "listNumberCC";
            this.listNumberCC.Size = new System.Drawing.Size(113, 124);
            this.listNumberCC.TabIndex = 34;
            // 
            // btn_DeleteGCards
            // 
            this.btn_DeleteGCards.Location = new System.Drawing.Point(850, 63);
            this.btn_DeleteGCards.Name = "btn_DeleteGCards";
            this.btn_DeleteGCards.Size = new System.Drawing.Size(121, 23);
            this.btn_DeleteGCards.TabIndex = 33;
            this.btn_DeleteGCards.Text = "Delete Gift Card";
            this.btn_DeleteGCards.UseVisualStyleBackColor = true;
            this.btn_DeleteGCards.Click += new System.EventHandler(this.button1_Click);
            // 
            // combo_cancelGPoint
            // 
            this.combo_cancelGPoint.FormattingEnabled = true;
            this.combo_cancelGPoint.Location = new System.Drawing.Point(850, 37);
            this.combo_cancelGPoint.Name = "combo_cancelGPoint";
            this.combo_cancelGPoint.Size = new System.Drawing.Size(121, 20);
            this.combo_cancelGPoint.TabIndex = 32;
            this.combo_cancelGPoint.Text = "List Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(757, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 12);
            this.label8.TabIndex = 29;
            this.label8.Text = "Price";
            // 
            // listBox_GPrice
            // 
            this.listBox_GPrice.FormattingEnabled = true;
            this.listBox_GPrice.ItemHeight = 12;
            this.listBox_GPrice.Location = new System.Drawing.Point(759, 169);
            this.listBox_GPrice.Name = "listBox_GPrice";
            this.listBox_GPrice.Size = new System.Drawing.Size(247, 124);
            this.listBox_GPrice.TabIndex = 28;
            // 
            // listBox_CustomerID
            // 
            this.listBox_CustomerID.FormattingEnabled = true;
            this.listBox_CustomerID.ItemHeight = 12;
            this.listBox_CustomerID.Location = new System.Drawing.Point(490, 169);
            this.listBox_CustomerID.Name = "listBox_CustomerID";
            this.listBox_CustomerID.Size = new System.Drawing.Size(255, 124);
            this.listBox_CustomerID.TabIndex = 27;
            // 
            // listBox_Qty
            // 
            this.listBox_Qty.FormattingEnabled = true;
            this.listBox_Qty.ItemHeight = 12;
            this.listBox_Qty.Location = new System.Drawing.Point(248, 169);
            this.listBox_Qty.Name = "listBox_Qty";
            this.listBox_Qty.Size = new System.Drawing.Size(236, 124);
            this.listBox_Qty.TabIndex = 26;
            // 
            // listBox_GiftCards
            // 
            this.listBox_GiftCards.FormattingEnabled = true;
            this.listBox_GiftCards.ItemHeight = 12;
            this.listBox_GiftCards.Location = new System.Drawing.Point(127, 169);
            this.listBox_GiftCards.Name = "listBox_GiftCards";
            this.listBox_GiftCards.Size = new System.Drawing.Size(105, 124);
            this.listBox_GiftCards.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 20;
            this.label2.Text = "Customer ID :";
            // 
            // txt_CustomerID
            // 
            this.txt_CustomerID.Location = new System.Drawing.Point(370, 89);
            this.txt_CustomerID.Name = "txt_CustomerID";
            this.txt_CustomerID.Size = new System.Drawing.Size(301, 22);
            this.txt_CustomerID.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(488, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 24;
            this.label5.Text = "Customer ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 12);
            this.label4.TabIndex = 23;
            this.label4.Text = "Qty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 12);
            this.label3.TabIndex = 22;
            this.label3.Text = "Gift Cards Point";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.listNumberEB);
            this.groupBox2.Controls.Add(this.btn_DeleteEBook);
            this.groupBox2.Controls.Add(this.combo_cancelEBook);
            this.groupBox2.Controls.Add(this.lab_EPrice);
            this.groupBox2.Controls.Add(this.listBox_EPrice);
            this.groupBox2.Controls.Add(this.listBox_EMailAddress);
            this.groupBox2.Controls.Add(this.listBox_EBook);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_EMail);
            this.groupBox2.Controls.Add(this.comboBox_EbookID);
            this.groupBox2.Controls.Add(this.label_EBookID);
            this.groupBox2.Controls.Add(this.label_Order);
            this.groupBox2.Controls.Add(this.btn_AddProduct);
            this.groupBox2.Location = new System.Drawing.Point(12, 327);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1078, 276);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "E-Book";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 12);
            this.label9.TabIndex = 34;
            this.label9.Text = "List Number";
            // 
            // listNumberEB
            // 
            this.listNumberEB.FormattingEnabled = true;
            this.listNumberEB.ItemHeight = 12;
            this.listNumberEB.Location = new System.Drawing.Point(0, 146);
            this.listNumberEB.Name = "listNumberEB";
            this.listNumberEB.Size = new System.Drawing.Size(120, 124);
            this.listNumberEB.TabIndex = 33;
            // 
            // btn_DeleteEBook
            // 
            this.btn_DeleteEBook.Location = new System.Drawing.Point(850, 50);
            this.btn_DeleteEBook.Name = "btn_DeleteEBook";
            this.btn_DeleteEBook.Size = new System.Drawing.Size(121, 23);
            this.btn_DeleteEBook.TabIndex = 32;
            this.btn_DeleteEBook.Text = "Delete E Book";
            this.btn_DeleteEBook.UseVisualStyleBackColor = true;
            this.btn_DeleteEBook.Click += new System.EventHandler(this.btn_DeleteEBook_Click);
            // 
            // combo_cancelEBook
            // 
            this.combo_cancelEBook.FormattingEnabled = true;
            this.combo_cancelEBook.Location = new System.Drawing.Point(850, 24);
            this.combo_cancelEBook.Name = "combo_cancelEBook";
            this.combo_cancelEBook.Size = new System.Drawing.Size(121, 20);
            this.combo_cancelEBook.TabIndex = 31;
            this.combo_cancelEBook.Text = "List Number";
            // 
            // lab_EPrice
            // 
            this.lab_EPrice.AutoSize = true;
            this.lab_EPrice.Location = new System.Drawing.Point(789, 131);
            this.lab_EPrice.Name = "lab_EPrice";
            this.lab_EPrice.Size = new System.Drawing.Size(38, 12);
            this.lab_EPrice.TabIndex = 30;
            this.lab_EPrice.Text = "E Price";
            // 
            // listBox_EPrice
            // 
            this.listBox_EPrice.FormattingEnabled = true;
            this.listBox_EPrice.ItemHeight = 12;
            this.listBox_EPrice.Location = new System.Drawing.Point(791, 146);
            this.listBox_EPrice.Name = "listBox_EPrice";
            this.listBox_EPrice.Size = new System.Drawing.Size(202, 124);
            this.listBox_EPrice.TabIndex = 29;
            // 
            // listBox_EMailAddress
            // 
            this.listBox_EMailAddress.FormattingEnabled = true;
            this.listBox_EMailAddress.ItemHeight = 12;
            this.listBox_EMailAddress.Location = new System.Drawing.Point(443, 146);
            this.listBox_EMailAddress.Name = "listBox_EMailAddress";
            this.listBox_EMailAddress.Size = new System.Drawing.Size(342, 124);
            this.listBox_EMailAddress.TabIndex = 29;
            // 
            // listBox_EBook
            // 
            this.listBox_EBook.FormattingEnabled = true;
            this.listBox_EBook.ItemHeight = 12;
            this.listBox_EBook.Location = new System.Drawing.Point(127, 146);
            this.listBox_EBook.Name = "listBox_EBook";
            this.listBox_EBook.Size = new System.Drawing.Size(297, 124);
            this.listBox_EBook.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(441, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 28;
            this.label7.Text = "E-Mail Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "E mail :";
            // 
            // txt_EMail
            // 
            this.txt_EMail.Location = new System.Drawing.Point(369, 47);
            this.txt_EMail.Name = "txt_EMail";
            this.txt_EMail.Size = new System.Drawing.Size(311, 22);
            this.txt_EMail.TabIndex = 12;
            this.txt_EMail.TextChanged += new System.EventHandler(this.txt_EMail_TextChanged);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(307, 625);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(83, 23);
            this.btn_Update.TabIndex = 21;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(335, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 12);
            this.label11.TabIndex = 36;
            this.label11.Text = "Qty :";
            // 
            // sales_create_Ebook_order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 922);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.label_Rearch);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.label_Price);
            this.Controls.Add(this.btn_SendOrder);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.label_searchEbook);
            this.Controls.Add(this.text_searchEbook);
            this.Controls.Add(this.btn_searchEbook);
            this.Name = "sales_create_Ebook_order";
            this.Text = "Create E-Book order";
            this.Load += new System.EventHandler(this.sales_borrow_book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_searchEbook;
        private System.Windows.Forms.TextBox text_searchEbook;
        private System.Windows.Forms.Label label_searchEbook;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_SendOrder;
        private System.Windows.Forms.ComboBox comboBox_EbookID;
        private System.Windows.Forms.Label label_EBookID;
        private System.Windows.Forms.Label label_Price;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label_Rearch;
        private System.Windows.Forms.Button btn_AddProduct;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label label_Order;
        private System.Windows.Forms.ComboBox comboBox_Gits;
        private System.Windows.Forms.Label label1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.ComboBox comboBox_QTY;
        private System.Windows.Forms.Button btn_AddGitsCard;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_CustomerID;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_EMail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox_CustomerID;
        private System.Windows.Forms.ListBox listBox_Qty;
        private System.Windows.Forms.ListBox listBox_GiftCards;
        private System.Windows.Forms.ListBox listBox_EMailAddress;
        private System.Windows.Forms.ListBox listBox_EBook;
        private System.Windows.Forms.ListBox listBox_GPrice;
        private System.Windows.Forms.Label lab_EPrice;
        private System.Windows.Forms.ListBox listBox_EPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listNumberCC;
        private System.Windows.Forms.Button btn_DeleteGCards;
        private System.Windows.Forms.ComboBox combo_cancelGPoint;
        private System.Windows.Forms.ListBox listNumberEB;
        private System.Windows.Forms.Button btn_DeleteEBook;
        private System.Windows.Forms.ComboBox combo_cancelEBook;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
    }
}