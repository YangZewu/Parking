using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BAL
{
   public class BikeInfoManag
    {
        public static object MakeCard(string icno, string bikeno, string bikeowername, string bikeowertel, string bikeoweraddr, System.DateTime icstatetime, System.DateTime icexpiretime,string icstate,string bikePhoto,string userName)
        {
            return BikeInfoServer.MakeCard(icno, bikeno, bikeowername, bikeowertel, bikeoweraddr, icstatetime, icexpiretime,icstate, bikePhoto, userName);
            
        }
        public static SqlDataReader getDataReader(string icno)
        {
            return BikeInfoServer.getDataReader(icno);
        }
        public static SqlDataReader getType(string icno)
        {
            return BikeInfoServer.getType(icno);
        }
    }
}
