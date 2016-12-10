<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdatePage.aspx.cs" Inherits="Comp229_Assign04.UpdatePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="col-xs-12 col-md-4">
        <asp:Image runat="server" ID="modelImg" Width="200px" />

    </div>

    <div class="col-xs-12 col-md-5">
        <table>
            <tr>
                <td>Name: </td>
                <td>
                    <asp:TextBox runat="server" ID="nameTextBox"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Faction: </td>
                <td>
                    <asp:TextBox runat="server" ID="factionTextBox"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Rank :</td>
                <td>
                    <asp:TextBox runat="server" ID="rankTextBox"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Base :</td>
                <td>
                    <asp:TextBox runat="server" ID="baseTextBox"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Size :</td>
                <td>
                    <asp:TextBox runat="server" ID="sizeTextBox"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Deployment Zone :</td>
                <td>
                    <asp:TextBox runat="server" ID="deploymentTextBox"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Traits: </td>
                <td>
                    <asp:Repeater runat="server" ID="traitsList">
                        <ItemTemplate>
                            <asp:TextBox runat="server" Text="<%# Container.DataItem.ToString() %>"></asp:TextBox>
                            <br />
                        </ItemTemplate>
                    </asp:Repeater>
                </td>
            </tr>
            <tr>
                <td>Types: </td>
                <td>
                    <asp:Repeater runat="server" ID="defenceList">
                        <ItemTemplate>
                            <asp:TextBox runat="server" Text="<%# Container.DataItem.ToString() %>"></asp:TextBox>
                            <br />
                        </ItemTemplate>
                    </asp:Repeater>
                </td>
            </tr>
            <tr>
                <td>Mobility: </td>
                <td>
                    <asp:TextBox runat="server" ID="mobilityTextBox"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Will Power: </td>
                <td>
                    <asp:TextBox runat="server" ID="willpowerTextBox"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Resiliance: </td>
                <td>
                    <asp:TextBox runat="server" ID="resilianceTextBox"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Wounds: </td>
                <td>
                    <asp:TextBox runat="server" ID="woundsTextBox"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Special Abilities: </td>
                <td>
                    <table>
                        <asp:Repeater runat="server" ID="abilitiesRepeater">
                            <ItemTemplate>
                                <tr>
                                    <td>
                                        <asp:Label runat="server" Text="Name: " Font-Bold="true"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "name") %>'></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label runat="server" Text="Description: " Font-Bold="true"></asp:Label>

                                    </td>
                                    <td>
                                        <asp:TextBox runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "description") %>'></asp:TextBox>
                                    </td>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                    </table>
                </td>
            </tr>
            <tr>
                <td>Actions: </td>
                <td>
                    <table>
                        <asp:Repeater runat="server" ID="actionsRepeater">
                            <ItemTemplate>
                                <tr>
                                    <td>
                                        <asp:Label runat="server" Font-Bold="true" Text="Name: "></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "name") %>'></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label runat="server" Font-Bold="true" Text="Type: "></asp:Label>

                                    </td>
                                    <td>
                                        <asp:TextBox runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "type") %>'></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label runat="server" Font-Bold="true" Text="Rating"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "rating") %>'></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:Label runat="server" Font-Bold="true" Text="Range"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "range") %>'></asp:TextBox>
                                    </td>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    <table>


                    </table>
                </td>
            </tr>
            
        </table>

        
        <div style="clear:both"></div>

    </div>
    


</asp:Content>
