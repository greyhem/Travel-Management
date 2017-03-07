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
        //if (Session["ID"] == null)
        //{
        //    Response.Redirect("~/Login.aspx");
        //}

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
  
}

