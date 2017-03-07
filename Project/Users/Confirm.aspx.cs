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

public partial class Users_Confirm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Request.QueryString["UID"] != null)
            {

            }
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        CheckPassword();
    }
    private void CheckPassword()
    {
        try
        {
            UsersBO ObjusersBO = new UsersBO();
            if (Request.QueryString["UID"] != null)
            {
                ObjusersBO.UserID = Convert.ToInt64(Request.QueryString["UID"].ToString());
            }
            //ObjusersBO.UserID = 5;
            DataSet ds = new DataSet();
            ObjusersBO.Password = txtPassword.Text.Trim();
            ds = ObjusersBO.ShowUserById();
            if (ds != null)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    if (ds.Tables[0].Rows[0]["Password"].ToString() == txtPassword.Text.Trim())
                    {
                        ObjusersBO.Status = "A";
                        int intResult = 0;
                        intResult = ObjusersBO.UpdateUserStatus();
                        if (intResult > 0)
                        {
                            Session["UserID"] = ds.Tables[0].Rows[0]["UserID"].ToString();
                            Response.Redirect("MyProfile.aspx");
                        }
                    }
                }
                else
                {
                    lblError.Text = "This Password Not Exist";
                }
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}
