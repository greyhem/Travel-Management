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
/// Summary description for FeedbackBO
/// </summary>
public class FeedbackBO
{
	public FeedbackBO()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private Int64 _FeedbackID;

    public Int64 FeedbackID
    {
        get { return _FeedbackID; }
        set { _FeedbackID = value; }
    }
    private string _UserName;

    public string UserName
    {
        get { return _UserName; }
        set { _UserName = value; }
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
    private string _Subject;

    public string Subject
    {
        get { return _Subject; }
        set { _Subject = value; }
    }
    private string _Phone;

    public string Phone
    {
        get { return _Phone; }
        set { _Phone = value; }
    }
	
    private string _Comments;

    public string Comments
    {
        get { return _Comments; }
        set { _Comments = value; }
    }

    private string _RatingOfSite;

    public string RatingOfSite
    {
        get { return _RatingOfSite; }
        set { _RatingOfSite = value; }
    }
    private DateTime _SendDate;

    public DateTime SendDate
    {
        get { return _SendDate; }
        set { _SendDate = value; }
    }
    //For Inserting Into tblFeedback
    public int InsertIntotblFeedback()
    {
        try
        {
            FeedbackDAL ObjFeedbackDAL = new FeedbackDAL();
            return ObjFeedbackDAL.InsertFeedback(this);
        }
        catch
        {
            return 0;
        }
    }
    public DataSet ShowFeedback()
    {
        try
        {
            FeedbackDAL ObjFeedbackDAL = new FeedbackDAL();
            return ObjFeedbackDAL.ShowFeedbackFromtblFeedback(this);
        }
        catch
        {
            return null;
        }
    }
    public DataSet ShowFeedback1()
    {
        try
        {
            FeedbackDAL ObjFeedbackDAL = new FeedbackDAL();
            return ObjFeedbackDAL.ShowFeedbackDetailsFromtblFeedback(this);
        }
        catch
        {
            return null;
        }
    }
    //For Deleting from tblFeedback
    public Boolean DeleteFromtblFeedback(String StrIds)
    {
        try
        {
            FeedbackDAL ObjFeedbackDAL = new FeedbackDAL();
            return ObjFeedbackDAL.DeleteFromtblFeedback(StrIds);
        }
        catch
        {
            return false;
        }
    }
}
