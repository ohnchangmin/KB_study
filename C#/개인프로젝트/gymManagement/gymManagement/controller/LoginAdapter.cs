using gymManagement.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gymManagement.controller
{
    class LoginAdapter
    {
        private Login login = new Login();
        private OraController orc;
        public LoginAdapter(OraController orc)
        {
            this.orc = orc;
        }
        public Login getLoginVo(string loginId, string loginPw)
        {
          Login login = orc.getLoginDb(loginId, loginPw);
          return login;
        }
    }
}
