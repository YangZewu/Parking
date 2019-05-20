using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class SpaceInfoServer
    {
        public static object getSpaceByType(string type)
        {
            string sql = string.Format("SELECT count(*) FROM SpaceInfo where ICCardNo is NULL and spaceType='{0}' ", type);
            return (int)DBHelper.executeScalar(sql);
        }
        public static object updateSpaceInfo(string icon, string type)
        {
            string sql = string.Format("set rowcount 1 update spaceinfo set ICCardNo='{0}' where ICCardNo is null and spaceType='{1}'", icon, type);
            return (int)DBHelper.ExecuteNonQuery(sql);
        }
    }
}
