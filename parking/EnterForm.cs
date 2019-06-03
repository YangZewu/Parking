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
using System.Data.SqlClient;
using System.IO;
namespace parking
{
    public partial class EnterForm : Form
    {
        public EnterForm()
        {
            InitializeComponent();
        }

        private void Readcard_Click(object sender, EventArgs e)
        {
            int icdev = DCHelper.dc_init(100, 115200);
            if (icdev > 0)
            {
                long snr = 0;
                int dccard = DCHelper.dc_card(icdev, 0, ref snr);
                if (dccard == 0)
                {
                    byte[] password = new byte[] { 0xff, 0xff, 0xff, 0xff, 0xff, 0xff };
                    int dckey = DCHelper.dc_load_key(icdev, 0, 1, password);
                    if (dckey == 0)
                    {
                        int authkey = DCHelper.dc_authentication(icdev, 0, 1);
                        if (authkey == 0)
                        {
                            byte[] data = new byte[16];
                            int dread = DCHelper.dc_read(icdev,4,data);
                            string s = System.Text.Encoding.Default.GetString(data);
                            SqlDataReader r= BikeInfoManag.getDataReader(s);
                            
                            if (dread == 0)
                            {
                                icno.Text = s;
                                if (r.Read())
                                {
                                    bikeno.Text = r["bikeNo"].ToString();
                                    pictureBox1.Image = Image.FromFile(r["bikePhoto"].ToString());                                    
                                    time.Text = System.DateTime.Now.ToString();
                                    r.Close();
                                    SqlDataReader rr = BikeInfoManag.getType(s);
                                    if (rr.Read())
                                    {
                                        icstate.Text = rr["spaceType"].ToString();
                                        
                                        
                                    }
                                    rr.Close();
                                    DCHelper.dc_beep(icdev, 100);
                                }
                                else
                                {
                                    MessageBox.Show("该卡无效");
                                    for (int i = 0; i < 3; i++)
                                        DCHelper.dc_beep(icdev, 10);
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("请正确放置卡！");
                }
            }
            else
            {
                MessageBox.Show("请检查设备！");
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            //确定入库
           int result= ParkingManag.insertParking(icno.Text, icstate.Text, time.Text);
            if (result == 1)
                MessageBox.Show("入库登记成功！");
            else
                MessageBox.Show("入库登记失败！");
        }
    }
}
