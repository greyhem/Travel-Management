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
/// Summary description for CompanyInfoBO
/// </summary>
public class CompanyInfoBO
{
	public CompanyInfoBO()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private Int64 _CompanyID;

    public Int64 CompanyID
    {
        get { return _CompanyID; }
        set { _CompanyID = value; }
    }
    private string _CompanyName;

    public string CompanyName
    {
        get { return _CompanyName; }
        set { _CompanyName = value; }
    }
    private string _Description;

    public string Description
    {
        get { return _Description; }
        set { _Description = value; }
    }
    private string _Address;

    public string Address
    {
        get { return _Address; }
        set { _Address = value; }
    }
    private string _CompanyLogo;

    public string CompanyLogo
    {
        get { return _CompanyLogo; }
        set { _CompanyLogo = value; }
    }
    private DateTime _CreatedDate;

    public DateTime CreatedDate
    {
        get { return _CreatedDate; }
        set { _CreatedDate = value; }
    }
    private DateTime _UpdatedDate;

    public DateTime UpdatedDate
    {
        get { return _UpdatedDate; }
        set { _UpdatedDate = value; }
    }
    //For Inserting Into tblCompanyInfo
    public int InsertIntoCompanyInfo()
    {
        try
        {
            CompanyInfoDAL ObjCompanyInfoDAL = new CompanyInfoDAL();
            return ObjCompanyInfoDAL.InsertCompanyInfo(this);
        }
        catch
        {
            return 0;
        }
    }
    public DataSet GetDataOrderByDate()
    {
        try
        {
            CompanyInfoDAL ObjCompanyInfoDAL = new CompanyInfoDAL();
            return ObjCompanyInfoDAL.GetDataOrderByDate(this);
        }
        catch
        {
            return null;
        }
    }
    public DataSet EditCompanyDetails()
    {
        try
        {
            CompanyInfoDAL ObjCompanyInfoDAL = new CompanyInfoDAL();
            return ObjCompanyInfoDAL.EditCompanyDetails(this);
        }
        catch
        {
            return null;
        }
    }
    public int UpdatetblCompanyInfo()
    {
        try
        {
            CompanyInfoDAL ObjCompanyInfoDAL = new CompanyInfoDAL();
            return ObjCompanyInfoDAL.UpdatetblCompanyInfo(this);
        }
        catch
        {
            return 0;
        }
    }
}
