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

public partial class Users_ChangePassword : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserID"] == null)
        {
            Response.Redirect("~/Login.aspx");
        }
       

    }
    protected void btnChangePwd_Click(object sender, EventArgs e)
    {
        ChangePassword();
    }

    private void ChangePassword()
    {
        try
        {
            UsersBO objUsersBO = new UsersBO();
            
            if (Session["UserId"].ToString() != null)
            {
                objUsersBO.UserID= Convert.ToInt64(Session["UserId"]);
                //objUsersBO.UserID = 5;
                DataSet DsChangePassword = new DataSet();
                DsChangePassword = objUsersBO.ShowUserById();
                if (DsChangePassword != null)
                {
                    if (txtOldPassword.Text == DsChangePassword.Tables[0].Rows[0]["Password"].ToString())
                    {
                        objUsersBO.Password = txtNewPwd.Text.Trim();
                        int Result = 0;
                        Result = objUsersBO.ChangePassword();
                        if (Result > 0)
                        {
                            //Response.Redirect("Welcome.aspx");
                            //lblErrMsg.Text = "Password Updated Successfully";
                            Page.RegisterStartupScript("SS", "<script> alert('Password Changed Succesfully'); </script>");
                            txtOldPassword.Text = "";
                            txtNewPwd.Text = "";
                            txtConfNewPwd.Text = "";
                        }
                        else
                        {
                            lblErrMsg.Text = "Error in Updation";
                        }
                    }
                    else
                    {
                        lblErrMsg.Text = "Invalid OldPassword";
                    }
                }
           }
            else
            {
                lblErrMsg.Text = "You have to login First For Changing The Password";
            }
        }
        catch
        {
            throw;
        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("MyProfile.aspx");
    }
}
