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

public partial class Users_BookTicket : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserID"] == null)
        {
            Response.Redirect("~/Login.aspx");
        }
       
        if (!Page.IsPostBack)
        {
            GetServiceNumbers();
        }


    }
    protected void GetServiceNumbers()
    {
        BookTicketBO objBookTicketBO = new BookTicketBO();
        DataSet Dt = new DataSet();
        Dt = objBookTicketBO.GetServiceNumbers();
        ddlServiceNumber.DataSource = Dt;
        ddlServiceNumber.DataTextField = "ServiceNumber";
        ddlServiceNumber.DataValueField = "ServiceNumber";
       ddlServiceNumber.DataBind();
    }
    protected void GetData()
    {

        if (ddlServiceNumber.SelectedIndex != 0)
        {
            BookTicketBO objBookTicketBO = new BookTicketBO();
            DataSet GetDatads = new DataSet();
            objBookTicketBO.ServiceNumber = ddlServiceNumber.SelectedItem.Text;
            try
            {
                GetDatads = objBookTicketBO.Record();
                txtTravelName.Text = GetDatads.Tables["tblBusInfo"].Rows[0]["TravelName"].ToString();
                txtCost.Text = GetDatads.Tables["tblBusInfo"].Rows[0]["Fare"].ToString();
                txtAvailableSeats.Text = GetDatads.Tables["tblBusInfo"].Rows[0]["NoOfSeatsAvailable"].ToString();
                txtStartTime.Text = GetDatads.Tables["tblBusInfo"].Rows[0]["StartTime"].ToString();
                txtJourneyDate.Text = GetDatads.Tables["tblBusInfo"].Rows[0]["DateOfJourney"].ToString();
                ddlBusType.Text = GetDatads.Tables["tblBusInfo"].Rows[0]["BusType"].ToString();
                ddlSource.Text = GetDatads.Tables["tblBusInfo"].Rows[0]["Source"].ToString();
                ddlDestination.Text = GetDatads.Tables["tblBusInfo"].Rows[0]["Destination"].ToString();
            }
            catch
            {
                throw;
            }
            finally
            {
                GetDatads.Dispose();
                objBookTicketBO = null;
               
            }
        }

    }
    protected void ddlServiceNumber_SelectedIndexChanged(object sender, EventArgs e)
    {
        GetData();
    }
    private void InsertIntotblBookTicket()
    {
        Int64 intTicketId = 0;
        try
        {
           
                DataSet ds = new DataSet();
                BookTicketBO objBookTicketBO = new BookTicketBO();
                objBookTicketBO.FullName = txtName.Text.Trim();
                objBookTicketBO.TravelName = txtTravelName.Text.Trim();
                objBookTicketBO.Fare = txtCost.Text.Trim();
                objBookTicketBO.AvailableSeats = txtAvailableSeats.Text.Trim();
                objBookTicketBO.JourneyDate=txtJourneyDate.Text.Trim();
                objBookTicketBO.StartTime = txtStartTime.Text.Trim();
                objBookTicketBO.Address = txtAddress.Text.Trim();
                objBookTicketBO.Gender = RadioButtonList1.SelectedValue;
                objBookTicketBO.NoOfPassengers = txtPassengers.Text.Trim();
                objBookTicketBO.IDCardType = txtCardType.Text.Trim();
                objBookTicketBO.IDCardNumber = txtCardNumber.Text.Trim();
                objBookTicketBO.Email = txtEmail.Text.Trim();
                objBookTicketBO.IssuingAuthority = txtAuthority.Text.Trim();
                if (ddlServiceNumber.SelectedIndex != 0)
                {
                    objBookTicketBO.ServiceNumber = ddlServiceNumber.SelectedItem.Text;
                }
                if (ddlSource.SelectedIndex != 0)
                {
                    objBookTicketBO.Source = ddlSource.SelectedItem.Text;
                }
                if (ddlDestination.SelectedIndex != 0)
                {
                    objBookTicketBO.Destination = ddlDestination.SelectedItem.Text;
                }
                if (ddlBusType.SelectedIndex != 0)
                {
                    objBookTicketBO.BusType = ddlBusType.SelectedItem.Text;
                }


                //objBookTicketBO.ServiceNumber = ddlServiceNumber.SelectedItem.Text.Trim();

                if (txtPhCountry.Text.Trim() != "" && txtPhSTD.Text.Trim() != "" && txtPhone.Text.Trim() != "")
                {
                    objBookTicketBO.Phone = txtPhCountry.Text.Trim() + "~" + txtPhSTD.Text.Trim() + "~" + txtPhone.Text.Trim();
                }

                if (txtMobileCountry.Text.Trim() != "" && txtMobile.Text.Trim() != "")
                {
                    objBookTicketBO.Mobile = txtMobileCountry.Text.Trim() + "~" + txtMobile.Text.Trim();
                }

                intTicketId = objBookTicketBO.InsertIntotblBookTicket();
                if (intTicketId > 0)
                {

                     //Page.RegisterStartupScript("SS", "<script> alert('Succesfully Booked The Ticket'); </script>");
                

                    Wizard1.ActiveStepIndex = 1;
                    Label1.Text = intTicketId.ToString();
                }
               
                else 
                {

                }
            }
       
        catch
        {
            throw;
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        InsertIntotblBookTicket();

    }
    protected void btnFinish_Click1(object sender, EventArgs e)
    {
        BookTicketBO objBookTicketBO = new BookTicketBO();
        Int64 TicketID = Convert.ToInt64(Label1.Text);
        String Name = txtName.Text.Trim();
        String Email = txtEmail.Text.Trim();
        String ServiceNumber = ddlServiceNumber.SelectedItem.Text.Trim();
        String TravelName = txtTravelName.Text.Trim();
        String DateOfJourney = txtJourneyDate.Text.Trim();
        String StartTime = txtStartTime.Text.Trim();
        String Mobile = txtMobile.Text.Trim();

        SendMail(Name,Email,ServiceNumber, TravelName, DateOfJourney, StartTime, Mobile, TicketID);
        Response.Redirect("MyProfile.aspx");
    }


    private void SendMail(String Name, String Email, String ServiceNumber, String TravelName, String DateOfJourney, String StartTime, String Mobile, Int64 TicketID)
    {
        try
        {
            MailMessage MailMsg = new MailMessage();
            MailMsg.From = new MailAddress("Obtrs@mail.com");
            MailMsg.To.Add(Email);
            MailMsg.Subject = "Ticket Confirmation Details";
            MailMsg.IsBodyHtml = true;
            MailMsg.Priority = MailPriority.Normal;
            String Bodytext = "";
            Bodytext = "<table cellpadding='0' cellspacing='0' width='100%' style='font-family:Verdana; font-size:12px'>";
            Bodytext += "<tr><td>Hi <b>" + Name + "</b>,</td></tr><tr><td>&nbsp;</td></tr>";
            Bodytext += "<tr><td>Thank you for Booking Ticket with Online Bus Ticket Reservation System. </td></tr>";
            Bodytext += "<tr><td>&nbsp;</td></tr>";
            Bodytext += "<tr><td><b>" + "<font color=\"red\">Your Ticket Details </font>" + "</b></td></tr>";
            Bodytext += "<tr><td>&nbsp;</td></tr>";
            Bodytext += "<tr><td>ServiceNumber:<b>" + ServiceNumber + "</b></td></tr>";
            Bodytext += "<tr><td>DateOfJourney:<b>" + DateOfJourney + "</b></td></tr>";
            Bodytext += "<tr><td>TravelName:<b>" + TravelName + "</b></td></tr>";
            Bodytext += "<tr><td>StartTime:<b>" + StartTime + "</b></td></tr>";
            Bodytext += "<tr><td>&nbsp;</td></tr>";
            Bodytext += "<tr><td>&nbsp;</td></tr>";
            Bodytext += "<tr><td><b>" + "<font color=\"red\">Your Current Contact Details Are: </font>" + "</b></td></tr>";
            Bodytext += "<tr><td>&nbsp;</td></tr>";
            Bodytext += "<tr><td>Mobile: <b>" + Mobile + "</b></td></tr>";
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
        if (Request.QueryString["From"] != null)
        {
            Response.Redirect("SearchForBus.aspx?From=" + Request.QueryString["From"].ToString() + "&To=" + Request.QueryString["To"].ToString() + "&No=" + Request.QueryString["No"].ToString() + "&Date=" + Request.QueryString["Date"].ToString());
        }
        else
        {
            Response.Redirect("SearchForBus.aspx");
        }

    }
}
