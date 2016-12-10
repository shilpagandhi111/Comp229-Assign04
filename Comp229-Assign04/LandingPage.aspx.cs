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
            Global.Email(NameText.Text,emailText.Text,MessageText.Text );
            emailText.Text = "";
            NameText.Text = "";
            MessageText.Text = "";
            Response.Redirect("LandingPage.aspx");
        }
        public static void Email(string EmailAddress, string Name, string MessageText)
        {
            SmtpClient smtpClient = new SmtpClient("smtp-mail.outlook.com", 587);
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;

            MailMessage message = new MailMessage();
            try
            {
                MailAddress fromAddress = new MailAddress("cc-comp229f2016@outlook.com", "Comp229-Assign04");
                MailAddress toAddress = new MailAddress(EmailAddress,Name,MessageText);
                message.From = fromAddress;
                message.To.Add(toAddress);
                message.Subject = "Comp229-Assign04 email";
                message.Body = MessageText;

                smtpClient.Host = "smtp-mail.outlook.com";
                smtpClient.EnableSsl = true;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new System.Net.NetworkCredential("cc-comp229f2016@outlook.com", "comp229pwd");

               
                message.Attachments.Add(new Attachment(System.Web.Hosting.HostingEnvironment.MapPath(@"C:\Users\shilp\Documents\Visual Studio 2015\Projects\Comp229-Assign04\Comp229-Assign04\Models\Assign04(1)Copy.json"), contentType));

                smtpClient.Send(message);
               
            }
            catch (Exception ex)
            {
               
            }



        }
}