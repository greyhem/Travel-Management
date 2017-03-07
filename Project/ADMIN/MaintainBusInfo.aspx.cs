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

public partial class ADMIN_MaintainBusInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["ID"] == null)
        {
            Response.Redirect("~/Login.aspx");
        }

        if (!Page.IsPostBack)
        {
            BusDetails();
        }


    }
    private void BusDetails()
    {
        try
        {
            BusInfoBO objBusInfoBO = new BusInfoBO();
            DataSet ds = new DataSet();
            ds = objBusInfoBO.ShowBusDetails();
            if (ds != null)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    dgBusInfo.DataSource = ds;
                    dgBusInfo.DataBind();
                }
            }
            else
            {
                dgBusInfo.DataSource = null;
                dgBusInfo.DataBind();

            }
        }
        catch
        {
            dgBusInfo.DataSource = null;
            dgBusInfo.DataBind();

        }
    }

    protected void lnkAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("CreateBusInfo.aspx");
       

    }
    protected void lnkCheckAll_Click(object sender, EventArgs e)
    {
        lblError.Text = "";
        for (int i = 0; i < dgBusInfo.Items.Count; i++)
        {
            CheckBox chk = (CheckBox)dgBusInfo.Items[i].FindControl("chkDel");
            chk.Checked = true;
        }

    }
    protected void lnkClearAll_Click(object sender, EventArgs e)
    {
        lblError.Text = "";
        for (int i = 0; i < dgBusInfo.Items.Count; i++)
        {
            CheckBox chk = (CheckBox)dgBusInfo.Items[i].FindControl("chkDel");
            chk.Checked = false;
        }

    }
    protected void lnlDelete_Click(object sender, EventArgs e)
    {
         try
        {
            String Ids = "";
            for (Int16 i = 0; i < dgBusInfo.Items.Count; i++)
            {
                if (((CheckBox)dgBusInfo.Items[i].FindControl("chkDel")).Checked == true)
                {
                    Ids += dgBusInfo.DataKeys[i] + ",";
                }
            }
            if (Ids != "")
            {
                Ids = Ids.TrimEnd(',');
                Boolean Result = false;
               BusInfoBO objBusInfoBO = new BusInfoBO();
                Result = objBusInfoBO.DeleteFromtblBusInfo(Ids);
                if (Result)
                {
                    BusDetails();
                    lblError.Text = "Service Details deleted successfully";
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

    protected void dgBusInfo_ItemCommand(object source, DataGridCommandEventArgs e)
    {

        if (e.CommandName == "Edit")
        {
            Response.Redirect("EditBusInfo.aspx?Id=" + dgBusInfo.DataKeys[e.Item.ItemIndex]);
        }
    }
}

