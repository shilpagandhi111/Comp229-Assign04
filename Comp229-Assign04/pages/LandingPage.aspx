﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LandingPage.aspx.cs" Inherits="Comp229_Assign04._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        
    </div>

   <div class="data">
        <asp:Repeater ID="repeater1" runat="server">
                <ItemTemplate>
                    <asp:LinkButton ID="PlayerNames" runat="server" Text='<%# Eval("name")%>' PostBackUrl='<%#string.Format("Model.aspx?name={0}&faction={1}", Eval("name"), Eval("faction")) %>' />
                    <br />
                </ItemTemplate>
     </asp:Repeater>
        <asp:Button ID="Button1" runat="server" Text="Delete Player" OnClick="Button1_Click" />
   </div>
    <div  class="text-center">
        <asp:Label ID="Name" runat="server" Text="Name:"> </asp:Label>
        <br />
        <asp:TextBox ID="NameText" runat="server"></asp:TextBox>
        <br />

         <asp:Label ID="Message" runat="server" Text="Message:"> </asp:Label>
        <br />
        <asp:TextBox ID="MessageText" runat="server" Height="116px"  Width="290px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="SendMessage" runat="server" Text=" Send " OnClick="SendMessage_Click" />
        <asp:Label ID="statusLabel" runat="server" Text="Label"></asp:Label>
    </div>

</asp:Content>