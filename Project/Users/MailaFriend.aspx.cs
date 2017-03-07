using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Net.Mail;

public partial class Users_MailaFriend : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserID"] == null)
        {
            Response.Redirect("~/Login.aspx");
        }

    }
    protected void btnSend_Click(object sender, EventArgs e)
    {
         MailaFriendBO ObjMailaFriendBO = new MailaFriendBO();
         String StandardContent = txtStandardContent.Text;
        String Comment = txtDetails.Text.Trim(); 
          String YourEmailID = txtYourEmailID.Text.Trim();
        String FriendsEmailID1 = txtFriendsEmailID1.Text.Trim();
        SendMail(StandardContent, Comment, YourEmailID, FriendsEmailID1);
        //Response.Redirect("~/Login.aspx");
        Page.RegisterStartupScript("SS", "<script> alert('Mail Was Sent Successfully'); </script>");
    }
    private void SendMail(String StandardContent, String Comment, String YourEmailID, String FriendsEmailID1)
    {
        try
        {
            MailMessage MailMsg = new MailMessage();
            MailMsg.From = new MailAddress("Obtrs@mail.com");
            MailMsg.To.Add(YourEmailID);
            MailMsg.Subject = "See This it is very good";
            MailMsg.IsBodyHtml = true;
            MailMsg.Priority = MailPriority.Normal;
            String Bodytext = "";
            Bodytext = "<table cellpadding='0' cellspacing='0' width='100%' style='font-family:Verdana; font-size:12px'>";
            Bodytext += "<tr><td>&nbsp;</td></tr>";
            Bodytext += "<tr><td><b>" + "<font color=\"red\">About This Website </font>" + "</b></td></tr>";
            Bodytext += "<tr><td>&nbsp;</td></tr>";
            Bodytext += "<tr><td><b>" + StandardContent + "</b></td></tr>";
            Bodytext += "<tr><td><b>" + Comment + "</b></td></tr>";
            Bodytext += "<tr><td>&nbsp;</td></tr>";
            Bodytext += "<tr><td>&nbsp;</td></tr>";
            Bodytext += "<tr><td>&nbsp;</td></tr>";
            Bodytext += "<tr><td>&nbsp;</td></tr><tr><td>&nbsp;</td></tr><tr><td>Thanks & Regards,<br />OnlineBusTicketReservation Team</td></tr>";
            Bodytext += "<tr><td>&nbsp;</td></tr></table>";
            MailMsg.Body = Bodytext;
            SmtpClient SC = new SmtpClient("localhost");
            SC.Send(MailMsg);
        }
        catch
        {
            throw;
        }
    }

  
    protected void btnBack_Click1(object sender, EventArgs e)
    {
        Response.Redirect("Home.aspx");
    }
}

