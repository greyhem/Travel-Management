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

public partial class Users_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Request.Cookies["mycookie"] != null)
            {
                HttpCookie cookie = Request.Cookies.Get("mycookie");
                string UserName = cookie.Values["UserName"].ToString();
                string Password = cookie.Values["Password"].ToString();
                txtUserName.Text = UserName;
                txtPassword.Attributes.Add("value", Password);
                chkSavePassword.Checked = true;
            }
        }

    }
    protected void BtnSubmit_Click(object sender, EventArgs e)
    {
        CheckLogin();

    }
    private void CheckLogin()
    {
        try
        {
            UsersBO ObjUsersBO = new UsersBO();
            ObjUsersBO.UserName = txtUserName.Text.Trim();
            ObjUsersBO.Password = txtPassword.Text.Trim();
            DataSet ds = new DataSet();
            ds = ObjUsersBO.CheckLogin();
            if (ds != null)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    if (Convert.ToChar(ds.Tables[0].Rows[0]["Status"]) != 'I')
                    {
                        if (chkSavePassword.Checked == true)
                        {
                            HttpCookie myCookie = new HttpCookie("myCookie");
                            Response.Cookies.Remove("myCookie");
                            Response.Cookies.Add(myCookie);
                            myCookie.Values.Add("UserName", txtUserName.Text.Trim().ToString());
                            myCookie.Values.Add("Password", txtPassword.Text.Trim().ToString());

                            myCookie.Expires = DateTime.Now.AddDays(1);
                        }
                        Session["UserID"] = ds.Tables[0].Rows[0]["UserID"];
                        //if (Request.QueryString["Id"] != null)
                        //{
                        //    Response.Redirect("ShowJob.aspx?Id=" + Request.QueryString["Id"].ToString());
                        //}
                        //else
                        //{
                        Response.Redirect("MyProfile.aspx");

                        //}

                    }
                    else
                    {
                        lblError.Text = "Profile was in InActive Mode";
                    }
                }
                else
                {
                    lblError.Text = "Invalid Username or Password";
                }
            }
            else
            {
                lblError.Text = "Invalid Username or Password";
            }
        }
        catch
        {

        }
    }
    protected void BtnReset_Click(object sender, EventArgs e)
    {

    }
}
