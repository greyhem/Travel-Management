<%@ Page Language="C#" MasterPageFile="~/Users/MasterPage.master" AutoEventWireup="true"
    CodeFile="EditProfile.aspx.cs" Inherits="Employees_EditProfile" Title="Employee Profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <script type="text/javascript">
      function Validation()
      {
         
              //For Email
            var Email=document.getElementById("<%=txtEmail.ClientID %>").value;
            var EmailLen=document.getElementById("<%=txtEmail.ClientID %>").value.length;
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
          
             //For Country
            if(document.getElementById("<%=ddlCountry.ClientID%>").selectedIndex==0)
            {
                alert('Select Country');
                document.getElementById("<%=ddlCountry.ClientID%>").focus();
                return false;
            }          
             //For City
           var ContactPerson=document.getElementById("<%=txtCity.ClientID %>").value;
            var ContactPersonLen=document.getElementById("<%=txtCity.ClientID %>").value.length;
            if(ContactPerson=="")
            {
                alert('Enter City');
                document.getElementById("<%=txtCity.ClientID %>").focus();
                return false;
            }
            if(ContactPerson.length<4 || ContactPerson.length>30)
            {
                alert('Min. Length of City is 4 and Max. Length 30\n Current Length='+ContactPersonLen);
                document.getElementById("<%=txtCity.ClientID %>").focus();
                return false;
            }
            var ExpContactPerson=/^[A-Z a-z/ .]+$/;
            if(!ContactPerson.match(ExpContactPerson))
            {
                alert('ContactPerson Allows Only Alphabets');
                document.getElementById("<%=txtCity.ClientID%>").focus();                                    
                return false;
            }
              //For Address
          
               var Address=document.getElementById("<%=txtAddress.ClientID%>").value;
               var AddressLen3=document.getElementById("<%=txtAddress.ClientID %>").value.length;  
               if(Address=="")
            {
                alert('Enter Address');
                document.getElementById("<%=txtAddress.ClientID %>").focus();
                return false;
            }
          
            //For Mobile Country Code
            var MobileCountryCode=document.getElementById("<%=txtMobileCountry.ClientID %>").value;
            var MobileCountryCodeLen=document.getElementById("<%=txtMobileCountry.ClientID %>").value.length;
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
            var MobileNumber=document.getElementById("<%=txtMobile.ClientID %>").value;
            var MobileNumberLen=document.getElementById("<%=txtMobile.ClientID %>").value.length;
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
          
           
             //For Phone Country Code2
            if(document.getElementById("<%=txtPhCountry.ClientID %>").value!="")
            {
                var PhoneCountryCode=document.getElementById("<%=txtPhCountry.ClientID %>").value;
                var PhoneCountryCodeLen=document.getElementById("<%=txtPhCountry.ClientID %>").value.length;            
                if(PhoneCountryCode.length<2 || PhoneCountryCode.length>2)
                {
                    alert('Min. Length of Country Code is 2 and Max. Length 2\n Current Length='+PhoneCountryCodeLen);
                    document.getElementById("<%=txtPhCountry.ClientID %>").focus();
                    return false;
                }
                var ExpPhoneCountryCode=/^[0-9]+$/;
                if(!PhoneCountryCode.match(ExpPhoneCountryCode))
                {
                    alert('Country Code Allows Numerics Only');
                    document.getElementById("<%=txtPhCountry.ClientID%>").focus();                                   
                    return false;
                }
            }
            //For Phone STD Code2
            if(document.getElementById("<%=txtPhSTD.ClientID %>").value!="")
            {
                var PhoneSTDCode=document.getElementById("<%=txtPhSTD.ClientID %>").value;
                var PhoneSTDCodeLen=document.getElementById("<%=txtPhSTD.ClientID %>").value.length;            
                if(PhoneSTDCode.length<3 || PhoneSTDCode.length>6)
                {
                    alert('Min. Length of STD Code is 3 and Max. Length 6\n Current Length='+PhoneSTDCodeLen);
                    document.getElementById("<%=txtPhSTD.ClientID %>").focus();
                    return false;
                }
                var ExpPhoneSTDCode=/^[0-9]+$/;
                if(!PhoneSTDCode.match(ExpPhoneSTDCode))
                {
                    alert('STD Code Allows Numerics Only');
                    document.getElementById("<%=txtPhSTD.ClientID%>").focus();                                   
                    return false;
                }
            }
            //For Phone Number2
            if(document.getElementById("<%=txtPhone.ClientID %>").value!="")
            {
                var Phone=document.getElementById("<%=txtPhone.ClientID %>").value;
                var PhoneLen=document.getElementById("<%=txtPhone.ClientID %>").value.length;            
                if(Phone.length<6 || Phone.length>10)
                {
                    alert('Min. Length of Phone is 6 and Max. Length 10\n Current Length='+PhoneLen);
                    document.getElementById("<%=txtPhone.ClientID %>").focus();
                    return false;
                }
                var ExpPhone=/^[0-9]+$/;
                if(!Phone.match(ExpPhone))
                {
                    alert('Phone Number Allows Numerics Only');
                    document.getElementById("<%=txtPhone.ClientID%>").focus();                                   
                    return false;
                }
            }
          
             
            }
    </script>

    <table cellpadding="0" cellspacing="5" width="100%">
        <tr>
            <td width="20%">
                &nbsp;
            </td>
            <td align="center">
                <table cellpadding="0" cellspacing="5" class="border1" width="100%">
                    <tr>
                        <td align="left" colspan="2">
                            <asp:Label ID="lblError" runat="server" ForeColor="Red" CssClass="ErrorText"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" align="right">
                            <font color="red">* Indicates mandatory</font>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" align="left" class="border">
                            <%--<b style="font-size: small;">Account Information</b>--%>
                            <span style="font-size: 9pt"><span style="color: maroon"><b><span style="color: darkred;">
                                <em>Account Information</em></span></b> </span></span>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" style="width: 170px">
                            <b>UserName :</b>
                        </td>
                        <td align="left">
                            <asp:Label ID="lblUserName" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" style="width: 170px">
                            <font color="red">*</font><b>Email :</b>
                        </td>
                        <td align="left">
                            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" style="width: 170px">
                            <font color="red">*</font><b>Address :</b>
                        </td>
                        <td align="left">
                            <asp:TextBox ID="txtAddress" runat="server" CssClass="textbox" TextMode="MultiLine"
                                MaxLength="250" Wrap="False"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" align="left" class="border">
                            <%--<b style="font-size: small;">Primary Contact Details</b>--%>
                            <span style="font-size: 9pt"><span style="color: maroon"><b><span style="color: darkred;">
                                <em>Primary Contact Details</em></span></b> </span></span>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" style="width: 170px">
                            <font color="red">*</font><b>Country :</b>
                        </td>
                        <td align="left">
                            <asp:DropDownList ID="ddlCountry" runat="server" Width="151px" onchange="return BindState();">
                                <asp:ListItem Value="0">Select</asp:ListItem>
                                <asp:ListItem Value="1">Australia</asp:ListItem>
                                <asp:ListItem Value="2">Bahrain</asp:ListItem>
                                <asp:ListItem Value="3">Bangladesh</asp:ListItem>
                                <asp:ListItem Value="4">Belgium</asp:ListItem>
                                <asp:ListItem Value="5">Canada</asp:ListItem>
                                <asp:ListItem Value="6">Doha</asp:ListItem>
                                <asp:ListItem Value="7">Dubai</asp:ListItem>
                                <asp:ListItem Value="8">France</asp:ListItem>
                                <asp:ListItem Value="9">Germany</asp:ListItem>
                                <asp:ListItem Value="10">Hong Kong</asp:ListItem>
                                <asp:ListItem Value="11">INDIA</asp:ListItem>
                                <asp:ListItem Value="12">Indonesia</asp:ListItem>
                                <asp:ListItem Value="13">Ireland</asp:ListItem>
                                <asp:ListItem Value="14">Italy</asp:ListItem>
                                <asp:ListItem Value="15">Japan</asp:ListItem>
                                <asp:ListItem Value="16">Kenya</asp:ListItem>
                                <asp:ListItem Value="17">Kuwait</asp:ListItem>
                                <asp:ListItem Value="18">Lebanon</asp:ListItem>
                                <asp:ListItem Value="19">Libya</asp:ListItem>
                                <asp:ListItem Value="20">Malaysia</asp:ListItem>
                                <asp:ListItem Value="21">Maldives</asp:ListItem>
                                <asp:ListItem Value="22">Mauritius</asp:ListItem>
                                <asp:ListItem Value="23">Mexico</asp:ListItem>
                                <asp:ListItem Value="24">Nepal</asp:ListItem>
                                <asp:ListItem Value="25">Netherlands</asp:ListItem>
                                <asp:ListItem Value="26">New Zealand</asp:ListItem>
                                <asp:ListItem Value="27">Norway</asp:ListItem>
                                <asp:ListItem Value="28">Oman</asp:ListItem>
                                <asp:ListItem Value="29">Pakistan</asp:ListItem>
                                <asp:ListItem Value="30">Qatar</asp:ListItem>
                                <asp:ListItem Value="31">Quilon</asp:ListItem>
                                <asp:ListItem Value="32">Russia</asp:ListItem>
                                <asp:ListItem Value="33">Saudi Arabia</asp:ListItem>
                                <asp:ListItem Value="34">Singapore</asp:ListItem>
                                <asp:ListItem Value="35">South Africa</asp:ListItem>
                                <asp:ListItem Value="36">South Korea</asp:ListItem>
                                <asp:ListItem Value="37">Spain</asp:ListItem>
                                <asp:ListItem Value="38">Sri Lanka</asp:ListItem>
                                <asp:ListItem Value="39">Sweden</asp:ListItem>
                                <asp:ListItem Value="40">Switzerland</asp:ListItem>
                                <asp:ListItem Value="41">Thailand</asp:ListItem>
                                <asp:ListItem Value="42">UAE</asp:ListItem>
                                <asp:ListItem Value="43">UK</asp:ListItem>
                                <asp:ListItem Value="44">US</asp:ListItem>
                                <asp:ListItem Value="45">Yemen</asp:ListItem>
                                <asp:ListItem Value="46">Zimbabwe</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" style="width: 170px">
                            <font color="red">*</font><b>City :</b>
                        </td>
                        <td align="left">
                            <asp:TextBox ID="txtCity" runat="server" CssClass="textbox" MaxLength="30" Wrap="False"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" style="width: 170px">
                            <b><font color="red">*</font><span class="boldtxt">Mobile :</span></b>
                        </td>
                        <td align="left">
                            <asp:TextBox runat="server" CssClass="textbox" ID="txtMobileCountry" Width="30px"
                                MaxLength="3" Wrap="False">91</asp:TextBox>
                            <b>-</b>
                            <asp:TextBox runat="server" CssClass="textbox" ID="txtMobile" MaxLength="10" Wrap="False"
                                Width="102px" />
                            <br />
                            Country Code - Mobile Number
                        </td>
                    </tr>
                    <tr>
                        <td align="right" style="width: 170px">
                            <b><span class="boldtxt">Phone Number :</span></b>
                        </td>
                        <td align="left">
                            <asp:TextBox runat="server" CssClass="textbox" ID="txtPhCountry" MaxLength="3" Width="30px"
                                Wrap="False"></asp:TextBox>
                            <b>-</b>
                            <asp:TextBox runat="server" CssClass="textbox" ID="txtPhSTD" MaxLength="6" Wrap="False"
                                Width="40px"></asp:TextBox>
                            <b>-</b>
                            <asp:TextBox runat="server" CssClass="textbox" ID="txtPhone" MaxLength="10" Wrap="False"></asp:TextBox>
                            <br />
                            Country Code - STD Code - Phone Number
                        </td>
                    </tr>
                    <%--<tr>
                        <td align="right">
                            <b>Created Date:</b>
                        </td>
                        <td align="left">
                            <asp:TextBox ID="txtCreatedDate" runat="server" CssClass="textbox" MaxLength="10"></asp:TextBox>
                        </td>
                    </tr>--%>
                    <tr>
                        <td colspan="2" align="center">
                            <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="button" OnClientClick="return Validation(this);"
                                OnClick="btnSave_Click" />
                            <asp:Button ID="btnReset" runat="server" Text="Cancel" CssClass="button" OnClick="btnReset_Click" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
