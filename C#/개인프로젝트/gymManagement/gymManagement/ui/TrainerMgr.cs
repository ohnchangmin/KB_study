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
            TextBox[] arr = {trainerName, trainerRrn1, trainerRrn2, trainerTel1, trainerTel2, trainerTel3,
                            trainerAddress, trainerJobType, trainerRank, trainerSalary};
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

        private void insertFormClear(TextBox[] arr)
        {
            /*TextBox[] arr = {trainerName, trainerRrn1, trainerRrn2, trainerTel1, trainerTel2, trainerTel3,
                            trainerAddress, trainerJobType, trainerRank, trainerSalary};*/

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].Clear();
            }
        }

       /* private void initTextBox()
        {
            TextBox[] arr = {trainerName, trainerRrn1, trainerRrn2, trainerTel1, trainerTel2, trainerTel3,
                            trainerAddress, trainerJobType, trainerRank, trainerSalary};
        }*/

        private void trainerInsert_Click(object sender, EventArgs e)
        {
            showList(insertTrainer());
            insertFormClear();
        }
    }
}
