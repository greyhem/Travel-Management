<%@ Page Language="C#" MasterPageFile="~/ADMIN/MasterPage.master" AutoEventWireup="true" CodeFile="AdminArea.aspx.cs" Inherits="ADMIN_AdminArea" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table cellpadding="0" cellspacing="0" width="100%" height="100%">
        <tr>
            <td valign="middle">
                <table cellpadding="3" cellspacing="0" border="0" class="border1" width="90%" align="center">
                    <tr>
                        <td align="center">
                            <b>ADMIN AREA</b>
                        </td>
                    </tr>
                    <tr>
                        <td class="Headerline" height="1">
                        </td>
                    </tr>
                    <tr>
                        <td valign="top">
                            <table width="70%" border="0" align="center" cellpadding="1" cellspacing="0" class="border0">
                                <tr>
                                    <td>
                                        <table width="100%" border="0" cellpadding="1" cellspacing="1" class="adminareatab2">
                                            <tr>
                                                <td align="center">
                                                    <a href="MaintainUsers.aspx">
                                                        <img src="../Images/usermanagement.gif" width="32" height="32" border="0"></a></td>
                                                <td align="left">
                                                    <a href="MaintainUsers.aspx" class="bluelinks"><b>Maintain Users</b></a>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                    <td>
                                        <table width="100%" border="0" cellpadding="1" cellspacing="1" class="adminareatab1">
                                            <tr>
                                                <td align="center">
                                                    <a href="MaintainCompanyInfo.aspx">
                                                        <img src="../Images/categorymanagement.gif" width="32" height="32" border="0"></a></td>
                                                <td align="left">
                                                    <a href="MaintainCompanyInfo.aspx" class="bluelinks"><b>Maintain CompanyInfo</b></a></td>
                                            </tr>
                                        </table>
                                    </td>
                                    <td>
                                        <table width="100%" border="0" cellpadding="1" cellspacing="1" class="adminareatab2">
                                            <tr>
                                                <td align="center">
                                                    <a href="MaintainBusInfo.aspx">
                                                        <img src="../Images/maintainpartners.gif" width="32" height="32" border="0"></a></td>
                                                <td align="left">
                                                    <a href="MaintainBusInfo.aspx" class="bluelinks"><b>Maintain BusInfo</b></a>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <table width="100%" border="0" cellpadding="1" cellspacing="1" class="adminareatab2">
                                            <tr>
                                                <td align="center">
                                                    <a href="MaintainEmployees.aspx">
                                                        <img src="../Images/brandmanagement.gif" width="32" height="32" border="0" /></a></td>
                                                <td align="left">
                                                    <a href="MaintainEmployees.aspx" class="bluelinks"><b>Maintain Employees</b></a>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                    <td>
                                        <table width="100%" border="0" cellpadding="1" cellspacing="1" class="adminareatab2">
                                            <tr>
                                                <td align="center">
                                                    <a href="#">
                                                        <img alt="" src="../Images/maintainsecureshopping.gif" width="32" height="32" border="0" /></a></td>
                                                <td align="left">
                                                    <a href="MaintainFeedback.aspx" class="bluelinks"><b>Maintain Feedbacks</b></a>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                    <td>
                                       
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                       
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
