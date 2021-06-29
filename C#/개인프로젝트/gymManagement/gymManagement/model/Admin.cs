using gymManagement.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gymManagement.model
{
    class Admin
    {
        Login login;
        private string name;
        private string rrn;
        private string tel;

        public Admin(Login login, string name, string rrn, string tel)
        {
            this.login = login;
            this.name = name;
            this.rrn = rrn;
            this.tel = tel;
        }

        public string Name { get => name; set => name = value; }
        public string Rrn { get => rrn; set => rrn = value; }
        public string Tel { get => tel; set => tel = value; }
        internal Login Login { get => login; set => login = value; }
    }
}
