using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gymManagement.model
{
    class Pt
    {
        Customer customer;
        Trainer trainer;
        private string price;
        private string times;

        public Pt(Customer customer, Trainer trainer, string price, string times)
        {
            this.customer = customer;
            this.trainer = trainer;
            this.price = price;
            this.times = times;
        }

        public string Price { get => price; set => price = value; }
        public string Times { get => times; set => times = value; }
        internal Customer Customer { get => customer; set => customer = value; }
        internal Trainer Trainer { get => trainer; set => trainer = value; }
    }
}
