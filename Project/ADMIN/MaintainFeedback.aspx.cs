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

public partial class ADMIN_MaintainFeedback : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["ID"] == null)
        {
            Response.Redirect("~/Login.aspx");
        }

        if (!Page.IsPostBack)
        {
            ShowFeedback();
        }
    }
    private void ShowFeedback()
    {
        try
        {
            FeedbackBO objFeedbackBO = new FeedbackBO();
            DataSet ds = new DataSet();
            ds = objFeedbackBO.ShowFeedback();
            if (ds != null)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    dgFeedback.DataSource = ds;
                    dgFeedback.DataBind();
                }
            }
            else
            {
                dgFeedback.DataSource = null;
                dgFeedback.DataBind();

            }
        }
        catch
        {
            dgFeedback.DataSource = null;
            dgFeedback.DataBind();

        }
    }

    protected void dgFeedback_ItemCommand(object source, DataGridCommandEventArgs e)
    {

        if (e.CommandName == "Edit")
        {
            Response.Redirect("ViewFeedback.aspx?Id=" + dgFeedback.DataKeys[e.Item.ItemIndex]);
        }
    }
    protected void lnkCheckAll_Click(object sender, EventArgs e)
    {
        lblError.Text = "";
        for (int i = 0; i < dgFeedback.Items.Count; i++)
        {
            CheckBox chk = (CheckBox)dgFeedback.Items[i].FindControl("chkDel");
            chk.Checked = true;
        }

    }
    protected void lnkClearAll_Click(object sender, EventArgs e)
    {
        lblError.Text = "";
        for (int i = 0; i < dgFeedback.Items.Count; i++)
        {
            CheckBox chk = (CheckBox)dgFeedback.Items[i].FindControl("chkDel");
            chk.Checked = false;
        }

    }
    protected void lnlDelete_Click(object sender, EventArgs e)
    {
        try
        {
            String Ids = "";
            for (Int16 i = 0; i < dgFeedback.Items.Count; i++)
            {
                if (((CheckBox)dgFeedback.Items[i].FindControl("chkDel")).Checked == true)
                {
                    Ids += dgFeedback.DataKeys[i] + ",";
                }
            }
            if (Ids != "")
            {
                Ids = Ids.TrimEnd(',');
                Boolean Result = false;
                FeedbackBO ObjFeedbackBO = new FeedbackBO();
                Result = ObjFeedbackBO.DeleteFromtblFeedback(Ids);
                if (Result)
                {
                    ShowFeedback();
                    lblError.Text = "Feedback Details deleted successfully";
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
}
