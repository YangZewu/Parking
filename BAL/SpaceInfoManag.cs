using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BAL
{
    public class SpaceInfoManag
    {
        public static object getSpaceByType(string type)
        {
            return SpaceInfoServer.getSpaceByType(type);
        }
        public static object updateSpaceInfo(string icon, string type)
        {
            return SpaceInfoServer.updateSpaceInfo(icon,type);
        }
    }
}
