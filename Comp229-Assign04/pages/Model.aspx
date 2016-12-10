<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Model.aspx.cs" Inherits="Comp229_Assign04.Model" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
         
     <div class="col-xs-12 col-md-3">
        <asp:Image runat="server" ID="modelImg" Width="200px" />

    </div>

    <div class="col-xs-12 col-md-5">
        <table>
             <!--name-->
            <tr>
                <td>
                     <strong> Name: </strong>
                </td>
                <td>
                <asp:Label runat="server" ID="nameLabel"></asp:Label>
                </td>
            </tr>
             <!--faction-->
            <tr>
                <td>
                    <strong> Faction: </strong>
                </td>
                <td>
                <asp:Label runat="server" ID="factionLabel"></asp:Label>
                </td>
            </tr>
             <!--rank-->
            <tr>
                <td>
                      <strong> Rank :  </strong>
                </td>
                <td>
                    <asp:Label runat="server" ID="rankLabel"></asp:Label>
                </td>
            </tr>
             <!--base-->
            <tr>
                <td>
                      <strong>Base :   </strong>
                </td>
                <td>
                    <asp:Label runat="server" ID="baseLabel"></asp:Label>
                </td>
            </tr>
             <!--size-->
            <tr>
                <td>
                    <strong>Size: </strong>

                </td>
                <td>
                    <asp:Label runat="server" ID="sizeLabel"></asp:Label>
                </td>
            </tr>
             <!--deployment zone-->
            <tr>
                <td>
                    <strong> Deployment Zone :</strong>

                </td>
                <td>
                    <asp:Label runat="server" ID="deploymentLabel"></asp:Label>
                </td>
            </tr>
            <!--traits string-->
            <tr>
                <td>Traits: </td>
                <td>
                <asp:Repeater runat="server" ID="traitsList">
                    <ItemTemplate>
                       <asp:Label runat="server" Text="<%# Container.DataItem.ToString() %>"></asp:Label> <br />
                    </ItemTemplate>
                </asp:Repeater>
                </td>
            </tr>
            <!--types string-->
            <tr>
                <td>
                    <strong>Types:</strong> 

                </td>
                <td>
                <asp:Repeater runat="server" ID="defenceList">
                     <ItemTemplate>
                       <asp:Label runat="server" Text="<%# Container.DataItem.ToString() %>"></asp:Label> <br />
                     </ItemTemplate>
                </asp:Repeater>
                </td>
            </tr>
            <!--mobility -->
            <tr>
                <td>
                    <strong>Mobility:</strong>
                </td>
                <td>
                    <asp:Label runat="server" ID="mobilityLabel"></asp:Label><br />
                </td>
            </tr>
            <!--willpower -->
            <tr>
                <td>
                    <strong>Willpower:</strong> 
                <td>
                    <asp:Label runat="server" ID="willpowerLabel"></asp:Label><br />
                </td>
            </tr>
            <!--resiliance -->
            <tr>
                <td>
                    <strong>Resiliance: </strong>

                </td>
                <td>
                    <asp:Label runat="server" ID="resilianceLabel"></asp:Label><br />
                </td>
            </tr>
             <!--wounds -->
            <tr>
                <td>
                    <strong>Wounds:</strong> 
                </td>
                <td>
                    <asp:Label runat="server" ID="woundsLabel"></asp:Label><br />
                </td>
            </tr>
             <!--special abilities string with separate repeater -->
            <tr>
                <td>
                    <strong>Special Abilities:</strong><br /><br /> </td>
                <td>
                    <table>
                    <asp:Repeater runat="server" ID="abilitiesRepeater">
                        <ItemTemplate>
                           <tr>
                                <td>
                                    <asp:Label runat="server" Text="Name: " Font-Bold="true"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "name") %>'></asp:Label><br />
                                </td>
                           </tr>
                           <tr>
                                <td>
                                    <asp:Label runat="server" Text="Description: " Font-Bold="true"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "description") %>'></asp:Label><br /><br />
                                </td>
                           </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                    </table>
                </td>
            </tr>
             <!-- actions string with separate repeater -->
            <tr>
                <td>
                    <strong>Actions:</strong><br /><br />
                </td>
                <td>
                    <table>
                    <asp:Repeater runat="server" ID="actionsRepeater">
                        <ItemTemplate>
                             <tr>
                                <td>
                                    <asp:Label runat="server" Font-Bold="true" Text="Name: "></asp:Label>
                                </td>
                                <td>
                                    <asp:Label runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "name") %>'></asp:Label><br/>
                                </td>
                            </tr>
                            <tr>
                                 <td>
                                    <asp:Label runat="server" Font-Bold="true" Text="Type: "></asp:Label>
                                 </td>
                                 <td>
                                    <asp:Label runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "type") %>'></asp:Label><br />
                                 </td>
                                  <td>
                                     <asp:Label runat="server" Font-Bold="true" Text="Rating:"></asp:Label>
                                  </td>
                                  <td>
                                     <asp:Label runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "rating") %>'></asp:Label><br />
                                  </td>
                                  <td>
                                      <asp:Label runat="server" Font-Bold="true" Text="Range: "></asp:Label>
                                  </td>
                                  <td>
                                      <asp:Label runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "range") %>'></asp:Label><br />
                                  </td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                    </table>
                </td>
            </tr>
        </table>

        <asp:LinkButton ID="Update" runat="server" Text="Update" />

    </div>
    
    <div style="clear:both"></div>
   
</asp:Content>