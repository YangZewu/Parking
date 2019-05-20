using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BAL;
using ParKing;
using System.IO;

namespace parking
{
    public partial class Login : Form
    {
        string inipath;
        /// <summary>
        /// 在1.0.1的基础上增加了用户登录功能，并可正常使用。
        /// </summary>
        public Login()
        {
            InitializeComponent();
        }
        //登录事件调用
        private void Btn_Login(object sender, EventArgs e)
        {
            Login_login();
        }
        //用户登录
        private void Login_login()
        {
            int i = UserManag.countByNamePwd(username.Text, userpwd.Text);
            if (i > 0)
            {
                if (!File.Exists(inipath))
                {
                    File.Create(inipath);
                }
                userInfo.Username = username.Text;
                OperaIniFile.SetValue("数据库服务器地址", "address", ip.Text, inipath);
                MessageBox.Show("恭喜你登录成功！");
                MianFrm mainfm = new MianFrm();
                mainfm.ShowDialog();
                //this.Close();
                //mainfm.ShowDialog();

            }
            else
            {
                MessageBox.Show("用户名或密码错误，请核对后重新输入");
                username.Text = "";
                userpwd.Text = "";
            }
        }

        private void BtnClose(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            IpConfig.Ip = ip.Text;
            string directory = System.AppDomain.CurrentDomain.BaseDirectory;  //  获取基目录，程序集所在的目录
            inipath = Path.Combine(directory, "config.ini");
            ip.Text = OperaIniFile.GetValue("数据库服务器地址", "address", inipath);
        }

        private void Btn_Reg(object sender, EventArgs e)
        {
            Reg reg = new Reg();
            reg.ShowDialog();
        }
    }
}
