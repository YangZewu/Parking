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
            string sql = string.Format("SELECT count(*) FROM SpaceInfo where spaceType='{0}' and ICCardNo is null", type);
            return (int)DBHelper.executeScalar(sql);
        }
    }
}
