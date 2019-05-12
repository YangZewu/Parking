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
using System.IO;
namespace parking
{
    /// <summary>
    /// 在1.0.3的基础上增加了发卡的功能，目前还不能插入图片
    /// </summary>
    public partial class MakeCardFrm : Form
    {
        public MakeCardFrm()
        {
            InitializeComponent();
        }

        private void MakeCardFrm_Load(object sender, EventArgs e)
        {
            int snum, tnum;//snum=固定，tnum=临时
            snum=(int)SpaceInfoManag.getSpaceByType("固定");
            tnum=(int)SpaceInfoManag.getSpaceByType("临时");
            MessageBox.Show("固定车位"+snum+"个，临时车位"+tnum+"个");
            icNo.Text = System.DateTime.Now.ToString("yyyymddhhmmss");
        }
        //调用方法
        private void btnMakeCard_Click(object sender, EventArgs e)
        {
            NoNull();
            MakeCard();
        }
        //发卡
        private void MakeCard()
        {
            if (state1.Checked == true)
            {
                int i = (int)BikeInfoManag.MakeCard(icNo.Text, bikeNo.Text, bikeOwerName.Text, bikeOwerTel.Text, bikeOwerAddr.Text, icStateTime.Value, icExpireTime.Value, state1.Text, ".\\image\\" + bikeNo.Text + ".jpg");
                if (i > 0)
                {
                    MessageBox.Show("发卡成功");
                }
            }
            else if (state2.Checked == true)
            {
                int i = (int)BikeInfoManag.MakeCard(icNo.Text, bikeNo.Text, bikeOwerName.Text, bikeOwerTel.Text, bikeOwerAddr.Text, icStateTime.Value, icExpireTime.Value, state2.Text, ".\\image\\" + bikeNo.Text + ".jpg");
                if (i > 0)
                {
                    MessageBox.Show("发卡成功");
                }
            }
            else
            {
                MessageBox.Show("请选择身份");
            }
               
        }
        //判断空值
        private void NoNull()
        {
            if (icNo.Text == "" && bikeNo.Text == "" && bikeOwerName.Text == "" && bikeOwerTel.Text == "" && bikeOwerAddr.Text == "")
            {
                MessageBox.Show("车主信息不能为空！");
            }
        }

        private void MakeCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //弹出对话框
            OpenFileDialog open = new OpenFileDialog();
            DialogResult r = open.ShowDialog();
            //在控件中显示图片
            if (r == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open.FileName);
                if (!Directory.Exists(System.AppDomain.CurrentDomain.BaseDirectory + "\\images\\"))
                {
                    Directory.CreateDirectory(System.AppDomain.CurrentDomain.BaseDirectory + "\\images\\");
                }
                File.Copy(open.FileName, System.AppDomain.CurrentDomain.BaseDirectory + "\\images\\" + bikeNo.Text + ".jpg", true);
            }
        }
    }
}
