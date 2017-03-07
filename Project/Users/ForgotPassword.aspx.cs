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

public partial class Users_ForgotPassword : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            UsersBO objUsersBO = new UsersBO();
            if (rdbtnUserNameType.SelectedIndex == 1)
            {
                objUsersBO.UserName = txtUserName.Text.Trim();
                DataSet DsCheckClientLogin = new DataSet();
                DsCheckClientLogin = objUsersBO.ForgotPassword();

                if (DsCheckClientLogin != null)
                {
                    if (DsCheckClientLogin.Tables[0].Rows.Count > 0)
                    {
                        String Password = DsCheckClientLogin.Tables[0].Rows[0]["Password"].ToString().Trim();
                        string name = objUsersBO.UserName;
                        String Email = DsCheckClientLogin.Tables[0].Rows[0]["Email"].ToString().Trim();
                        SendMail(name, Email, Password);
                        lblResult.Text = "Hai " + objUsersBO.UserName + ", Password Sent To your MailId " + Email;
                    }
                    else
                    {
                        lblErrMsg.Text = "Invalid UserName";
                    }
                }
                else
                {
                    lblErrMsg.Text = "Invalid UserName";
                }
            }
            else
            {
                if (rdbtnUserNameType.SelectedIndex == 0)
                {
                    string Email = txtUserName.Text.Trim();
                    DataSet DsCheckClientLogin = new DataSet();
                    DsCheckClientLogin = objUsersBO.ForgotPasswordForEmail(Email);
                    if (DsCheckClientLogin != null)
                    {
                        if (DsCheckClientLogin.Tables[0].Rows.Count > 0)
                        {
                            String Password = DsCheckClientLogin.Tables[0].Rows[0]["Password"].ToString().Trim();
                            string name = DsCheckClientLogin.Tables[0].Rows[0]["UserName"].ToString().Trim();
                            //String Email = txtUserName.Text.Trim();
                            SendMail(name, Email, Password);
                            lblResult.Text = "Hai " + name + ", Password Sent To your MailId " + Email;
                        }
                        else
                        {
                            lblErrMsg.Text = "This mail id is not in our database.Make sure that you are giving your active profile's mail";
                        }
                    }
                    else
                    {
                        lblErrMsg.Text = "This mail id is not in our database.Make sure that you are giving your active profile's mail";
                    }
                }
                else
                {
                    //lblErrMsg.Text = "Invalid UserName";
                }
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }

    }

    private void SendMail(String Name, String Email, String Password)
    {
        try
        {
            MailMessage MailMsg = new MailMessage();
            MailMsg.From = new MailAddress("Obtrs@mail.com");
            MailMsg.To.Add(Email);
            MailMsg.Subject = "BSR Travels: Forgot Password";
            MailMsg.IsBodyHtml = true;
            MailMsg.Priority = MailPriority.Normal;
            String Bodytext = "";
            Bodytext = "<table cellpadding='0' cellspacing='0' width='100%' style='font-family:Verdana; font-size:12px'>";
            Bodytext += "<tr><td>Hi <b>" + Name + "</b>,</td></tr><tr><td>&nbsp;</td></tr>";
            Bodytext += "<tr><td>Thanks for your interest on Online Bus Ticket Reservation System</td></tr>";
            Bodytext += "<tr><td>&nbsp;</td></tr>";
            Bodytext += "<tr><td>Following are the credentials for your account</td></tr>";
            Bodytext += "<tr><td>&nbsp;</td></tr>";
            Bodytext += "<tr><td>Username: " + Name + "</td></tr>";
            Bodytext += "<tr><td>Password: " + Password + "</td></tr>";
            Bodytext += "<tr><td>&nbsp;</td></tr>";
            Bodytext += "<tr><td>&nbsp;</td></tr><tr><td>&nbsp;</td></tr><tr><td>Thanks & Regards<br />Online Bus Ticket Reservation System Team</td></tr>";
            Bodytext += "<tr><td>&nbsp;</td></tr></table>";

            MailMsg.Body = Bodytext;

            SmtpClient SC = new SmtpClient("localhost");
            SC.Send(MailMsg);
        }
        catch { }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Home.aspx");
    }
}
