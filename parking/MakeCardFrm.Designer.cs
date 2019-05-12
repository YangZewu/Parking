namespace parking
{
    partial class MakeCardFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.state2 = new System.Windows.Forms.RadioButton();
            this.state1 = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.btnMakeCard = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.icExpireTime = new System.Windows.Forms.DateTimePicker();
            this.icStateTime = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bikeOwerAddr = new System.Windows.Forms.TextBox();
            this.bikeOwerTel = new System.Windows.Forms.TextBox();
            this.bikeOwerName = new System.Windows.Forms.TextBox();
            this.bikeNo = new System.Windows.Forms.TextBox();
            this.icNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.state2);
            this.groupBox1.Controls.Add(this.state1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.btnMakeCard);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.icExpireTime);
            this.groupBox1.Controls.Add(this.icStateTime);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.bikeOwerAddr);
            this.groupBox1.Controls.Add(this.bikeOwerTel);
            this.groupBox1.Controls.Add(this.bikeOwerName);
            this.groupBox1.Controls.Add(this.bikeNo);
            this.groupBox1.Controls.Add(this.icNo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(763, 549);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "请填写以下资料";
            // 
            // state2
            // 
            this.state2.AutoSize = true;
            this.state2.Location = new System.Drawing.Point(497, 322);
            this.state2.Name = "state2";
            this.state2.Size = new System.Drawing.Size(59, 16);
            this.state2.TabIndex = 25;
            this.state2.Text = "临时卡";
            this.state2.UseVisualStyleBackColor = true;
            // 
            // state1
            // 
            this.state1.AutoSize = true;
            this.state1.Checked = true;
            this.state1.Location = new System.Drawing.Point(364, 322);
            this.state1.Name = "state1";
            this.state1.Size = new System.Drawing.Size(59, 16);
            this.state1.TabIndex = 24;
            this.state1.TabStop = true;
            this.state1.Text = "固定卡";
            this.state1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(456, 462);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "取消";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.MakeCancle_Click);
            // 
            // btnMakeCard
            // 
            this.btnMakeCard.Location = new System.Drawing.Point(183, 462);
            this.btnMakeCard.Name = "btnMakeCard";
            this.btnMakeCard.Size = new System.Drawing.Size(75, 23);
            this.btnMakeCard.TabIndex = 22;
            this.btnMakeCard.Text = "确定";
            this.btnMakeCard.UseVisualStyleBackColor = true;
            this.btnMakeCard.Click += new System.EventHandler(this.btnMakeCard_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(572, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "选择图片";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // icExpireTime
            // 
            this.icExpireTime.Location = new System.Drawing.Point(94, 316);
            this.icExpireTime.Name = "icExpireTime";
            this.icExpireTime.Size = new System.Drawing.Size(164, 21);
            this.icExpireTime.TabIndex = 18;
            // 
            // icStateTime
            // 
            this.icStateTime.Location = new System.Drawing.Point(94, 276);
            this.icStateTime.Name = "icStateTime";
            this.icStateTime.Size = new System.Drawing.Size(164, 21);
            this.icStateTime.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(497, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 142);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "图片管理";
            // 
            // bikeOwerAddr
            // 
            this.bikeOwerAddr.Location = new System.Drawing.Point(94, 235);
            this.bikeOwerAddr.Name = "bikeOwerAddr";
            this.bikeOwerAddr.Size = new System.Drawing.Size(164, 21);
            this.bikeOwerAddr.TabIndex = 12;
            // 
            // bikeOwerTel
            // 
            this.bikeOwerTel.Location = new System.Drawing.Point(94, 197);
            this.bikeOwerTel.Name = "bikeOwerTel";
            this.bikeOwerTel.Size = new System.Drawing.Size(164, 21);
            this.bikeOwerTel.TabIndex = 11;
            // 
            // bikeOwerName
            // 
            this.bikeOwerName.Location = new System.Drawing.Point(94, 155);
            this.bikeOwerName.Name = "bikeOwerName";
            this.bikeOwerName.Size = new System.Drawing.Size(164, 21);
            this.bikeOwerName.TabIndex = 10;
            // 
            // bikeNo
            // 
            this.bikeNo.Location = new System.Drawing.Point(94, 118);
            this.bikeNo.Name = "bikeNo";
            this.bikeNo.Size = new System.Drawing.Size(164, 21);
            this.bikeNo.TabIndex = 9;
            // 
            // icNo
            // 
            this.icNo.Location = new System.Drawing.Point(94, 80);
            this.icNo.Name = "icNo";
            this.icNo.Size = new System.Drawing.Size(164, 21);
            this.icNo.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "到期时间";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "开卡日期";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "车主地址";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "车主电话";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "车主姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "车牌号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "卡号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(28, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "带*号为必填字段";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MakeCardFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 573);
            this.Controls.Add(this.groupBox1);
            this.Name = "MakeCardFrm";
            this.Text = "MakeCardFrm";
            this.Load += new System.EventHandler(this.MakeCardFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnMakeCard;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker icExpireTime;
        private System.Windows.Forms.DateTimePicker icStateTime;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox bikeOwerAddr;
        private System.Windows.Forms.TextBox bikeOwerTel;
        private System.Windows.Forms.TextBox bikeOwerName;
        private System.Windows.Forms.TextBox bikeNo;
        private System.Windows.Forms.TextBox icNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton state2;
        private System.Windows.Forms.RadioButton state1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}