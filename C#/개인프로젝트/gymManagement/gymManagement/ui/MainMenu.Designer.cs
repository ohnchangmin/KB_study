
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
            this.gymEnter = new MetroFramework.Controls.MetroTile();
            this.gymNewCus = new MetroFramework.Controls.MetroTile();
            this.gymCus = new MetroFramework.Controls.MetroTile();
            this.gymPt = new MetroFramework.Controls.MetroTile();
            this.gymLocker = new MetroFramework.Controls.MetroTile();
            this.gymAdmin = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // gymEnter
            // 
            this.gymEnter.ActiveControl = null;
            this.gymEnter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gymEnter.Location = new System.Drawing.Point(106, 121);
            this.gymEnter.Name = "gymEnter";
            this.gymEnter.Size = new System.Drawing.Size(272, 177);
            this.gymEnter.Style = MetroFramework.MetroColorStyle.Purple;
            this.gymEnter.TabIndex = 0;
            this.gymEnter.Text = "회원입장";
            this.gymEnter.UseSelectable = true;
            // 
            // gymNewCus
            // 
            this.gymNewCus.ActiveControl = null;
            this.gymNewCus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gymNewCus.Location = new System.Drawing.Point(384, 121);
            this.gymNewCus.Name = "gymNewCus";
            this.gymNewCus.Size = new System.Drawing.Size(245, 177);
            this.gymNewCus.TabIndex = 1;
            this.gymNewCus.Text = "회원등록";
            this.gymNewCus.UseSelectable = true;
            this.gymNewCus.Click += new System.EventHandler(this.gymNewCus_Click);
            // 
            // gymCus
            // 
            this.gymCus.ActiveControl = null;
            this.gymCus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gymCus.Location = new System.Drawing.Point(635, 121);
            this.gymCus.Name = "gymCus";
            this.gymCus.Size = new System.Drawing.Size(217, 177);
            this.gymCus.Style = MetroFramework.MetroColorStyle.Orange;
            this.gymCus.TabIndex = 1;
            this.gymCus.Text = "회원관리";
            this.gymCus.UseSelectable = true;
            // 
            // gymPt
            // 
            this.gymPt.ActiveControl = null;
            this.gymPt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gymPt.Location = new System.Drawing.Point(106, 304);
            this.gymPt.Name = "gymPt";
            this.gymPt.Size = new System.Drawing.Size(193, 177);
            this.gymPt.TabIndex = 2;
            this.gymPt.Text = "PT";
            this.gymPt.UseSelectable = true;
            // 
            // gymLocker
            // 
            this.gymLocker.ActiveControl = null;
            this.gymLocker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gymLocker.Location = new System.Drawing.Point(305, 304);
            this.gymLocker.Name = "gymLocker";
            this.gymLocker.Size = new System.Drawing.Size(247, 177);
            this.gymLocker.Style = MetroFramework.MetroColorStyle.Green;
            this.gymLocker.TabIndex = 0;
            this.gymLocker.Text = "라커룸 관리";
            this.gymLocker.UseSelectable = true;
            // 
            // gymAdmin
            // 
            this.gymAdmin.ActiveControl = null;
            this.gymAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gymAdmin.Location = new System.Drawing.Point(558, 304);
            this.gymAdmin.Name = "gymAdmin";
            this.gymAdmin.Size = new System.Drawing.Size(294, 177);
            this.gymAdmin.Style = MetroFramework.MetroColorStyle.Red;
            this.gymAdmin.TabIndex = 1;
            this.gymAdmin.Text = "관리자모드";
            this.gymAdmin.UseSelectable = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 575);
            this.Controls.Add(this.gymPt);
            this.Controls.Add(this.gymAdmin);
            this.Controls.Add(this.gymCus);
            this.Controls.Add(this.gymNewCus);
            this.Controls.Add(this.gymLocker);
            this.Controls.Add(this.gymEnter);
            this.Name = "MainMenu";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "GYM";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile gymEnter;
        private MetroFramework.Controls.MetroTile gymNewCus;
        private MetroFramework.Controls.MetroTile gymCus;
        private MetroFramework.Controls.MetroTile gymPt;
        private MetroFramework.Controls.MetroTile gymLocker;
        private MetroFramework.Controls.MetroTile gymAdmin;
    }
}

