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

            if (name.Equals("") || name.Equals(null))
            {
                Console.WriteLine("이름을 입력해주세요");
                ActiveControl = trainerName;
            }
            else if (trainerRrn1.Text.Equals("") || trainerRrn1.Text.Equals(null))
            {
                Console.WriteLine("주민등록번호 앞자리를 입력해주세요");
                ActiveControl = trainerRrn1;
            }
            else if (trainerRrn2.Text.Equals("") || trainerRrn2.Text.Equals(null))
            {
                Console.WriteLine("주민등록번호 뒷자리를 입력해주세요");
                ActiveControl = trainerRrn2;
            }
            else if (trainerTel1.Text.Equals("") || trainerTel1.Text.Equals(null))
            {
                Console.WriteLine("전화번호를 입력해주세요");
                ActiveControl = trainerTel1;
            }
            else if (trainerTel2.Text.Equals("") || trainerTel2.Text.Equals(null))
            {
                Console.WriteLine("전화번호를 입력해주세요");
                ActiveControl = trainerTel2;
            }
            else if (trainerTel3.Text.Equals("") || trainerTel3.Text.Equals(null))
            {
                Console.WriteLine("전화번호를 입력해주세요");
                ActiveControl = trainerTel3;
            }
            else if (jobType.Equals("") || jobType.Equals(null))
            {
                Console.WriteLine("근로형태를 입력해주세요");
                ActiveControl = trainerJobType;
            }
            else if (address.Equals("") || address.Equals(null))
            {
                Console.WriteLine("주소를 입력해주세요");
                ActiveControl = trainerAddress;
            }
            else if (rank.Equals("") || rank.Equals(null))
            {
                Console.WriteLine("직급을 입력해주세요");
                ActiveControl = trainerRank;
            }
            else if (salary.Equals("") || salary.Equals(null))
            {
                Console.WriteLine("급여를 입력해주세요");
                ActiveControl = trainerSalary;
            }
            else
            {
                list.Add(new Trainer(name, rrn, tel, address, jobType, rank, salary));
                textBoxClear();
            }
            return list;
        }

        private void textBoxClear()
        {
            TextBox[] arr = {trainerName, trainerRrn1, trainerRrn2, trainerTel1, trainerTel2, trainerTel3,
                            trainerAddress, trainerJobType, trainerRank, trainerSalary};

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].Clear();
            }
        }

        private void trainerInsert_Click(object sender, EventArgs e)
        {
            showList(insertTrainer());            
        }
    }
}
