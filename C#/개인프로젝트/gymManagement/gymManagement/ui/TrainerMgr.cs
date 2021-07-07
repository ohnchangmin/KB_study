using gymManagement.controller;
using gymManagement.model;
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
    partial class TrainerMgr : Form
    {
        Adapter ad;
        public TrainerMgr(Adapter ad)
        {
            this.ad = ad;
            InitializeComponent();
        }

        private void TrainerMgr_Load(object sender, EventArgs e)
        {
            showList(ad.getTrainerVo());
        }
        private void showList(List<Trainer> list)
        {
            for(int i=0; i<list.Count; i++)
            {
                viewTrainer.Items.Add(new ListViewItem(new string[] { list[i].Name, list[i].Rrn, list[i].Tel, list[i].Address, list[i].JobType, list[i].Rank, list[i].Salary }));
            }
        }
    }
}
