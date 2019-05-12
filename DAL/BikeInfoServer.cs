using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class BikeInfoServer
    {
        public static object MakeCard(string icno, string bikeno, string bikeowername, string bikeowertel, string bikeoweraddr, System.DateTime icstatetime, System.DateTime icexpiretime,string icstate,string bikePhoto)
        {
            string sql = string.Format("INSERT INTO BikeInfo (icNo, bikeNo,bikeOwerName,bikeOwerTel,bikeOwerAddr,icStateTime,icExpireTime,icState,bikePhoto) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", icno, bikeno, bikeowername, bikeowertel, bikeoweraddr, icstatetime, icexpiretime,icstate,bikePhoto);
            return (int)DBHelper.ExecuteNonQuery(sql);
        }
    }
}
