using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BAL
{
   public class BikeInfoManag
    {
        public static object MakeCard(string icno, string bikeno, string bikeowername, string bikeowertel, string bikeoweraddr, System.DateTime icstatetime, System.DateTime icexpiretime,string icstate,string bikePhoto)
        {
            return BikeInfoServer.MakeCard(icno, bikeno, bikeowername, bikeowertel, bikeoweraddr, icstatetime, icexpiretime,icstate, bikePhoto);
            
        }
    }
}
