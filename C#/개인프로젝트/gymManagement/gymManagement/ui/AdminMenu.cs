using gymManagement.common;
using gymManagement.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gymManagement.ui
{
    partial class AdminMenu : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        private Adapter ad;
        ThemeColor theme = new ThemeColor();
        //private Form activeForm;

        public AdminMenu(Adapter ad)
        {
            InitializeComponent();
            this.ad = ad;
            random = new Random();
        }       
        //private Color SelectThemeColor()
        //{
        //    int index = random.Next(ThemeColor.ColorList.Count);
        //    while (tempIndex == index)
        //    {
        //        index = random.Next(ThemeColor.ColorList.Count);
        //    }
        //    tempIndex = index;
        //    string color = ThemeColor.ColorList[index];
        //    return ColorTranslator.FromHtml(color);
        //}
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = theme.SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    adminTitleBar.BackColor = color;
                    adminLogoSpace.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
//                    btnCloseChildForm.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in adminSideMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void sendMessage_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

        }

        private void setTrainer_Click(object sender, EventArgs e)
        {            
            adminTitle.Text = "트레이너 관리";
            OpenChildForm(new ui.TrainerMgr(ad), sender);       
        }

        private void setPrice_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void setAccount_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void closeAdminMenu_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
