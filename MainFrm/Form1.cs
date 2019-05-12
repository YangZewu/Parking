using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainFrm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text=DateTime.Now.ToString("yyyy年MM月dd日 HH:mm:ss");
        }
        public void mainFrm()
        {
            InitializeComponent();
            //页面加载时打开定时器
            timer1.Start();
            //给状态栏中的操作员赋值
            toolStripStatusLabel3.Text = userInfo.Username; 
            time.Text = DateTime.Now.ToString("yyyy年MM月dd日 HH:mm:ss");
        }

    }
}
