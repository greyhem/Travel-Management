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

public partial class ADMIN_CreateCompanyInfo : System.Web.UI.Page
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
                CompanyInfoBO ObjCompanyInfoBO = new CompanyInfoBO();
                ObjCompanyInfoBO.CompanyName = txtCompanyName.Text.Trim();
                ObjCompanyInfoBO.Description= txtDescription.Text.Trim();
                ObjCompanyInfoBO.Address = txtAddress.Text.Trim();

                intResult = ObjCompanyInfoBO.InsertIntoCompanyInfo();
                if (intResult > 0)
                {
                    Page.RegisterStartupScript("SS", "<script> alert('Succesfully Created'); </script>");
                    txtCompanyName.Text = "";
                    txtDescription.Text = "";
                    txtAddress.Text = "";
                  
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
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("MaintainCompanyInfo.aspx");


    }
}
