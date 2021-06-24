using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gymManagement.model
{
    class Customer
    {
        private string name;
        private string tel;
        private string gender;
        private string birth;
        private string address;
        private string regiDate;
        private string expireDate;

        public Customer(string name, string tel, string gender, string birth, string address, string regiDate, string expireDate)
        {
            this.name = name;
            this.tel = tel;
            this.gender = gender;
            this.birth = birth;
            this.address = address;
            this.regiDate = regiDate;
            this.expireDate = expireDate;
        }

        public string Name { get => name; set => name = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Birth { get => birth; set => birth = value; }
        public string Address { get => address; set => address = value; }
        public string RegiDate { get => regiDate; set => regiDate = value; }
        public string ExpireDate { get => expireDate; set => expireDate = value; }
    }
}
