using _210611_carFixMgr.common;
using _210611_carFixMgr.handler;
using _210611_carFixMgr.model;
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
        }

        public void initList()
        {
            string strPrice = string.Format("{0:#,0}원", 120000);
            string[] data = { "1", "2021년6월24일", strPrice, "숭당당", "고객객" };
            viewList.Items.Add(new ListViewItem(data));

            for (int i = 0; i < 50; i++)
            {
                viewList.Items.Add(new ListViewItem(
                    new string[]
                    {(i+2).ToString(), "2021년6월24일", strPrice, "숭당당", "고객객" }));
            }
        }

        public void initList(List<ReceiptVO> listReceiptVO)
        {
            for (int i = 0; i < listReceiptVO.Count; i++)
            {
                string strPrice = string.Format("{0:#,0}원", listReceiptVO[i].TotalPrice);
                viewList.Items.Add(new ListViewItem(
                    new string[]
                    {(i+1).ToString(), listReceiptVO[i].Indate, strPrice, listReceiptVO[i].StaffName, listReceiptVO[i].CustName}));
            }
            CommUtill.setRowColor(viewList, Color.WhiteSmoke, Color.White);
            int index = viewList.Items.Count - 1;
            viewList.Items[index].Selected = true;
            viewList.Items[index].Focused = true;
            viewList.EnsureVisible(index);
        }

        //public void initList(List<RepairItem> listRepairItem)
        //{
        //    for (int i = 0; i < listRepairItem.Count; i++)
        //    {
        //        string strPrice = string.Format("{0:#,0}원", listRepairItem[i].Price);
        //        Console.WriteLine("번호: " + listRepairItem[i].Idx);
        //        Console.WriteLine("수리항목: " + listRepairItem[i].Repair);
        //        Console.WriteLine("수리비: " + strPrice);
        //    }
        //    CommUtill.setRowColor(viewList, Color.WhiteSmoke, Color.White);
        //}

        public void initGrid(List<RepairItem> listRepairItem)
        { 
            for (int i = 0; i < listRepairItem.Count; i++)
            {
                string strPrice = string.Format("{0:#,0}원", listRepairItem[i].Price);
                viewGrid.Rows.Add(new string[]
                    {
                        (i+1).ToString(), listRepairItem[i].Repair.ToString(), strPrice
                    });
            }
            int count = viewGrid.Rows.Count - 1;
            viewGrid.FirstDisplayedScrollingRowIndex = count;
            viewGrid.CurrentCell = viewGrid.Rows[count - 1].Cells[0];
        }


        private void viewClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ReceiptView_Load(object sender, EventArgs e)
        {
            CommUtill.colorListViewHeader(ref viewList, Color.Gray, Color.White);
            List<ReceiptVO> listReceiptVO = adapter.getReceiptDb();
            initList(listReceiptVO);
        }

        private void viewList_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewGrid.ClearRows();

            if (viewList.SelectedItems.Count != 0)
            {
                int n = viewList.SelectedItems[0].Index;
                string num = viewList.Items[n].SubItems[0].Text;
                string date = viewList.Items[n].SubItems[1].Text;
                string price = viewList.Items[n].SubItems[2].Text;
                string staff = viewList.Items[n].SubItems[3].Text;
                string cust = viewList.Items[n].SubItems[4].Text;
                //Console.WriteLine("번호: " + num);
                //Console.WriteLine("접수날짜: " + date);
                //Console.WriteLine("총결제금액: " + price);
                //Console.WriteLine("담당자: " + staff);
                //Console.WriteLine("고객명: " + cust);

                List<RepairItem> list = adapter.GetRepairItemsDb(cust);
                initGrid(list);

                //for (int i = 0; i < list.Count; i++)
                //{
                //    Console.WriteLine("수리항목: " + list[i].Repair);
                //    Console.WriteLine("수리비: " + list[i].Price);
                //}

            }
        }

        
    }
}
