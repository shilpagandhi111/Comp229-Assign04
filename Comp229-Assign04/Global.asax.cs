using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;

namespace Comp229_Assign04
{
    public class Global : HttpApplication
    {
       /// string MessageText = Encoding.ASCII.GetString(bytes);
        public static List<Models.Model.modelsData> models;
        private const string updatedJsonFilePath = @"C:\Users\shilp\Documents\Visual Studio 2015\Projects\Comp229-Assign04\Comp229-Assign04\Models\Assign04(1)Copy.json";
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            DisplayData();
            
        }

        public static void Email(string clientEmailAddress, string clientName)
        {
            SmtpClient smtpClient = new SmtpClient("smtp-mail.outlook.com", 587);
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
         
            MailMessage message = new MailMessage();
            try
            {
                MailAddress fromAddress = new MailAddress("cc-comp229f2016@outlook.com", "Comp229-Assign04");
              /////Cannot make th message item to work due to the conversion of string
                ////MailAddress toAddress = new MailAddress(clientEmailAddress, clientName,MessageText);
                MailAddress toAddress = new MailAddress(clientEmailAddress, clientName);
                message.From = fromAddress;
                message.To.Add(toAddress);
                message.Subject = "Comp229-Assign04 email";
                message.Body = "using same message body for each email";

                smtpClient.Host = "smtp-mail.outlook.com";
                smtpClient.EnableSsl = true;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new System.Net.NetworkCredential("cc-comp229f2016@outlook.com", "comp229pwd");
                smtpClient.Send(message);
              
            }
            catch (Exception e)
            {
              
            }
        }

        private void DisplayData()
        {
            using (StreamReader sr = new StreamReader(Server.MapPath("~/Models/Assign04(1).json")))
            {
                models = JsonConvert.DeserializeObject<List<Models.Model.modelsData>>(sr.ReadToEnd());
            }
        }
        public static void UpdateNewJsonFile()
        {
            using (StreamWriter streamWriter = File.CreateText(System.Web.Hosting.HostingEnvironment.MapPath("~/Models/Assign04(1)Copy.json")))
            {
                streamWriter.WriteLine(JsonConvert.SerializeObject(models));
            }
        }


    }
}