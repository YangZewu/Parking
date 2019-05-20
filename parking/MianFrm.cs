using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parking
{
    public partial class MianFrm : Form
    {
        public MianFrm()
        {
            InitializeComponent();
        }


        private void MianFrm_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel5.Text = System.DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel5.Text = System.DateTime.Now.ToLongTimeString();
        }

        private void 注册ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reg reg = new Reg();
            reg.MdiParent = this;
            reg.Show();
        }

        private void 发卡ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MakeCardFrm m = new MakeCardFrm();
            m.MdiParent = this;
            m.Show();
        }

        private void 入库管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnterForm en = new EnterForm();
            en.MdiParent = this;
            en.Show();
        }
    }
}
