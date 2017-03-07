<%@ Page Language="C#" MasterPageFile="~/ADMIN/MasterPage.master" AutoEventWireup="true"
    CodeFile="MaintainCompanyInfo.aspx.cs" Inherits="ADMIN_MaintainCompanyInfo" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table cellpadding="0" cellspacing="0" width="90%" align="center">
        <tr>
            <td align="left">
                <b style="font-size: small;">Company Details</b>
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
                <asp:DataGrid ID="dgCompanyInfo" runat="server" DataKeyField="CompanyID"
                    Width="100%" AutoGenerateColumns="False" OnItemCommand="dgCompanyInfo_ItemCommand" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <HeaderStyle HorizontalAlign="Center" Height="20px" CssClass="gridheader" BackColor="#507CD1" Font-Bold="True" ForeColor="White"></HeaderStyle>
                    <Columns>
                        <asp:BoundColumn DataField="CompanyName" HeaderText="CompanyName"></asp:BoundColumn>
                        <asp:BoundColumn DataField="Description" HeaderText="Description Name"></asp:BoundColumn>
                        <asp:BoundColumn DataField="Address" HeaderText="Address"></asp:BoundColumn>
                            <asp:TemplateColumn>
                            <ItemTemplate>
                                <asp:LinkButton ID="lnkView" runat="server" CommandName="Edit" CssClass="bluelinks">Edit</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateColumn>
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
       
    </table>
</asp:Content>
