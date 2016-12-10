using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Comp229_Assign04
{
    public partial class _Default : Page
    {
        public object MessageBox { get; private set; }
       
        protected void Page_Load(object sender, EventArgs e)
        {

            repeater1.DataSource = Global.models;
            repeater1.DataBind();
        }
       
        protected void SendMessage_Click(object sender, EventArgs e)
        {

            SmtpClient smtpClient = new SmtpClient("smtp-mail.outlook.com", 587);
            MailMessage message = new MailMessage();
            try
            {
                MailAddress fromAddress = new MailAddress("cc-comp229f2016@outlook.com", "Comp229-Assign04");
                MailAddress toAddress = new MailAddress("shilpagandhi111@gmail.com", "To You");
                message.From = fromAddress;
                message.To.Add(toAddress);
                message.Subject = "testing Assign04";
                message.Body = " body";
                smtpClient.Host = "smtp-mail.outlook.com";
                smtpClient.Credentials = new System.Net.NetworkCredential("cc-comp229f2016@outlook.com", "Comp229pwd");
                smtpClient.Send(message);
            }
            catch (Exception)
            {
                throw;
            }
        }

      

    }
}