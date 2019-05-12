namespace parking
{
    partial class Reg
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
            this.RegBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RegName = new System.Windows.Forms.TextBox();
            this.RegPwd = new System.Windows.Forms.TextBox();
            this.RegCal = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.RegTel = new System.Windows.Forms.TextBox();
            this.RegOperator = new System.Windows.Forms.RadioButton();
            this.RegMent = new System.Windows.Forms.RadioButton();
            this.cheakName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RegBtn
            // 
            this.RegBtn.Location = new System.Drawing.Point(161, 291);
            this.RegBtn.Margin = new System.Windows.Forms.Padding(4);
            this.RegBtn.Name = "RegBtn";
            this.RegBtn.Size = new System.Drawing.Size(100, 29);
            this.RegBtn.TabIndex = 0;
            this.RegBtn.Text = "注册";
            this.RegBtn.UseVisualStyleBackColor = true;
            this.RegBtn.Click += new System.EventHandler(this.RegBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "密 码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 196);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "用户类别";
            // 
            // RegName
            // 
            this.RegName.Location = new System.Drawing.Point(257, 94);
            this.RegName.Margin = new System.Windows.Forms.Padding(4);
            this.RegName.Name = "RegName";
            this.RegName.Size = new System.Drawing.Size(152, 25);
            this.RegName.TabIndex = 4;
            this.RegName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cheakname);
            // 
            // RegPwd
            // 
            this.RegPwd.Location = new System.Drawing.Point(257, 141);
            this.RegPwd.Margin = new System.Windows.Forms.Padding(4);
            this.RegPwd.Name = "RegPwd";
            this.RegPwd.PasswordChar = '*';
            this.RegPwd.Size = new System.Drawing.Size(152, 25);
            this.RegPwd.TabIndex = 5;
            // 
            // RegCal
            // 
            this.RegCal.Location = new System.Drawing.Point(323, 291);
            this.RegCal.Margin = new System.Windows.Forms.Padding(4);
            this.RegCal.Name = "RegCal";
            this.RegCal.Size = new System.Drawing.Size(100, 29);
            this.RegCal.TabIndex = 8;
            this.RegCal.Text = "取消";
            this.RegCal.UseVisualStyleBackColor = true;
            this.RegCal.Click += new System.EventHandler(this.RegCal_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 234);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "联系方式";
            // 
            // RegTel
            // 
            this.RegTel.Location = new System.Drawing.Point(257, 224);
            this.RegTel.Margin = new System.Windows.Forms.Padding(4);
            this.RegTel.Name = "RegTel";
            this.RegTel.Size = new System.Drawing.Size(152, 25);
            this.RegTel.TabIndex = 10;
            // 
            // RegOperator
            // 
            this.RegOperator.AutoSize = true;
            this.RegOperator.Checked = true;
            this.RegOperator.Location = new System.Drawing.Point(257, 191);
            this.RegOperator.Name = "RegOperator";
            this.RegOperator.Size = new System.Drawing.Size(73, 19);
            this.RegOperator.TabIndex = 11;
            this.RegOperator.TabStop = true;
            this.RegOperator.Text = "操作员";
            this.RegOperator.UseVisualStyleBackColor = true;
            // 
            // RegMent
            // 
            this.RegMent.AutoSize = true;
            this.RegMent.Location = new System.Drawing.Point(336, 191);
            this.RegMent.Name = "RegMent";
            this.RegMent.Size = new System.Drawing.Size(73, 19);
            this.RegMent.TabIndex = 12;
            this.RegMent.Text = "管理员";
            this.RegMent.UseVisualStyleBackColor = true;
            // 
            // cheakName
            // 
            this.cheakName.AutoSize = true;
            this.cheakName.Location = new System.Drawing.Point(435, 104);
            this.cheakName.Name = "cheakName";
            this.cheakName.Size = new System.Drawing.Size(0, 15);
            this.cheakName.TabIndex = 13;
            // 
            // Reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 499);
            this.Controls.Add(this.cheakName);
            this.Controls.Add(this.RegMent);
            this.Controls.Add(this.RegOperator);
            this.Controls.Add(this.RegTel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RegCal);
            this.Controls.Add(this.RegPwd);
            this.Controls.Add(this.RegName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Reg";
            this.Text = "Reg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RegBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RegName;
        private System.Windows.Forms.TextBox RegPwd;
        private System.Windows.Forms.Button RegCal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RegTel;
        private System.Windows.Forms.RadioButton RegOperator;
        private System.Windows.Forms.RadioButton RegMent;
        private System.Windows.Forms.Label cheakName;
    }
}