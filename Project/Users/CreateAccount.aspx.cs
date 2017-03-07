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

public partial class USERS_CreateAccount : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSave_Click(object sender, EventArgs e)
     {

        if (VerifyCode())
        {
            InsertIntotblEmployees();
        }
        else
        {
            lblError.Text = "Wrong Code Entered";
            
        }
    }
    private void InsertIntotblEmployees()
    {
        Int64 intUserId = 0;
        try
        {
            if (ValidateFields())
            {
                DataSet ds = new DataSet();
                UsersBO ObjUsersBO = new UsersBO();
                ObjUsersBO.UserName = txtUserName.Text.Trim();
                ObjUsersBO.Password = txtPassword.Text.Trim();
                lblPwd.Text = txtPassword.Text.Trim();
                ObjUsersBO.Country= ddlCountry.SelectedItem.Text.Trim();
                ObjUsersBO.City= txtCity.Text.Trim();
                ObjUsersBO.Email = txtEmail.Text.Trim();
                ObjUsersBO.Address = txtAddress.Text.Trim();

                ObjUsersBO.Status = "I";
                if (txtPhCountry.Text.Trim() != "" && txtPhSTD.Text.Trim() != "" && txtPhone.Text.Trim() != "")
                {
                    ObjUsersBO.Phone = txtPhCountry.Text.Trim() + "~" + txtPhSTD.Text.Trim() + "~" + txtPhone.Text.Trim();
                }
                
                if (txtMobileCountry.Text.Trim() != "" && txtMobile.Text.Trim() != "")
                {
                    ObjUsersBO.Mobile = txtMobileCountry.Text.Trim() + "~" + txtMobile.Text.Trim();
                }

                intUserId = ObjUsersBO.InsertIntotblUsers();
                if (intUserId > 0)
                {
                   
                    Wizard1.ActiveStepIndex = 1;
                    Label1.Text = intUserId.ToString();
                }
                else if (intUserId == -1)
                {
                    TextBoxHip.Text = "";
                    lblError.Text = "Email Id you entered Already Exists";
                    TextBoxHip.Text = "";
                   
                }
                else if (intUserId == 0)
                {
                    TextBoxHip.Text = "";
                    lblError.Text = " User Name Already Exists";
                    TextBoxHip.Text = "";
                    
                }
            }
        }
        catch
        {
            throw;
        }
    }
    private bool ValidateFields()
    {
        try
        {
            if (txtUserName.Text.Trim() == "")
            {
                lblError.Text = "Enter User Name";
                return false;
            }
            if (txtPassword.Text.Trim() == "")
            {
                lblError.Text = "Enter Password";
                return false;
            }
            if (txtEmail.Text.Trim() == "")
            {
                lblError.Text = "Enter Email ID";
                return false;
            }
            if (txtAddress.Text.Trim() == "")
            {
                lblError.Text = "Enter Address";
                return false;
            }
            if (ddlCountry.SelectedIndex == 0)
            {
                lblError.Text = "Select Country";
                return false;
            }
            if (txtCity.Text.Trim() == "")
            {
                lblError.Text = "Enter City";
                return false;
            }
          
            if (txtMobileCountry.Text.Trim() == "")
            {
                lblError.Text = "Enter Mobile Country Code";
                return false;
            }
            if (txtMobile.Text.Trim() == "")
            {
                lblError.Text = "Enter Mobile Number";
                return false;
            }

            return true;
        }
        catch
        {
            return false;
        }
    }
   
    private void SendMail(String Name, String Email, String Mobile, String Phone, Int64 UserID)
    {
        try
        {
            MailMessage MailMsg = new MailMessage();
            MailMsg.From = new MailAddress("Obtrs@mail.com");
            MailMsg.To.Add(Email);
            MailMsg.Subject = "Welcome To Online Bus Ticket Reservation";
            MailMsg.IsBodyHtml = true;
            MailMsg.Priority = MailPriority.Normal;
            String Bodytext = "";
            Bodytext = "<table cellpadding='0' cellspacing='0' width='100%' style='font-family:Verdana; font-size:12px'>";
            Bodytext += "<tr><td>Hi <b>" + Name + "</b>,</td></tr><tr><td>&nbsp;</td></tr>";
            Bodytext += "<tr><td>Thank you for registering with Online Bus Ticket Reservation! To complete your registration, please click on the link below to confirm your e-mail address. You will then be redirected to Online Bus Ticket Reservation System. </td></tr>";
            Bodytext += "<tr><td>&nbsp;</td></tr>";
            Bodytext += "<tr><td><b>" + "<font color=\"red\">Your Account Details </font>" + "</b></td></tr>";
            Bodytext += "<tr><td>&nbsp;</td></tr>";
            Bodytext += "<tr><td>Username:<b>" + Name + "</b></td></tr>";
            //Bodytext += "<tr><td>Password:<b>" + Password + "</b></td></tr>";
            Bodytext += "<tr><td>&nbsp;</td></tr>";
            Bodytext += "<tr><td>&nbsp;</td></tr>";
            Bodytext += "<tr><td><b>" + "<font color=\"red\">Your Current Contact Details Are: </font>" + "</b></td></tr>";
            Bodytext += "<tr><td>&nbsp;</td></tr>";
            Bodytext += "<tr><td>Phone:<b>" + Phone + "</b></td></tr>";
            Bodytext += "<tr><td>Mobile: <b>" + Mobile + "</b></td></tr>";
            Bodytext += "<tr><td>&nbsp;</td></tr>";
            Bodytext += "<tr><td>&nbsp;</td></tr>";
            string Path = "http://localhost/OnlineBusTicketReservation/Users/Confirm.aspx";
            Bodytext += "<tr><td>&nbsp;</td></tr><tr><td><a href='" + Path + "Confirm.aspx?UID=" + UserID + "'>Please Click Here To Confirm Your EmailId</a></td></tr>";
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


    //For Checking verification Code
    private Boolean VerifyCode()
    {
        try
        {
            if (IsPostBack)
            {
                // Verify the submitted code to the generated code
                System.Security.Cryptography.SHA256Managed hashAlg = new System.Security.Cryptography.SHA256Managed();
                string hashText = HttpUtility.UrlEncode(hashAlg.ComputeHash(System.Text.Encoding.Default.GetBytes(TextBoxHip.Text)));
                string hashTextFromHeader = Request.Cookies["HipHash"].Value;
                if (hashTextFromHeader != hashText)
                {
                    return false;
                }
            }
            if (!IsPostBack)
            {
                if (Session["HipControlToVerifyValue"] != null)
                {
                }
                Session["HipControlToVerifyValue"] = null;
            }
            return true;
        }
        catch
        {
            return false;
        }
    }

   

    private void checkAvailable()
    {
        if (txtUserName.Text.Trim() != "")
        {
            UsersBO ObjUsersBO = new UsersBO();
            ObjUsersBO.UserName = txtUserName.Text.Trim();
            DataSet DS = new DataSet();
            DS = ObjUsersBO.CheckAvailable();
            if (DS.Tables[0].Rows.Count > 0)
            {
                lblAvailability.Text = "Not Available, Select Another UserName";
                lblAvailability.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblAvailability.Text = "UserName Available";
                lblAvailability.ForeColor = System.Drawing.Color.Green;
            }
        }
        else
        {
            lblError.Text = "Enter Username";
        }
    }
    protected void lnkCheckAvailability_Click1(object sender, EventArgs e)
    {
   
      checkAvailable();

    }
    protected void btnFinish_Click1(object sender, EventArgs e)
    {
        UsersBO ObjUsersBO = new UsersBO();
        Int64 UserID = Convert.ToInt64(Label1.Text);
        String Password = lblPwd.Text;
        String Name = txtUserName.Text.Trim();
        String Email = txtEmail.Text.Trim();
        String Mobile = txtMobile.Text.Trim();
        String Phone = " ";
        if (txtPhCountry.Text.Trim() != "" && txtPhSTD.Text.Trim() != "" && txtPhone.Text.Trim() != "")
        {
            Phone = txtPhCountry.Text.Trim() + "~" + txtPhSTD.Text.Trim() + "~" + txtPhone.Text.Trim();
        }
        else
        {
            Phone = "Not Mentioned";

        }
        SendMail(Name, Email, Mobile, Phone, UserID);
        Response.Redirect("Default.aspx");
    }
}
