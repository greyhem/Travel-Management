using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

/// <summary>
/// Summary description for BaseDAL
/// </summary>
public class BaseDAL
{
    //SqlConnection SqlCon;
	public BaseDAL()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public static SqlConnection Connection_through_Config()
    {
        string ConString;
        ConString = ConfigurationManager.AppSettings["ConStr"];
        SqlConnection SqlCon = new SqlConnection(ConString);
        return SqlCon;
    }
}
