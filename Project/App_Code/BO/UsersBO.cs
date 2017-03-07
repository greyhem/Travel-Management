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
/// Summary description for UsersBO
/// </summary>
public class UsersBO
{
    public UsersBO()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    private Int64 _UserID;

    public Int64 UserID
    {
        get { return _UserID; }
        set { _UserID = value; }
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
    private string _Email;

    public string Email
    {
        get { return _Email; }
        set { _Email = value; }
    }

    private string _Mobile;

    public string Mobile
    {
        get { return _Mobile; }
        set { _Mobile = value; }
    }
    private string _Phone;

    public string Phone
    {
        get { return _Phone; }
        set { _Phone = value; }
    }
    private string _Country;

    public string Country
    {
        get { return _Country; }
        set { _Country = value; }
    }
    private string _City;

    public string City
    {
        get { return _City; }
        set { _City = value; }
    }


    private string _Address;

    public string Address
    {
        get { return _Address; }
        set { _Address = value; }
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
    private string _Status;

    public string Status
    {
        get { return _Status; }
        set { _Status = value; }
    }
    //For Inserting Into tblEmployees
    public Int64 InsertIntotblUsers()
    {
        try
        {
            UsersDAL ObjUsersDAL = new UsersDAL();
            return ObjUsersDAL.InsertIntotblUsers(this);
        }
        catch
        {
            return 0;
        }
    }
    public DataSet CheckAvailable()
    {
        try
        {
            UsersDAL ObjUsersDAL = new UsersDAL();
            return ObjUsersDAL.CheckAvailability(this);
        }
        catch
        {
            return null;
        }
    }
    //For Showing Users Details
    public DataSet ShowUsersInfo()
    {
        try
        {
            UsersDAL ObjUsersDAL = new UsersDAL();
            return ObjUsersDAL.ShowUsersInfo(this);
        }
        catch
        {
            return null;
        }
    }
    //For Showing Users Details
    public DataSet ShowUsersInfo1()
    {
        try
        {
            UsersDAL ObjUsersDAL = new UsersDAL();
            return ObjUsersDAL.ShowUsersInfo1(this);
        }
        catch
        {
            return null;
        }
    }
    //For Updating User Details
    public int UpdatetblUsers()
    {
        try
        {
            UsersDAL ObjUsersDAL = new UsersDAL();
            return ObjUsersDAL.UpdatetblUsers(this);
        }
        catch
        {
            return 0;
        }
    }
    //To ChangePassword
    public int ChangePassword()
    {
        try
        {
            UsersDAL ObjUsersDAL = new UsersDAL();
            return ObjUsersDAL.ChangePassword(this);
        }
        catch
        {
            return 0;
        }
    }
    //To get Details By USERId
    public DataSet ShowUserById()
    {
        try
        {
            UsersDAL ObjUsersDAL = new UsersDAL();
            return ObjUsersDAL.ShowUsers(this);
        }
        catch
        {
            return null;
        }

    }
    public DataSet GetDataOrderByDate()
    {
        try
        {
            UsersDAL ObjUsersDAL = new UsersDAL();
            return ObjUsersDAL.ShowUsers(this);
        }
        catch
        {
            return null;
        }
    }
    public DataSet EditUserDetails()
    {
        try
        {
            UsersDAL ObjUsersDAL = new UsersDAL();
            return ObjUsersDAL.EditUserDetails(this);
        }
        catch
        {
            return null;
        }
    }
    //For Deleting from tblUsers
    public Boolean DeleteFromtblUsers(String StrIds)
    {
        try
        {
            UsersDAL ObjUsersDAL = new UsersDAL();
            return ObjUsersDAL.DeleteFromtblUsers(StrIds);
        }
        catch
        {
            return false;
        }
    }
    //For Updating user Status
    public int UpdateUserStatus()
    {
        try
        {
            UsersDAL objUsersDAL = new UsersDAL();
            return objUsersDAL.UpdateUserStatus(this);
        }
        catch
        {
            return 0;
        }
    }
    //For Checking User Login
    public DataSet CheckLogin()
    {
        try
        {
            UsersDAL ObjUsersDAL = new UsersDAL();
            return ObjUsersDAL.CheckLogin(this);
        }
        catch
        {
            return null;
        }
    }
    //For Forgot Password when Email was given

    public DataSet ForgotPasswordForEmail(string Email)
    {
        try
        {
            UsersDAL ObjUsersDAL = new UsersDAL();
            return ObjUsersDAL.ForgotPasswordforEamil(Email);
        }
        catch
        {
            return null;
        }
    }
    //For Forgot Password when username given

    public DataSet ForgotPassword()
    {
        try
        {
            UsersDAL ObjUsersDAL = new UsersDAL();
            return ObjUsersDAL.ForgotPassword(this);
        }
        catch
        {
            return null;
        }

    }
    public DataSet Login(string check)
    {
        try
        {
            UsersDAL ObjUsersDAL = new UsersDAL();
            return ObjUsersDAL.Login(this, check);
        }
        catch
        {
            return null;
        }
    }
}

