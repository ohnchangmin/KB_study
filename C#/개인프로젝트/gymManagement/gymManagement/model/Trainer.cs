using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gymManagement.model
{
    class Trainer
    {
        private string name;
        private string rrn;
        private string tel;
        private string address;
        private string jobType;
        private string rank;
        private string salary;

        public Trainer(string name, string rrn, string tel, string address, string jobType, string rank, string salary)
        {
            this.name = name;
            this.rrn = rrn;
            this.tel = tel;
            this.address = address;
            this.jobType = jobType;
            this.rank = rank;
            this.salary = salary;
        }

        public string Name { get => name; set => name = value; }
        public string Rrn { get => rrn; set => rrn = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Address { get => address; set => address = value; }
        public string JobType { get => jobType; set => jobType = value; }
        public string Rank { get => rank; set => rank = value; }
        public string Salary { get => salary; set => salary = value; }
    }
}
