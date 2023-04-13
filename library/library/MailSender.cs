using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace library
{
    internal class MailSender
    {
        public NetworkCredential login = new NetworkCredential("miecho.pierwszy966@gmail.com", "luomhgaxzwlsxjah");
        public SmtpClient client;
        public MailMessage msg_email = new MailMessage();

        public MailSender()
        {
            // set super email data
            this.msg_email = new MailMessage();
            this.login = new NetworkCredential("miecho.pierwszy966@gmail.com", "luomhgaxzwlsxjah");
            this.client = new SmtpClient("smtp.gmail.com");
            this.client.Port = 587;
            client.EnableSsl = true;
            client.Credentials = login;
            msg_email = new MailMessage { From = new MailAddress("miecho.pierwszy966@gmail.com", "Library-kckc", Encoding.UTF8) };
        }

        private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            // This method shows feedback for every scenario.
            if (e.Cancelled)
                MessageBox.Show(string.Format("{0} send canceled.", e.UserState), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (e.Error != null)
                MessageBox.Show(string.Format("{0} {1}", e.Error), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("E-mail sended", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Send(string email, string first_name, string surname, string phone_number)
        {
            // This method sends an email to user.

            msg_email.Subject = "Your Library-kckc data";
            try
            {
                if (!(email.Equals("")))
                {
                    msg_email.To.Add(new MailAddress(email));
                }

                msg_email.Body = "<h2>Hello dear " + first_name + " " + surname + "<h2/><p> You are receiving this message because Your data was added to our Library database.<br />Do not show this message to anyone.<p/>" +
                    "<p><b>First name: " + first_name + "<br />Phone number: " + phone_number + "</b><p/> <p>Yours sincerely, <br /> Admin of Library-kckc<p/>";
               

                msg_email.BodyEncoding = Encoding.UTF8;
                msg_email.IsBodyHtml = true;
                msg_email.Priority = MailPriority.Normal;
                msg_email.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
                string userstate = "Sending...";
                client.SendAsync(msg_email, userstate);
            }
            catch
            {
                MessageBox.Show("E-mail can not be send - no e-mail address has been entered", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public static bool IsValidEmail(string email)
        // This method checks email validation.
        {
            List<string> top_domain = new List<string>() { ".com", ".org", ".net", ".int", ".edu", ".gov" };
            try
            {
                if (!(top_domain.Contains(email.Substring((email.Length - 4), 4))))
                {
                    return false;
                }
                var eMailValidator = new MailAddress(email);
                return email.LastIndexOf(".") > email.LastIndexOf("@");
            }
            catch
            {
                return false;
            }
        }
    }
}
