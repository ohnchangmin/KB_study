using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gymManagement.common
{
    class Login
    {
        private string id;
        private string password;

        public Login()
        {
        }

        public Login(string id, string password)
        {
            this.id = id;
            this.password = password;
        }
        public string Id { get => id; set => id = value; }
        public string Password { get => password; set => password = value; }
    }
}
