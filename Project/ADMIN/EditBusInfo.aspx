<%@ Page Language="C#" MasterPageFile="~/ADMIN/MasterPage.master" AutoEventWireup="true"
    CodeFile="EditBusInfo.aspx.cs" Inherits="ADMIN_EditBusInfo" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <script type="text/javascript">
      function Validation()
      {
            //For Service Name
            var UserName=trim(document.getElementById("<%=txtServiceName.ClientID %>").value);
            var UserNAmeLen=trim(document.getElementById("<%=txtServiceName.ClientID %>").value).length;
            if(UserName=="")
            {
                alert('Enter Service Name');
                document.getElementById("<%=txtServiceName.ClientID %>").focus();
                return false;
            }
            if(UserName.length<6 || UserName.length>20)
            {
                alert('Min. Length of Service Name is 6 and Max. Length 20\n Current Length='+UserNAmeLen);
                document.getElementById("<%=txtServiceName.ClientID %>").focus();
                return false;
            }
            var ExpUserName=/^[A-Za-z0-9/.@-_$*()]+$/;
            if(!UserName.match(ExpUserName))
            {
                alert('Service Name Contains Invalid Characters');
                document.getElementById("<%=txtServiceName.ClientID%>").focus();                                    
                return false;
            }
             //For Service Number
         
               var ServiceNumber=document.getElementById("<%=txtServiceNumber.ClientID%>").value;
               var ServiceNumberLen=document.getElementById("<%=txtServiceNumber.ClientID %>").value.length;  
                if(ServiceNumber=="")
            {
                alert('Enter Service Number');
                document.getElementById("<%=txtServiceNumber.ClientID %>").focus();
                return false;
            }
               var ExpServiceNumber=/^[0-9]+$/;
               if(!ServiceNumber.match(ExpServiceNumber))
               {
                    alert('Service Number Number Allows Numerics Only');
                    document.getElementById("<%=txtServiceNumber.ClientID%>").focus();                                   
                    return false;
               }          
               if(ServiceNumber.length<4 || ServiceNumber.length>6)
               {
                   alert('Invalid Service Number');
                   document.getElementById("<%=txtServiceNumber.ClientID %>").focus();
                   return false;
               }                                    
         
                //For Travel Name
            var CompanyName=trim(document.getElementById("<%=txtTravelName.ClientID %>").value);
            var CompanyNameLen=trim(document.getElementById("<%=txtTravelName.ClientID %>").value).length;
            if(CompanyName=="")
            {
                alert('Enter Travel Name');
                document.getElementById("<%=txtTravelName.ClientID %>").focus();
                return false;
            }
            if(CompanyName.length<5 || CompanyName.length>30)
            {
                alert('Min. Length of Travel Name is 5 and Max. Length 30\n Current Length is '+CompanyNameLen);
                document.getElementById("<%=txtTravelName.ClientID %>").focus();
                return false;
            }
            var ExpCompanyName=/^[A-Za-z0-9/. @$,#_-]+$/;
            if(!CompanyName.match(ExpCompanyName))
            {
                alert('Travel Name Contains Invalid Characters');
                document.getElementById("<%=txtTravelName.ClientID%>").focus();                                    
                return false;
            }
         
             
             //For Bus Type
            if(document.getElementById("<%=ddlBusType.ClientID%>").selectedIndex==0)
            {
                alert('Select Bus Type');
                document.getElementById("<%=ddlBusType.ClientID%>").focus();
                return false;
            }  
             //For Source Point
            if(document.getElementById("<%=ddlSource.ClientID%>").selectedIndex==0)
            {
                alert('Select Source Point ');
                document.getElementById("<%=ddlSource.ClientID%>").focus();
                return false;
            }   
            
           //For Destination Point
            if(document.getElementById("<%=ddlDestination.ClientID%>").selectedIndex==0)
            {
                alert('Select Destination Point ');
                document.getElementById("<%=ddlDestination.ClientID%>").focus();
                return false;
            }   
               //For Bus Fare
          
               var Pin1=trim(document.getElementById("<%=txtFare.ClientID%>").value);
               var PinLen1=trim(document.getElementById("<%=txtFare.ClientID %>").value).length;  
               if(Pin1=="")
            {
                alert('Enter Fare');
                document.getElementById("<%=txtFare.ClientID %>").focus();
                return false;
            }
               var ExpPin1=/^[0-9]+$/;
               if(!Pin1.match(ExpPin1))
               {
                    alert('Bus Fare Allows Numerics Only');
                    document.getElementById("<%=txtFare.ClientID%>").focus();                                   
                    return false;
               }          
               if(Pin1.length<2 || Pin1.length>4)
               {
                   alert('Invalid Fare');
                   document.getElementById("<%=txtFare.ClientID %>").focus();
                   return false;
               }                                    
                  //For Number Of Seats
         
               var Pin2=trim(document.getElementById("<%=txtNoOfSeatsAvailable.ClientID%>").value);
               var PinLen2=trim(document.getElementById("<%=txtNoOfSeatsAvailable.ClientID %>").value).length;  
               if(Pin2=="")
            {
                alert('Enter Available Seats');
                document.getElementById("<%=txtNoOfSeatsAvailable.ClientID %>").focus();
                return false;
            }
               var ExpPin2=/^[0-9]+$/;
               if(!Pin2.match(ExpPin2))
               {
                    alert('Number Of Seats Allows Numerics Only');
                    document.getElementById("<%=txtNoOfSeatsAvailable.ClientID%>").focus();                                   
                    return false;
               }          
               if(Pin2.length<1 || Pin2.length>2)
               {
                   alert('Invalid Number Of Seats');
                   document.getElementById("<%=txtNoOfSeatsAvailable.ClientID %>").focus();
                   return false;
               }                                    
                //For Bus Start Time
          
               var Pin3=trim(document.getElementById("<%=txtTime.ClientID%>").value);
               var PinLen3=trim(document.getElementById("<%=txtTime.ClientID %>").value).length;  
               if(Pin3=="")
            {
                alert('Enter Bus Start Time');
                document.getElementById("<%=txtTime.ClientID %>").focus();
                return false;
            }
          
               //For Data Of Journey
          
               var Pin4=trim(document.getElementById("<%=txtDateOfJourney.ClientID%>").value);
               var PinLen4=trim(document.getElementById("<%=txtDateOfJourney.ClientID %>").value).length;  
               if(Pin4=="")
            {
                alert('Choose Date Of Journey');
                document.getElementById("<%=txtDateOfJourney.ClientID %>").focus();
                return false;
            }
          
          
           
      
            }
    </script>

    <table cellpadding="0" cellspacing="0" width="100%">
        <tr>
            <td align="center">
                <table cellpadding="0" cellspacing="5" align="center" class="border1" width="50%">
                    <tr>
                        <td colspan="2" align="center">
                            <span style="font-size: 12pt"><span style="color: maroon"><b><span style="color: darkred;">
                                Bus Information Details</span></b> </span></span>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" align="right">
                            <b><span style="color: #cc0000">* Compulsory Fields</span></b>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <font color="red">*</font><b>Service Name :</b>
                        </td>
                        <td align="left">
                            <asp:TextBox ID="txtServiceName" runat="server" CssClass="textbox"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <font color="red">*</font><b>Service Number :</b>
                        </td>
                        <td align="left">
                            <asp:TextBox ID="txtServiceNumber" runat="server" CssClass="textbox"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <font color="red">*</font><b>Travel Name :</b>
                        </td>
                        <td align="left">
                            <asp:TextBox ID="txtTravelName" runat="server" CssClass="textbox"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <font color="red">*</font><b>Bus Type :</b>
                        </td>
                        <td align="left">
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
                    <tr>
                        <td align="right">
                            <font color="red">*</font><b>Source :</b>
                        </td>
                        <td align="left">
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
                    <tr>
                        <td align="right">
                            <font color="red">*</font><b>Destination :</b>
                        </td>
                        <td align="left">
                            <asp:DropDownList ID="ddlDestination" runat="server">
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
                    <tr>
                        <td align="right">
                            <font color="red">*</font><b>Ticket Fare :</b>
                        </td>
                        <td align="left">
                            <asp:TextBox ID="txtFare" runat="server" CssClass="textbox" Height="16px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <font color="red">*</font><b>No. Of Seats Available :</b>
                        </td>
                        <td align="left">
                            <asp:TextBox ID="txtNoOfSeatsAvailable" runat="server" CssClass="textbox" Height="16px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <font color="red">*</font><span><b>Bus Strating Time :</b></span>
                        </td>
                        <td align="left">
                            <asp:TextBox ID="txtTime" runat="server" CssClass="textbox" MaxLength="10" Wrap="False" />
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <font color="red">*</font><span><b>Date Of Journey :</b></span>
                        </td>
                        <td align="left">
                            <asp:TextBox ID="txtDateOfJourney" runat="server" CssClass="textbox" MaxLength="10"
                                Wrap="False" /><a href="javascript:NewCal('<%=txtDateOfJourney.ClientID %>','mmddyyyy')"><img
                                    src="../images/cal.gif" width="16" height="16" border="0" alt="Pick a date" /></a><br />
                            &nbsp;&nbsp;mm/dd/yyyy
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <span><b>Alloted Date :</b></span>
                        </td>
                        <td align="left">
                            <asp:Label ID="lblAllotedDate" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="center" colspan="2">
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td align="center">
                        </td>
                        <td align="left">
                            <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="button" OnClientClick="return Validation(this);"
                                OnClick="btnSave_Click" />
                            <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="button" OnClick="btnCancel_Click1" />
                    </tr>
                    <tr>
                        <td align="left" colspan="2">
                            <asp:Label ID="lblError" runat="server" Font-Bold="True" ForeColor="#CC0000"></asp:Label>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
