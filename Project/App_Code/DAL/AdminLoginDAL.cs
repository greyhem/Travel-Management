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
/// Summary description for AdminLoginDAL
/// </summary>
public class AdminLoginDAL
{
    SqlConnection SqlCon = BaseDAL.Connection_through_Config();
	public AdminLoginDAL()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}
