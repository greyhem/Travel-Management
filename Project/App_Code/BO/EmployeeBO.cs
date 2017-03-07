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
/// Summary description for EmployeeBO
/// </summary>
public class EmployeeBO
{
	public EmployeeBO()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private Int64 _EmployeeID;

    public Int64 EmployeeID
    {
        get { return _EmployeeID; }
        set { _EmployeeID = value; }
    }
    private string _EmployeeName;

    public string EmployeeName
    {
        get { return _EmployeeName; }
        set { _EmployeeName = value; }
    }
    private string _Designation;

    public string Designation
    {
        get { return _Designation; }
        set { _Designation = value; }
    }
    private string _Email;

    public string Email
    {
        get { return _Email; }
        set { _Email = value; }
    }
    private string _Address;

    public string Address
    {
        get { return _Address; }
        set { _Address = value; }
    }
    private string _Mobile;

    public string Mobile
    {
        get { return _Mobile; }
        set { _Mobile = value; }
    }
    private string _AllotedToBranch;

    public string AllotedToBranch
    {
        get { return _AllotedToBranch; }
        set { _AllotedToBranch = value; }
    }
    private DateTime _CreatedDate;

    public DateTime CreatedDate
    {
        get { return _CreatedDate; }
        set { _CreatedDate = value; }
    }

    //For Inserting Into tblEmployeeInfo
    public int InsertIntoEmployeeInfo()
    {
        try
        {
            EmployeeDAL ObjEmployeeDAL = new EmployeeDAL();
            return ObjEmployeeDAL.InsertEmployeeInfo(this);
        }
        catch
        {
            return 0;
        }
    }
    public DataSet ShowEmployeeDetails()
    {
        try
        {
            EmployeeDAL ObjEmployeeDAL = new EmployeeDAL();
            return ObjEmployeeDAL.ShowEmployeeDetails(this);
        }
        catch
        {
            return null;
        }
    }
    public int UpdatetblEmployees()
    {
        try
        {
            EmployeeDAL ObjEmployeeDAL = new EmployeeDAL();
            return ObjEmployeeDAL.UpdatetblEmployees(this);
        }
        catch
        {
            return 0;
        }
    }
    public DataSet ShowEmployee()
    {
        try
        {
            EmployeeDAL ObjEmployeeDAL = new EmployeeDAL();
            return ObjEmployeeDAL.ShowEmployee(this);
        }
        catch
        {
            return null;
        }
    }
    //For Deleting from tblEmployees
    public Boolean DeleteFromtblEmployees(String StrIds)
    {
        try
        {
            EmployeeDAL ObjEmployeeDAL = new EmployeeDAL();
            return ObjEmployeeDAL.DeleteFromtblEmployees(StrIds);
        }
        catch
        {
            return false;
        }
    }
}
