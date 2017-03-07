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

public partial class ADMIN_CreateEmployee : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["ID"] == null)
        {
            Response.Redirect("~/Login.aspx");
        }

        if (!Page.IsPostBack)
        {
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
         try
        {
                int intResult = 0;
                EmployeeBO ObjEmployeeBO = new EmployeeBO();
                ObjEmployeeBO.EmployeeName = txtEmployeeName.Text.Trim();
                ObjEmployeeBO.Email= txtEmail.Text.Trim();
                ObjEmployeeBO.Address = txtAddress.Text.Trim();
                ObjEmployeeBO.Designation=txtDesignation.Text.Trim();
               if (txtMobileCountry.Text.Trim() != "" && txtMobile.Text.Trim() != "")
                {
                    ObjEmployeeBO.Mobile = txtMobileCountry.Text.Trim() + "~" + txtMobile.Text.Trim();
                }
                     if (ddlBranch.SelectedIndex != 0)
                {
                    ObjEmployeeBO.AllotedToBranch = ddlBranch.SelectedItem.Text;
                }
         

                intResult =ObjEmployeeBO.InsertIntoEmployeeInfo();
                if (intResult > 0)
                {
                    Page.RegisterStartupScript("SS", "<script> alert('Succesfully Created The Employee Details'); </script>");
                    txtEmployeeName.Text = "";
                    txtEmail.Text = "";
                    txtAddress.Text = "";
                    txtDesignation.Text = "";
                    txtMobileCountry.Text = "";
                    ddlBranch.SelectedIndex = 0;
                    txtMobile.Text = "";
                    
                }
                else
                {
                   

                }
            }
        
        catch
        {
            throw;
        }
       
    }
    protected void brnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("MaintainEmployees.aspx");
    }
}

