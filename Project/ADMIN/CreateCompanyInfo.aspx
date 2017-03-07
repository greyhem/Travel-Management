<%@ Page Language="C#" MasterPageFile="~/ADMIN/MasterPage.master" AutoEventWireup="true"
    CodeFile="CreateCompanyInfo.aspx.cs" Inherits="ADMIN_CreateCompanyInfo" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <script type="text/javascript">
      function Validation()
      {
             //For Company Name
            var CompanyName=trim(document.getElementById("<%=txtCompanyName.ClientID %>").value);
            var CompanyNameLen=trim(document.getElementById("<%=txtCompanyName.ClientID %>").value).length;
            if(CompanyName=="")
            {
                alert('Enter Company Name');
                document.getElementById("<%=txtCompanyName.ClientID %>").focus();
                return false;
            }
            if(CompanyName.length<5 || CompanyName.length>30)
            {
                alert('Min. Length of Company Name is 5 and Max. Length 30\n Current Length is '+CompanyNameLen);
                document.getElementById("<%=txtCompanyName.ClientID %>").focus();
                return false;
            }
            var ExpCompanyName=/^[A-Za-z0-9/. @$,#_-]+$/;
            if(!CompanyName.match(ExpCompanyName))
            {
                alert('Company Name Contains Invalid Characters');
                document.getElementById("<%=txtCompanyName.ClientID%>").focus();                                    
                return false;
            }
         
               //For Description
          
               var Pin3=trim(document.getElementById("<%=txtDescription.ClientID%>").value);
               var PinLen3=trim(document.getElementById("<%=txtDescription.ClientID %>").value).length;  
               if(Pin3=="")
            {
                alert('Enter Description');
                document.getElementById("<%=txtDescription.ClientID %>").focus();
                return false;
            }
             if(Pin3.length<15 || Pin3.length>60)
            {
                alert('Min. Length of Description is 15 and Max. Length 60\n Current Length is '+PinLen3);
                document.getElementById("<%=txtDescription.ClientID %>").focus();
                return false;
            }
          
               //For Address
          
               var Pin4=trim(document.getElementById("<%=txtAddress.ClientID%>").value);
               var PinLen4=trim(document.getElementById("<%=txtAddress.ClientID %>").value).length;  
               if(Pin4=="")
            {
                alert('Enter Address');
                document.getElementById("<%=txtAddress.ClientID %>").focus();
                return false;
            }
          
          
           
      
            }
    </script>

    <table cellpadding="0" cellspacing="5" align="center" class="border1" width="50%">
        <tr>
            <td colspan="2" align="center">
                <span style="font-size: 12pt"><span style="color: maroon"><b><span style="color: darkred;">
                    <em>Creation Of Company Information</em></span></b> </span></span>
            </td>
        </tr>
        <tr>
            <td colspan="2" align="right">
                <b><span style="color: #cc0000">* Compulsory Fields</span></b>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2">
            </td>
        </tr>
        <tr>
            <td align="right">
                <font color="red">*</font><b>CompanyName :</b>
            </td>
            <td align="left" colspan="2">
                <asp:TextBox ID="txtCompanyName" runat="server" CssClass="textbox" Width="144px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right">
                <font color="red">*</font><b>Description :</b>
            </td>
            <td align="left" colspan="2">
                <asp:TextBox ID="txtDescription" runat="server" CssClass="textbox" Height="120px"
                    TextMode="MultiLine" Width="336px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right">
                <font color="red">*</font><b>Address :</b>
            </td>
            <td align="left" colspan="2">
                <asp:TextBox ID="txtAddress" runat="server" CssClass="textbox" Height="56px" TextMode="MultiLine"
                    Width="152px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2">
            </td>
        </tr>
        <tr>
            <td align="center">
                &nbsp
            </td>
            <td align="center">
                <asp:Button ID="Button1" runat="server" Text="CREATE" OnClick="Button1_Click" CssClass="button"
                    OnClientClick="return Validation(this);" />
                <asp:Button ID="btnBack" runat="server" Text="Back" CssClass="button" OnClick="btnBack_Click" />
            </td>
        </tr>
        <tr>
            <td align="left" colspan="2">
                <asp:Label ID="lblError" runat="server" Font-Bold="True" ForeColor="#CC0000"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
