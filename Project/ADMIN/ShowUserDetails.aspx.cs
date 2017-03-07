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

public partial class ADMIN_ShowUserDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["ID"] == null)
        {
            Response.Redirect("~/Login.aspx");
        }

        if (!Page.IsPostBack)
        {
            ShowUserDetails();
        }

    }
    private void ShowUserDetails()
    {
        UsersBO ObjUsersBO = new UsersBO();
        if (Request.QueryString["Id"] != null)
        {

            ObjUsersBO.UserID = Convert.ToInt16(Request.QueryString["Id"]);
        }
        DataSet DsGetDataById = new DataSet();
        DsGetDataById = ObjUsersBO.EditUserDetails();
        if (DsGetDataById != null)
        {
            if (DsGetDataById.Tables[0].Rows.Count > 0)
            {
                if (DsGetDataById.Tables[0].Rows[0]["UserName"].ToString() != "")
                {
                    txtUserName.Text = DsGetDataById.Tables[0].Rows[0]["UserName"].ToString();
                }
                else
                {
                    txtUserName.Text = "Not Mentioned";
                }

                if (DsGetDataById.Tables[0].Rows[0]["Email"].ToString() != "")
                {
                    txtEmail.Text = DsGetDataById.Tables[0].Rows[0]["Email"].ToString();
                }
                else
                {
                    txtEmail.Text = "Not Mentioned";
                }
                if (DsGetDataById.Tables[0].Rows[0]["Country"].ToString() != "")
                {
                   lblCountry.Text = DsGetDataById.Tables[0].Rows[0]["Country"].ToString();
                }
                else
                {
                    lblCountry.Text = "Not Mentioned";
                }
                if (DsGetDataById.Tables[0].Rows[0]["CreatedDate"].ToString() != "")
                {
                    lblCreatedDate.Text = DsGetDataById.Tables[0].Rows[0]["CreatedDate"].ToString();
                }
                else
                {
                    lblCreatedDate.Text = "Not Mentioned";
                }
                if (DsGetDataById.Tables[0].Rows[0]["City"].ToString() != "")
                {
                    txtCity.Text = DsGetDataById.Tables[0].Rows[0]["City"].ToString();
                }
                else
                {
                    txtCity.Text = "Not Mentioned";
                }
                if (DsGetDataById.Tables[0].Rows[0]["Address"].ToString() != "")
                {
                    txtAddress.Text = DsGetDataById.Tables[0].Rows[0]["Address"].ToString();
                }
                else
                {
                    txtAddress.Text = "Not Mentioned";
                }
                if (DsGetDataById.Tables[0].Rows[0]["Mobile"].ToString() != "")
                {
                    string[] strMobile = (DsGetDataById.Tables[0].Rows[0]["Mobile"].ToString()).Split('~');
                    txtMobileCountry.Text = strMobile[0].ToString();
                    txtMobile.Text = strMobile[1].ToString();
                }
                else
                {
                    txtMobileCountry.Text = " ";
                }
                if (DsGetDataById.Tables[0].Rows[0]["Phone"].ToString() != "")
                {
                    string[] strPh = (DsGetDataById.Tables[0].Rows[0]["Phone"].ToString()).Split('~');
                    txtPhCountry.Text = strPh[0].ToString();
                    txtPhSTD.Text = strPh[1].ToString();
                    txtPhone.Text = strPh[2].ToString();
                }

            }
        }
    }
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("MaintainUsers.aspx");
    }
}
