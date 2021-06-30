﻿using gymManagement.controller;
using gymManagement.ui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gymManagement
{
    public partial class MainMenu : MetroFramework.Forms.MetroForm
    {
        OraController orc;
        LoginAdapter la;
        public MainMenu()
        {
            InitializeComponent();
            orc = new OraController();
            la = new LoginAdapter(orc);
        }

        private void gymNewCus_Click(object sender, EventArgs e)
        {
            new NewRegi().ShowDialog();
        }

        private void MainAdmin_Click(object sender, EventArgs e)
        {
            new LoginMenu(la).ShowDialog();
        }
    }
}
