
namespace _210611_carFixMgr.ui
{
    partial class ReceiptView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.viewGrid = new Sunny.UI.UIDataGridView();
            this.gridCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridRepair = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewList = new System.Windows.Forms.ListView();
            this.lCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lInDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lTotalPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lStaffName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lCustName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.viewSelect = new Sunny.UI.UIComboBox();
            this.viewInput = new CxFlatUI.CxFlatTextBox();
            this.viewSearch = new Sunny.UI.UISymbolButton();
            this.viewSearchAll = new Sunny.UI.UISymbolButton();
            this.viewConfirm = new Sunny.UI.UISymbolButton();
            this.viewDelete = new Sunny.UI.UISymbolButton();
            this.viewModify = new Sunny.UI.UISymbolButton();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.viewClose = new Sunny.UI.UISymbolButton();
            ((System.ComponentModel.ISupportInitialize)(this.viewGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // viewGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.viewGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.viewGrid.BackgroundColor = System.Drawing.Color.White;
            this.viewGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.viewGrid.ColumnHeadersHeight = 32;
            this.viewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.viewGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridCount,
            this.gridRepair,
            this.gridPrice});
            this.viewGrid.EnableHeadersVisualStyles = false;
            this.viewGrid.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.viewGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.viewGrid.Location = new System.Drawing.Point(49, 416);
            this.viewGrid.Name = "viewGrid";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.viewGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.viewGrid.RowTemplate.Height = 29;
            this.viewGrid.SelectedIndex = -1;
            this.viewGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewGrid.ShowGridLine = true;
            this.viewGrid.Size = new System.Drawing.Size(702, 202);
            this.viewGrid.TabIndex = 1;
            // 
            // gridCount
            // 
            this.gridCount.HeaderText = "번호";
            this.gridCount.Name = "gridCount";
            // 
            // gridRepair
            // 
            this.gridRepair.HeaderText = "수리항목";
            this.gridRepair.Name = "gridRepair";
            // 
            // gridPrice
            // 
            this.gridPrice.HeaderText = "수리비용";
            this.gridPrice.Name = "gridPrice";
            // 
            // viewList
            // 
            this.viewList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lCount,
            this.lInDate,
            this.lTotalPrice,
            this.lStaffName,
            this.lCustName});
            this.viewList.FullRowSelect = true;
            this.viewList.HideSelection = false;
            this.viewList.Location = new System.Drawing.Point(49, 132);
            this.viewList.Name = "viewList";
            this.viewList.Size = new System.Drawing.Size(702, 196);
            this.viewList.TabIndex = 2;
            this.viewList.UseCompatibleStateImageBehavior = false;
            this.viewList.View = System.Windows.Forms.View.Details;
            this.viewList.SelectedIndexChanged += new System.EventHandler(this.viewList_SelectedIndexChanged);
            // 
            // lCount
            // 
            this.lCount.Text = "번호";
            // 
            // lInDate
            // 
            this.lInDate.Text = "접수날짜";
            this.lInDate.Width = 100;
            // 
            // lTotalPrice
            // 
            this.lTotalPrice.Text = "총결제금액";
            this.lTotalPrice.Width = 120;
            // 
            // lStaffName
            // 
            this.lStaffName.Text = "담당자";
            this.lStaffName.Width = 100;
            // 
            // lCustName
            // 
            this.lCustName.Text = "고객명";
            this.lCustName.Width = 100;
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel1.Location = new System.Drawing.Point(49, 87);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(106, 39);
            this.uiSymbolLabel1.Symbol = 61564;
            this.uiSymbolLabel1.TabIndex = 3;
            this.uiSymbolLabel1.Text = "검색항목";
            // 
            // viewSelect
            // 
            this.viewSelect.FillColor = System.Drawing.Color.White;
            this.viewSelect.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.viewSelect.Items.AddRange(new object[] {
            "고객명",
            "차량번호"});
            this.viewSelect.Location = new System.Drawing.Point(166, 91);
            this.viewSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewSelect.MinimumSize = new System.Drawing.Size(63, 0);
            this.viewSelect.Name = "viewSelect";
            this.viewSelect.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.viewSelect.RectColor = System.Drawing.Color.Black;
            this.viewSelect.Size = new System.Drawing.Size(170, 29);
            this.viewSelect.Style = Sunny.UI.UIStyle.Custom;
            this.viewSelect.TabIndex = 4;
            this.viewSelect.Text = "검색항목 선택";
            this.viewSelect.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // viewInput
            // 
            this.viewInput.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.viewInput.Hint = "검색어를 입력하세요";
            this.viewInput.Location = new System.Drawing.Point(348, 87);
            this.viewInput.MaxLength = 32767;
            this.viewInput.Multiline = false;
            this.viewInput.Name = "viewInput";
            this.viewInput.PasswordChar = '\0';
            this.viewInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.viewInput.SelectedText = "";
            this.viewInput.SelectionLength = 0;
            this.viewInput.SelectionStart = 0;
            this.viewInput.Size = new System.Drawing.Size(203, 38);
            this.viewInput.TabIndex = 5;
            this.viewInput.TabStop = false;
            this.viewInput.UseSystemPasswordChar = false;
            // 
            // viewSearch
            // 
            this.viewSearch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.viewSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewSearch.FillColor = System.Drawing.Color.White;
            this.viewSearch.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.viewSearch.ForeColor = System.Drawing.Color.Black;
            this.viewSearch.Location = new System.Drawing.Point(557, 87);
            this.viewSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.viewSearch.Name = "viewSearch";
            this.viewSearch.RectColor = System.Drawing.Color.Black;
            this.viewSearch.Size = new System.Drawing.Size(86, 39);
            this.viewSearch.Style = Sunny.UI.UIStyle.Custom;
            this.viewSearch.Symbol = 61442;
            this.viewSearch.TabIndex = 6;
            this.viewSearch.Text = "검색";
            // 
            // viewSearchAll
            // 
            this.viewSearchAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewSearchAll.FillColor = System.Drawing.Color.White;
            this.viewSearchAll.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.viewSearchAll.ForeColor = System.Drawing.Color.Black;
            this.viewSearchAll.Location = new System.Drawing.Point(647, 87);
            this.viewSearchAll.MinimumSize = new System.Drawing.Size(1, 1);
            this.viewSearchAll.Name = "viewSearchAll";
            this.viewSearchAll.RectColor = System.Drawing.Color.Black;
            this.viewSearchAll.Size = new System.Drawing.Size(104, 39);
            this.viewSearchAll.Style = Sunny.UI.UIStyle.Custom;
            this.viewSearchAll.Symbol = 57591;
            this.viewSearchAll.TabIndex = 7;
            this.viewSearchAll.Text = "전체검색";
            // 
            // viewConfirm
            // 
            this.viewConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewConfirm.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.viewConfirm.Location = new System.Drawing.Point(487, 334);
            this.viewConfirm.MinimumSize = new System.Drawing.Size(1, 1);
            this.viewConfirm.Name = "viewConfirm";
            this.viewConfirm.Size = new System.Drawing.Size(84, 39);
            this.viewConfirm.Symbol = 61639;
            this.viewConfirm.TabIndex = 8;
            this.viewConfirm.Text = "완료";
            // 
            // viewDelete
            // 
            this.viewDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewDelete.FillColor = System.Drawing.Color.Red;
            this.viewDelete.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.viewDelete.Location = new System.Drawing.Point(667, 334);
            this.viewDelete.MinimumSize = new System.Drawing.Size(1, 1);
            this.viewDelete.Name = "viewDelete";
            this.viewDelete.RectColor = System.Drawing.Color.Red;
            this.viewDelete.Size = new System.Drawing.Size(84, 39);
            this.viewDelete.Style = Sunny.UI.UIStyle.Custom;
            this.viewDelete.Symbol = 62005;
            this.viewDelete.TabIndex = 9;
            this.viewDelete.Text = "삭제";
            // 
            // viewModify
            // 
            this.viewModify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewModify.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.viewModify.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.viewModify.Location = new System.Drawing.Point(577, 334);
            this.viewModify.MinimumSize = new System.Drawing.Size(1, 1);
            this.viewModify.Name = "viewModify";
            this.viewModify.RectColor = System.Drawing.Color.MediumSeaGreen;
            this.viewModify.Size = new System.Drawing.Size(84, 39);
            this.viewModify.Style = Sunny.UI.UIStyle.Custom;
            this.viewModify.Symbol = 61508;
            this.viewModify.TabIndex = 10;
            this.viewModify.Text = "수정";
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel2.Location = new System.Drawing.Point(49, 371);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(149, 39);
            this.uiSymbolLabel2.Symbol = 61717;
            this.uiSymbolLabel2.TabIndex = 11;
            this.uiSymbolLabel2.Text = "상세수리내역";
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.uiSymbolLabel3.Location = new System.Drawing.Point(3, -7);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel3.Size = new System.Drawing.Size(103, 72);
            this.uiSymbolLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel3.Symbol = 61508;
            this.uiSymbolLabel3.SymbolColor = System.Drawing.Color.White;
            this.uiSymbolLabel3.TabIndex = 13;
            this.uiSymbolLabel3.Text = "접수내역";
            // 
            // viewClose
            // 
            this.viewClose.BackColor = System.Drawing.Color.Transparent;
            this.viewClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewClose.FillColor = System.Drawing.Color.Transparent;
            this.viewClose.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.viewClose.ForeHoverColor = System.Drawing.Color.Red;
            this.viewClose.ForePressColor = System.Drawing.Color.Cyan;
            this.viewClose.IsCircle = true;
            this.viewClose.Location = new System.Drawing.Point(744, 4);
            this.viewClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.viewClose.Name = "viewClose";
            this.viewClose.RectColor = System.Drawing.Color.Transparent;
            this.viewClose.RectHoverColor = System.Drawing.Color.Transparent;
            this.viewClose.RectPressColor = System.Drawing.Color.Transparent;
            this.viewClose.Size = new System.Drawing.Size(50, 61);
            this.viewClose.Style = Sunny.UI.UIStyle.Custom;
            this.viewClose.Symbol = 61457;
            this.viewClose.SymbolSize = 48;
            this.viewClose.TabIndex = 12;
            this.viewClose.Click += new System.EventHandler(this.viewClose_Click);
            // 
            // ReceiptView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 630);
            this.ControlBox = false;
            this.Controls.Add(this.uiSymbolLabel3);
            this.Controls.Add(this.viewClose);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.viewModify);
            this.Controls.Add(this.viewDelete);
            this.Controls.Add(this.viewConfirm);
            this.Controls.Add(this.viewSearchAll);
            this.Controls.Add(this.viewSearch);
            this.Controls.Add(this.viewInput);
            this.Controls.Add(this.viewSelect);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.viewList);
            this.Controls.Add(this.viewGrid);
            this.Name = "ReceiptView";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.ReceiptView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIDataGridView viewGrid;
        private System.Windows.Forms.ListView viewList;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UIComboBox viewSelect;
        private CxFlatUI.CxFlatTextBox viewInput;
        private Sunny.UI.UISymbolButton viewSearch;
        private Sunny.UI.UISymbolButton viewSearchAll;
        private Sunny.UI.UISymbolButton viewConfirm;
        private Sunny.UI.UISymbolButton viewDelete;
        private Sunny.UI.UISymbolButton viewModify;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private Sunny.UI.UISymbolButton viewClose;
        private System.Windows.Forms.ColumnHeader lCount;
        private System.Windows.Forms.ColumnHeader lInDate;
        private System.Windows.Forms.ColumnHeader lTotalPrice;
        private System.Windows.Forms.ColumnHeader lStaffName;
        private System.Windows.Forms.ColumnHeader lCustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridRepair;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridPrice;
    }
}