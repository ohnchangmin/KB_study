using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gymManagement.model
{
    class Admin
    {
        private string id;
        private string password;
        private string name;
        private string rrn;
        private string tel;

        public Admin(string id, string password, string name, string rrn, string tel)
        {
            this.id = id;
            this.password = password;
            this.name = name;
            this.rrn = rrn;
            this.tel = tel;
        }

        public string Id { get => id; set => id = value; }
        public string Password { get => password; set => password = value; }
        public string Name { get => name; set => name = value; }
        public string Rrn { get => rrn; set => rrn = value; }
        public string Tel { get => tel; set => tel = value; }
    }
}
