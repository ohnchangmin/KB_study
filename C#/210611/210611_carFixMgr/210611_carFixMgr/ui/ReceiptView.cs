using _210611_carFixMgr.handler;
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

namespace _210611_carFixMgr.ui
{
    partial class ReceiptView : MaterialForm
    {
        private ReceiptAdapter adapter;

        public ReceiptView()
        {
            InitializeComponent();
        }

        public ReceiptView(ReceiptAdapter adapter)
        {
            InitializeComponent();
            this.adapter = adapter;
            initList();
        }

        public void initList()
        {
            string strPrice = string.Format("{0:#,0}원", 120000);
            string[] data = { "1", "2021년6월24일", strPrice, "숭당당", "고객객" };
            viewList.Items.Add(new ListViewItem(data));

            for(int i=0; i<50; i++)
            {
                viewList.Items.Add(new ListViewItem(
                    new string[]
                    {(i+2).ToString(), "2021년6월24일", strPrice, "숭당당", "고객객" }));
            }
        }
        

        private void viewClose_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
