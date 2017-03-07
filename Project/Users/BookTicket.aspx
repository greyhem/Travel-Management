<%@ Page Language="C#" MasterPageFile="~/Users/MasterPage.master" AutoEventWireup="true"
    CodeFile="BookTicket.aspx.cs" Inherits="Users_BookTicket" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <script type="text/javascript">
      function Validation()
      {
            
            //For User Name
            var UserName=document.getElementById("<%=txtName.ClientID %>").value;
            var UserNAmeLen=document.getElementById("<%=txtName.ClientID %>").value.length;
            if(UserName=="")
            {
                alert('Enter User Name');
                document.getElementById("<%=txtName.ClientID %>").focus();
                return false;
            }
            if(UserName.length<6 || UserName.length>20)
            {
                alert('Min. Length of User Name is 6 and Max. Length 20\n Current Length='+UserNAmeLen);
                document.getElementById("<%=txtName.ClientID %>").focus();
                return false;
            }
            var ExpUserName=/^[A-Za-z0-9/.@-_$#%&*()]+$/;
            if(!UserName.match(ExpUserName))
            {
                alert('UserName Contains Invalid Characters');
                document.getElementById("<%=txtName.ClientID%>").focus();                                    
                return false;
            }
           
         
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
          
             //For Service Number
            if(document.getElementById("<%=ddlServiceNumber.ClientID%>").selectedIndex==0)
            {
                alert('Choose Service Number');
                document.getElementById("<%=ddlServiceNumber.ClientID%>").focus();
                return false;
            }      
            //For ID Card Type
            var CardName=trim(document.getElementById("<%=txtCardType.ClientID %>").value);
            var CardNameLen=trim(document.getElementById("<%=txtCardType.ClientID %>").value).length;
            if(CardName=="")
            {
                alert('Enter Card Type');
                document.getElementById("<%=txtCardType.ClientID %>").focus();
                return false;
            }
            if(CardName.length<4 || CardName.length>20)
            {
                alert('Min. Length of Card Name is 4 and Max. Length 20\n Current Length='+CardNameLen);
                document.getElementById("<%=txtCardType.ClientID %>").focus();
                return false;
            }
            var ExpCardName=/^[A-Za-z0-9/.@-_$*()]+$/;
            if(!CardName.match(ExpCardName))
            {
                alert('ID Card Type Contains Invalid Characters');
                document.getElementById("<%=txtCardType.ClientID%>").focus();                                    
                return false;
            }
             //For ID Card Number
         
               var ServiceNumber=document.getElementById("<%=txtCardNumber.ClientID%>").value;
               var ServiceNumberLen=document.getElementById("<%=txtCardNumber.ClientID %>").value.length;  
                if(ServiceNumber=="")
            {
                alert('Enter Card Number');
                document.getElementById("<%=txtCardNumber.ClientID %>").focus();
                return false;
            }
               var ExpServiceNumber=/^[0-9]+$/;
               if(!ServiceNumber.match(ExpServiceNumber))
               {
                    alert('Card Number Number Allows Numerics Only');
                    document.getElementById("<%=txtCardNumber.ClientID%>").focus();                                   
                    return false;
               }          
               if(ServiceNumber.length<4 || ServiceNumber.length>6)
               {
                   alert('Invalid Card Number');
                   document.getElementById("<%=txtCardNumber.ClientID %>").focus();
                   return false;
               } 
                //For Issuing Authority
            var CardName1=trim(document.getElementById("<%=txtAuthority.ClientID %>").value);
            var CardNameLen1=trim(document.getElementById("<%=txtAuthority.ClientID %>").value).length;
            if(CardName1=="")
            {
                alert('Enter Issuing Authority');
                document.getElementById("<%=txtAuthority.ClientID %>").focus();
                return false;
            }
            if(CardName1.length<4 || CardName1.length>20)
            {
                alert('Min. Length of Issuing Authority is 4 and Max. Length 20\n Current Length='+CardNameLen1);
                document.getElementById("<%=txtAuthority.ClientID %>").focus();
                return false;
            }
            var ExpCardName1=/^[A-Za-z0-9/.@-_$*()]+$/;
            if(!CardName1.match(ExpCardName1))
            {
                alert('Issuing Authority Contains Invalid Characters');
                document.getElementById("<%=txtAuthority.ClientID%>").focus();                                    
                return false;
            }                                   
             
                 //For Number Of Passengers
         
               var ServiceNumber1=document.getElementById("<%=txtPassengers.ClientID%>").value;
               var ServiceNumberLen1=document.getElementById("<%=txtPassengers.ClientID %>").value.length;  
                if(ServiceNumber1=="")
            {
                alert('Enter Number Of Passengers');
                document.getElementById("<%=txtPassengers.ClientID %>").focus();
                return false;
            }
               var ExpServiceNumber1=/^[0-9]+$/;
               if(!ServiceNumber1.match(ExpServiceNumber1))
               {
                    alert('Number Of Passengers Allows Numerics Only');
                    document.getElementById("<%=txtPassengers.ClientID%>").focus();                                   
                    return false;
               }          
               if(ServiceNumber1.length<1 || ServiceNumber1.length>6)
               {
                   alert('Invalid Number Of Passengers');
                   document.getElementById("<%=txtPassengers.ClientID %>").focus();
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

    <asp:Wizard ID="Wizard1" runat="server" CancelButtonText="" CancelButtonType="Link"
        FinishCompleteButtonText="" FinishCompleteButtonType="Link" FinishPreviousButtonText=""
        FinishPreviousButtonType="Link" StartNextButtonText="" StartNextButtonType="Link"
        StepNextButtonText="" StepNextButtonType="Link" StepPreviousButtonText="" StepPreviousButtonType="Link"
        DisplaySideBar="False" align="center" Width="800px" ActiveStepIndex="0">
        <WizardSteps>
            <asp:WizardStep ID="WizardStep1" runat="server" Title="Step 1" AllowReturn="False"
                StepType="Start">
                <table cellpadding="0" cellspacing="5" align="center" width="100%" class="border1" >
                    <tr>
                        <td align="left" colspan="2">
                            <asp:Label ID="lblError" runat="server" CssClass="ErrorText" ForeColor="Red"></asp:Label>
                            <asp:Label ID="Label1" runat="server" Visible="False"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" align="right">
                            <font color="red">* Indicates mandatory</font>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <table id="tblAccountDetails" runat="server" cellpadding="0" cellspacing="5" width="100%">
                                <tr id="Tr1" runat="server">
                                    <td colspan="2" align="center">
                                        <span style="font-size: 12pt"><span style="color: maroon"><b><span style="color: darkred;">
                                            <em>RESERVE A TICKET</em></span></b> </span></span>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        <font color="red">*</font><span class="boldtxt">Name :</span>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtName" runat="server" CssClass="textbox" MaxLength="30" Wrap="False"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        <font color="red">*</font><span class="boldtxt">Email :</span>
                                    </td>
                                    <td align="left">
                                        <asp:TextBox ID="txtEmail" runat="server" CssClass="textbox" MaxLength="30" Wrap="False"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr id="Tr3" runat="server">
                                    <td id="Td4" align="right" runat="server">
                                        <font color="red">*</font><b>Service Number :</b>
                                    </td>
                                    <td id="Td5" align="left" runat="server">
                                        <asp:DropDownList ID="ddlServiceNumber" runat="server" AppendDataBoundItems="True"
                                            AutoPostBack="True" Width="128px" OnSelectedIndexChanged="ddlServiceNumber_SelectedIndexChanged">
                                            <asp:ListItem>Select Service Number</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr id="Tr4" runat="server">
                                    <td id="Td6" align="right" runat="server">
                                        <b>Travel Name :</b>
                                    </td>
                                    <td id="Td7" align="left" runat="server">
                                        <asp:TextBox ID="txtTravelName" runat="server" CssClass="textbox" MaxLength="20"
                                            Wrap="False"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr id="Tr2" runat="server">
                                    <td id="Td2" align="right" runat="server">
                                        <b>Source :</b>
                                    </td>
                                    <td id="Td3" align="left" runat="server">
                                        <asp:DropDownList ID="ddlSource" runat="server">
                                            <asp:ListItem>Select StartingPoint</asp:ListItem>
                                            <asp:ListItem>Hyderabad</asp:ListItem>
                                            <asp:ListItem>Chennai</asp:ListItem>
                                            <asp:ListItem>Banglore</asp:ListItem>
                                            <asp:ListItem>Ahmadhabad</asp:ListItem>
                                            <asp:ListItem>Nellore</asp:ListItem>
                                            <asp:ListItem>Shirdi</asp:ListItem>
                                            <asp:ListItem>Mumbai</asp:ListItem>
                                            <asp:ListItem>Kurnool</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr id="Tr5" runat="server">
                                    <td id="Td8" align="right" runat="server">
                                        <b>Destination :</b>
                                    </td>
                                    <td id="Td9" align="left" runat="server">
                                        <asp:DropDownList ID="ddlDestination" runat="server" Width="144px">
                                            <asp:ListItem>Select Destination</asp:ListItem>
                                            <asp:ListItem>Hyderabad</asp:ListItem>
                                            <asp:ListItem>Chennai</asp:ListItem>
                                            <asp:ListItem>Banglore</asp:ListItem>
                                            <asp:ListItem>Ahmadhabad</asp:ListItem>
                                            <asp:ListItem>Nellore</asp:ListItem>
                                            <asp:ListItem>Shirdi</asp:ListItem>
                                            <asp:ListItem>Mumbai</asp:ListItem>
                                            <asp:ListItem>Kurnool</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr id="Tr6" runat="server">
                                    <td id="Td10" align="right" runat="server">
                                        <b>Available Seats :</b>
                                    </td>
                                    <td id="Td11" align="left" runat="server">
                                        <asp:TextBox ID="txtAvailableSeats" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr id="Tr7" runat="server">
                                    <td id="Td12" align="right" runat="server">
                                        <b>Bus Type :</b>
                                    </td>
                                    <td id="Td13" align="left" runat="server">
                                        <asp:DropDownList ID="ddlBusType" runat="server">
                                            <asp:ListItem>Select Type</asp:ListItem>
                                            <asp:ListItem>Hi-Tech</asp:ListItem>
                                            <asp:ListItem>Deluxe</asp:ListItem>
                                            <asp:ListItem>Luxury</asp:ListItem>
                                            <asp:ListItem>Super Luxury</asp:ListItem>
                                            <asp:ListItem>Volvo</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr id="Tr11" runat="server">
                                    <td id="Td20" align="right" runat="server">
                                        <b>Ticket Cost : </b>
                                    </td>
                                    <td id="Td21" align="left" runat="server">
                                        <asp:TextBox ID="txtCost" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr id="Tr8" runat="server">
                                    <td id="Td14" align="right" runat="server">
                                        <b>Journey Date :</b>
                                    </td>
                                    <td id="Td15" align="left" runat="server">
                                        <asp:TextBox ID="txtJourneyDate" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr id="Tr9" runat="server">
                                    <td id="Td16" align="right" runat="server">
                                        <b>Start Time :</b>
                                    </td>
                                    <td id="Td17" align="left" runat="server">
                                        <asp:TextBox ID="txtStartTime" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" align="left" class="border">
                            <span style="font-size: 12pt"><span style="color: maroon"><b><span style="color: darkred;">
                                <em>Payment Details</em></span></b> </span></span>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" width="40%">
                            <font color="red">*</font><span class="boldtxt">ID Card Type :</span>
                        </td>
                        <td align="left">
                            <asp:TextBox runat="server" CssClass="textbox" ID="txtCardType" MaxLength="30" Wrap="False"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <font color="red">*</font><span class="boldtxt">ID Card Number :</span>
                        </td>
                        <td align="left">
                            <asp:TextBox ID="txtCardNumber" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <font color="red">&nbsp;*</font><span class="boldtxt">Issuing Authority :</span>
                        </td>
                        <td align="left">
                            <asp:TextBox runat="server" CssClass="textbox" ID="txtAuthority" MaxLength="30" Wrap="False"></asp:TextBox>
                        </td>
                    </tr>
                    <tr id="Tr10" runat="server">
                        <td id="Td18" align="right" runat="server">
                            <font color="red">*</font><b>Number Of Passengers :</b>
                        </td>
                        <td id="Td19" align="left" runat="server">
                            <asp:TextBox ID="txtPassengers" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <span class="boldtxt">Gender :</span>
                        </td>
                        <td align="left">
                            <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
                                <asp:ListItem Value="M">Male</asp:ListItem>
                                <asp:ListItem Value="F" Selected="True">Female</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <font color="red">&nbsp;*</font><span class="boldtxt">Address :</span>
                        </td>
                        <td align="left">
                            <asp:TextBox runat="server" CssClass="textbox" ID="txtAddress" MaxLength="30" Wrap="False"
                                TextMode="MultiLine"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <span class="boldtxt">Phone :</span>
                        </td>
                        <td align="left">
                            <asp:TextBox runat="server" CssClass="textbox" ID="txtPhCountry" Width="30px" MaxLength="3"
                                Wrap="False"></asp:TextBox>
                            <b>-</b>
                            <asp:TextBox runat="server" CssClass="textbox" ID="txtPhSTD" Width="50px" MaxLength="6"
                                Wrap="False"></asp:TextBox>
                            <b>-</b>
                            <asp:TextBox runat="server" CssClass="textbox" ID="txtPhone" Width="100px" MaxLength="10"
                                Wrap="False"></asp:TextBox>
                            <br />
                            Country Code - STD Code - Phone Number
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <font color="red">*</font><span class="boldtxt">Mobile :</span>
                        </td>
                        <td align="left">
                            <asp:TextBox runat="server" CssClass="textbox" ID="txtMobileCountry" Width="30px"
                                MaxLength="3" Wrap="False" Text="91" />
                            <asp:TextBox runat="server" CssClass="textbox" ID="txtMobile" MaxLength="10" Wrap="False" />
                            <br />
                            Country Code - Mobile Number
                        </td>
                    </tr>
                    <tr>
                        <td  align="center">
                        &nbsp;
                           
                        </td>
                        <td  align="left">
                            <asp:Button ID="btnSave" runat="server" Text="Book Ticket" CssClass="button" OnClientClick="return Validation(this);"
                                OnClick="btnSave_Click" />
                            <asp:Button ID="btnBack" runat="server" Text="Back" CssClass="button" OnClick="btnBack_Click1" 
                                 />
                        </td>
                    </tr>
                </table>
            </asp:WizardStep>
            <asp:WizardStep ID="WizardStep2" runat="server" Title="Step 2">
                <table cellspacing="6" cellpadding="0" align="center" border="0" width="100%">
                    <tr>
                        <td align="center" colspan="2">
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td valign="top" align="center">
                            <br />
                            <table class="border" align="center" cellspacing="0" cellpadding="2" width="90%"
                                border="0">
                                <tr>
                                    <td class="sheader" width="100%">
                                        <b></b>
                                    </td>
                                </tr>
                                <tr>
                                    <td valign="top">
                                        <br />
                                        <table cellpadding="3" cellspacing="0" border="0" class="border1" width="95%" align="center">
                                            <tr id="trMsgForNewProfile" runat="server">
                                                <td id="Td36" align="center" valign="top" runat="server">
                                                    <br />
                                                    Your Ticket Has Confirmed<br />
                                                    Ticket Details will be Sent To Your Mail Id
                                                    <br />
                                                    Thank You
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="center">
                                                    &nbsp;
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="center">
                                                    <asp:Button Text="Finish" runat="server" CssClass="button" ID="btnFinish" OnClick="btnFinish_Click1">
                                                    </asp:Button>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="center">
                                                    &nbsp;
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
                    <tr>
                        <td>
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;
                        </td>
                    </tr>
                </table>
            </asp:WizardStep>
        </WizardSteps>
    </asp:Wizard>
</asp:Content>
