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

public partial class ADMIN_EditBusInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["ID"] == null)
        {
            Response.Redirect("~/Login.aspx");
        }

        if (!Page.IsPostBack)
        {
            EditBusDetails();
        }
    }
    private void EditBusDetails()
    {
        BusInfoBO ObjBusInfoBO = new BusInfoBO();
         if (Request.QueryString["Id"] != null)
        {

            ObjBusInfoBO.ServiceID = Convert.ToInt16(Request.QueryString["Id"]);
        }
        DataSet DsGetDataById = new DataSet();
        DsGetDataById = ObjBusInfoBO.EditBusDetails();
        if (DsGetDataById != null)
        {
            if (DsGetDataById.Tables[0].Rows.Count > 0)
            {
                if (DsGetDataById.Tables[0].Rows[0]["ServiceName"].ToString() != "")
                {
                    txtServiceName.Text = DsGetDataById.Tables[0].Rows[0]["ServiceName"].ToString();
                }
                else
                {
                    txtServiceName.Text = "Not Mentioned";
                }

                if (DsGetDataById.Tables[0].Rows[0]["ServiceNumber"].ToString() != "")
                {
                    txtServiceNumber.Text = DsGetDataById.Tables[0].Rows[0]["ServiceNumber"].ToString();
                }
                else
                {
                    txtServiceNumber.Text = "Not Mentioned";
                }
                if (DsGetDataById.Tables[0].Rows[0]["TravelName"].ToString() != "")
                {
                    txtTravelName.Text = DsGetDataById.Tables[0].Rows[0]["TravelName"].ToString();
                }
                else
                {
                    txtTravelName.Text = "Not Mentioned";
                }
                if (DsGetDataById.Tables[0].Rows[0]["StartTime"].ToString() != "")
                {
                    txtTime.Text = DsGetDataById.Tables[0].Rows[0]["StartTime"].ToString();
                }
                else
                {
                    txtTime.Text = "Not Mentioned";
                }
                if (DsGetDataById.Tables[0].Rows[0]["DateOfJourney"].ToString() != "")
                {
                    txtDateOfJourney.Text = DsGetDataById.Tables[0].Rows[0]["DateOfJourney"].ToString();
                }
                else
                {
                    txtDateOfJourney.Text = "Not Mentioned";
                }
                if (DsGetDataById.Tables[0].Rows[0]["NoOfSeatsAvailable"].ToString() != "")
                {
                    txtNoOfSeatsAvailable.Text = DsGetDataById.Tables[0].Rows[0]["NoOfSeatsAvailable"].ToString();
                }
                else
                {
                    txtNoOfSeatsAvailable.Text = "Not Mentioned";
                }
                if (DsGetDataById.Tables[0].Rows[0]["Fare"].ToString() != "")
                {
                    txtFare.Text = DsGetDataById.Tables[0].Rows[0]["Fare"].ToString();
                }
                else
                {
                    txtFare.Text = "Not Mentioned";
                }
                if (DsGetDataById.Tables[0].Rows[0]["BusType"].ToString() != "")
                {
                    ddlBusType.Text = DsGetDataById.Tables[0].Rows[0]["BusType"].ToString();
                }
                else
                {
                    ddlBusType.Text = "Not Mentioned";
                }
                if (DsGetDataById.Tables[0].Rows[0]["Source"].ToString() != "")
                {
                    ddlSource.Text = DsGetDataById.Tables[0].Rows[0]["Source"].ToString();
                }
                else
                {
                    ddlSource.Text = "Not Mentioned";
                }
                if (DsGetDataById.Tables[0].Rows[0]["Destination"].ToString() != "")
                {
                    ddlDestination.Text = DsGetDataById.Tables[0].Rows[0]["Destination"].ToString();
                }
                else
                {
                    ddlDestination.Text = "Not Mentioned";
                }

                if (DsGetDataById.Tables[0].Rows[0]["AllotedDate"].ToString() != "")
                {
                    lblAllotedDate.Text = DsGetDataById.Tables[0].Rows[0]["AllotedDate"].ToString();
                }
                else
                {
                    lblAllotedDate.Text = "Not Mentioned";
                }

             }
        }
    }
    private void UpdatetblBusInfo()
    {

        try
        {
            int intResult = 0;
            BusInfoBO ObjBusInfoBO = new BusInfoBO();
            ObjBusInfoBO.ServiceID = int.Parse(Request.QueryString["Id"].ToString());
            ObjBusInfoBO.DateOfJourney= Convert.ToDateTime(txtDateOfJourney.Text.Trim());
            ObjBusInfoBO.Fare = txtFare.Text.Trim();
            ObjBusInfoBO.NoOfSeatsAvailable = txtNoOfSeatsAvailable.Text.Trim();
            ObjBusInfoBO.ServiceName = txtServiceName.Text.Trim();
            ObjBusInfoBO.ServiceNumber= txtServiceNumber.Text.Trim();
            ObjBusInfoBO.StartTime = txtTime.Text.Trim();
            ObjBusInfoBO.TravelName = txtTravelName.Text.Trim();
          
            if (ddlBusType.SelectedIndex != 0)
            {
                ObjBusInfoBO.BusType = ddlBusType.SelectedItem.Text;
            }
            if (ddlSource.SelectedIndex != 0)
            {
                ObjBusInfoBO.Source = ddlSource.SelectedItem.Text;
            }

            if (ddlDestination.SelectedIndex != 0)
            {
                ObjBusInfoBO.Destination = ddlDestination.SelectedItem.Text;
            }

            intResult = ObjBusInfoBO.UpdatetblBusInfo();
            if (intResult > 0)
            {

                //Response.Redirect("MaintainEmployees.aspx");
                Page.RegisterStartupScript("SS", "<script> alert('Updated Succesfully'); </script>");
                txtServiceName.Text = "";
                txtServiceNumber.Text = "";
                txtTravelName.Text = "";
                txtFare.Text = "";
                txtNoOfSeatsAvailable.Text = "";
                ddlDestination.SelectedIndex = 0;
                ddlSource.SelectedIndex = 0;
                ddlBusType.SelectedIndex = 0;
                txtTime.Text = "";
                txtDateOfJourney.Text = ""; 

            }
            else
            {
                lblError.Text = "Error while Creation";
            }
        }

        catch
        {
            throw;
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {

        UpdatetblBusInfo();
    }
  
    protected void btnCancel_Click1(object sender, EventArgs e)
    {
        Response.Redirect("MaintainBusInfo.aspx");
    }
}
