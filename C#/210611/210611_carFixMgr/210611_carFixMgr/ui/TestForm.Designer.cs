
namespace _210611_carFixMgr.ui
{
    partial class TestForm
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
            this.uiComboBox8 = new Sunny.UI.UIComboBox();
            this.staffName = new Sunny.UI.UIComboBox();
            this.receiptClose = new Sunny.UI.UISymbolButton();
            this.uiLine2 = new Sunny.UI.UILine();
            this.uiLine1 = new Sunny.UI.UILine();
            this.receiptSave = new Sunny.UI.UISymbolButton();
            this.chk10 = new Sunny.UI.UICheckBox();
            this.chk9 = new Sunny.UI.UICheckBox();
            this.chk8 = new Sunny.UI.UICheckBox();
            this.chk7 = new Sunny.UI.UICheckBox();
            this.chk6 = new Sunny.UI.UICheckBox();
            this.chk5 = new Sunny.UI.UICheckBox();
            this.chk4 = new Sunny.UI.UICheckBox();
            this.chk3 = new Sunny.UI.UICheckBox();
            this.chk2 = new Sunny.UI.UICheckBox();
            this.chk1 = new Sunny.UI.UICheckBox();
            this.uiSymbolLabel9 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel8 = new Sunny.UI.UISymbolLabel();
            this.carNum = new Sunny.UI.UITextBox();
            this.carYear = new Sunny.UI.UIComboBox();
            this.uiSymbolLabel7 = new Sunny.UI.UISymbolLabel();
            this.carCC = new Sunny.UI.UIComboBox();
            this.uiSymbolLabel6 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel5 = new Sunny.UI.UISymbolLabel();
            this.carModel = new Sunny.UI.UIComboBox();
            this.uiSymbolLabel4 = new Sunny.UI.UISymbolLabel();
            this.custDay = new Sunny.UI.UIComboBox();
            this.custMonth = new Sunny.UI.UIComboBox();
            this.custYear = new Sunny.UI.UIComboBox();
            this.uiComboBox1 = new Sunny.UI.UIComboBox();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.custTelHead = new Sunny.UI.UIComboBox();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.uiComboBox3 = new Sunny.UI.UIComboBox();
            this.custTelBody = new Sunny.UI.UITextBox();
            this.custName = new Sunny.UI.UITextBox();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.carNum.SuspendLayout();
            this.custTelBody.SuspendLayout();
            this.custName.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiComboBox8
            // 
            this.uiComboBox8.FillColor = System.Drawing.Color.White;
            this.uiComboBox8.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiComboBox8.Location = new System.Drawing.Point(-75, 98);
            this.uiComboBox8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox8.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox8.Name = "uiComboBox8";
            this.uiComboBox8.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBox8.Size = new System.Drawing.Size(156, 29);
            this.uiComboBox8.TabIndex = 3;
            this.uiComboBox8.Text = "uiComboBox8";
            this.uiComboBox8.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // staffName
            // 
            this.staffName.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.staffName.FillColor = System.Drawing.Color.White;
            this.staffName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.staffName.Items.AddRange(new object[] {
            "김점검",
            "박수리",
            "오고침",
            "최교체"});
            this.staffName.Location = new System.Drawing.Point(172, 456);
            this.staffName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.staffName.MinimumSize = new System.Drawing.Size(63, 0);
            this.staffName.Name = "staffName";
            this.staffName.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.staffName.Size = new System.Drawing.Size(117, 29);
            this.staffName.TabIndex = 70;
            this.staffName.Text = "선택";
            this.staffName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // receiptClose
            // 
            this.receiptClose.BackColor = System.Drawing.Color.Transparent;
            this.receiptClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.receiptClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.receiptClose.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.receiptClose.Location = new System.Drawing.Point(315, 625);
            this.receiptClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.receiptClose.Name = "receiptClose";
            this.receiptClose.Radius = 45;
            this.receiptClose.Size = new System.Drawing.Size(137, 55);
            this.receiptClose.Style = Sunny.UI.UIStyle.Custom;
            this.receiptClose.Symbol = 61579;
            this.receiptClose.TabIndex = 69;
            this.receiptClose.Text = "닫 기";
            // 
            // uiLine2
            // 
            this.uiLine2.BackColor = System.Drawing.SystemColors.Control;
            this.uiLine2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLine2.Location = new System.Drawing.Point(52, 424);
            this.uiLine2.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine2.Name = "uiLine2";
            this.uiLine2.Size = new System.Drawing.Size(528, 10);
            this.uiLine2.TabIndex = 68;
            // 
            // uiLine1
            // 
            this.uiLine1.BackColor = System.Drawing.SystemColors.Control;
            this.uiLine1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLine1.Location = new System.Drawing.Point(52, 220);
            this.uiLine1.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(528, 10);
            this.uiLine1.TabIndex = 67;
            // 
            // receiptSave
            // 
            this.receiptSave.BackColor = System.Drawing.Color.Transparent;
            this.receiptSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.receiptSave.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.receiptSave.Location = new System.Drawing.Point(172, 625);
            this.receiptSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.receiptSave.Name = "receiptSave";
            this.receiptSave.Radius = 45;
            this.receiptSave.Size = new System.Drawing.Size(137, 55);
            this.receiptSave.Symbol = 61563;
            this.receiptSave.TabIndex = 66;
            this.receiptSave.Text = "저 장";
            // 
            // chk10
            // 
            this.chk10.BackColor = System.Drawing.Color.Transparent;
            this.chk10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk10.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.chk10.Location = new System.Drawing.Point(172, 583);
            this.chk10.MinimumSize = new System.Drawing.Size(1, 1);
            this.chk10.Name = "chk10";
            this.chk10.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.chk10.Size = new System.Drawing.Size(132, 23);
            this.chk10.TabIndex = 65;
            this.chk10.Text = "기타 공임비";
            // 
            // chk9
            // 
            this.chk9.BackColor = System.Drawing.Color.Transparent;
            this.chk9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk9.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.chk9.Location = new System.Drawing.Point(448, 554);
            this.chk9.MinimumSize = new System.Drawing.Size(1, 1);
            this.chk9.Name = "chk9";
            this.chk9.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.chk9.Size = new System.Drawing.Size(132, 23);
            this.chk9.TabIndex = 64;
            this.chk9.Text = "부동액";
            // 
            // chk8
            // 
            this.chk8.BackColor = System.Drawing.Color.Transparent;
            this.chk8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk8.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.chk8.Location = new System.Drawing.Point(310, 554);
            this.chk8.MinimumSize = new System.Drawing.Size(1, 1);
            this.chk8.Name = "chk8";
            this.chk8.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.chk8.Size = new System.Drawing.Size(132, 23);
            this.chk8.TabIndex = 63;
            this.chk8.Text = "정기검진";
            // 
            // chk7
            // 
            this.chk7.BackColor = System.Drawing.Color.Transparent;
            this.chk7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk7.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.chk7.Location = new System.Drawing.Point(172, 554);
            this.chk7.MinimumSize = new System.Drawing.Size(1, 1);
            this.chk7.Name = "chk7";
            this.chk7.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.chk7.Size = new System.Drawing.Size(132, 23);
            this.chk7.TabIndex = 62;
            this.chk7.Text = "에어컨 가스";
            // 
            // chk6
            // 
            this.chk6.BackColor = System.Drawing.Color.Transparent;
            this.chk6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk6.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.chk6.Location = new System.Drawing.Point(448, 525);
            this.chk6.MinimumSize = new System.Drawing.Size(1, 1);
            this.chk6.Name = "chk6";
            this.chk6.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.chk6.Size = new System.Drawing.Size(132, 23);
            this.chk6.TabIndex = 61;
            this.chk6.Text = "브레이크 오일";
            // 
            // chk5
            // 
            this.chk5.BackColor = System.Drawing.Color.Transparent;
            this.chk5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.chk5.Location = new System.Drawing.Point(310, 525);
            this.chk5.MinimumSize = new System.Drawing.Size(1, 1);
            this.chk5.Name = "chk5";
            this.chk5.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.chk5.Size = new System.Drawing.Size(132, 23);
            this.chk5.TabIndex = 60;
            this.chk5.Text = "휠 밸런스";
            // 
            // chk4
            // 
            this.chk4.BackColor = System.Drawing.Color.Transparent;
            this.chk4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.chk4.Location = new System.Drawing.Point(172, 525);
            this.chk4.MinimumSize = new System.Drawing.Size(1, 1);
            this.chk4.Name = "chk4";
            this.chk4.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.chk4.Size = new System.Drawing.Size(132, 23);
            this.chk4.TabIndex = 59;
            this.chk4.Text = "와이퍼";
            // 
            // chk3
            // 
            this.chk3.BackColor = System.Drawing.Color.Transparent;
            this.chk3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.chk3.Location = new System.Drawing.Point(448, 496);
            this.chk3.MinimumSize = new System.Drawing.Size(1, 1);
            this.chk3.Name = "chk3";
            this.chk3.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.chk3.Size = new System.Drawing.Size(132, 23);
            this.chk3.TabIndex = 58;
            this.chk3.Text = "타이어 교체";
            // 
            // chk2
            // 
            this.chk2.BackColor = System.Drawing.Color.Transparent;
            this.chk2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.chk2.Location = new System.Drawing.Point(310, 496);
            this.chk2.MinimumSize = new System.Drawing.Size(1, 1);
            this.chk2.Name = "chk2";
            this.chk2.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.chk2.Size = new System.Drawing.Size(132, 23);
            this.chk2.TabIndex = 57;
            this.chk2.Text = "에어컨 필터";
            // 
            // chk1
            // 
            this.chk1.BackColor = System.Drawing.Color.Transparent;
            this.chk1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.chk1.Location = new System.Drawing.Point(172, 496);
            this.chk1.MinimumSize = new System.Drawing.Size(1, 1);
            this.chk1.Name = "chk1";
            this.chk1.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.chk1.Size = new System.Drawing.Size(132, 23);
            this.chk1.TabIndex = 56;
            this.chk1.Text = "엔진 오일";
            // 
            // uiSymbolLabel9
            // 
            this.uiSymbolLabel9.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel9.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel9.Location = new System.Drawing.Point(52, 487);
            this.uiSymbolLabel9.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel9.Name = "uiSymbolLabel9";
            this.uiSymbolLabel9.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel9.Size = new System.Drawing.Size(113, 40);
            this.uiSymbolLabel9.Symbol = 57397;
            this.uiSymbolLabel9.TabIndex = 55;
            this.uiSymbolLabel9.Text = "수리항목";
            this.uiSymbolLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel8
            // 
            this.uiSymbolLabel8.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel8.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel8.Location = new System.Drawing.Point(52, 451);
            this.uiSymbolLabel8.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel8.Name = "uiSymbolLabel8";
            this.uiSymbolLabel8.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel8.Size = new System.Drawing.Size(113, 37);
            this.uiSymbolLabel8.Symbol = 62142;
            this.uiSymbolLabel8.TabIndex = 54;
            this.uiSymbolLabel8.Text = "담당자";
            this.uiSymbolLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // carNum
            // 
            this.carNum.Controls.Add(this.uiComboBox8);
            this.carNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.carNum.FillColor = System.Drawing.Color.White;
            this.carNum.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.carNum.Location = new System.Drawing.Point(172, 289);
            this.carNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.carNum.Maximum = 2147483647D;
            this.carNum.Minimum = -2147483648D;
            this.carNum.MinimumSize = new System.Drawing.Size(1, 1);
            this.carNum.Name = "carNum";
            this.carNum.Padding = new System.Windows.Forms.Padding(5);
            this.carNum.Size = new System.Drawing.Size(117, 29);
            this.carNum.TabIndex = 53;
            this.carNum.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // carYear
            // 
            this.carYear.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.carYear.FillColor = System.Drawing.Color.White;
            this.carYear.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.carYear.Items.AddRange(new object[] {
            "2021",
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010"});
            this.carYear.Location = new System.Drawing.Point(172, 374);
            this.carYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.carYear.MinimumSize = new System.Drawing.Size(63, 0);
            this.carYear.Name = "carYear";
            this.carYear.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.carYear.Size = new System.Drawing.Size(117, 29);
            this.carYear.TabIndex = 52;
            this.carYear.Text = "선택";
            this.carYear.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel7
            // 
            this.uiSymbolLabel7.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel7.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel7.Location = new System.Drawing.Point(52, 370);
            this.uiSymbolLabel7.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel7.Name = "uiSymbolLabel7";
            this.uiSymbolLabel7.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel7.Size = new System.Drawing.Size(113, 37);
            this.uiSymbolLabel7.Symbol = 61881;
            this.uiSymbolLabel7.TabIndex = 51;
            this.uiSymbolLabel7.Text = "차량연식";
            this.uiSymbolLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // carCC
            // 
            this.carCC.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.carCC.FillColor = System.Drawing.Color.White;
            this.carCC.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.carCC.Items.AddRange(new object[] {
            "1000cc 이하",
            "1600cc 이하",
            "2000cc 이하",
            "2200cc 이하",
            "2200cc 초과"});
            this.carCC.Location = new System.Drawing.Point(172, 331);
            this.carCC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.carCC.MinimumSize = new System.Drawing.Size(63, 0);
            this.carCC.Name = "carCC";
            this.carCC.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.carCC.Size = new System.Drawing.Size(117, 29);
            this.carCC.TabIndex = 50;
            this.carCC.Text = "선택";
            this.carCC.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel6
            // 
            this.uiSymbolLabel6.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel6.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel6.Location = new System.Drawing.Point(52, 327);
            this.uiSymbolLabel6.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel6.Name = "uiSymbolLabel6";
            this.uiSymbolLabel6.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel6.Size = new System.Drawing.Size(113, 37);
            this.uiSymbolLabel6.Symbol = 61881;
            this.uiSymbolLabel6.TabIndex = 49;
            this.uiSymbolLabel6.Text = "배기량";
            this.uiSymbolLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel5
            // 
            this.uiSymbolLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel5.Location = new System.Drawing.Point(52, 284);
            this.uiSymbolLabel5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel5.Name = "uiSymbolLabel5";
            this.uiSymbolLabel5.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel5.Size = new System.Drawing.Size(113, 37);
            this.uiSymbolLabel5.Symbol = 61881;
            this.uiSymbolLabel5.TabIndex = 48;
            this.uiSymbolLabel5.Text = "차량번호";
            this.uiSymbolLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // carModel
            // 
            this.carModel.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.carModel.FillColor = System.Drawing.Color.White;
            this.carModel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.carModel.Items.AddRange(new object[] {
            "아반떼",
            "벨로스터",
            "아이오닉",
            "소나타",
            "그랜져",
            "제네시스",
            "투싼",
            "산타페",
            "펠리셰이드",
            "스타렉스",
            "모닝",
            "레이",
            "K3",
            "K5",
            "K7",
            "K8",
            "K9",
            "스팅어"});
            this.carModel.Location = new System.Drawing.Point(172, 245);
            this.carModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.carModel.MinimumSize = new System.Drawing.Size(63, 0);
            this.carModel.Name = "carModel";
            this.carModel.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.carModel.Size = new System.Drawing.Size(117, 29);
            this.carModel.TabIndex = 47;
            this.carModel.Text = "선택";
            this.carModel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel4
            // 
            this.uiSymbolLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel4.Location = new System.Drawing.Point(52, 241);
            this.uiSymbolLabel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel4.Name = "uiSymbolLabel4";
            this.uiSymbolLabel4.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel4.Size = new System.Drawing.Size(113, 37);
            this.uiSymbolLabel4.Symbol = 61881;
            this.uiSymbolLabel4.TabIndex = 46;
            this.uiSymbolLabel4.Text = "차량모델";
            this.uiSymbolLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // custDay
            // 
            this.custDay.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.custDay.FillColor = System.Drawing.Color.White;
            this.custDay.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custDay.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
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
            "31"});
            this.custDay.Location = new System.Drawing.Point(330, 176);
            this.custDay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.custDay.MinimumSize = new System.Drawing.Size(63, 0);
            this.custDay.Name = "custDay";
            this.custDay.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.custDay.Size = new System.Drawing.Size(71, 29);
            this.custDay.TabIndex = 45;
            this.custDay.Text = "선택";
            this.custDay.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // custMonth
            // 
            this.custMonth.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.custMonth.FillColor = System.Drawing.Color.White;
            this.custMonth.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custMonth.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.custMonth.Location = new System.Drawing.Point(251, 176);
            this.custMonth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.custMonth.MinimumSize = new System.Drawing.Size(63, 0);
            this.custMonth.Name = "custMonth";
            this.custMonth.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.custMonth.Size = new System.Drawing.Size(71, 29);
            this.custMonth.TabIndex = 44;
            this.custMonth.Text = "선택";
            this.custMonth.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // custYear
            // 
            this.custYear.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.custYear.FillColor = System.Drawing.Color.White;
            this.custYear.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custYear.Items.AddRange(new object[] {
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990",
            "1989",
            "1988",
            "1987",
            "1986",
            "1985",
            "1984",
            "1983",
            "1982",
            "1981"});
            this.custYear.Location = new System.Drawing.Point(172, 176);
            this.custYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.custYear.MinimumSize = new System.Drawing.Size(63, 0);
            this.custYear.Name = "custYear";
            this.custYear.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.custYear.Size = new System.Drawing.Size(71, 29);
            this.custYear.TabIndex = 43;
            this.custYear.Text = "선택";
            this.custYear.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiComboBox1
            // 
            this.uiComboBox1.FillColor = System.Drawing.Color.White;
            this.uiComboBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiComboBox1.Location = new System.Drawing.Point(-75, 98);
            this.uiComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox1.Name = "uiComboBox1";
            this.uiComboBox1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBox1.Size = new System.Drawing.Size(156, 29);
            this.uiComboBox1.TabIndex = 3;
            this.uiComboBox1.Text = "uiComboBox1";
            this.uiComboBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel3.Location = new System.Drawing.Point(52, 172);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel3.Size = new System.Drawing.Size(113, 37);
            this.uiSymbolLabel3.Symbol = 61949;
            this.uiSymbolLabel3.TabIndex = 42;
            this.uiSymbolLabel3.Text = "생년월일";
            this.uiSymbolLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // custTelHead
            // 
            this.custTelHead.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.custTelHead.FillColor = System.Drawing.Color.White;
            this.custTelHead.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custTelHead.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.custTelHead.Items.AddRange(new object[] {
            "010",
            "011"});
            this.custTelHead.Location = new System.Drawing.Point(172, 133);
            this.custTelHead.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.custTelHead.MinimumSize = new System.Drawing.Size(63, 0);
            this.custTelHead.Name = "custTelHead";
            this.custTelHead.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.custTelHead.Size = new System.Drawing.Size(71, 29);
            this.custTelHead.TabIndex = 40;
            this.custTelHead.Text = "선택";
            this.custTelHead.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel2.Location = new System.Drawing.Point(52, 129);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(113, 37);
            this.uiSymbolLabel2.Symbol = 57488;
            this.uiSymbolLabel2.TabIndex = 39;
            this.uiSymbolLabel2.Text = "연락처";
            this.uiSymbolLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiComboBox3
            // 
            this.uiComboBox3.FillColor = System.Drawing.Color.White;
            this.uiComboBox3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiComboBox3.Location = new System.Drawing.Point(-75, 98);
            this.uiComboBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox3.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox3.Name = "uiComboBox3";
            this.uiComboBox3.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBox3.Size = new System.Drawing.Size(156, 29);
            this.uiComboBox3.TabIndex = 3;
            this.uiComboBox3.Text = "uiComboBox3";
            this.uiComboBox3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // custTelBody
            // 
            this.custTelBody.Controls.Add(this.uiComboBox3);
            this.custTelBody.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.custTelBody.FillColor = System.Drawing.Color.White;
            this.custTelBody.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custTelBody.Location = new System.Drawing.Point(251, 133);
            this.custTelBody.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.custTelBody.Maximum = 2147483647D;
            this.custTelBody.Minimum = -2147483648D;
            this.custTelBody.MinimumSize = new System.Drawing.Size(1, 1);
            this.custTelBody.Name = "custTelBody";
            this.custTelBody.Padding = new System.Windows.Forms.Padding(5);
            this.custTelBody.Size = new System.Drawing.Size(150, 29);
            this.custTelBody.TabIndex = 41;
            this.custTelBody.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // custName
            // 
            this.custName.Controls.Add(this.uiComboBox1);
            this.custName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.custName.FillColor = System.Drawing.Color.White;
            this.custName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custName.Location = new System.Drawing.Point(172, 91);
            this.custName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.custName.Maximum = 2147483647D;
            this.custName.Minimum = -2147483648D;
            this.custName.MinimumSize = new System.Drawing.Size(1, 1);
            this.custName.Name = "custName";
            this.custName.Padding = new System.Windows.Forms.Padding(5);
            this.custName.Size = new System.Drawing.Size(117, 29);
            this.custName.TabIndex = 38;
            this.custName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel1.Location = new System.Drawing.Point(52, 86);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(113, 37);
            this.uiSymbolLabel1.Symbol = 57607;
            this.uiSymbolLabel1.TabIndex = 37;
            this.uiSymbolLabel1.Text = "이   름";
            this.uiSymbolLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 697);
            this.Controls.Add(this.staffName);
            this.Controls.Add(this.receiptClose);
            this.Controls.Add(this.uiLine2);
            this.Controls.Add(this.uiLine1);
            this.Controls.Add(this.receiptSave);
            this.Controls.Add(this.chk10);
            this.Controls.Add(this.chk9);
            this.Controls.Add(this.chk8);
            this.Controls.Add(this.chk7);
            this.Controls.Add(this.chk6);
            this.Controls.Add(this.chk5);
            this.Controls.Add(this.chk4);
            this.Controls.Add(this.chk3);
            this.Controls.Add(this.chk2);
            this.Controls.Add(this.chk1);
            this.Controls.Add(this.uiSymbolLabel9);
            this.Controls.Add(this.uiSymbolLabel8);
            this.Controls.Add(this.carNum);
            this.Controls.Add(this.carYear);
            this.Controls.Add(this.uiSymbolLabel7);
            this.Controls.Add(this.carCC);
            this.Controls.Add(this.uiSymbolLabel6);
            this.Controls.Add(this.uiSymbolLabel5);
            this.Controls.Add(this.carModel);
            this.Controls.Add(this.uiSymbolLabel4);
            this.Controls.Add(this.custDay);
            this.Controls.Add(this.custMonth);
            this.Controls.Add(this.custYear);
            this.Controls.Add(this.uiSymbolLabel3);
            this.Controls.Add(this.custTelHead);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.custTelBody);
            this.Controls.Add(this.custName);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Name = "TestForm";
            this.Text = "Form1";
            this.carNum.ResumeLayout(false);
            this.carNum.PerformLayout();
            this.custTelBody.ResumeLayout(false);
            this.custTelBody.PerformLayout();
            this.custName.ResumeLayout(false);
            this.custName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIComboBox uiComboBox8;
        private Sunny.UI.UIComboBox staffName;
        private Sunny.UI.UISymbolButton receiptClose;
        private Sunny.UI.UILine uiLine2;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UISymbolButton receiptSave;
        private Sunny.UI.UICheckBox chk10;
        private Sunny.UI.UICheckBox chk9;
        private Sunny.UI.UICheckBox chk8;
        private Sunny.UI.UICheckBox chk7;
        private Sunny.UI.UICheckBox chk6;
        private Sunny.UI.UICheckBox chk5;
        private Sunny.UI.UICheckBox chk4;
        private Sunny.UI.UICheckBox chk3;
        private Sunny.UI.UICheckBox chk2;
        private Sunny.UI.UICheckBox chk1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel9;
        private Sunny.UI.UISymbolLabel uiSymbolLabel8;
        private Sunny.UI.UITextBox carNum;
        private Sunny.UI.UIComboBox carYear;
        private Sunny.UI.UISymbolLabel uiSymbolLabel7;
        private Sunny.UI.UIComboBox carCC;
        private Sunny.UI.UISymbolLabel uiSymbolLabel6;
        private Sunny.UI.UISymbolLabel uiSymbolLabel5;
        private Sunny.UI.UIComboBox carModel;
        private Sunny.UI.UISymbolLabel uiSymbolLabel4;
        private Sunny.UI.UIComboBox custDay;
        private Sunny.UI.UIComboBox custMonth;
        private Sunny.UI.UIComboBox custYear;
        private Sunny.UI.UIComboBox uiComboBox1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private Sunny.UI.UIComboBox custTelHead;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UIComboBox uiComboBox3;
        private Sunny.UI.UITextBox custTelBody;
        private Sunny.UI.UITextBox custName;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
    }
}