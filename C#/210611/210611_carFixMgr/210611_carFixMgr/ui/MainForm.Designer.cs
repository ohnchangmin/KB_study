
namespace _210611_carFixMgr
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.cxFlatPictureBox1 = new CxFlatUI.CxFlatPictureBox();
            this.custFixView = new CxFlatUI.CxFlatRoundButton();
            this.custFixAddmin = new CxFlatUI.CxFlatRoundButton();
            this.custFixRand = new CxFlatUI.CxFlatRoundButton();
            this.custFixInfo = new CxFlatUI.CxFlatRoundButton();
            this.custFixAdd = new Sunny.UI.UISymbolButton();
            this.mainExit = new Sunny.UI.UISymbolButton();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.mainMin = new Sunny.UI.UISymbolButton();
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cxFlatPictureBox1
            // 
            this.cxFlatPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.cxFlatPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("cxFlatPictureBox1.Image")));
            this.cxFlatPictureBox1.Location = new System.Drawing.Point(27, 86);
            this.cxFlatPictureBox1.Name = "cxFlatPictureBox1";
            this.cxFlatPictureBox1.Size = new System.Drawing.Size(376, 339);
            this.cxFlatPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cxFlatPictureBox1.TabIndex = 0;
            this.cxFlatPictureBox1.TabStop = false;
            // 
            // custFixView
            // 
            this.custFixView.BackColor = System.Drawing.Color.White;
            this.custFixView.ButtonType = CxFlatUI.ButtonType.Success;
            this.custFixView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.custFixView.Location = new System.Drawing.Point(455, 149);
            this.custFixView.Name = "custFixView";
            this.custFixView.Size = new System.Drawing.Size(226, 63);
            this.custFixView.TabIndex = 2;
            this.custFixView.Text = "수리 내역";
            this.custFixView.TextColor = System.Drawing.Color.White;
            this.custFixView.Click += new System.EventHandler(this.custFixView_Click);
            // 
            // custFixAddmin
            // 
            this.custFixAddmin.ButtonType = CxFlatUI.ButtonType.Waring;
            this.custFixAddmin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.custFixAddmin.Location = new System.Drawing.Point(473, 220);
            this.custFixAddmin.Name = "custFixAddmin";
            this.custFixAddmin.Size = new System.Drawing.Size(226, 63);
            this.custFixAddmin.TabIndex = 3;
            this.custFixAddmin.Text = "관리자 모드";
            this.custFixAddmin.TextColor = System.Drawing.Color.White;
            this.custFixAddmin.Click += new System.EventHandler(this.custFixAddmin_Click);
            // 
            // custFixRand
            // 
            this.custFixRand.ButtonType = CxFlatUI.ButtonType.Primary;
            this.custFixRand.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.custFixRand.Location = new System.Drawing.Point(455, 291);
            this.custFixRand.Name = "custFixRand";
            this.custFixRand.Size = new System.Drawing.Size(226, 63);
            this.custFixRand.TabIndex = 4;
            this.custFixRand.Text = "랜덤 정보 추가";
            this.custFixRand.TextColor = System.Drawing.Color.White;
            this.custFixRand.Click += new System.EventHandler(this.custFixRand_Click);
            // 
            // custFixInfo
            // 
            this.custFixInfo.ButtonType = CxFlatUI.ButtonType.Info;
            this.custFixInfo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.custFixInfo.Location = new System.Drawing.Point(429, 362);
            this.custFixInfo.Name = "custFixInfo";
            this.custFixInfo.Size = new System.Drawing.Size(226, 63);
            this.custFixInfo.TabIndex = 5;
            this.custFixInfo.Text = "앱 정보";
            this.custFixInfo.TextColor = System.Drawing.Color.White;
            this.custFixInfo.Click += new System.EventHandler(this.custFixInfo_Click);
            // 
            // custFixAdd
            // 
            this.custFixAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custFixAdd.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custFixAdd.Location = new System.Drawing.Point(438, 86);
            this.custFixAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.custFixAdd.Name = "custFixAdd";
            this.custFixAdd.Size = new System.Drawing.Size(217, 55);
            this.custFixAdd.Symbol = 62004;
            this.custFixAdd.TabIndex = 6;
            this.custFixAdd.Text = "고객정보 접수";
            this.custFixAdd.Click += new System.EventHandler(this.custFixAdd_Click);
            // 
            // mainExit
            // 
            this.mainExit.BackColor = System.Drawing.Color.Transparent;
            this.mainExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainExit.FillColor = System.Drawing.Color.Transparent;
            this.mainExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.mainExit.ForeHoverColor = System.Drawing.Color.Red;
            this.mainExit.ForePressColor = System.Drawing.Color.Cyan;
            this.mainExit.IsCircle = true;
            this.mainExit.Location = new System.Drawing.Point(744, 5);
            this.mainExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainExit.Name = "mainExit";
            this.mainExit.RectColor = System.Drawing.Color.Transparent;
            this.mainExit.RectHoverColor = System.Drawing.Color.Transparent;
            this.mainExit.RectPressColor = System.Drawing.Color.Transparent;
            this.mainExit.Size = new System.Drawing.Size(50, 61);
            this.mainExit.Style = Sunny.UI.UIStyle.Custom;
            this.mainExit.Symbol = 61457;
            this.mainExit.SymbolSize = 48;
            this.mainExit.TabIndex = 7;
            this.mainExit.Click += new System.EventHandler(this.mainExit_Click);
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.uiSymbolLabel1.Location = new System.Drawing.Point(3, -6);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(179, 72);
            this.uiSymbolLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel1.Symbol = 57397;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.White;
            this.uiSymbolLabel1.TabIndex = 8;
            this.uiSymbolLabel1.Text = "카센터 관리 앱 v1.0";
            // 
            // mainMin
            // 
            this.mainMin.BackColor = System.Drawing.Color.Transparent;
            this.mainMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainMin.FillColor = System.Drawing.Color.Transparent;
            this.mainMin.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.mainMin.ForeHoverColor = System.Drawing.Color.Chartreuse;
            this.mainMin.ForePressColor = System.Drawing.Color.Cyan;
            this.mainMin.IsCircle = true;
            this.mainMin.Location = new System.Drawing.Point(688, 5);
            this.mainMin.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainMin.Name = "mainMin";
            this.mainMin.RectColor = System.Drawing.Color.Transparent;
            this.mainMin.RectHoverColor = System.Drawing.Color.Transparent;
            this.mainMin.RectPressColor = System.Drawing.Color.Transparent;
            this.mainMin.Size = new System.Drawing.Size(50, 61);
            this.mainMin.Style = Sunny.UI.UIStyle.Custom;
            this.mainMin.Symbol = 61544;
            this.mainMin.SymbolSize = 48;
            this.mainMin.TabIndex = 9;
            this.mainMin.Click += new System.EventHandler(this.mainMin_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.mainMin);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.mainExit);
            this.Controls.Add(this.custFixAdd);
            this.Controls.Add(this.custFixInfo);
            this.Controls.Add(this.custFixRand);
            this.Controls.Add(this.custFixAddmin);
            this.Controls.Add(this.custFixView);
            this.Controls.Add(this.cxFlatPictureBox1);
            this.Name = "MainForm";
            this.Sizable = false;
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CxFlatUI.CxFlatPictureBox cxFlatPictureBox1;
        private CxFlatUI.CxFlatRoundButton custFixView;
        private CxFlatUI.CxFlatRoundButton custFixAddmin;
        private CxFlatUI.CxFlatRoundButton custFixRand;
        private CxFlatUI.CxFlatRoundButton custFixInfo;
        private Sunny.UI.UISymbolButton custFixAdd;
        private Sunny.UI.UISymbolButton mainExit;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UISymbolButton mainMin;
    }
}

