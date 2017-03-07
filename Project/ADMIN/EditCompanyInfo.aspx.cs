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

public partial class ADMIN_EditCompanyInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["ID"] == null)
        {
            Response.Redirect("~/Login.aspx");
        }

        if (!Page.IsPostBack)
        {
            EditCompanyDetails();
        }

    }
    private void EditCompanyDetails()
    {
        CompanyInfoBO ObjCompanyInfoBO = new CompanyInfoBO();
        if (Request.QueryString["Id"] != null)
        {

            ObjCompanyInfoBO.CompanyID = Convert.ToInt16(Request.QueryString["Id"]);
        }
        DataSet DsGetDataById = new DataSet();
        DsGetDataById = ObjCompanyInfoBO.EditCompanyDetails();
        if (DsGetDataById != null)
        {
            if (DsGetDataById.Tables[0].Rows.Count > 0)
            {
                if (DsGetDataById.Tables[0].Rows[0]["CompanyName"].ToString() != "")
                {
                    txtCompanyName.Text = DsGetDataById.Tables[0].Rows[0]["CompanyName"].ToString();
                }
                else
                {
                    txtCompanyName.Text = "Not Mentioned";
                }

                if (DsGetDataById.Tables[0].Rows[0]["Description"].ToString() != "")
                {
                    txtDescription.Text = DsGetDataById.Tables[0].Rows[0]["Description"].ToString();
                }
                else
                {
                    txtDescription.Text = "Not Mentioned";
                }
                if (DsGetDataById.Tables[0].Rows[0]["Address"].ToString() != "")
                {
                    txtAddress.Text = DsGetDataById.Tables[0].Rows[0]["Address"].ToString();
                }
                else
                {
                    txtAddress.Text = "Not Mentioned";
                }
                if (DsGetDataById.Tables[0].Rows[0]["CreatedDate"].ToString() != "")
                {
                    lblCreatedDate.Text = DsGetDataById.Tables[0].Rows[0]["CreatedDate"].ToString();
                }
                else
                {
                    lblCreatedDate.Text = "Not Mentioned";
                }
              
            }
        }
    }
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("MaintainCompanyInfo.aspx");
    }
    private void UpdatetblCompanyInfo()
    {

        try
        {
            int intResult = 0;
            CompanyInfoBO ObjCompanyInfoBO = new CompanyInfoBO();
            ObjCompanyInfoBO.CompanyID = int.Parse(Request.QueryString["Id"].ToString());
            ObjCompanyInfoBO.CompanyName = txtCompanyName.Text.Trim();
            ObjCompanyInfoBO.Description= txtDescription.Text.Trim();
            ObjCompanyInfoBO.Address = txtAddress.Text.Trim();

            intResult = ObjCompanyInfoBO.UpdatetblCompanyInfo();
            if (intResult > 0)
            {

                //Response.Redirect("MaintainEmployees.aspx");
                Page.RegisterStartupScript("SS", "<script> alert('Company Details Are Updated Succesfully'); </script>");
                txtCompanyName.Text = "";
                txtDescription.Text = "";
                txtAddress.Text = "";

            }
            else
            {
                lblError.Text = "Error while Creation";
            }
        }

        catch
        {
            throw;
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        UpdatetblCompanyInfo();
    }
}
