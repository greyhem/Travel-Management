<%@ Page Language="C#" MasterPageFile="~/ADMIN/MasterPage.master" AutoEventWireup="true"
    CodeFile="ShowUserDetails.aspx.cs" Inherits="ADMIN_ShowUserDetails" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table cellpadding="0" cellspacing="6" align="center" width="100%" >
        <tr>
            <td colspan="2">
                <table id="tblAccountDetails" runat="server" cellpadding="0" cellspacing="5" align="center" class="border1" width="40%">
                    <tr id="Tr1" runat="server">
                        <td colspan="2" align="center" style="height: 18px">
                            <span style="font-size: 12pt"><span style="color: maroon"><b><span style="color: darkred;">
                                <em>
                               User Details</em></span></b> </span></span>
                        </td>
                    </tr>
                    <tr id="Tr2" runat="server">
                        <td id="Td2" align="right" width="27%" runat="server">
                            <b>User Name :</b>
                        </td>
                        <td id="Td3" align="left" runat="server">
                            <asp:Label ID="txtUserName" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" width="27%">
                            <span class="boldtxt">Email :</span>
                        </td>
                        <td align="left">
                            <asp:Label runat="server" ID="txtEmail" MaxLength="30" Wrap="False"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <span class="boldtxt">Country :</span>
                        </td>
                        <td align="left">
                            <asp:Label ID="lblCountry" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <span class="boldtxt">City :</span>
                        </td>
                        <td align="left">
                            <asp:Label runat="server" ID="txtCity" MaxLength="30" Wrap="False"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <span class="boldtxt">Address :</span>
                        </td>
                        <td align="left">
                            <asp:Label runat="server" ID="txtAddress" MaxLength="30" Wrap="False"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <span class="boldtxt">Phone :</span>
                        </td>
                        <td align="left">
                            <asp:Label runat="server" ID="txtPhCountry" Width="30px" MaxLength="3" Wrap="False"></asp:Label>
                            <b>-</b>
                            <asp:Label runat="server" ID="txtPhSTD" Width="50px" MaxLength="6" Wrap="False"></asp:Label>
                            <b>-</b>
                            <asp:Label runat="server" ID="txtPhone" Width="100px" MaxLength="10" Wrap="False"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <span class="boldtxt">Mobile :</span>
                        </td>
                        <td align="left">
                            <asp:Label runat="server" ID="txtMobileCountry" Width="30px" MaxLength="3" Wrap="False" />
                            <asp:Label runat="server" ID="txtMobile" MaxLength="10" Wrap="False" />
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <span class="boldtxt">Created Date :</span>
                        </td>
                        <td align="left">
                            <asp:Label ID="lblCreatedDate" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" align="center">
                            <asp:Button ID="btnBack" runat="server" Text="Back" CssClass="button" OnClick="btnBack_Click" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
