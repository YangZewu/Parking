using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
namespace parking
{
    public class DCHelper
    {
        //初始化
        [DllImport("dcrf32.dll")]
        public static extern int dc_init(int port, int baud);
        //蜂鸣
        [DllImport("dcrf32.dll")]
        public static extern int dc_beep(int icdev, int _Msec);

        [DllImport("dcrf32.dll")]
        public static extern int dc_card(int icdev, int _Mode, ref long _Snr);    //寻卡

        [DllImport("dcrf32.dll")]
        public static extern int dc_load_key(int icdev, int _Mode, int _SecNr, byte[] _NKey);  //装载密码

        [DllImport("dcrf32.dll")]
        public static extern int dc_authentication(int icdev, int _Mode, int _SecNr);   //验证密码

        [DllImport("dcrf32.dll")]
        public static extern int dc_read(int icdev, int _Adr, byte[] _Data);   //读卡

        [DllImport("dcrf32.dll")]
        public static extern int dc_write(int icdev, int _Adr, string[] _Data);   //写卡
    }
}
