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
/// Summary description for MailaFriendBO
/// </summary>
public class MailaFriendBO
{
	public MailaFriendBO()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private Int64 _ID;

    public Int64 ID
    {
        get { return _ID; }
        set { _ID = value; }
    }
    private string _YourEmailID;

    public string YourEmailID
    {
        get { return _YourEmailID; }
        set { _YourEmailID = value; }
    }
    private string _FriendsEmailID1;

    public string FriendsEmailID1
    {
        get { return _FriendsEmailID1; }
        set { _FriendsEmailID1 = value; }
    }
    private string _EmailID2;

    public string EmailID2
    {
        get { return _EmailID2; }
        set { _EmailID2 = value; }
    }
	 private string _EmailID3;

    public string EmailID3
    {
        get { return _EmailID3; }
        set { _EmailID3 = value; }
    }
    private string _EmailID4;

    public string EmailID4
    {
        get { return _EmailID4; }
        set { _EmailID4 = value; }
    }
    private string _EmailID5;

    public string EmailID5
    {
        get { return _EmailID5; }
        set { _EmailID5 = value; }
    }
    private string _StandardContent;

    public string StandardContent
    {
        get { return _StandardContent; }
        set { _StandardContent = value; }
    }

    private string _Comments;

    public string Comments
    {
        get { return _Comments; }
        set { _Comments = value; }
    }
    private DateTime _SendDate;

    public DateTime SendDate
    {
        get { return _SendDate; }
        set { _SendDate = value; }
    }
    //For Showing Users Details
    public DataSet getEmailId()
    {
        try
        {
            MailaFriendDAL ObjMailaFriendDAL = new MailaFriendDAL();
            return ObjMailaFriendDAL.getEmailId(this);
        }
        catch
        {
            return null;
        }
    }
		
}
