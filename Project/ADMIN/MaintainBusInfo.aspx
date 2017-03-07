<%@ Page Language="C#" MasterPageFile="~/ADMIN/MasterPage.master" AutoEventWireup="true" CodeFile="MaintainBusInfo.aspx.cs" Inherits="ADMIN_MaintainBusInfo" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <script type="text/javascript" language="javascript">
         function checkAll()
         {
            var c = new Array();
            c = document.getElementsByTagName('input');
            for (var i = 0; i < c.length; i++)
            {
              if (c[i].type == "checkbox")
              {
                c[i].checked = true;
              }
            }
            return false;
         }
         function uncheckAll()
         {
             var c = new Array();
            c = document.getElementsByTagName('input');
            for (var i = 0; i < c.length; i++)
            {
              if (c[i].type == "checkbox")
              {
                c[i].checked = false;
              }
            }
            return false;
         }
    </script>

        <script type="text/javascript">
        
         function AtleastCheckOne()
         {
            var rowCount=<%=dgBusInfo.Items.Count %>;
            var intLoop;
		    var intIndex=2;
		    var Count=0;
		    for(intLoop=0;intLoop<rowCount;intLoop++)
		    {
		        if(intIndex<10)
		        {            
                    if(document.getElementById("ctl00_ContentPlaceHolder1_dgBusInfo_ctl0"+intIndex+"_chkDel").checked==true)                    
                    {  
                        Count=Count+1;       
                    } 
                }
                else                     
                {
                    if(document.getElementById("ctl00_ContentPlaceHolder1_dgBusInfo_ctl"+intIndex+"_chkDel").checked==true)
                    {
                        Count=Count+1;
                    }
                } 
                intIndex=intIndex+1;
            }
            if(Count==0)
            {   
                alert('Select atleast one Option to delete');
                return false;
            }  
            else
            {
            confirm("Are you sure you want to delete the Service Details.");
            }
         }
    </script>
     <table cellpadding="0" cellspacing="0" width="90%" align="center">
        <tr>
            <td align="left" >
                <b style="font-size: small;">Service Details</b>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblError" runat="server" Text="" ForeColor="red" CssClass="ErrorText"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                <asp:DataGrid ID="dgBusInfo" runat="server" DataKeyField="ServiceID"
                    Width="100%" AutoGenerateColumns="False" OnItemCommand="dgBusInfo_ItemCommand" CellPadding="4" ForeColor="#333333" GridLines="None" >
                    <ItemStyle HorizontalAlign="left"/>
                    <HeaderStyle HorizontalAlign="Center" Height="20px" CssClass="gridheader" BackColor="#507CD1" Font-Bold="True" ForeColor="White"></HeaderStyle>
                    <Columns>
                        <asp:TemplateColumn HeaderText="Action">
                            <ItemTemplate>
                                <asp:CheckBox ID="chkDel" runat="server" />
                            </ItemTemplate>
                        </asp:TemplateColumn>
                        <asp:BoundColumn DataField="ServiceName" HeaderText="Service Name"></asp:BoundColumn>
                        <asp:BoundColumn DataField="BusType" HeaderText="Bus Type"></asp:BoundColumn>
                        <asp:BoundColumn DataField="ServiceNumber" HeaderText="Service Number"></asp:BoundColumn>
                        <asp:BoundColumn DataField="Source" HeaderText="Source"></asp:BoundColumn>
                        <asp:BoundColumn DataField="Destination" HeaderText="Destination"></asp:BoundColumn>
                        <asp:BoundColumn DataField="NoOfSeatsAvailable" HeaderText="NoOfSeatsAvailable"></asp:BoundColumn>
                        <asp:TemplateColumn>
                            <ItemTemplate>
                                <asp:LinkButton ID="lnkView" runat="server" CommandName="Edit" CssClass="bluelinks">Edit</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateColumn>
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
         <tr>
            <td style="height: 12px">
                <asp:LinkButton ID="lnkAdd" runat="server" CssClass="links3" Font-Bold="True" OnClick="lnkAdd_Click">Add</asp:LinkButton>&nbsp;&nbsp;|&nbsp;&nbsp;
                <asp:LinkButton ID="lnkCheckAll" runat="server" OnClientClick="return checkAll();" CssClass="links3" Font-Bold="True" OnClick="lnkCheckAll_Click">Check All</asp:LinkButton>&nbsp;&nbsp;|&nbsp;&nbsp;
                <asp:LinkButton ID="lnkClearAll" runat="server" OnClientClick="return uncheckAll();" CssClass="links3" Font-Bold="True" OnClick="lnkClearAll_Click">Clear All</asp:LinkButton>&nbsp;&nbsp;|&nbsp;&nbsp;
                <asp:LinkButton ID="lnlDelete" runat="server" CssClass="links3" Font-Bold="True" OnClientClick="return AtleastCheckOne();"
                    OnClick="lnlDelete_Click">Delete Checked</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
            </td>
        </tr>
    </table>
      
</asp:Content>

