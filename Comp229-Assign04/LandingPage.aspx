<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LandingPage.aspx.cs" Inherits="Comp229_Assign04._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        
    </div>

   <div class="data">
        <asp:Repeater ID="repeater1" runat="server">
                <ItemTemplate>
                    <asp:LinkButton ID="PlayerNames" runat="server" Text='<%# Eval("name")%>' PostBackUrl='<%#string.Format("~/ModelPage.aspx?name={0}&faction={1}", Eval("name"), Eval("faction")) %>' />
                    <br />
                </ItemTemplate>
     </asp:Repeater>
   </div>

</asp:Content>
