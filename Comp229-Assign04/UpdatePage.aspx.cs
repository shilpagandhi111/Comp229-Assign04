using System;
using System.Collections.Generic;
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

        }
        private void updatePlayerInfo()
        {
           
                dataModel.name = nameTextBox.Text;
                dataModel.faction = factionTextBox.Text;
                dataModel.rank = int.Parse(rankTextBox.Text);
                dataModel._base = int.Parse(baseTextBox.Text);
                dataModel.size = int.Parse(sizeTextBox.Text);
                dataModel.deploymentZone = deploymentTextBox.Text;
                dataModel.mobility = int.Parse(mobilityTextBox.Text); ;
                dataModel.willpower = int.Parse(willpowerTextBox.Text);
                dataModel.resiliance = int.Parse(resilianceTextBox.Text);
                dataModel.wounds = int.Parse(woundsTextBox.Text);
            }

        protected void Button1_Click(object sender, EventArgs e)
        {
            updatePlayerInfo();
            Global.UpdateNewJsonFile();
        }
    }
}