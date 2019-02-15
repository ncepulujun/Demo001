namespace EMailTool
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSmtp1 = new System.Windows.Forms.TextBox();
            this.txtProt1 = new System.Windows.Forms.TextBox();
            this.txtSender = new System.Windows.Forms.TextBox();
            this.txtSendPwd = new System.Windows.Forms.TextBox();
            this.txtReceiver = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbSSL1 = new System.Windows.Forms.CheckBox();
            this.rtxtContext = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.rtxtLog = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtInerval = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnStopSend = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtLoginName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.send_oftime = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "SMTP1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "端口号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "发送账号：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "密码：";
            // 
            // txtSmtp1
            // 
            this.txtSmtp1.Location = new System.Drawing.Point(94, 31);
            this.txtSmtp1.Name = "txtSmtp1";
            this.txtSmtp1.Size = new System.Drawing.Size(152, 21);
            this.txtSmtp1.TabIndex = 4;
            // 
            // txtProt1
            // 
            this.txtProt1.Location = new System.Drawing.Point(311, 31);
            this.txtProt1.Name = "txtProt1";
            this.txtProt1.Size = new System.Drawing.Size(135, 21);
            this.txtProt1.TabIndex = 5;
            // 
            // txtSender
            // 
            this.txtSender.Location = new System.Drawing.Point(94, 65);
            this.txtSender.Name = "txtSender";
            this.txtSender.Size = new System.Drawing.Size(152, 21);
            this.txtSender.TabIndex = 6;
            // 
            // txtSendPwd
            // 
            this.txtSendPwd.Location = new System.Drawing.Point(311, 65);
            this.txtSendPwd.Name = "txtSendPwd";
            this.txtSendPwd.PasswordChar = '*';
            this.txtSendPwd.Size = new System.Drawing.Size(135, 21);
            this.txtSendPwd.TabIndex = 7;
            // 
            // txtReceiver
            // 
            this.txtReceiver.Location = new System.Drawing.Point(94, 92);
            this.txtReceiver.Name = "txtReceiver";
            this.txtReceiver.Size = new System.Drawing.Size(352, 21);
            this.txtReceiver.TabIndex = 8;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(94, 121);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(352, 21);
            this.txtSubject.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "收件人：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "邮件主题：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "邮件正文：";
            // 
            // cmbSSL1
            // 
            this.cmbSSL1.AutoSize = true;
            this.cmbSSL1.Location = new System.Drawing.Point(469, 39);
            this.cmbSSL1.Name = "cmbSSL1";
            this.cmbSSL1.Size = new System.Drawing.Size(42, 16);
            this.cmbSSL1.TabIndex = 14;
            this.cmbSSL1.Text = "SSL";
            this.cmbSSL1.UseVisualStyleBackColor = true;
            // 
            // rtxtContext
            // 
            this.rtxtContext.Location = new System.Drawing.Point(94, 152);
            this.rtxtContext.Name = "rtxtContext";
            this.rtxtContext.Size = new System.Drawing.Size(544, 79);
            this.rtxtContext.TabIndex = 15;
            this.rtxtContext.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(469, 119);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 16;
            this.btnSend.Text = ".Net发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btn_SendClik);
            // 
            // rtxtLog
            // 
            this.rtxtLog.Location = new System.Drawing.Point(94, 237);
            this.rtxtLog.Name = "rtxtLog";
            this.rtxtLog.Size = new System.Drawing.Size(544, 123);
            this.rtxtLog.TabIndex = 23;
            this.rtxtLog.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 22;
            this.label10.Text = "日志：";
            // 
            // txtInerval
            // 
            this.txtInerval.Location = new System.Drawing.Point(563, 37);
            this.txtInerval.Name = "txtInerval";
            this.txtInerval.Size = new System.Drawing.Size(75, 21);
            this.txtInerval.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(522, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 12);
            this.label11.TabIndex = 25;
            this.label11.Text = "间隔:";
            // 
            // btnStopSend
            // 
            this.btnStopSend.Location = new System.Drawing.Point(563, 119);
            this.btnStopSend.Name = "btnStopSend";
            this.btnStopSend.Size = new System.Drawing.Size(75, 23);
            this.btnStopSend.TabIndex = 26;
            this.btnStopSend.Text = "CDO发送";
            this.btnStopSend.UseVisualStyleBackColor = true;
            this.btnStopSend.Click += new System.EventHandler(this.btn_StopSendClik);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(466, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 12);
            this.label12.TabIndex = 28;
            this.label12.Text = "登录名:";
            // 
            // txtLoginName
            // 
            this.txtLoginName.Location = new System.Drawing.Point(524, 68);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Size = new System.Drawing.Size(114, 21);
            this.txtLoginName.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 12);
            this.label8.TabIndex = 29;
            this.label8.Text = "注：qq邮箱的密码栏，填写的是授权码";
            // 
            // send_oftime
            // 
            this.send_oftime.Location = new System.Drawing.Point(468, 92);
            this.send_oftime.Name = "send_oftime";
            this.send_oftime.Size = new System.Drawing.Size(75, 23);
            this.send_oftime.TabIndex = 30;
            this.send_oftime.Text = "定时发送";
            this.send_oftime.UseVisualStyleBackColor = true;
            this.send_oftime.Click += new System.EventHandler(this.btn_sendOfTimeClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 372);
            this.Controls.Add(this.send_oftime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtLoginName);
            this.Controls.Add(this.btnStopSend);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtInerval);
            this.Controls.Add(this.rtxtLog);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.rtxtContext);
            this.Controls.Add(this.cmbSSL1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtReceiver);
            this.Controls.Add(this.txtSendPwd);
            this.Controls.Add(this.txtSender);
            this.Controls.Add(this.txtProt1);
            this.Controls.Add(this.txtSmtp1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "邮件发送测试小工具";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSmtp1;
        private System.Windows.Forms.TextBox txtProt1;
        private System.Windows.Forms.TextBox txtSender;
        private System.Windows.Forms.TextBox txtSendPwd;
        private System.Windows.Forms.TextBox txtReceiver;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cmbSSL1;
        private System.Windows.Forms.RichTextBox rtxtContext;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RichTextBox rtxtLog;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtInerval;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnStopSend;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtLoginName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button send_oftime;
    }
}

