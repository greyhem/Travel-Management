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

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
        }

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
         if (rdbtnlDesignation.SelectedIndex == -1 && txtUserName.Text == "" && txtPassword.Text == "")
        {
            lblError.Text = "Please Select Your Designation and Enter UserName and Password";
        }
        else if (txtUserName.Text == "")
        {
            lblError.Text = "Plese Enter UserName";
        }
        else if (txtPassword.Text == "")
        {
            lblError.Text = "Plese Enter Password";
        }
        else if (rdbtnlDesignation.SelectedIndex == -1)
        {
            lblError.Text = "Plese Select Designation";
        }
        else if (rdbtnlDesignation.SelectedIndex != -1)
        {
            string check = string.Empty;
            UsersBO ObjUsersBO = new UsersBO();
            ObjUsersBO.UserName = txtUserName.Text.Trim();
            ObjUsersBO.Password = txtPassword.Text.Trim();
            if (rdbtnlDesignation.SelectedIndex == 0)
            {
                check = "A";
            }
            else
                if (rdbtnlDesignation.SelectedIndex == 1)
                {
                    check = "U";
                }
               
            DataSet ds = new DataSet();
            ds = ObjUsersBO.Login(check);

            if (ds != null)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    if (rdbtnlDesignation.SelectedIndex == 0)
                    {
                        Session["ID"] = ds.Tables[0].Rows[0]["ID"].ToString();
                        Response.Redirect("~/ADMIN/AdminArea.aspx");

                    }
                    else
                        if (rdbtnlDesignation.SelectedIndex == 1)
                        {
                            if (ds.Tables[0].Rows[0]["Status"].ToString() == "A")
                            {
                                Session["UserID"] = ds.Tables[0].Rows[0]["UserID"].ToString();
                                Session["UserName"] = ds.Tables[0].Rows[0]["UserName"].ToString();
                                Response.Redirect("~/Users/Home.aspx");
                            }
                            else
                            {
                                lblError.Text = "Profile was in Inactive Mode";
                            }

                        }
                       
                }
                else
                {
                    lblError.Text = "Incorrect Username and Password";
                }
            }
            else
            {
                lblError.Text = "Incorrect Username and Password";
            }




        }
    }
    //protected void CheckLogin()
    //{

    //}

    }

