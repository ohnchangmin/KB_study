
namespace gymManagement
{
    partial class MainMenu
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
            this.uiButton1 = new Sunny.UI.UIButton();
            this.mainCustomer = new Sunny.UI.UIButton();
            this.uiButton3 = new Sunny.UI.UIButton();
            this.uiButton4 = new Sunny.UI.UIButton();
            this.mainAdmin = new Sunny.UI.UIButton();
            this.uiButton5 = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.FillColor = System.Drawing.Color.DarkGray;
            this.uiButton1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiButton1.Location = new System.Drawing.Point(76, 118);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.RectColor = System.Drawing.Color.Transparent;
            this.uiButton1.Size = new System.Drawing.Size(192, 178);
            this.uiButton1.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton1.TabIndex = 3;
            this.uiButton1.Text = "uiButton1";
            // 
            // mainCustomer
            // 
            this.mainCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainCustomer.FillColor = System.Drawing.Color.CornflowerBlue;
            this.mainCustomer.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.mainCustomer.Location = new System.Drawing.Point(274, 118);
            this.mainCustomer.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainCustomer.Name = "mainCustomer";
            this.mainCustomer.RectColor = System.Drawing.Color.Transparent;
            this.mainCustomer.Size = new System.Drawing.Size(233, 178);
            this.mainCustomer.Style = Sunny.UI.UIStyle.Custom;
            this.mainCustomer.TabIndex = 3;
            this.mainCustomer.Text = "고객관리";
            // 
            // uiButton3
            // 
            this.uiButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton3.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.uiButton3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiButton3.Location = new System.Drawing.Point(513, 118);
            this.uiButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton3.Name = "uiButton3";
            this.uiButton3.RectColor = System.Drawing.Color.Transparent;
            this.uiButton3.Size = new System.Drawing.Size(314, 178);
            this.uiButton3.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton3.TabIndex = 3;
            this.uiButton3.Text = "uiButton1";
            // 
            // uiButton4
            // 
            this.uiButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton4.FillColor = System.Drawing.Color.Khaki;
            this.uiButton4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiButton4.Location = new System.Drawing.Point(76, 302);
            this.uiButton4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton4.Name = "uiButton4";
            this.uiButton4.RectColor = System.Drawing.Color.Transparent;
            this.uiButton4.Size = new System.Drawing.Size(233, 178);
            this.uiButton4.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton4.TabIndex = 3;
            this.uiButton4.Text = "uiButton1";
            // 
            // mainAdmin
            // 
            this.mainAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainAdmin.FillColor = System.Drawing.Color.LightSkyBlue;
            this.mainAdmin.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.mainAdmin.Location = new System.Drawing.Point(609, 302);
            this.mainAdmin.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainAdmin.Name = "mainAdmin";
            this.mainAdmin.RectColor = System.Drawing.Color.Transparent;
            this.mainAdmin.Size = new System.Drawing.Size(218, 178);
            this.mainAdmin.Style = Sunny.UI.UIStyle.Custom;
            this.mainAdmin.TabIndex = 3;
            this.mainAdmin.Text = "관리자모드";
            this.mainAdmin.Click += new System.EventHandler(this.MainAdmin_Click);
            // 
            // uiButton5
            // 
            this.uiButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton5.FillColor = System.Drawing.Color.Plum;
            this.uiButton5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiButton5.Location = new System.Drawing.Point(315, 302);
            this.uiButton5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton5.Name = "uiButton5";
            this.uiButton5.RectColor = System.Drawing.Color.Transparent;
            this.uiButton5.Size = new System.Drawing.Size(288, 178);
            this.uiButton5.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton5.TabIndex = 3;
            this.uiButton5.Text = "uiButton1";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 570);
            this.Controls.Add(this.mainAdmin);
            this.Controls.Add(this.uiButton5);
            this.Controls.Add(this.uiButton4);
            this.Controls.Add(this.uiButton3);
            this.Controls.Add(this.mainCustomer);
            this.Controls.Add(this.uiButton1);
            this.Name = "MainMenu";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "GYM";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIButton mainCustomer;
        private Sunny.UI.UIButton uiButton3;
        private Sunny.UI.UIButton uiButton4;
        private Sunny.UI.UIButton mainAdmin;
        private Sunny.UI.UIButton uiButton5;
    }
}

