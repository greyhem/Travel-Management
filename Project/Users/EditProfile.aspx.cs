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

public partial class Employees_EditProfile : System.Web.UI.Page
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

                ShowUsersInfo();
            }
        }
    }
    private void ShowUsersInfo()
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
               
               
                if (DsGetDataById.Tables[0].Rows[0]["Address"].ToString() != "")
                {
                    txtAddress.Text = DsGetDataById.Tables[0].Rows[0]["Address"].ToString();
                }
                else
                {
                    txtAddress.Text = " ";
                }
               
               
                if (DsGetDataById.Tables[0].Rows[0]["Country"].ToString() != "")
                {
                    ddlCountry.ClearSelection();
                    ddlCountry.Items.FindByText(DsGetDataById.Tables[0].Rows[0]["Country"].ToString()).Selected = true;
                }
                else
                {
                    ddlCountry.Text = " ";
                }
                if (DsGetDataById.Tables[0].Rows[0]["City"].ToString() != "")
                {
                    txtCity.Text = DsGetDataById.Tables[0].Rows[0]["City"].ToString();
                }
                else
                {
                    txtCity.Text = " ";
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

                if (DsGetDataById.Tables[0].Rows[0]["Email"].ToString() != "")
                {
                    txtEmail.Text = DsGetDataById.Tables[0].Rows[0]["Email"].ToString();
                }
                else
                {
                    txtEmail.Text = " ";
                }
             

               
            }
        }

    }
    private void UpdatetblUsers()
    {

        try
        {
            if (ValidateFields())
            {
                int intResult = 0;
                UsersBO ObjUsersBO = new UsersBO();
                ObjUsersBO.UserID = int.Parse(Session["UserID"].ToString());
                //ObjUsersBO.UserID = 5;
                ObjUsersBO.Address = txtAddress.Text.Trim();
                ObjUsersBO.City = txtCity.Text.Trim();
                ObjUsersBO.Email = txtEmail.Text.Trim();
              
                if (txtPhCountry.Text.Trim() != "" && txtPhSTD.Text.Trim() != "" && txtPhone.Text.Trim() != "")
                {
                    ObjUsersBO.Phone = txtPhCountry.Text.Trim() + "~" + txtPhSTD.Text.Trim() + "~" + txtPhone.Text.Trim();
                }

                if (txtMobileCountry.Text.Trim() != "" && txtMobile.Text.Trim() != "")
                {
                    ObjUsersBO.Mobile = txtMobileCountry.Text.Trim() + "~" + txtMobile.Text.Trim();
                }

              
                if (ddlCountry.SelectedIndex != 0)
                {
                    ObjUsersBO.Country = ddlCountry.SelectedItem.Text;
                }


                intResult = ObjUsersBO.UpdatetblUsers();
                if (intResult > 0)
                {
                    
                    Response.Redirect("MyProfile.aspx");
                    
                }
                else
                {
                    lblError.Text = "Error while Creation";
                }
            }
        }
        catch
        {
            throw;
        }
    }

    private bool ValidateFields()
    {
        try
        {
           
            if (txtEmail.Text.Trim() == "")
            {
                lblError.Text = "Enter Email ID";
                return false;
            }
            if (txtAddress.Text.Trim() == "")
            {
                lblError.Text = "Enter Address";
                return false;
            }
            if (ddlCountry.SelectedIndex == 0)
            {
                lblError.Text = "Select Country";
                return false;
            }
            if (txtCity.Text.Trim() == "")
            {
                lblError.Text = "Enter City";
                return false;
            }

            if (txtMobileCountry.Text.Trim() == "")
            {
                lblError.Text = "Enter Mobile Country Code";
                return false;
            }
            if (txtMobile.Text.Trim() == "")
            {
                lblError.Text = "Enter Mobile Number";
                return false;
            }

            return true;
        }
        catch
        {
            return false;
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        UpdatetblUsers();
    }
    protected void btnReset_Click(object sender, EventArgs e)
    {
        Response.Redirect("MyProfile.aspx");
    }
}
