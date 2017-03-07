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

public partial class ADMIN_MaintainCompanyInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["ID"] == null)
        {
            Response.Redirect("~/Login.aspx");
        }

        if (!Page.IsPostBack)
        {
            ShowCompanyInfo();
        }
    }
    private void ShowCompanyInfo()
    
    {
        try
        {
            CompanyInfoBO objCompanyInfoBO = new CompanyInfoBO();
            DataSet DsGetDataOrderByDate = new DataSet();
            DsGetDataOrderByDate = objCompanyInfoBO.GetDataOrderByDate();
            if (DsGetDataOrderByDate != null)
            {
                if (DsGetDataOrderByDate.Tables[0].Rows.Count > 0)
                {
                    dgCompanyInfo.DataSource = DsGetDataOrderByDate;
                    dgCompanyInfo.DataBind();
                }
            }
            else
            {
                dgCompanyInfo.DataSource = null;
                dgCompanyInfo.DataBind();
               
            }
        }
        catch
        {
            dgCompanyInfo.DataSource = null;
            dgCompanyInfo.DataBind();
           
        }
    }

    protected void dgCompanyInfo_ItemCommand(object source, DataGridCommandEventArgs e)
    {
        if (e.CommandName == "Edit")
        {
            Response.Redirect("EditCompanyInfo.aspx?Id=" + dgCompanyInfo.DataKeys[e.Item.ItemIndex]);
        }
    }
}
