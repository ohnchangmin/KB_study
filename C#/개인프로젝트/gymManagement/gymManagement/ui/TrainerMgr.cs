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

        private List<Trainer> insertTrainer()
        {
            string name = trainerName.Text;
            string rrn = trainerRrn1.Text + '-' + trainerRrn2.Text;
            string tel = trainerTel1.Text + '-' + trainerTel2.Text + '-' + trainerTel3.Text;
            string address = trainerAddress.Text;
            string jobType = trainerJobType.Text;
            string rank = trainerRank.Text;
            string salary = trainerSalary.Text;

            List<Trainer> list = new List<Trainer>();
            list.Add(new Trainer(name, rrn, tel, address, jobType, rank, salary));
            return list;
        }

        private void trainerInsert_Click(object sender, EventArgs e)
        {
            showList(insertTrainer());
            trainerName.Clear();
            trainerRrn1.Clear();
            trainerRrn2.Clear();
            trainerTel1.Clear();
            trainerTel2.Clear();
            trainerTel3.Clear();
            trainerAddress.Clear();
        }
    }
}
