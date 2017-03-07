<%@ Page Language="C#" MasterPageFile="~/Users/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Users_Login" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <script type="text/javascript">
    function CheckLogin()
    {
        //For User Name
        var UserName=trim(document.getElementById("<%=txtUserName.ClientID %>").value);
        if(UserName=="")
        {
            alert('Enter User Name');
            document.getElementById("<%=txtUserName.ClientID %>").focus();
            return false;
        }
        //For Password
        var Password=trim(document.getElementById("<%=txtPassword.ClientID %>").value);
        if(Password=="")
        {
            alert('Enter Password');
            document.getElementById("<%=txtPassword.ClientID %>").focus();
            return false;
        }
    }        
    </script>

   <asp:Panel ID="Panel1" runat="server" Height="190px" Style="z-index: 100; left: 320px;
                        position: absolute; top: 352px" Width="271px">
                        <table style="z-index: 100; left: 8px; position: absolute; top: 0px">
                            <tr>
                                <td style="width: 100px; height: 45px;">
                                    &nbsp;<br />
                                    <asp:Label ID="LblUserName" runat="server" Text="UserName" Style="z-index: 100; left: 16px;
                                        position: absolute; top: 16px" Font-Bold="True" Font-Names="Arial" Font-Size="10pt"
                                        ForeColor="Black"></asp:Label>
                                </td>
                                <td style="width: 149px; height: 45px;">
                                    <asp:TextBox ID="txtUserName" runat="server" Font-Names="Arial" Font-Size="8pt" Style="z-index: 100;
                                        left: 120px; position: absolute; top: 16px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 100px">
                                    &nbsp;<br />
                                    <asp:Label ID="LblPassword" runat="server" Text="Password" Style="z-index: 100; left: 16px;
                                        position: absolute; top: 64px" Font-Bold="True" Font-Names="Arial" Font-Size="10pt"
                                        ForeColor="Black"></asp:Label>
                                </td>
                                <td style="width: 149px">
                                    <asp:TextBox ID="txtPassword" runat="server" Font-Names="Arial" Font-Size="8pt" TextMode="Password"
                                        Style="z-index: 100; left: 120px; position: absolute; top: 64px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <asp:Button ID="BtnSubmit" runat="server" Text="Submit" Style="z-index: 100; left: 144px;
                                        position: absolute; top: 96px" Font-Bold="True" Font-Names="Arial" Font-Size="8pt"
                                        ForeColor="White" OnClick="BtnSubmit_Click" Width="56px" CssClass="button" BackColor="Black" />
                                    <tr>
                                    <td colspan="2" align="center">
                                        <asp:CheckBox ID="chkSavePassword" runat="server" />
                                        <b>Remember my Login</b>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2" align="left">
                                        <asp:Label ID="lblError" runat="server" ForeColor="Red" CssClass="ErrorText" />
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2" align="center">
                                        <a href="ForgotPassword.aspx" class="links">Forgot Password?</a>
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>

