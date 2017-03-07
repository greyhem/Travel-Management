<%@ Page Language="C#" MasterPageFile="~/Users/MasterPage.master" AutoEventWireup="true"
    CodeFile="ChangePassword.aspx.cs" Inherits="Users_ChangePassword" Title="Changing Forword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <script type="text/javascript">
    function Changepassword()
    {
        //For oldPassWord
            var OldPassword=document.getElementById("<%=txtOldPassword.ClientID%>").value;
            if(OldPassword=="")
            {
                alert('Enter old Password');
                document.getElementById("<%=txtOldPassword.ClientID %>").focus();
                return false;
            }

            //For Password
            var Password=document.getElementById("<%=txtNewPwd.ClientID %>").value;
            var PasswordLen=document.getElementById("<%=txtNewPwd.ClientID %>").value.length;
            if(Password=="")
            {
                alert('Enter New Password');
                document.getElementById("<%=txtNewPwd.ClientID %>").focus();
                return false;
            }
            if(Password.length<4 || Password.length>20)
            {
                alert('Min. Length of Password is 4 and Max. Length 20\n Current Length is '+PasswordLen);
                document.getElementById("<%=txtNewPwd.ClientID %>").focus();
                return false;
            }
            var ExpPassword=/^[A-Za-z0-9/_@#$&~!%^*-.]+$/;
            if(!Password.match(ExpPassword))
            {
                alert('Password Contains invalid Characters');
                document.getElementById("<%=txtNewPwd.ClientID%>").focus();                                   
                return false;
            }
            //For confirm Password
            if(document.getElementById("<%=txtNewPwd.ClientID%>").value!=document.getElementById("<%=txtConfNewPwd.ClientID%>").value)
            {
                alert('Password and confirm password must be same');
                document.getElementById("<%=txtConfNewPwd.ClientID%>").focus();
                return false;
            }   
    }
    </script>

    <table class="border0" cellspacing="0" cellpadding="0" width="95%" align="center"
        border="0">
        <tr>
            <td class="sheader" width="100%" align="center">
                <%-- <b style="color: Black;">Change Your Password</b></td>--%>
                <span style="font-size: 12pt"><span style="color: maroon"><b><span style="color: darkred;">
                    <em>Change Your Password</em></span></b> </span></span>
        </tr>
        <tr valign="top">
            <td height="20" valign="middle" align="left">
                <font color="red">&nbsp;&nbsp;* Indicates mandatory</font></td>
        </tr>
        <tr valign="top">
            <td>
                <table cellspacing="0" cellpadding="0" width="95%" align="center" border="0">
                    <tr>
                        <td valign="top">
                            <table class="border1" cellspacing="0" cellpadding="2" width="100%" align="center"
                                border="0">
                                <tr>
                                    <td colspan="2">
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="4" height="10" align="left">
                                        <asp:Label ID="lblErrMsg" runat="server" CssClass="ErrorText" ForeColor="Red"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" width="45%">
                                        <font color="red">*</font><strong>Old Password:</strong></td>
                                    <td align="left">
                                        <asp:TextBox ID="txtOldPassword" runat="server" TextMode="Password" CssClass="textbox"
                                            MaxLength="20" Wrap="False"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" width="40%">
                                        <font color="red">*</font><strong>New Password:</strong></td>
                                    <td align="left">
                                        <asp:TextBox ID="txtNewPwd" runat="server" TextMode="Password" CssClass="textbox"
                                            MaxLength="20" Wrap="False"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" width="40%">
                                        <font color="red">*</font><strong>Confirm New Password:</strong></td>
                                    <td align="left">
                                        <asp:TextBox ID="txtConfNewPwd" runat="server" TextMode="Password" CssClass="textbox"
                                            MaxLength="20" Wrap="False"></asp:TextBox>&nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2">
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center" colspan="2">
                                        <asp:Button ID="btnChangePwd" runat="server" CssClass="button" Text="Change Password"
                                            OnClientClick="return Changepassword();" OnClick="btnChangePwd_Click"></asp:Button>&nbsp;
                                        <asp:Button ID="btnCancel" runat="server" CssClass="button" Text="Back" OnClick="btnCancel_Click">
                                        </asp:Button>
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
            </td>
        </tr>
        <tr valign="top">
            <td height="15">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
