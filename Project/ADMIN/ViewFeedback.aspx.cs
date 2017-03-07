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

public partial class ADMIN_ViewFeedback : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["ID"] == null)
        {
            Response.Redirect("~/Login.aspx");
        }

        if (!Page.IsPostBack)
        {
            ShowFeedbackDetails();
        }

    }
    private void ShowFeedbackDetails()
    {
        FeedbackBO ObjFeedbackBO = new FeedbackBO();
        if (Request.QueryString["Id"] != null)
        {

            ObjFeedbackBO.FeedbackID = Convert.ToInt16(Request.QueryString["Id"]);
        }
        DataSet DsGetDataById = new DataSet();
        DsGetDataById = ObjFeedbackBO.ShowFeedback1();
        if (DsGetDataById != null)
        {
            if (DsGetDataById.Tables[0].Rows.Count > 0)
            {
                if (DsGetDataById.Tables[0].Rows[0]["UserName"].ToString() != "")
                {
                    txtName.Text = DsGetDataById.Tables[0].Rows[0]["UserName"].ToString();
                }
                else
                {
                    txtName.Text = "Not Mentioned";
                }

                if (DsGetDataById.Tables[0].Rows[0]["Email"].ToString() != "")
                {
                    txtEmail.Text = DsGetDataById.Tables[0].Rows[0]["Email"].ToString();
                }
                else
                {
                    txtEmail.Text = "Not Mentioned";
                }
                if (DsGetDataById.Tables[0].Rows[0]["Comments"].ToString() != "")
                {
                    txtComments.Text = DsGetDataById.Tables[0].Rows[0]["Comments"].ToString();
                }
                else
                {
                    txtComments.Text = "Not Mentioned";
                }
                if (DsGetDataById.Tables[0].Rows[0]["RatingOfSite"].ToString() != "")
                {
                    lblRating.Text = DsGetDataById.Tables[0].Rows[0]["RatingOfSite"].ToString();
                }
                else
                {
                    lblRating.Text = "Not Mentioned";
                }


                if (DsGetDataById.Tables[0].Rows[0]["SendDate"].ToString() != "")
                {
                    lblCreatedDate.Text = DsGetDataById.Tables[0].Rows[0]["SendDate"].ToString();
                }
                else
                {
                    lblCreatedDate.Text = "Not Mentioned";
                }

                if (DsGetDataById.Tables[0].Rows[0]["Mobile"].ToString() != "")
                {
                    txtMobileCountry.Text = DsGetDataById.Tables[0].Rows[0]["Mobile"].ToString().Replace('~', '-');
                }
                else
                {
                    txtMobileCountry.Text = "Not Mentioned";
                }
                if (DsGetDataById.Tables[0].Rows[0]["Phone"].ToString() != "")
                {
                    txtPhCountry1.Text = DsGetDataById.Tables[0].Rows[0]["Phone"].ToString().Replace('~', '-');
                }
                else
                {
                    txtPhCountry1.Text = "Not Mentioned";
                }


            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        Response.Redirect("MaintainFeedback.aspx");
    }
}
