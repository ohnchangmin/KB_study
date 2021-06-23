﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _210611_carFixMgr.model
{
    class Receipt
    {
        private Customer cust;
        private Car car;
        private string inDate;
        private string staffName;
        private List<RepairItem> itemList;
        private int totalPrice;

        public Receipt(Customer cust, Car car, string inDate, string staffName, List<RepairItem> itemList)
        {
            this.cust = cust;
            this.car = car;
            this.inDate = inDate;
            this.staffName = staffName;
            this.itemList = itemList;
        }

        public Receipt(Customer cust, Car car, string inDate, string staffName, List<RepairItem> itemList, int totalPrice)
        {
            this.cust = cust;
            this.car = car;
            this.inDate = inDate;
            this.staffName = staffName;
            this.itemList = itemList;
            this.totalPrice = totalPrice;
        }

        public string InDate { get => inDate; set => inDate = value; }
        public string StaffName { get => staffName; set => staffName = value; }
        internal Customer Cust { get => cust; set => cust = value; }
        internal Car Car { get => car; set => car = value; }
        internal List<RepairItem> ItemList { get => itemList; set => itemList = value; }
        public int TotalPrice { get => totalPrice; set => totalPrice = value; }
    }
}
