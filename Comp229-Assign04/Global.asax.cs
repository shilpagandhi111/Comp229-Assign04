using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;

namespace Comp229_Assign04
{
    public class Global : HttpApplication
    {
        public static List<Models.Model.modelsData> models;
        private const string updatedJsonFilePath = @"C:\Users\shilp\Documents\Visual Studio 2015\Projects\Comp229-Assign04\Comp229-Assign04\Models\Assign04(1)Copy.json";
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            DisplayData();
            
        }

        internal static void Email(string text1, string text2, string text3)
        {
            throw new NotImplementedException();
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