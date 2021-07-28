
namespace gymManagement.ui
{
    partial class CustomerMenu
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
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.adminSideMenu = new System.Windows.Forms.Panel();
            this.closeAdminMenu = new System.Windows.Forms.Button();
            this.setAccount = new System.Windows.Forms.Button();
            this.setPrice = new System.Windows.Forms.Button();
            this.setTrainer = new System.Windows.Forms.Button();
            this.sendMessage = new System.Windows.Forms.Button();
            this.adminLogoSpace = new System.Windows.Forms.Panel();
            this.adminLogo = new System.Windows.Forms.PictureBox();
            this.adminTitleBar = new System.Windows.Forms.Panel();
            this.adminTitle = new System.Windows.Forms.Label();
            this.adminSideMenu.SuspendLayout();
            this.adminLogoSpace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminLogo)).BeginInit();
            this.adminTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Location = new System.Drawing.Point(190, 95);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(974, 475);
            this.panelDesktopPane.TabIndex = 5;
            // 
            // adminSideMenu
            // 
            this.adminSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.adminSideMenu.Controls.Add(this.panelDesktopPane);
            this.adminSideMenu.Controls.Add(this.closeAdminMenu);
            this.adminSideMenu.Controls.Add(this.setAccount);
            this.adminSideMenu.Controls.Add(this.setPrice);
            this.adminSideMenu.Controls.Add(this.setTrainer);
            this.adminSideMenu.Controls.Add(this.sendMessage);
            this.adminSideMenu.Controls.Add(this.adminLogoSpace);
            this.adminSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.adminSideMenu.Location = new System.Drawing.Point(0, 0);
            this.adminSideMenu.Name = "adminSideMenu";
            this.adminSideMenu.Size = new System.Drawing.Size(190, 570);
            this.adminSideMenu.TabIndex = 3;
            // 
            // closeAdminMenu
            // 
            this.closeAdminMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.closeAdminMenu.FlatAppearance.BorderSize = 0;
            this.closeAdminMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeAdminMenu.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeAdminMenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.closeAdminMenu.Image = global::gymManagement.Properties.Resources.exit1;
            this.closeAdminMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closeAdminMenu.Location = new System.Drawing.Point(0, 375);
            this.closeAdminMenu.Name = "closeAdminMenu";
            this.closeAdminMenu.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.closeAdminMenu.Size = new System.Drawing.Size(190, 70);
            this.closeAdminMenu.TabIndex = 5;
            this.closeAdminMenu.Text = "나가기";
            this.closeAdminMenu.UseVisualStyleBackColor = true;
            // 
            // setAccount
            // 
            this.setAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.setAccount.FlatAppearance.BorderSize = 0;
            this.setAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setAccount.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setAccount.ForeColor = System.Drawing.Color.Gainsboro;
            this.setAccount.Image = global::gymManagement.Properties.Resources.admin;
            this.setAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.setAccount.Location = new System.Drawing.Point(0, 305);
            this.setAccount.Name = "setAccount";
            this.setAccount.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.setAccount.Size = new System.Drawing.Size(190, 70);
            this.setAccount.TabIndex = 4;
            this.setAccount.Text = "정보수정";
            this.setAccount.UseVisualStyleBackColor = true;
            // 
            // setPrice
            // 
            this.setPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.setPrice.FlatAppearance.BorderSize = 0;
            this.setPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setPrice.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setPrice.ForeColor = System.Drawing.Color.Gainsboro;
            this.setPrice.Image = global::gymManagement.Properties.Resources.money;
            this.setPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.setPrice.Location = new System.Drawing.Point(0, 235);
            this.setPrice.Name = "setPrice";
            this.setPrice.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.setPrice.Size = new System.Drawing.Size(190, 70);
            this.setPrice.TabIndex = 3;
            this.setPrice.Text = "회원조회";
            this.setPrice.UseVisualStyleBackColor = true;
            // 
            // setTrainer
            // 
            this.setTrainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.setTrainer.FlatAppearance.BorderSize = 0;
            this.setTrainer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setTrainer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setTrainer.ForeColor = System.Drawing.Color.Gainsboro;
            this.setTrainer.Image = global::gymManagement.Properties.Resources.muscle;
            this.setTrainer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.setTrainer.Location = new System.Drawing.Point(0, 165);
            this.setTrainer.Name = "setTrainer";
            this.setTrainer.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.setTrainer.Size = new System.Drawing.Size(190, 70);
            this.setTrainer.TabIndex = 2;
            this.setTrainer.Text = "기간연장";
            this.setTrainer.UseVisualStyleBackColor = true;
            // 
            // sendMessage
            // 
            this.sendMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.sendMessage.FlatAppearance.BorderSize = 0;
            this.sendMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendMessage.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendMessage.ForeColor = System.Drawing.Color.Gainsboro;
            this.sendMessage.Image = global::gymManagement.Properties.Resources.letter;
            this.sendMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sendMessage.Location = new System.Drawing.Point(0, 95);
            this.sendMessage.Name = "sendMessage";
            this.sendMessage.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.sendMessage.Size = new System.Drawing.Size(190, 70);
            this.sendMessage.TabIndex = 1;
            this.sendMessage.Text = "신규등록";
            this.sendMessage.UseVisualStyleBackColor = true;
            // 
            // adminLogoSpace
            // 
            this.adminLogoSpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.adminLogoSpace.Controls.Add(this.adminLogo);
            this.adminLogoSpace.Dock = System.Windows.Forms.DockStyle.Top;
            this.adminLogoSpace.Location = new System.Drawing.Point(0, 0);
            this.adminLogoSpace.Name = "adminLogoSpace";
            this.adminLogoSpace.Size = new System.Drawing.Size(190, 95);
            this.adminLogoSpace.TabIndex = 0;
            // 
            // adminLogo
            // 
            this.adminLogo.Image = global::gymManagement.Properties.Resources.onGym;
            this.adminLogo.Location = new System.Drawing.Point(9, 0);
            this.adminLogo.Name = "adminLogo";
            this.adminLogo.Size = new System.Drawing.Size(172, 120);
            this.adminLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.adminLogo.TabIndex = 0;
            this.adminLogo.TabStop = false;
            // 
            // adminTitleBar
            // 
            this.adminTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.adminTitleBar.Controls.Add(this.adminTitle);
            this.adminTitleBar.Location = new System.Drawing.Point(190, 0);
            this.adminTitleBar.Name = "adminTitleBar";
            this.adminTitleBar.Size = new System.Drawing.Size(974, 95);
            this.adminTitleBar.TabIndex = 4;
            // 
            // adminTitle
            // 
            this.adminTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.adminTitle.AutoSize = true;
            this.adminTitle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminTitle.ForeColor = System.Drawing.Color.White;
            this.adminTitle.Location = new System.Drawing.Point(451, 36);
            this.adminTitle.Name = "adminTitle";
            this.adminTitle.Size = new System.Drawing.Size(74, 25);
            this.adminTitle.TabIndex = 0;
            this.adminTitle.Text = "HOME";
            this.adminTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CustomerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 570);
            this.ControlBox = false;
            this.Controls.Add(this.adminSideMenu);
            this.Controls.Add(this.adminTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CustomerMenu";
            this.adminSideMenu.ResumeLayout(false);
            this.adminLogoSpace.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adminLogo)).EndInit();
            this.adminTitleBar.ResumeLayout(false);
            this.adminTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Panel adminSideMenu;
        private System.Windows.Forms.Button closeAdminMenu;
        private System.Windows.Forms.Button setAccount;
        private System.Windows.Forms.Button setPrice;
        private System.Windows.Forms.Button setTrainer;
        private System.Windows.Forms.Button sendMessage;
        private System.Windows.Forms.Panel adminLogoSpace;
        private System.Windows.Forms.PictureBox adminLogo;
        private System.Windows.Forms.Panel adminTitleBar;
        private System.Windows.Forms.Label adminTitle;
    }
}