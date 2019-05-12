using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UsersServer
    {
        public static int countByNamePwd(string name, string pwd)
        {
            string sql = string.Format("SELECT count(*) FROM Users where userName='{0}' and passWord='{1}'", name, pwd);
            return (int)DBHelper.executeScalar(sql);
        }
        //注册用户1
        public static int Reg(string name,string pwd,string type,string telephone)
        {
            string sql = string.Format("INSERT INTO Users (userName, passWord,userType,telePhone) VALUES ('{0}','{1}','{2}','{3}')",name,pwd,type,telephone); 
            return (int)DBHelper.ExecuteNonQuery(sql);
        }
        //判断是否相同用户名
        public static int CheckName(string name)
        {
            string sql = string.Format("SELECT count(*) FROM Users where userName='{0}'",name);
            return (int)DBHelper.executeScalar(sql);
        }
    }
}
