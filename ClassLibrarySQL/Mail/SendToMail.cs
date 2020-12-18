using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace Library
{
    public static class Mail
    {
        /// <summary>
        /// SendMessage - отправка почты
        /// </summary>
        public static bool Send(string smtpServer, int smtpPort, string smtpLogin, string smtpPassword, string senderAddress, string senderName, List<Recipient> recipients, string subject, string body, List<string> filename = null, bool isSSL = false)
        {
            try
            {
                SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort);
                smtpClient.EnableSsl = isSSL;
                smtpClient.Credentials = new NetworkCredential(smtpLogin, smtpPassword);
                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress(senderAddress, senderName);
                foreach (Recipient recipient in recipients)
                {
                    if (!string.IsNullOrEmpty(recipient.Address))
                    {
                        mailMessage.To.Add(new MailAddress(recipient.Address, recipient.Name));
                    }
                }
                mailMessage.Subject = subject;
                mailMessage.Body = body;
                mailMessage.IsBodyHtml = true;
                if (filename != null)
                {
                    foreach (string fileName in filename)
                    {
                        Attachment item = new Attachment(fileName, "application/octet-stream");
                        mailMessage.Attachments.Add(item);
                    }
                    try
                    {
                        smtpClient.Send(mailMessage);
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        return false;
                    }
                }
                smtpClient.Send(mailMessage);
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message, ex2.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            return true;
        }
    }
}
