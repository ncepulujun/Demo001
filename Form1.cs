using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Threading;
using System.Timers;
using System.IO;
using CDO;

namespace EMailTool
{
    public partial class Form1 : Form
    {
        System.Timers.Timer timer = new System.Timers.Timer();
        string[] _receivers;
        string _smtp = string.Empty;
        string _mailSender = string.Empty;
        string _loginName = string.Empty;
        string _senderPwd = string.Empty;
        string _subject = string.Empty;
        string _content = string.Empty;
        string _stmpport = string.Empty;
        bool _isSSL = false;
        int _interval = 2;

        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            this.txtSmtp1.Text = "smtp.qq.com";
            this.txtSender.Text = "2676766417@qq.com";
            this.txtSendPwd.Text = "";
            this.txtReceiver.Text = "";
            this.txtSubject.Text = "邮件工具的测试邮件";
            this.txtLoginName.Text = "2676766417@qq.com";
            this.rtxtContext.Text = "邮件测试工具的邮件正文内容！！！";
            this.txtInerval.Text = "5";
        }

        private void SetTimerParms()
        {
            string receivers = this.txtReceiver.Text.Trim();
            _receivers = receivers.Split(';', ',');
            _smtp = this.txtSmtp1.Text.Trim();
            _stmpport = this.txtProt1.Text.Trim();
            _mailSender = this.txtSender.Text.Trim();
            _loginName = this.txtLoginName.Text.Trim();
            _senderPwd = this.txtSendPwd.Text.Trim();
            _subject = this.txtSubject.Text.Trim();
            _content = this.rtxtContext.Text.Trim();
            _isSSL = this.cmbSSL1.Checked;
            _interval = Convert.ToInt32(this.txtInerval.Text);
            if (_interval > 0)
            {
                timer.Interval = _interval * 1000;
            }
            timer.AutoReset = true;
            timer.Enabled = true;
            timer.Elapsed += new ElapsedEventHandler(SetMail);
        }

        private void SetMail(object sender, ElapsedEventArgs e)
        {
            SendMail();
        }

        private void SetMailValue()
        {
        }

        private void btn_SendClik(object sender, EventArgs e)
        {
            //IsNowDay();
            SendMail();
            //SetTimerParms();
        }
        private bool IsNowDay()
        {
            DateTime dateTime;
            DateTime.TryParse("2018-5-27 15:22:12", out dateTime);

            DateTime dateTime1;
            DateTime.TryParse("2018-5-25 05:22:12", out dateTime1);

            DateTime dateTime2;
            DateTime.TryParse("2018-5-29 19:22:12", out dateTime2);
            bool isSameDay = false;
            string dddf = DateTime.Now.ToString("yyyy-MM-dd HH:MM:ss");
            if (dateTime != null)
            {
                DateTime nowTime = DateTime.Now;
                TimeSpan sp = nowTime.Subtract(dateTime);
                double d = sp.TotalDays;
                TimeSpan sp1 = nowTime.Subtract(dateTime1);
                double d1 = sp1.TotalDays;
                TimeSpan sp2 = nowTime.Subtract(dateTime2);
                double d2 = sp2.TotalDays;
                if (d < 0)
                    d = -d;
                if (d > 86400 || (dateTime.Day != nowTime.Day)) //不是同一天了
                { }
            }
            return isSameDay;
        }

        private void btn_StopSendClik(object sender, EventArgs e)
        {
            if (timer != null)
            {
                timer.Stop();
            }
            SetMailValue();
            SendCdoMail();
        }

        
        private void SendMail()
        {
            SetMailValue();
            try
            {
                MailMessage mailMsg = new MailMessage();
                if (_receivers.Length > 0)
                {
                    for (int i = _receivers.Length - 1; i >= 0; i--)
                    {
                        string curEMail = _receivers[i].Trim();
                        if (curEMail.Length > 0)
                        {
                            if (System.Text.RegularExpressions.Regex.IsMatch(curEMail, "\\w+([-+.]\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*"))
                                mailMsg.To.Add(curEMail);
                        }
                    }
                    mailMsg.From = new MailAddress(_mailSender, _loginName, System.Text.Encoding.Default);
                    mailMsg.Subject = _subject;
                    mailMsg.Body = _content;
                    mailMsg.BodyEncoding = System.Text.Encoding.Default;

                    string[] SmtpServer = _smtp.Trim().Split(':');
                    SmtpClient client = null;
                    if (string.IsNullOrEmpty(_stmpport))
                        client = new SmtpClient(_smtp);
                    else
                        client = new SmtpClient(_smtp, Convert.ToInt32(_stmpport));
                    var t = client.ServicePoint;
                    client.UseDefaultCredentials = true;
                    client.EnableSsl = _isSSL;
                    client.Credentials = new System.Net.NetworkCredential(_mailSender, _senderPwd);
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;

                    client.Send(mailMsg);
                    string msg = "主题：" + _subject + "发送成功！";
                    WriteLog(msg);
                    WriteLog(msg, true);
                    mailMsg.Dispose();
                }
            }
            catch (Exception e)
            {
                string msg = "异常：" + e.Message + "\r\n";
                if (e.InnerException != null)
                {
                    msg += "   内部异常：" + e.InnerException.Message;
                }
                WriteLog(msg);
            }
            finally
            { }
        }

        /// <summary>
        /// 需要引用Com组件
        /// </summary>
        private void SendCdoMail()
        {

            try
            {
                CDO.Message mailMsg = new CDO.Message();
                var conf = mailMsg.Configuration;
                var oFields = conf.Fields;
                oFields["http://schemas.microsoft.com/cdo/configuration/sendusing"].Value = CdoSendUsing.cdoSendUsingPort;
                oFields["http://schemas.microsoft.com/cdo/configuration/smtpauthenticate"].Value = CdoProtocolsAuthentication.cdoBasic;
                if (_isSSL)
                {
                    oFields["http://schemas.microsoft.com/cdo/configuration/smtpusessl"].Value = true;
                }
                oFields["http://schemas.microsoft.com/cdo/configuration/smtpserver"].Value = _smtp;//必填，而且要真实可用   
                oFields["http://schemas.microsoft.com/cdo/configuration/smtpserverport"].Value = Convert.ToInt32(_stmpport);//邮箱端口
                oFields["http://schemas.microsoft.com/cdo/configuration/sendemailaddress"].Value = _mailSender;//发送者邮箱
                oFields["http://schemas.microsoft.com/cdo/configuration/sendusername"].Value = _loginName;//邮箱发送者名称   
                oFields["http://schemas.microsoft.com/cdo/configuration/sendpassword"].Value = _senderPwd;   //邮箱发送者密码，必须真实   
                oFields.Update();

                mailMsg.Configuration = conf;
                mailMsg.Subject = _subject;//主题
                mailMsg.HTMLBody = _content;//邮件正文                      
                mailMsg.From = _mailSender;//发送者
                mailMsg.To = _receivers[0];//接收者
                mailMsg.Send();//发送
                               //MailMessage mailMsg = new MailMessage();

                string msg = "主题：" + _subject + "发送成功！";
                WriteLog(msg);
                WriteLog(msg, true);

            }
            catch (Exception e)
            {
                string msg = "异常：" + e.Message + "\r\n";
                if (e.InnerException != null)
                {
                    msg += "   内部异常：" + e.InnerException.Message;
                }
                WriteLog(msg);
            }
            finally
            { }
        }

        private void WriteLog(string msg)
        {
            string nowTime = DateTime.Now.ToString();
            msg = nowTime + "  " + msg;
            if (this.rtxtLog.InvokeRequired)
            {
                Action<string> action = (x) => { this.rtxtLog.Text += msg + "\r\n"; };
            }
            else
            {
                this.rtxtLog.Text += msg + "\r\n";
            }
        }

        private void WriteDebugLog()
        {

        }

        private void WriteLog(string strMessage, bool isTxtLog)
        {

            try
            {
                string strFile = string.Format("EmailLog{0}{1}{2}.txt", DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);

                string LogFile = System.IO.Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).FullName;
                string path = System.IO.Directory.GetParent(LogFile) + "\\log";   //父路径
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                if (LogFile.ToLower().EndsWith("bin"))
                {
                    LogFile = path + "\\" + strFile;
                }
                else
                    LogFile = path + "\\" + strFile;



                using (StreamWriter sw = new StreamWriter(LogFile, true, Encoding.Default))
                {
                    sw.WriteLine(String.Format("{0}: {1}", DateTime.Now.ToString(), strMessage));
                    sw.Close();
                }
            }
            catch (Exception ex)
            {

            }


        }

        private void btn_sendOfTimeClick(object sender, EventArgs e)
        {
            SetTimerParms();
        }

        DataTable htlock = new DataTable();
        private void WriteTxtLog(string strMessage)
        {
            lock (htlock)
            {
                try
                {
                    string strFile = string.Format("EmailLog{0}{1}{2}.txt", DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
                    string LogFile = System.IO.Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).FullName;
                    string path = System.IO.Directory.GetParent(LogFile) + "\\maillog";   //父路径
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    if (LogFile.ToLower().EndsWith("bin"))
                    {
                        LogFile = path + "\\" + strFile;
                    }
                    else
                        LogFile = path + "\\" + strFile;
                    using (StreamWriter sw = new StreamWriter(LogFile, true, Encoding.Default))
                    {
                        sw.WriteLine(String.Format("{0}: {1}", DateTime.Now.ToString(), strMessage));
                        sw.Close();
                    }
                }
                catch (Exception ex)
                {
                }

            }
        }
    }
}
