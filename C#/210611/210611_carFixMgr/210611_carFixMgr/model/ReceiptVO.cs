using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _210611_carFixMgr.model
{
    class ReceiptVO
    {
        private int receiptId;
        private string indate;
        private int totalPrice;
        private string custName;
        private string staffName;
        private string carNum;

        public ReceiptVO(string indate, int totalPrice, string custName, string staffName)
        {
            this.indate = indate;
            this.totalPrice = totalPrice;
            this.custName = custName;
            this.staffName = staffName;
        }

        public ReceiptVO(int receiptId, string indate, int totalPrice, string custName, string staffName, string carNum)
        {
            this.receiptId = receiptId;
            this.indate = indate;
            this.totalPrice = totalPrice;
            this.custName = custName;
            this.staffName = staffName;
            this.carNum = carNum;
        }

        public int ReceiptId { get => receiptId; set => receiptId = value; }
        public string Indate { get => indate; set => indate = value; }
        public int TotalPrice { get => totalPrice; set => totalPrice = value; }
        public string CustName { get => custName; set => custName = value; }
        public string StaffName { get => staffName; set => staffName = value; }
        public string CarNum { get => carNum; set => carNum = value; }
    }
}
