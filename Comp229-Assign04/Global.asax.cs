using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;

namespace Comp229_Assign04
{
    public class Global : HttpApplication
    {
        public static List<Models.Model.modelsData> models;

        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            DisplayData();
        }
          private void DisplayData()
        {
            using (StreamReader sr = new StreamReader(Server.MapPath("~/Models/Assign04(1).json")))
            {
                models = JsonConvert.DeserializeObject<List<Models.Model.modelsData>>(sr.ReadToEnd());
            }
        }

    }
}