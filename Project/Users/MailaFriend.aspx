<%@ Page Language="C#" MasterPageFile="~/Users/MasterPage.master" AutoEventWireup="true"
    CodeFile="MailaFriend.aspx.cs" Inherits="Users_MailaFriend" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <script type="text/javascript">
      function Validation()
      {
            
          
              //For Email
            var Email=document.getElementById("<%=txtYourEmailID.ClientID %>").value;
            var EmailLen=document.getElementById("<%=txtYourEmailID.ClientID %>").value.length;
            var EmailExp=/^(\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)+$/;
            if(Email=="")
            {
                alert('Enter EMailId');
                document.getElementById("<%=txtYourEmailID.ClientID %>").focus();
                return false;
            }
            if(Email.length>40)
            {
                alert('Max. Length of Email is 40\n Current Length='+EmailLen);
                document.getElementById("<%=txtYourEmailID.ClientID %>").focus();
                return false;
            }  
            if(!Email.match(EmailExp))
            {
                alert('Invalid EmailId');
                document.getElementById("<%=txtYourEmailID.ClientID%>").focus();                                   
                return false;
            }
               //For Friends Email
            var Email1=document.getElementById("<%=txtFriendsEmailID1.ClientID %>").value;
            var EmailLen1=document.getElementById("<%=txtFriendsEmailID1.ClientID %>").value.length;
            var EmailExp1=/^(\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)+$/;
            if(Email1=="")
            {
                alert('Enter Friends EMailId');
                document.getElementById("<%=txtFriendsEmailID1.ClientID %>").focus();
                return false;
            }
            if(Email1.length>40)
            {
                alert('Max. Length of  Friends Email is 40\n Current Length='+EmailLen1);
                document.getElementById("<%=txtFriendsEmailID1.ClientID %>").focus();
                return false;
            }  
            if(!Email1.match(EmailExp1))
            {
                alert('Invalid Friends EmailId');
                document.getElementById("<%=txtFriendsEmailID1.ClientID%>").focus();                                   
                return false;
            }
           
              //For Standard Content
          
               var Address=document.getElementById("<%=txtStandardContent.ClientID%>").value;
               var AddressLen3=document.getElementById("<%=txtStandardContent.ClientID %>").value.length;  
               if(Address=="")
            {
                alert('Enter Standard Content');
                document.getElementById("<%=txtStandardContent.ClientID %>").focus();
                return false;
            }
          
            //For Comment
          
               var Address1=document.getElementById("<%=txtDetails.ClientID%>").value;
               var AddressLen31=document.getElementById("<%=txtDetails.ClientID %>").value.length;  
               if(Address1=="")
            {
                alert('Enter Your Comments');
                document.getElementById("<%=txtDetails.ClientID %>").focus();
                return false;
            }
          
          
             
            }
    </script>

    <table cellpadding="0" cellspacing="5" align="center" class="border1" width="50%">
        <%-- <tr>
                                    <td align="center" colspan="2" style="height: 16px">
                                    
                                        <span style="font-size: 10pt"><span style="color: maroon"><b><span style="color: darkred">
                                            Mail About This To a Friend</span></b> </span></span>
                                    </td>
                                     <td align="right" colspan="2" style="height: 16px">
                                        <b><span style="color: #cc0000">* Compulsory Fields</span></b>
                                    </td>
                                   
                                </tr>--%>
        <tr>
            <td colspan="3" align="center">
                <span style="font-size: 12pt"><span style="color: maroon"><b><span style="color: darkred;">
                    <em>Mail About This To a Friend</em></span></b> </span></span>
            </td>
        </tr>
        <tr>
            <td colspan="3" align="right">
                <b><span style="color: #cc0000">* Compulsory Fields</span></b>
            </td>
        </tr>
        <tr>
            <td align="right" colspan="2">
                <font color="red">*</font><b>Your EmailId:</b>
            </td>
            <td align="left" colspan="2">
                <asp:TextBox ID="txtYourEmailID" runat="server" CssClass="textbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" colspan="2">
                <font color="red">*</font><b>FriendsEmailId1:</b>
            </td>
            <td align="left" colspan="2">
                <asp:TextBox ID="txtFriendsEmailID1" runat="server" CssClass="textbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" colspan="2">
                <b>EmailId2:</b>
            </td>
            <td align="left" colspan="2">
                <asp:TextBox ID="txtEmailID2" runat="server" CssClass="textbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" colspan="2">
                <b>EmailId3:</b>
            </td>
            <td align="left" colspan="2">
                <asp:TextBox ID="txtEmailID3" runat="server" CssClass="textbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" colspan="2">
                <b>EmailId4:</b>
            </td>
            <td align="left" colspan="2">
                <asp:TextBox ID="txtEmailID4" runat="server" CssClass="textbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" colspan="2">
                <b>EmailId5:</b>
            </td>
            <td align="left" colspan="2">
                <asp:TextBox ID="txtEmailID5" runat="server" CssClass="textbox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" style="height: 63px" colspan="2">
                <font color="red">*</font><b>Standard Content:</b>
            </td>
            <td align="left" colspan="2" style="height: 63px">
                <asp:TextBox ID="txtStandardContent" runat="server" CssClass="textbox" Height="104px" Width="200px" ReadOnly="True" TextMode="MultiLine">BSR Travels is a pioneer in the online bus reservation in India which utilizes the advantages of the internet to provide our clients with the best in bus transportation services from the comforts of their homes &amp; offices.BSR Travels provides real-time Internet quotations and real-time bus booking services to direct customers,agents and tour operator partners.</asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" colspan="2">
                <font color="red">*</font><b>Your Comment:</b>
            </td>
            <td align="left">
                <asp:TextBox ID="txtDetails" runat="server" CssClass="textbox" Height="107px" TextMode="MultiLine"
                    Width="201px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2">
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2">
            </td>
            <td align="center" colspan="2">
                <asp:Button ID="btnSend" runat="server" Text="Send" CssClass="button" OnClientClick="return Validation(this);"
                    OnClick="btnSend_Click" />
                      <asp:Button ID="btnBack" runat="server" Text="Back" CssClass="button" OnClick="btnBack_Click1" 
                    />
            </td>
        </tr>
        <tr>
            <td align="left" colspan="2">
                <asp:Label ID="lblError" runat="server" Font-Bold="True" ForeColor="#CC0000"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
