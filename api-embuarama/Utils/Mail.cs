using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace api_embuarama.Utils
{
    public class Mail
    {
        public void EnviarEmail(string recepient, string cc,string bcc, string subject, string body)
        {
            try
            {
                string EmailRecovery = ConfigurationSettings.AppSettings["Email"].ToString();
                string SenhaRecovery = ConfigurationSettings.AppSettings["Senha"].ToString();

                MailMessage email = new MailMessage();
                email.From = new MailAddress(EmailRecovery);
                email.To.Add(new MailAddress(recepient));

                if (cc != "")
                {
                    email.CC.Add(new MailAddress(cc));
                }
                if (bcc != "")

                {
                    email.Bcc.Add(new MailAddress(bcc));
                }

                email.Subject = subject;
                email.Body = body;
                email.IsBodyHtml = true;
                email.Priority = MailPriority.Normal;

                using (var smtp = new SmtpClient("smtp.gmail.com"))
                {
                    smtp.EnableSsl = true; // GMail requer SSL 
                    smtp.Port = 587;       // porta para SSL
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network; // modo de envio
                    smtp.UseDefaultCredentials = false; // vamos utilizar credencias especificas

                    // seu usuário e senha para autenticação
                    smtp.Credentials = new NetworkCredential(EmailRecovery, SenhaRecovery);

                    // envia o e-mail
                    smtp.Send(email);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}