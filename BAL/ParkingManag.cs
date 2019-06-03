using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BAL
{
    public class ParkingManag
    {
        public static int insertParking(string ICCardNo, string BikeType, string enterTime)
        {
            return ParkingServer.insertParking(ICCardNo,BikeType,enterTime);
        }
    }
}
