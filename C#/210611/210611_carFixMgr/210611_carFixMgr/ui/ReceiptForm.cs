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
    public partial class ReceiptForm : MaterialForm
    {
        public ReceiptForm()
        {
            InitializeComponent();
        }

        private void receiptSave_Click(object sender, EventArgs e)
        {
            string name = custName.Text;
            string telH = custTelHead.SelectedText;
            string telB = custTelBody.Text;
            string year = custYear.SelectedText;
            string month = custMonth.SelectedText;
            string day = custDay.SelectedText;
            string model = carModel.SelectedText;
            string number = carNum.Text;
            string cc = carCC.SelectedText;
            string caryear = carYear.SelectedText;
            string staff = staffName.SelectedText;
            bool[] repairBool = { chk1.Checked, chk2.Checked, chk3.Checked, chk4.Checked, chk5.Checked,
                chk6.Checked, chk7.Checked, chk8.Checked, chk9.Checked, chk10.Checked };
            string[] repairText = {chk1.Text, chk2.Text, chk2.Text, chk3.Text, chk4.Text, chk5.Text,
                chk6.Text, chk7.Text, chk8.Text, chk9.Text, chk10.Text};

            if (name.Equals(""))
            {
                MessageBox.Show("고객 이름 정보가 누락되었습니다.", "고객 정보 입력", MessageBoxButtons.OK);
                custName.Focus();
            }

            else if(telH.Equals(""))
            {
                MessageBox.Show("고객 연락처 정보가 누락되었습니다.", "고객 정보 입력", MessageBoxButtons.OK);
                custTelHead.Focus();
            }

            else if (telB.Equals(""))
            {
                MessageBox.Show("고객 연락처 정보가 누락되었습니다.", "고객 정보 입력", MessageBoxButtons.OK);
                custTelBody.Focus();
            }

            else if (year.Equals(""))
            {
                MessageBox.Show("고객 생일 정보가 누락되었습니다.", "고객 정보 입력", MessageBoxButtons.OK);
                custYear.Focus();
            }

            else if (month.Equals(""))
            {
                MessageBox.Show("고객 생일 정보가 누락되었습니다.", "고객 정보 입력", MessageBoxButtons.OK);
                custMonth.Focus();
            }

            else if (day.Equals(""))
            {
                MessageBox.Show("고객 생일 정보가 누락되었습니다.", "고객 정보 입력", MessageBoxButtons.OK);
                custDay.Focus();
            }

            else if (model.Equals(""))
            {
                MessageBox.Show("차량 모델 정보가 누락되었습니다.", "차량 정보 입력", MessageBoxButtons.OK);
                carModel.Focus();
            }

            else if (number.Equals(""))
            {
                MessageBox.Show("차량 번호 정보가 누락되었습니다.", "차량 정보 입력", MessageBoxButtons.OK);
                carNum.Focus();
            }

            else if (cc.Equals(""))
            {
                MessageBox.Show("차량 출력 정보가 누락되었습니다.", "차량 정보 입력", MessageBoxButtons.OK);
                carCC.Focus();
            }

            else if (year.Equals(""))
            {
                MessageBox.Show("차량 연식 정보가 누락되었습니다.", "차량 정보 입력", MessageBoxButtons.OK);
                carYear.Focus();
            }

            else if (staff.Equals(""))
            {
                MessageBox.Show("담당자 정보가 누락되었습니다.", "담당자 정보 입력", MessageBoxButtons.OK);
                staffName.Focus();
            }


            else
            {
                if (chk1.Checked == false && chk2.Checked == false && chk3.Checked == false &&
                    chk4.Checked == false && chk5.Checked == false && chk6.Checked == false &&
                        chk7.Checked == false && chk8.Checked == false && chk9.Checked == false &&
                        chk10.Checked == false)
                {
                    MessageBox.Show("수리 항목을 하나 이상 선택하세요", "수리 항목 선택", MessageBoxButtons.OK);
                }

                else
                {
                    Console.WriteLine("이름: " + name);
                    Console.WriteLine("연락처: " + telH + telB);
                    Console.WriteLine("생년월일: " + year + "-" + month + "-" + day);
                    Console.WriteLine("차량모델: " + model);
                    Console.WriteLine("차량번호: " + number);
                    Console.WriteLine("배기량: " + cc);
                    Console.WriteLine("차량연식: " + caryear);
                    Console.WriteLine("담당자: " + staff);
                    Console.Write("수리항목: ");


                    for (int i = 0; i < repairBool.Length; i++)
                    {
                        if (repairBool[i] == true)
                        {
                            Console.Write(repairText[i] + " ");
                        }
                    }

                    Console.WriteLine();
                    Close();
                }
            }
        }

        private void receiptClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
