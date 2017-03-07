<%@ Page Language="C#" MasterPageFile="~/ADMIN/MasterPage.master" AutoEventWireup="true"
    CodeFile="EditEmployeeInfo.aspx.cs" Inherits="ADMIN_EditEmployeeInfo" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <script type="text/javascript">
      function Validation()
      {
                       
            //For Employee Name
            var UserName=trim(document.getElementById("<%=txtEmployeeName.ClientID %>").value);
            var UserNAmeLen=trim(document.getElementById("<%=txtEmployeeName.ClientID %>").value).length;
            if(UserName=="")
            {
                alert('Enter Employee Name');
                document.getElementById("<%=txtEmployeeName.ClientID %>").focus();
                return false;
            }
            if(UserName.length<6 || UserName.length>20)
            {
                alert('Min. Length of Employee Name is 6 and Max. Length 20\n Current Length='+UserNAmeLen);
                document.getElementById("<%=txtEmployeeName.ClientID %>").focus();
                return false;
            }
            var ExpUserName=/^[A-Za-z0-9/.@-_$*()]+$/;
            if(!UserName.match(ExpUserName))
            {
                alert('Employee Name Contains Invalid Characters');
                document.getElementById("<%=txtEmployeeName.ClientID%>").focus();                                    
                return false;
            }
                  
         
                //For Designation
            var CompanyName=trim(document.getElementById("<%=txtDesignation.ClientID %>").value);
            var CompanyNameLen=trim(document.getElementById("<%=txtDesignation.ClientID %>").value).length;
            if(CompanyName=="")
            {
                alert('Enter Designation');
                document.getElementById("<%=txtDesignation.ClientID %>").focus();
                return false;
            }
            if(CompanyName.length<5 || CompanyName.length>30)
            {
                alert('Min. Length of Designation is 5 and Max. Length 30\n Current Length is '+CompanyNameLen);
                document.getElementById("<%=txtDesignation.ClientID %>").focus();
                return false;
            }
            var ExpCompanyName=/^[A-Za-z0-9/. @$,#_-]+$/;
            if(!CompanyName.match(ExpCompanyName))
            {
                alert('Designation Contains Invalid Characters');
                document.getElementById("<%=txtDesignation.ClientID%>").focus();                                    
                return false;
            }
         
                //For Email
            var Email=trim(document.getElementById("<%=txtEmail.ClientID %>").value);
            var EmailLen=trim(document.getElementById("<%=txtEmail.ClientID %>").value).length;
            var EmailExp=/^(\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)+$/;
            if(Email=="")
            {
                alert('Enter EMailId');
                document.getElementById("<%=txtEmail.ClientID %>").focus();
                return false;
            }
            if(Email.length>40)
            {
                alert('Max. Length of Email is 40\n Current Length='+EmailLen);
                document.getElementById("<%=txtEmail.ClientID %>").focus();
                return false;
            }  
            if(!Email.match(EmailExp))
            {
                alert('Invalid EmailId');
                document.getElementById("<%=txtEmail.ClientID%>").focus();                                   
                return false;
            }
              //For Mobile Country Code
            var MobileCountryCode=trim(document.getElementById("<%=txtMobileCountry.ClientID %>").value);
            var MobileCountryCodeLen=trim(document.getElementById("<%=txtMobileCountry.ClientID %>").value).length;
            if(MobileCountryCode=="")
            {
                alert('Enter Country Code');
                document.getElementById("<%=txtMobileCountry.ClientID %>").focus();
                return false;
            }
            if(MobileCountryCode.length<1 || MobileCountryCode.length>3)
            {
                alert('Min. Length of Country Code is 1 and Max. Length 3\n Current Length='+MobileCountryCodeLen);
                document.getElementById("<%=txtMobileCountry.ClientID %>").focus();
                return false;
            }
            var ExpMobileCountryCode=/^[0-9]+$/;
            if(!MobileCountryCode.match(ExpMobileCountryCode))
            {
                alert('Country Code Allows Numerics Only');
                document.getElementById("<%=txtMobileCountry.ClientID%>").focus();                                   
                return false;
            }
            //For Mobile Number
            var MobileNumber=trim(document.getElementById("<%=txtMobile.ClientID %>").value);
            var MobileNumberLen=trim(document.getElementById("<%=txtMobile.ClientID %>").value).length;
            if(MobileNumber=="")
            {
                alert('Enter Mobile Number');
                document.getElementById("<%=txtMobile.ClientID %>").focus();
                return false;
            }
            var ExpMobileNumber=/^[0-9]+$/;
            if(!MobileNumber.match(ExpMobileNumber))
            {
                alert('Mobile Number Allows Numerics Only');
                document.getElementById("<%=txtMobile.ClientID%>").focus();                                   
                return false;
            }
            if(MobileNumber.length<10 || MobileNumber.length>10)
            {
                alert('Min. Length of Mobile Number is 10 and Max. Length 10\n Current Length='+MobileNumberLen);
                document.getElementById("<%=txtMobile.ClientID %>").focus();
                return false;
            }
            
                     
                         
                //For Address
          
               var Pin3=trim(document.getElementById("<%=txtAddress.ClientID%>").value);
               var PinLen3=trim(document.getElementById("<%=txtAddress.ClientID %>").value).length;  
               if(Pin3=="")
            {
                alert('Enter Address');
                document.getElementById("<%=txtAddress.ClientID %>").focus();
                return false;
            }
          
               //For Alloted To Branch
            if(document.getElementById("<%=ddlBranch.ClientID%>").selectedIndex==0)
            {
                alert('Select Bus Type');
                document.getElementById("<%=ddlBranch.ClientID%>").focus();
                return false;
            }  
            
          
          
           
      
            }
    </script>

    <table cellpadding="0" cellspacing="5" align="center" class="border1" width="40%">
        <tr>
            <td colspan="2" align="center">
                <span style="font-size: 12pt"><span style="color: maroon"><b><span style="color: darkred;">
                    <em>Employee Details</em></span></b> </span></span>
            </td>
        </tr>
        <tr>
            <td colspan="2" align="right">
                <b><span style="color: #cc0000">* Compulsory Fields</span></b>
            </td>
        </tr>
        <tr>
            <td align="right">
                <font color="red">*</font><b>Employee Name :</b>
            </td>
            <td align="left" colspan="2">
                <asp:TextBox ID="txtEmployeeName" runat="server" CssClass="textbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right">
                <font color="red">*</font><b>Designation :</b>
            </td>
            <td align="left" colspan="2">
                <asp:TextBox ID="txtDesignation" runat="server" CssClass="textbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right">
                <font color="red">*</font><b>Email :</b>
            </td>
            <td align="left" colspan="2">
                <asp:TextBox ID="txtEmail" runat="server" CssClass="textbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right">
                <font color="red">*</font><b>Mobile :</b>
            </td>
            <td align="left" colspan="2">
                <asp:TextBox runat="server" CssClass="textbox" ID="txtMobileCountry" Width="30px"
                    MaxLength="3" Wrap="False"></asp:TextBox>
                <b>-</b>
                <asp:TextBox runat="server" CssClass="textbox" ID="txtMobile" MaxLength="10" Wrap="False" />
                <br />
                Country Code - Mobile Number
            </td>
        </tr>
        <tr>
            <td align="right" style="height: 86px">
                <font color="red">*</font><b>Address :</b>
            </td>
            <td align="left" style="width: 190px; height: 86px">
                <asp:TextBox ID="txtAddress" runat="server" CssClass="textbox" Height="56px" TextMode="MultiLine"
                    Width="168px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right">
                <font color="red">*</font><b>Alloted To Branch :</b>
            </td>
            <td align="left" style="width: 190px">
                <asp:DropDownList ID="ddlBranch" runat="server">
                    <asp:ListItem>Select Branch</asp:ListItem>
                    <asp:ListItem>Hyderabad</asp:ListItem>
                    <asp:ListItem>Chennai</asp:ListItem>
                    <asp:ListItem>Kurnool</asp:ListItem>
                    <asp:ListItem>Nandyal</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td align="right">
                <b>Created Date :</b>
            </td>
            <td align="left" colspan="2">
                <asp:Label ID="lblCreatedDate" runat="server" Text="Label"></asp:Label>
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
                <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="button" OnClientClick="return Validation(this);"
                    OnClick="btnSave_Click" />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="button" OnClick="btnCancel_Click" />
            </td>
        </tr>
        <tr>
            <td align="left" colspan="2">
                <asp:Label ID="lblError" runat="server" Font-Bold="True" ForeColor="#CC0000"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
