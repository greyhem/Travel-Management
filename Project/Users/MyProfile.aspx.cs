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

public partial class USERS_MyProfile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserID"] == null)
        {
            Response.Redirect("~/Login.aspx");
        }
        if (!Page.IsPostBack)
        {
            if (Session["UserID"] != null)
            {
                ShowUserDetails();
            }
        }
    
    }
    private void ShowUserDetails()
    {
        UsersBO ObjUsersBO = new UsersBO();
        ObjUsersBO.UserID = int.Parse(Session["UserID"].ToString());
        //ObjUsersBO.UserID = 5;
        DataSet DsGetDataById = new DataSet();
        DsGetDataById = ObjUsersBO.ShowUsersInfo();
        if (DsGetDataById != null)
        {
            if (DsGetDataById.Tables[0].Rows.Count > 0)
            {
                if (DsGetDataById.Tables[0].Rows[0]["UserName"].ToString() != "")
                {
                    lblUserName.Text = DsGetDataById.Tables[0].Rows[0]["UserName"].ToString();
                }
                else
                {
                    lblUserName.Text = "Not Mentioned";
                }
               
                if (DsGetDataById.Tables[0].Rows[0]["Email"].ToString() != "")
                {
                    lblEmail.Text = DsGetDataById.Tables[0].Rows[0]["Email"].ToString();
                }
                else
                {
                    lblEmail.Text = "Not Mentioned";
                }
                if (DsGetDataById.Tables[0].Rows[0]["Address"].ToString() != "")
                {
                    lblAddress.Text = DsGetDataById.Tables[0].Rows[0]["Address"].ToString();
                }
                else
                {
                    lblAddress.Text = "Not Mentioned";
                }
             
               
                if (DsGetDataById.Tables[0].Rows[0]["Country"].ToString() != "")
                {
                    ddlCountry.Text = DsGetDataById.Tables[0].Rows[0]["Country"].ToString();
                }
                else
                {
                    ddlCountry.Text = " ";
                }
                if (DsGetDataById.Tables[0].Rows[0]["City"].ToString() != "")
                {
                    ddlCity.Text = DsGetDataById.Tables[0].Rows[0]["City"].ToString();
                }
                else
                {
                    ddlCity.Text = "";
                }
               

                if (DsGetDataById.Tables[0].Rows[0]["CreatedDate"].ToString() != "")
                {
                    lblCreatedDate.Text = DsGetDataById.Tables[0].Rows[0]["CreatedDate"].ToString();
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
                    txtPhCountry.Text = DsGetDataById.Tables[0].Rows[0]["Phone"].ToString().Replace('~', '-');
                }
                else
                {
                    txtPhCountry.Text = "Not Mentioned";
                }

                
            }
        }
    }
    protected void btnEdit_Click(object sender, EventArgs e)
    {
       
        Response.Redirect("EditProfile.aspx");
    }
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("Home.aspx");
    }
}
