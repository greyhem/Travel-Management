<%@ Page Language="C#" MasterPageFile="~/Users/MasterPage.master" AutoEventWireup="true"
    CodeFile="SearchForBus.aspx.cs" Inherits="Users_SearchPage" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <script type="text/javascript">
      function Validation()
      {
        
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
                             
                  //For Number Of Passengers
         
               var Pin2=trim(document.getElementById("<%=txtNoOfPassengers.ClientID%>").value);
               var PinLen2=trim(document.getElementById("<%=txtNoOfPassengers.ClientID %>").value).length;  
               if(Pin2=="")
            {
                alert('Enter Number Of Passengers');
                document.getElementById("<%=txtNoOfPassengers.ClientID %>").focus();
                return false;
            }
               var ExpPin2=/^[0-9]+$/;
               if(!Pin2.match(ExpPin2))
               {
                    alert('Number Of Passengers Allows Numerics Only');
                    document.getElementById("<%=txtNoOfPassengers.ClientID%>").focus();                                   
                    return false;
               }          
               if(Pin2.length<1 || Pin2.length>2)
               {
                   alert('Invalid Number Of Passengers');
                   document.getElementById("<%=txtNoOfPassengers.ClientID %>").focus();
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
            <td align="right">
                <asp:Button ID="btnBook" runat="server" Text="BOOK TICKET" CssClass="button" OnClick="btnBook_Click" />&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
        </tr>
        <tr>
            <td align="center">
                <table cellpadding="0" cellspacing="5" align="center" class="border1" width="70%">
                    <tr>
                        <td colspan="2" align="center">
                            <span style="font-size: 12pt"><span style="color: maroon"><b><span style="color: darkred;">
                                BOOK TICKETS NOW!</span></b> </span></span>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" align="right">
                            <b><span style="color: #cc0000">* Compulsory Fields</span></b>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <font color="red">*</font><b>From :</b>
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
                            <font color="red">*</font><b>To :</b>
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
                            <font color="red">*</font><b>No Of Passengers :</b>
                        </td>
                        <td align="left">
                            <asp:TextBox ID="txtNoOfPassengers" runat="server" CssClass="textbox" Height="16px"></asp:TextBox>
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
                        <td align="center" colspan="2">
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td align="center" colspan="2">
                            <asp:Button ID="btnCheck" runat="server" Text="Check Availability" CssClass="button"
                                OnClick="btnCheck_Click" OnClientClick="return Validation(this);" />
                        </td>
                    </tr>
                    <tr>
                        <td align="left" colspan="2">
                            <asp:Label ID="lblError" runat="server" Font-Bold="True" ForeColor="#CC0000"></asp:Label>
                        </td>
                    </tr>
                </table>
                <table id="tblSearch" cellpadding="0" cellspacing="5" align="center" class="border1"
                    width="80%" runat="server">
                    <tr>
                        <td colspan="2" align="center">
                            <asp:DataGrid ID="dgSearchResults" runat="server" Width="100%"
                                AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                                <HeaderStyle HorizontalAlign="Center" Height="20px" CssClass="gridheader" BackColor="#507CD1" Font-Bold="True" ForeColor="White"></HeaderStyle>
                                <Columns>
                                    <asp:BoundColumn DataField="ServiceName" HeaderText="Service"></asp:BoundColumn>
                                    <asp:BoundColumn DataField="TravelName" HeaderText="TravelName"></asp:BoundColumn>
                                    <asp:BoundColumn DataField="BusType" HeaderText="BusType"></asp:BoundColumn>
                                    <asp:BoundColumn DataField="StartTime" HeaderText="StartTime"></asp:BoundColumn>
                                    <asp:BoundColumn DataField="Fare" HeaderText="Fare"></asp:BoundColumn>
                                    <asp:BoundColumn DataField="NoOfSeatsAvailable" HeaderText="NoOfSeatsAvailable"></asp:BoundColumn>
                                    <asp:BoundColumn DataField="DateOfJourneyFMT" HeaderText="DateOfJourney"></asp:BoundColumn>
                                </Columns>
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" BackColor="#EFF3FB" />
                                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                <EditItemStyle BackColor="#2461BF" />
                                <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                <AlternatingItemStyle BackColor="White" />
                            </asp:DataGrid>
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
