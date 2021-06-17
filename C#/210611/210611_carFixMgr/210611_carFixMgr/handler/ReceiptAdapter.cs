using _210611_carFixMgr.model;
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


        public void addReceipt(Receipt recipt)
        {
            receiptList.Add(recipt);
        }

        public void viewReceipt()
        {
            dataGridView1.DataSource = receiptList;
        }
    }
}
