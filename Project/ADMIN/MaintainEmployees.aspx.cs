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

public partial class ADMIN_MaintainEmployees : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["ID"] == null)
        {
            Response.Redirect("~/Login.aspx");
        }

        if (!Page.IsPostBack)
        {
            EmployeeDetails();
        }
    }
    private void EmployeeDetails()
    {
        try
        {
            EmployeeBO objEmployeeBO = new EmployeeBO();
            DataSet ds = new DataSet();
            ds = objEmployeeBO.ShowEmployee();
            if (ds != null)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    dgEmployees.DataSource = ds;
                    dgEmployees.DataBind();
                }
            }
            else
            {
                dgEmployees.DataSource = null;
                dgEmployees.DataBind();

            }
        }
        catch
        {
            dgEmployees.DataSource = null;
            dgEmployees.DataBind();

        }
    }
    protected void lnkAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("CreateEmployee.aspx");

    }
    protected void lnkCheckAll_Click(object sender, EventArgs e)
    {
        lblError.Text = "";
        for (int i = 0; i < dgEmployees.Items.Count; i++)
        {
            CheckBox chk = (CheckBox)dgEmployees.Items[i].FindControl("chkDel");
            chk.Checked = true;
        }

    }
    protected void lnkClearAll_Click(object sender, EventArgs e)
    {
        lblError.Text = "";
        for (int i = 0; i < dgEmployees.Items.Count; i++)
        {
            CheckBox chk = (CheckBox)dgEmployees.Items[i].FindControl("chkDel");
            chk.Checked = false;
        }

    }
    protected void lnlDelete_Click(object sender, EventArgs e)
    {
         try
        {
            String Ids = "";
            for (Int16 i = 0; i < dgEmployees.Items.Count; i++)
            {
                if (((CheckBox)dgEmployees.Items[i].FindControl("chkDel")).Checked == true)
                {
                    Ids += dgEmployees.DataKeys[i] + ",";
                }
            }
            if (Ids != "")
            {
                Ids = Ids.TrimEnd(',');
                Boolean Result = false;
                EmployeeBO objEmployeeBO = new EmployeeBO();
                Result = objEmployeeBO.DeleteFromtblEmployees(Ids);
                if (Result)
                {
                    EmployeeDetails();
                    lblError.Text = "Employee Details deleted successfully";
                }
                else
                {
                    lblError.Text = "Error in deletion";
                }
            }
            else
            {
                lblError.Text = "Select a record to delete";
            }
        }
        catch
        {
        }    

    }

    protected void dgEmployees_ItemCommand(object source, DataGridCommandEventArgs e)
    {

        if (e.CommandName == "Edit")
        {
            Response.Redirect("EditEmployeeInfo.aspx?Id=" + dgEmployees.DataKeys[e.Item.ItemIndex]);
        }
    }
}

