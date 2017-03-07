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

public partial class ADMIN_EditEmployeeInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["ID"] == null)
        {
            Response.Redirect("~/Login.aspx");
        }

        if (!Page.IsPostBack)
        {

            DisplayEmployeeDetails();
        }
    }
    private void DisplayEmployeeDetails()
    {
        EmployeeBO ObjEmployeeBO = new EmployeeBO();
        if (Request.QueryString["Id"] != null)
        {

            ObjEmployeeBO.EmployeeID= Convert.ToInt16(Request.QueryString["Id"]);
        }
      
        DataSet DsGetDataById = new DataSet();
        DsGetDataById = ObjEmployeeBO.ShowEmployeeDetails();
        if (DsGetDataById != null)
        {
            if (DsGetDataById.Tables[0].Rows.Count > 0)
            {
                if (DsGetDataById.Tables[0].Rows[0]["EmployeeName"].ToString() != "")
                {
                    txtEmployeeName.Text = DsGetDataById.Tables[0].Rows[0]["EmployeeName"].ToString();
                }
                else
                {
                    txtEmployeeName.Text = "Not Mentioned";
                }

                if (DsGetDataById.Tables[0].Rows[0]["Email"].ToString() != "")
                {
                    txtEmail.Text = DsGetDataById.Tables[0].Rows[0]["Email"].ToString();
                }
                else
                {
                    txtEmail.Text = "Not Mentioned";
                }
                if (DsGetDataById.Tables[0].Rows[0]["Designation"].ToString() != "")
                {
                    txtDesignation.Text = DsGetDataById.Tables[0].Rows[0]["Designation"].ToString();
                }
                else
                {
                    txtDesignation.Text = "Not Mentioned";
                }
                if (DsGetDataById.Tables[0].Rows[0]["Address"].ToString() != "")
                {
                    txtAddress.Text = DsGetDataById.Tables[0].Rows[0]["Address"].ToString();
                }
                else
                {
                    txtAddress.Text = "Not Mentioned";
                }
                if (DsGetDataById.Tables[0].Rows[0]["AllotedToBranch"].ToString() != "")
                {
                    ddlBranch.Text = DsGetDataById.Tables[0].Rows[0]["AllotedToBranch"].ToString();
                }
                else
                {
                    ddlBranch.Text = "Not Mentioned";
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
                    string[] strMobile = (DsGetDataById.Tables[0].Rows[0]["Mobile"].ToString()).Split('~');
                    txtMobileCountry.Text = strMobile[0].ToString();
                    txtMobile.Text = strMobile[1].ToString();
                }
                else
                {
                    txtMobileCountry.Text = " ";
                }

            }
        }
    }
   
    private void UpdatetblEmployees()
    {

        try
        {
              int intResult = 0;
                EmployeeBO ObjEmployeeBO = new EmployeeBO();
                ObjEmployeeBO.EmployeeID = int.Parse(Request.QueryString["Id"].ToString());
                //ObjEmployeeBO.Address = txtAddress.Text.Trim();
                ObjEmployeeBO.EmployeeName = txtEmployeeName.Text.Trim();
                ObjEmployeeBO.Designation = txtDesignation.Text.Trim();
                ObjEmployeeBO.Address= txtAddress.Text.Trim();
                ObjEmployeeBO.Email = txtEmail.Text.Trim();

               
                if (txtMobileCountry.Text.Trim() != "" && txtMobile.Text.Trim() != "")
                {
                    ObjEmployeeBO.Mobile = txtMobileCountry.Text.Trim() + "~" + txtMobile.Text.Trim();
                }


                if (ddlBranch.SelectedIndex != 0)
                {
                    ObjEmployeeBO.AllotedToBranch = ddlBranch.SelectedItem.Text;
                }


                intResult = ObjEmployeeBO.UpdatetblEmployees();
                if (intResult > 0)
                {

                    //Response.Redirect("MaintainEmployees.aspx");
                    Page.RegisterStartupScript("SS", "<script> alert('Updated Succesfully'); </script>");
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
        UpdatetblEmployees();
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("MaintainEmployees.aspx");
    }
}
