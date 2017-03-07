using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Summary description for AdminLoginBO
/// </summary>
public class AdminLoginBO
{
	public AdminLoginBO()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private int _ID;

    public int ID
    {
        get { return _ID; }
        set { _ID = value; }
    }
    private string _UserName;

    public string UserName
    {
        get { return _UserName; }
        set { _UserName = value; }
    }
    private string _Password;

    public string Password
    {
        get { return _Password; }
        set { _Password = value; }
    }	
}
