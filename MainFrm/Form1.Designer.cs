namespace MainFrm
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.车位管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.费率管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.车位管理ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.进出管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.入库管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.出库管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.卡管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.发卡ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.销卡ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.time = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.车位管理ToolStripMenuItem,
            this.进出管理ToolStripMenuItem,
            this.卡管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(893, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 车位管理ToolStripMenuItem
            // 
            this.车位管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.费率管理ToolStripMenuItem,
            this.车位管理ToolStripMenuItem1});
            this.车位管理ToolStripMenuItem.Name = "车位管理ToolStripMenuItem";
            this.车位管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.车位管理ToolStripMenuItem.Text = "车位管理";
            // 
            // 费率管理ToolStripMenuItem
            // 
            this.费率管理ToolStripMenuItem.Name = "费率管理ToolStripMenuItem";
            this.费率管理ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.费率管理ToolStripMenuItem.Text = "费率管理";
            // 
            // 车位管理ToolStripMenuItem1
            // 
            this.车位管理ToolStripMenuItem1.Name = "车位管理ToolStripMenuItem1";
            this.车位管理ToolStripMenuItem1.Size = new System.Drawing.Size(144, 26);
            this.车位管理ToolStripMenuItem1.Text = "车位管理";
            // 
            // 进出管理ToolStripMenuItem
            // 
            this.进出管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.入库管理ToolStripMenuItem,
            this.出库管理ToolStripMenuItem});
            this.进出管理ToolStripMenuItem.Name = "进出管理ToolStripMenuItem";
            this.进出管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.进出管理ToolStripMenuItem.Text = "进出管理";
            // 
            // 入库管理ToolStripMenuItem
            // 
            this.入库管理ToolStripMenuItem.Name = "入库管理ToolStripMenuItem";
            this.入库管理ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.入库管理ToolStripMenuItem.Text = "入库管理";
            // 
            // 出库管理ToolStripMenuItem
            // 
            this.出库管理ToolStripMenuItem.Name = "出库管理ToolStripMenuItem";
            this.出库管理ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.出库管理ToolStripMenuItem.Text = "出库管理";
            // 
            // 卡管理ToolStripMenuItem
            // 
            this.卡管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.发卡ToolStripMenuItem,
            this.销卡ToolStripMenuItem});
            this.卡管理ToolStripMenuItem.Name = "卡管理ToolStripMenuItem";
            this.卡管理ToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.卡管理ToolStripMenuItem.Text = "卡管理";
            // 
            // 发卡ToolStripMenuItem
            // 
            this.发卡ToolStripMenuItem.Name = "发卡ToolStripMenuItem";
            this.发卡ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.发卡ToolStripMenuItem.Text = "发卡";
            // 
            // 销卡ToolStripMenuItem
            // 
            this.销卡ToolStripMenuItem.Name = "销卡ToolStripMenuItem";
            this.销卡ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.销卡ToolStripMenuItem.Text = "销卡";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.time});
            this.statusStrip1.Location = new System.Drawing.Point(0, 464);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(893, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(174, 20);
            this.toolStripStatusLabel1.Text = "欢迎来到停车场管理系统";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(69, 20);
            this.toolStripStatusLabel2.Text = "管理员：";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(167, 20);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(84, 20);
            this.toolStripStatusLabel4.Text = "当前时间：";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // time
            // 
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(167, 20);
            this.time.Text = "toolStripStatusLabel5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 489);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MainFfm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 车位管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 费率管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 车位管理ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 进出管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 入库管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 出库管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 卡管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 发卡ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 销卡ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel time;
        private System.Windows.Forms.Timer timer1;
    }
}

