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

public partial class ADMIN_CreateBusInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["ID"] == null)
        {
            Response.Redirect("~/Login.aspx");
        }

        if (!Page.IsPostBack)
        {
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
           try
        {
                int intResult = 0;
                BusInfoBO ObjBusInfoBO = new BusInfoBO();
                ObjBusInfoBO.ServiceName= txtServiceName.Text.Trim();
                ObjBusInfoBO.ServiceNumber = txtServiceNumber.Text.Trim();
                ObjBusInfoBO.TravelName = txtTravelName.Text.Trim();
                ObjBusInfoBO.Fare= txtFare.Text.Trim();
                ObjBusInfoBO.NoOfSeatsAvailable = txtNoOfSeatsAvailable.Text.Trim();
                ObjBusInfoBO.StartTime = txtTime.Text.Trim();
                ObjBusInfoBO.DateOfJourney= Convert.ToDateTime(txtDateOfJourney.Text.Trim());
                if (ddlBusType.SelectedIndex != 0)
                {
                    ObjBusInfoBO.BusType = ddlBusType.SelectedItem.Text;
                }
                if (ddlSource.SelectedIndex != 0)
                {
                    ObjBusInfoBO.Source= ddlSource.SelectedItem.Text;
                }
                if (ddlDestination.SelectedIndex != 0)
                {
                    ObjBusInfoBO.Destination= ddlDestination.SelectedItem.Text;
                }
         

                intResult =ObjBusInfoBO.InsertIntoBusInfo();
                if (intResult > 0)
                {
                    Page.RegisterStartupScript("SS", "<script> alert('Succesfully Provided The Bus Details'); </script>");
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
                   
                  
                }
            }
        
        catch
        {
            throw;
        }
       
    }
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("MaintainBusInfo.aspx");
    }
}

