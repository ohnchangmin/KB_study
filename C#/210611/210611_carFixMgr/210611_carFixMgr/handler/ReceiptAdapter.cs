using _210611_carFixMgr.model;
using carFixMgr0611.handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _210611_carFixMgr.handler
{
    class ReceiptAdapter
    {
        private List<Receipt> receiptList = new List<Receipt>();
        private OraHandler oraHandler;

        public ReceiptAdapter(OraHandler oraHandler)
        {
            this.oraHandler = oraHandler;
        }


        public void addReceipt(Receipt recipt)
        {
            receiptList.Add(recipt);
        }

        public void addReceiptDb()
        {
            for(int i = 0; i<receiptList.Count; i++)
            {
               
            }
            receiptList.Clear();
        }

        public void viewReceipt()
        {
            for(int i =0; i<receiptList.Count; i++)
            {
                Customer cust = receiptList[i].Cust;
                Console.WriteLine("고객명: " + cust.Name);
                Console.WriteLine("연락처: " + cust.Tel);
                Console.WriteLine("생년월일: " + cust.Birth);

                Car car = receiptList[i].Car;
                Console.WriteLine("차량모델: " + car.Model);
                Console.WriteLine("차량번호: " + car.Number);
                Console.WriteLine("배기량: " + car.Cc);
                Console.WriteLine("차량연식: " + car.Year);


                Console.WriteLine("접수일: " + receiptList[i].InDate);
                Console.WriteLine("담당자: " + receiptList[i].StaffName);
                
                List<RepairItem> itemList = receiptList[i].ItemList;
                for(int j = 0; j<itemList.Count; j++)
                {
                    Console.WriteLine("수리번호: " + itemList[j].Idx);
                    Console.WriteLine("수리항목: " + itemList[j].Repair);
                    Console.WriteLine("수리비용: " + itemList[j].Price);
                }


            }    
        }
    }
}
