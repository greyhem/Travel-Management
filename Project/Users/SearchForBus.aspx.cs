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

public partial class Users_SearchPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserID"] == null)
        {
            Response.Redirect("~/Login.aspx");
        }
        if (!IsPostBack)
        {
            if (Request.QueryString["From"] != null)
            {
                getSearchDetails();
                tblSearch.Visible = true;
            }
            else
            {
                tblSearch.Visible = false;
                lblError.Text = "";
            }
        }
       

    }

    private void getSearchDetails()
    {
        BusInfoBO ObjBusInfoBO = new BusInfoBO();
        string SearchString = string.Empty;
        
        SearchString = SearchString + "(Destination like '%" + Request.QueryString["To"].ToString() + "%' and ";
        if (ddlDestination.Items.FindByText(Request.QueryString["To"].ToString()) != null)
        {
            ddlDestination.Items.FindByText(Request.QueryString["To"].ToString()).Selected = true;
        }
        SearchString += "Source like '%" + Request.QueryString["From"].ToString() + "%' and ";
        if (ddlSource.Items.FindByText(Request.QueryString["From"].ToString()) != null)
        {
            ddlSource.Items.FindByText(Request.QueryString["From"].ToString()).Selected = true;
        }
        SearchString += "NoOfSeatsAvailable >=" + Request.QueryString["No"].ToString() + " and ";
        txtNoOfPassengers.Text = Request.QueryString["No"].ToString();
        SearchString += "convert(varchar(20),DateOfJourney,101) ='" + Request.QueryString["Date"].ToString() + "')";
        txtDateOfJourney.Text = Request.QueryString["Date"].ToString();

        DataSet ds = new DataSet();

        ds = ObjBusInfoBO.SearchDetails(SearchString);

        if (ds != null && ds.Tables[0].Rows.Count > 0)
        {
            tblSearch.Visible = true;
            dgSearchResults.DataSource = ds;
            dgSearchResults.DataBind();
            lblError.Text = "";
        }
        else
        {
            lblError.Text = "Sorry There are no buses for your Search";
        }

        
    }
    protected void btnCheck_Click(object sender, EventArgs e)
    {

        BusInfoBO ObjBusInfoBO = new BusInfoBO();
        string SearchString = string.Empty;

        SearchString = SearchString + "(Destination like '%"+ ddlDestination.SelectedItem.Text+"%' and ";
        SearchString += "Source like '%" + ddlSource.SelectedItem.Text + "%' and ";
        SearchString += "NoOfSeatsAvailable >=" + txtNoOfPassengers.Text.Trim() + " and ";
        SearchString += "convert(varchar(20),DateOfJourney,101) ='" + txtDateOfJourney.Text.Trim() + "')";

        DataSet ds = new DataSet();

        ds = ObjBusInfoBO.SearchDetails(SearchString);

        if (ds != null && ds.Tables[0].Rows.Count > 0)
        {
            tblSearch.Visible = true;
            dgSearchResults.DataSource = ds;
            dgSearchResults.DataBind();
            lblError.Text = "";
        }
        else
        {
            lblError.Text = "Sorry There are no buses for your Search";
        }




    }
    protected void btnBook_Click(object sender, EventArgs e)
    {
        //Response.Redirect("BookTicket.aspx");

        Response.Redirect("BookTicket.aspx?From=" + ddlSource.SelectedItem.Text + "&To=" + ddlDestination.SelectedItem.Text + "&No=" + txtNoOfPassengers.Text.Trim() + "&Date=" + txtDateOfJourney.Text.Trim());
    }
}
