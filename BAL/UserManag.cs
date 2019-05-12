using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BAL
{
    public class UserManag
    {
        public static int countByNamePwd(string name, string pwd)
        {
            return UsersServer.countByNamePwd(name, pwd);
        }

        //注册用户2
        public static int Reg(string name, string pwd, string type, string telphone)
        {
            return UsersServer.Reg(name, pwd, type, telphone);
        }
        public static int CheckName(string name)
        {
            return UsersServer.CheckName(name);
        }
    }
}
