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
    public partial class LoginMenu : Form
    {
        private OraController orc;
        public LoginMenu()
        {
            InitializeComponent();

        }

        public LoginMenu(OraController orc)
        {
            InitializeComponent();
            this.orc = orc;
            orc.showDb();
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
