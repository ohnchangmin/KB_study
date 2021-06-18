using _210611_carFixMgr.handler;
using _210611_carFixMgr.model;
using _210611_carFixMgr.utill;
using MaterialSkin.Controls;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _210611_carFixMgr.ui
{
    partial class ReceiptAdd : MaterialForm
    {
        ReceiptAdapter adapter;
        public ReceiptAdd()
        {
            InitializeComponent();
        }

        public ReceiptAdd(ReceiptAdapter adapter)
        {
            InitializeComponent();
            this.adapter = adapter;
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

            /*bool[] repairBool = { chk1.Checked, chk2.Checked, chk3.Checked, chk4.Checked, chk5.Checked,
                chk6.Checked, chk7.Checked, chk8.Checked, chk9.Checked, chk10.Checked };
            string[] repairText = {chk1.Text, chk2.Text, chk2.Text, chk3.Text, chk4.Text, chk5.Text,
                chk6.Text, chk7.Text, chk8.Text, chk9.Text, chk10.Text};
            */


            string[] arrData = new string[]
            {
                name, telH, telB, year, month, day, model, number, cc, caryear, staff
            };

            object[] arrObj = new object[]
            {
                custName, custTelHead, custTelBody, custYear, custMonth,
                custDay, carModel, carNum, carCC, carYear, staffName
            };

            string[] arrMsg = new string[]
            {
                "이름을 입력하세요.", "전화번호 앞자리를 선택하세요.", "전화번호 뒷자리를 입력하세요.", "출생년도를 선택하세요."
                ,"출생달을 선택하세요.", "출생일을 입력하세요.", "차량 모델을 선택하세요.",
                "차량번호를 입력하세요.", "배기량을 선택하세요."
                , "차량연식을 선택하세요.", "담당자를 선택하세요."
            };

#if !DEBUG
            for (int i = 0; i < arrData.Length; i++)
            {
                if (arrData[i].Equals("") || arrData[i].Equals("선택"))
                {
                    MessageBox.Show(arrMsg[i], "정보 입력 오류");
                    ActiveControl = (Control)arrObj[i];
                    //ActiveControl = arrObj[i] as Control;
                    ActiveControl.Focus();
                    return;
                }
            }
#endif

            Dictionary<Object, string> dicInput = new Dictionary<Object, string>();
            for (int i = 0; i<arrData.Length; i++)
            {
                dicInput.Add(arrObj[i], arrData[i]);
            }

            int cnt = 0;
            foreach(KeyValuePair<object, string> item in dicInput)
            {
                if(item.Value.Equals("") || item.Value.Equals("선택"))
                {
                    setFocus(item.Key as Control, arrMsg[cnt]);
                    return;
                }
                cnt++;
            }

            UICheckBox[] checkBox = new UICheckBox[]
            {
                chk1, chk2, chk3, chk4, chk5, chk6, chk7, chk8, chk9, chk10
            };

            List<RepairItem> repairList = new List<RepairItem>();

            for (int i = RepairTable.ENGINE_OIL; i <= RepairTable.ETC_COST; i++)
            {
                if (checkBox[i].Checked)
                {
                    repairList.Add(new RepairItem(i, checkBox[i].Text, RepairTable.fixMoney[i]));
                    //RepairItem repairitem = new RepairItem(i, checkBox[i].Text, RepairTable.fixMoney[i]);
                    //Console.WriteLine("수리항목: " + checkBox[i].Text);
                    //Console.WriteLine("수리비: " + RepairTable.fixMoney[i]);
                }
            }


            if (repairList.Count == 0)
            {
                MessageBox.Show("수리 항목을 하나 이상 체크하세요", "정보 입력 오류");
                return;
            }

            // 한글 입력 체크
            Regex regex = new Regex(@"^[가-힣]{2,4}$");
            Match m = regex.Match(name);
            if (m.Success == false)
            {
                setFocus(custName, Properties.Resources.ERR_NAME_WRONG);
                return;
            }

            

            //if (chk1.Checked == false && chk2.Checked == false && chk3.Checked == false &&
            //    chk4.Checked == false && chk5.Checked == false && chk6.Checked == false &&
            //        chk7.Checked == false && chk8.Checked == false && chk9.Checked == false &&
            //        chk10.Checked == false)
            //{
            //    MessageBox.Show("수리 항목을 하나 이상 선택하세요", "수리 항목 선택", MessageBoxButtons.OK);
            //}

            //else
            //{




            /*
            //자리수 체크
            Regex regex = new Regex(@"[가-힣]{3}");
            Match m = regex.Match(name);
            if (m.Success == false)
            {
                setFocus(custName, Properties.Resources.ERR_NAME_LENGTH);
                return;
            }
            */

            string telAll = telH + telB;
            
            if (telAll.Length == 10 || telAll.Length == 11)
            {
                Regex regex2 = new Regex(@"01{1}[01]{1}[0-9]{7,8}$");
                Match m2 = regex2.Match(telAll);
                if(m2.Success == false)
                {
                    MessageBox.Show("잘못된 전화번호");
                    return;
                }
            }
            else
            {
                MessageBox.Show("올바른 전화번호 자리수를 입력하세요.");
                return;
            }

            //Console.WriteLine("이름: " + name);
            //Console.WriteLine("연락처: " + telH + telB);
            //Console.WriteLine("생년월일: " + year + "-" + month + "-" + day);
            //Console.WriteLine("차량모델: " + model);
            //Console.WriteLine("차량번호: " + number);
            //Console.WriteLine("배기량: " + cc);
            //Console.WriteLine("차량연식: " + caryear);
            //Console.WriteLine("담당자: " + staff);
            //Console.Write("수리항목: ");
            //Console.WriteLine();

            /*for (int i = 0; i < repairBool.Length; i++)
            {
                if (repairBool[i] == true)
                {
                    Console.Write(repairText[i] + " ");
                }
            }*/

            //Receipt receipt = new Receipt(new Customer(name, telH + telB, year + "-" + month + "-" + day),
            //                                new Car(model, number, cc, caryear), DateTime.Now.ToString(),
            //                                staff, repairList);

            //ReceiptAdapter ra = new ReceiptAdapter();
            //ra.addReceipt(receipt);

            adapter.addReceipt(new Receipt(new Customer(name, telH + telB, year + "-" + month + "-" + day),
                                            (new Car(model, number, cc, caryear)),
                                            DateTime.Now.ToString("yyyy년MM월dd일"), staff, repairList));

            Close();
        }

        private void setFocus(Control cont, string msg)
        {
            MessageBox.Show(msg);
            ActiveControl = cont;
            ActiveControl.Focus();
            cont.Text = "";

        }

        private void receiptClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
