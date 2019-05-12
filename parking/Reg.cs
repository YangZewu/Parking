using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;

namespace parking
{
    public partial class Reg : Form
    {
        /// <summary>
        /// 在1.0.2的基础上增加了用户注册的功能，并可正常使用
        /// </summary>
        public Reg()
        {
            InitializeComponent();
        }
        //调用注册方法
        private void RegBtn_Click(object sender, EventArgs e)
        {
            Nonull(); 
            Type();
        }

        //判断是否为空
        private void Nonull()
        {
            if (RegName.Text == "" && RegPwd.Text == "" && RegTel.Text == "")
            {
                MessageBox.Show("注册信息不能为空！");
            }
        }
        //注册用方法
        private void Type()
        {
            if (RegOperator.Checked == true)
            {
                int i = UserManag.Reg(RegName.Text, RegPwd.Text, RegOperator.Text, RegTel.Text);
                if (i > 0)
                {
                    MessageBox.Show("注册成功！");

                    int icdev;
                    icdev = DCHelper.dc_init(100, 115200);
                    for(int x=0;x<3;x++)
                        DCHelper.dc_beep(icdev, 100);
                }
            }
            else if (RegMent.Checked == true)
            {

                int i = UserManag.Reg(RegName.Text, RegPwd.Text, RegMent.Text, RegTel.Text);
                if (i>0)
                {
                    MessageBox.Show("注册成功！");
                    int icdev;
                    icdev = DCHelper.dc_init(100, 115200);
                    for (int x = 0; x < 3; x++)
                        DCHelper.dc_beep(icdev, 100);
                }

            }
            else
            {
                MessageBox.Show("请选择您的身份！");
            }
        }
        //判断用户名是否重复
        private void cheakname(object sender, KeyEventArgs e)
        {
            int i = UserManag.CheckName(RegName.Text);
            if (i > 0)
            {
                cheakName.Text = "用户名重复，请重新输入！";
                RegBtn.Enabled = false;
            }
            else
            {
                cheakName.Text = "用户名可以使用！";
                RegBtn.Enabled = true;
            }
        }
        //关闭注册
        private void RegCal_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //private void button1_Click(object sender, EventArgs e)
        //{
        //    int icdev;

        //    icdev = DCHelper.dc_init(100,115200);
        //    DCHelper.dc_beep(icdev,3);

        //}


    }
}
