<%@ Page Language="C#" MasterPageFile="~/ADMIN/MasterPage.master" AutoEventWireup="true"
    CodeFile="ViewFeedback.aspx.cs" Inherits="ADMIN_ViewFeedback" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table cellpadding="0" cellspacing="5" align="center" class="border1" width="40%">
        <tr>
            <td colspan="2" align="center" style="height: 18px">
                <span style="font-size: 12pt"><span style="color: maroon"><b><span style="color: darkred;">
                    <em>Feedback Details</em></span></b> </span></span>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2">
            </td>
        </tr>
        <tr>
            <td align="right" width="20%">
                <b>Name :</b>
            </td>
            <td align="left" colspan="2">
                <asp:Label ID="txtName" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="right">
               <b> Email Address :</b>
            </td>
            <td align="left" colspan="2">
                <asp:Label ID="txtEmail" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="right">
               <b> Mobile :</b>
            </td>
            <td align="left" colspan="2">
                <asp:Label runat="server" ID="txtMobileCountry" Width="30px" MaxLength="3" Wrap="False"></asp:Label>
                <b>-</b>
                <asp:Label runat="server" ID="txtMobile" MaxLength="10" Wrap="False" />
            </td>
        </tr>
        <tr>
            <td align="right">
                <b>Phone :</b>
            </td>
            <td align="left">
                <asp:Label runat="server" ID="txtPhCountry1" Width="30px" MaxLength="2"></asp:Label>
                <b>-</b>
                <asp:Label runat="server" ID="txtPhSTD1" Width="50px" MaxLength="6" Wrap="False"></asp:Label>
                <b>-</b>
                <asp:Label runat="server" ID="txtPhone1" Width="100px" MaxLength="15"></asp:Label>
                <br />
            </td>
        </tr>
        <tr>
            <td align="right">
                <b>Comments/Suggetions:</b>
            </td>
            <td align="left">
                <asp:Label ID="txtComments" runat="server" Height="107px" TextMode="MultiLine" Width="201px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="right">
               <b> Rating Of This Site :</b>
            </td>
            <td align="left">
                <asp:Label ID="lblRating" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="right">
                <b>Send Date :</b>
            </td>
            <td align="left">
                <asp:Label ID="lblCreatedDate" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2">
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <asp:Button ID="Button1" runat="server" Text="Back" OnClick="Button1_Click" CssClass="button" />
            </td>
        </tr>
    </table>
</asp:Content>
