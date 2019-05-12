using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParKing
{
    public class IpConfig
    {
        private static string ip;

        public static string Ip
        {
            get
            {
                return ip;
            }

            set
            {
                ip = value;
            }
        }
    }
}
