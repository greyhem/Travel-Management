<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AvailableServices.aspx.cs" Inherits="ADMIN_MaintainBusInfo" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <table cellpadding="0" cellspacing="0" width="90%" align="center">
        <tr>
            <td align="left" >
                <b style="font-size: small;">Service Details</b>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblError" runat="server" Text="" ForeColor="red" CssClass="ErrorText"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                <asp:DataGrid ID="dgBusInfo" runat="server" DataKeyField="ServiceID"
                    Width="100%" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None"  >
                    <HeaderStyle HorizontalAlign="Center" Height="20px" CssClass="gridheader" BackColor="#507CD1" Font-Bold="True" ForeColor="White"></HeaderStyle>
                    <Columns>
                        <asp:BoundColumn DataField="ServiceName" HeaderText="Service Name"></asp:BoundColumn>
                        <asp:BoundColumn DataField="BusType" HeaderText="Bus Type"></asp:BoundColumn>
                        <asp:BoundColumn DataField="ServiceNumber" HeaderText="Service Number"></asp:BoundColumn>
                        <asp:BoundColumn DataField="Source" HeaderText="Source"></asp:BoundColumn>
                        <asp:BoundColumn DataField="Destination" HeaderText="Destination"></asp:BoundColumn>
                        <asp:BoundColumn DataField="NoOfSeatsAvailable" HeaderText="NoOfSeatsAvailable"></asp:BoundColumn>
                       
                    </Columns>
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" BackColor="#EFF3FB" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <EditItemStyle BackColor="#2461BF" />
                    <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <AlternatingItemStyle BackColor="White" />
                </asp:DataGrid>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
        </tr>
        <%-- <tr>
            <td style="height: 12px">
                <asp:LinkButton ID="lnkAdd" runat="server" CssClass="links3" Font-Bold="True" OnClick="lnkAdd_Click">Add</asp:LinkButton>&nbsp;&nbsp;|&nbsp;&nbsp;
               
            </td>
        </tr>--%>
        <tr>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
            </td>
        </tr>
    </table>
      
</asp:Content>

