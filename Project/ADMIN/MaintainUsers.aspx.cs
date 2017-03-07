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

public partial class ADMIN_MaintainUsers : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["ID"] == null)
        {
            Response.Redirect("~/Login.aspx");
        }

        if (!Page.IsPostBack)
        {
            ShowUser();

        }

    }
    private void ShowUser()
    {
        try
        {
            UsersBO objUsersBO = new UsersBO();
            DataSet ds = new DataSet();
            ds = objUsersBO.ShowUsersInfo1();
            if (ds != null)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    dgUsers.DataSource = ds;
                    dgUsers.DataBind();
                }
            }
            else
            {
                dgUsers.DataSource = null;
                dgUsers.DataBind();

            }
        }
        catch
        {
            dgUsers.DataSource = null;
            dgUsers.DataBind();

        }
    }
    protected void lnkCheckAll_Click(object sender, EventArgs e)
    {
        lblError.Text = "";
        for (int i = 0; i < dgUsers.Items.Count; i++)
        {
            CheckBox chk = (CheckBox)dgUsers.Items[i].FindControl("chkDel");
            chk.Checked = true;
        }

    }
    protected void lnkClearAll_Click(object sender, EventArgs e)
    {
        lblError.Text = "";
        for (int i = 0; i < dgUsers.Items.Count; i++)
        {
            CheckBox chk = (CheckBox)dgUsers.Items[i].FindControl("chkDel");
            chk.Checked = false;
        }

    }
    protected void lnlDelete_Click(object sender, EventArgs e)
    {
         try
        {
            String Ids = "";
            for (Int16 i = 0; i < dgUsers.Items.Count; i++)
            {
                if (((CheckBox)dgUsers.Items[i].FindControl("chkDel")).Checked == true)
                {
                    Ids += dgUsers.DataKeys[i] + ",";
                }
            }
            if (Ids != "")
            {
                Ids = Ids.TrimEnd(',');
                Boolean Result = false;
                UsersBO objUsersBO = new UsersBO();
                Result = objUsersBO.DeleteFromtblUsers(Ids);
                if (Result)
                {
                    ShowUser();
                    lblError.Text = "User Details deleted successfully";
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

    

    protected void dgUsers_ItemCommand(object source, DataGridCommandEventArgs e)
    {
        if (e.CommandName == "Edit")
        {
            Response.Redirect("ShowUserDetails.aspx?Id=" + dgUsers.DataKeys[e.Item.ItemIndex]);
        }

    }
}
