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
            Global.Email(NameText.Text,emailText.Text);
            emailText.Text = "";
            NameText.Text = "";
            MessageText.Text = "";
           
            Response.Redirect("LandingPage.aspx");
        }

        }
}