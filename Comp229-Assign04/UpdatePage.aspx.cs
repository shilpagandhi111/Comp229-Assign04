using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Comp229_Assign04
{
    public partial class UpdatePage : System.Web.UI.Page
    {
        private Models.Model.modelsData dataModel;
       
        protected void Page_Load(object sender, EventArgs e)
        {
           string  Name = Request.QueryString["name"];
           string  Faction = Request.QueryString["faction"];
            dataModel = Global.models.FirstOrDefault(tModel => tModel.name == Name && tModel.faction == Faction);

            if (!Name.Equals("") && !Faction.Equals(""))
            {


                updatePlayerInfo();
            }
            else
            {
                Response.Redirect("Default.aspx");
            }
        }
        private void updatePlayerInfo()
        {
           
                modelImg.ImageUrl = dataModel.imageUrl;
                nameTextBox.Text = dataModel.name;
                factionTextBox.Text = dataModel.faction;
                rankTextBox.Text = dataModel.rank.ToString();
                baseTextBox.Text = dataModel._base.ToString();
                sizeTextBox.Text = dataModel.size.ToString();
                deploymentTextBox.Text = dataModel.deploymentZone;
                willpowerTextBox.Text = dataModel.willpower.ToString();
                resilianceTextBox.Text = dataModel.resiliance.ToString();
                woundsTextBox.Text = dataModel.wounds.ToString();

            }
        protected void Button1_Click(object sender, EventArgs e)
        {
           
                dataModel.name = nameTextBox.Text;
                dataModel.faction = factionTextBox.Text;
                dataModel.rank = Convert.ToInt32(rankTextBox.Text);
                dataModel._base = Convert.ToInt32(baseTextBox.Text);
                dataModel.size = Convert.ToInt32(sizeTextBox.Text);
                dataModel.mobility = Convert.ToInt32(mobilityTextBox.Text);
                dataModel.willpower = Convert.ToInt32(willpowerTextBox.Text);
                dataModel.resiliance = Convert.ToInt32(resilianceTextBox.Text);
                dataModel.wounds = Convert.ToInt32(woundsTextBox.Text);

                createNewJSON();
                Response.Redirect("LandingPage.aspx");
            
            
           
        }

        private void createNewJSON()
        {
            using (StreamWriter streamWriter = File.CreateText(Server.MapPath("~/Models/Assign04(1)Copy.json")))
            {
                streamWriter.WriteLine(JsonConvert.SerializeObject(dataModel));
            }
        }
    }
}