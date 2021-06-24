using _210611_carFixMgr.common;
using _210611_carFixMgr.handler;
using _210611_carFixMgr.ui;
using carFixMgr0611.handler;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _210611_carFixMgr
{
    public partial class MainForm : MaterialForm
    {
        OraHandler oraHandler;
        ReceiptAdapter adapter;
       
        public MainForm()
        {
            InitializeComponent();
            CommUtill.initTheme(this);
            oraHandler = new OraHandler();
            adapter = new ReceiptAdapter(oraHandler);
        }

        private void mainExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void custFixAdd_Click(object sender, EventArgs e)
        {
            new ReceiptAdd(adapter).ShowDialog();
            adapter.addReceiptDb();
            //oraHandler.insertDB(null);
        }

        private void custFixView_Click(object sender, EventArgs e)
        {
            new ReceiptView(adapter).ShowDialog();
            //adapter.viewReceiptDb(oraHandler);
        }

        private void custFixAddmin_Click(object sender, EventArgs e)
        {

        }

        private void custFixRand_Click(object sender, EventArgs e)
        {

        }

        private void custFixInfo_Click(object sender, EventArgs e)
        {

        }

        private void mainMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
