using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL
{
    public class ParkingServer
    {
        public static int insertParking(string ICCardNo, string BikeType, string enterTime)
        {
            string sql = string.Format("insert into ParkingInfo (ICCardNo,BikeType,enterTime) values('{0}','{1}','{2}')",ICCardNo,BikeType,enterTime);
            return (int)DBHelper.ExecuteNonQuery(sql);
        }
    }
}
