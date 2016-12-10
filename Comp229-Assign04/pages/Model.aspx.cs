using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Comp229_Assign04
{
    public partial class Model : System.Web.UI.Page
    {
        private Models.Model.modelsData dataModel;

        protected void Page_Load(object sender, EventArgs e)
        {
            string Name = Request.QueryString["name"];
            string Faction = Request.QueryString["faction"];

            try
            {
                if (!Name.Equals("") && !Faction.Equals(""))
                {
                    dataModel = Global.models.FirstOrDefault(tModel => tModel.name == Name && tModel.faction == Faction);
                    DisplayData();
                }
                else
                {
                    Response.Redirect("Default.aspx");
                }
            }

            catch
            {
                Response.Write("try again");
            }
        }
        private void DisplayData()
        {

            nameLabel.Text = dataModel.name;
            factionLabel.Text = dataModel.faction;
            rankLabel.Text = dataModel.rank.ToString();
            baseLabel.Text = dataModel._base.ToString();
            sizeLabel.Text = dataModel.size.ToString();
            deploymentLabel.Text = dataModel.deploymentZone;


            traitsList.DataSource = dataModel.traits;
            traitsList.DataBind();
            defenceList.DataSource = dataModel.defenseChart;
            defenceList.DataBind();


            mobilityLabel.Text = dataModel.mobility.ToString();
            willpowerLabel.Text = dataModel.willpower.ToString();
            resilianceLabel.Text = dataModel.resiliance.ToString();
            woundsLabel.Text = dataModel.wounds.ToString();


            abilitiesRepeater.DataSource = dataModel.specialAbilities;
            abilitiesRepeater.DataBind();

            actionsRepeater.DataSource = dataModel.actions;
            modelImg.ImageUrl = dataModel.imageUrl;
            actionsRepeater.DataBind();

            Update.PostBackUrl = "~/UpdatePage.aspx?name=" + dataModel.name + "&faction=" + dataModel.faction;
        }
      

    }
       
}
