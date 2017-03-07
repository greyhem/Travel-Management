<%@ Page Language="C#" MasterPageFile="~/USERS/MasterPage.master" AutoEventWireup="true" CodeFile="MyProfile.aspx.cs" Inherits="USERS_MyProfile" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <table cellpadding="0" cellspacing="5" width="100%">
        <tr>
            <td valign="top" align="left">
                &nbsp;</td>
            <td valign="top" align="left">
               
            </td>
            <td valign="top">
                <table cellpadding="3" cellspacing="5" class="border1" width="80%" align="center">
                    <tr>
                        <td align="left" colspan="2">
                            <asp:Label ID="lblError" runat="server" ForeColor="Red" CssClass="ErrorText"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                    </tr>
                    <tr>
                        <td colspan="2" align="left">
                            <span class="heading">Account Information</span>
                        </td>
                    </tr>
                   <%-- <tr>
                        <td align="left" colspan="2">
                            <img alt="" src="../Images/Div_line.gif" />
                        </td>
                    </tr>--%>
                    <tr>
                        <td align="right">
                            <b>UserName :</b>
                        </td>
                        <td align="left">
                            <asp:Label ID="lblUserName" runat="server"></asp:Label>
                        </td>
                    </tr>
                   
                    <tr>
                        <td align="right">
                            <b>Email :</b>
                        </td>
                        <td align="left">
                            <asp:Label ID="lblEmail" runat="server"></asp:Label>
                        </td>
                    </tr>
                    
                   
                    
                    <tr>
                        <td align="right">
                            <b>Address :</b>
                        </td>
                        <td align="left">
                            <asp:Label ID="lblAddress" runat="server"></asp:Label>
                        </td>
                    </tr>
                  
                   
                  
                   
                    <tr>
                        <td colspan="2" align="left">
                            <span class="heading">Primary Contact Details</span>
                        </td>
                    </tr>
                    <%--<tr>
                        <td align="left" colspan="2">
                            <img alt="" src="../Images/Div_line.gif" />
                        </td>
                    </tr>--%>
                    <tr>
                        <td align="right">
                            <b>Country :</b>
                        </td>
                        <td align="left">
                            <asp:Label ID="ddlCountry" runat="server"></asp:Label>
                        </td>
                    </tr>
                    
                    <tr>
                        <td align="right">
                            <b>City :</b>
                        </td>
                        <td align="left">
                            <asp:Label ID="ddlCity" runat="server"></asp:Label>
                        </td>
                    </tr>
                    
                    <tr>
                        <td align="right">
                            <b><span class="boldtxt">Mobile :</span></b>
                        </td>
                        <td align="left">
                            <asp:Label ID="txtMobileCountry" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <b><span class="boldtxt">Phone Number :</span></b>
                        </td>
                        <td align="left">
                            <asp:Label ID="txtPhCountry" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <b>Created Date:</b>
                        </td>
                        <td align="left">
                            <asp:Label ID="lblCreatedDate" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <asp:Button ID="btnEdit" runat="server" Text="Edit Profile" CssClass="button" OnClick="btnEdit_Click" />
                        </td>
                        <td align="left">
                            <asp:Button ID="btnBack" runat="server" Text="Back To BSR" CssClass="button" OnClick="btnBack_Click"
                                />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            &nbsp;
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>

