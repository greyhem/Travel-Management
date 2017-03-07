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

public partial class Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblError.Text = "";

    }
    protected void btnCheck_Click(object sender, EventArgs e)
    {
        BusInfoBO ObjBusInfoBO = new BusInfoBO();
        string SearchString = string.Empty;

        SearchString = SearchString + "(Destination like '%" + ddlDestination.SelectedItem.Text + "%' and ";
        SearchString += "Source like '%" + ddlSource.SelectedItem.Text + "%' and ";
        SearchString += "NoOfSeatsAvailable >=" + txtNoOfPassengers.Text.Trim() + " and ";
        SearchString += "DateOfJourney >=" + txtDateOfJourney.Text.Trim() + ")";

        DataSet ds = new DataSet();

        ds = ObjBusInfoBO.SearchDetails(SearchString);

        if (ds != null && ds.Tables[0].Rows.Count > 0)
        {
            dgSearchResults.DataSource = ds;
            dgSearchResults.DataBind();
            lblError.Text = "";
        }
        else
        {
            dgSearchResults.DataSource = null;
            dgSearchResults.DataBind();
            lblError.Text = "Sorry There are no buses for your Search";
        }




    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~Home.aspx");



    }
}
