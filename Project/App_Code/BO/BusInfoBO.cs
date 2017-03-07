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
/// Summary description for BusInfoBO
/// </summary>
public class BusInfoBO
{
	public BusInfoBO()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private Int64 _ServiceID;

    public Int64 ServiceID
    {
        get { return _ServiceID; }
        set { _ServiceID = value; }
    }
    private string _ServiceName;

    public string ServiceName
    {
        get { return _ServiceName; }
        set { _ServiceName = value; }
    }
    private string _ServiceNumber;

    public string ServiceNumber
    {
        get { return _ServiceNumber; }
        set { _ServiceNumber = value; }
    }
    private string _TravelName;

    public string TravelName
    {
        get { return _TravelName; }
        set { _TravelName = value; }
    }
    private string _BusType;

    public string BusType
    {
        get { return _BusType; }
        set { _BusType = value; }
    }
    private string _Source;

    public string Source
    {
        get { return _Source; }
        set { _Source = value; }
    }
    private string _Destination;

    public string Destination
    {
        get { return _Destination; }
        set { _Destination = value; }
    }
    private string _StartTime;

    public string StartTime
    {
        get { return _StartTime; }
        set { _StartTime = value; }
    }
    private string _ReachTime;

    public string ReachTime
    {
        get { return _ReachTime; }
        set { _ReachTime = value; }
    }
    private string _Fare;

    public string Fare
    {
        get { return _Fare; }
        set { _Fare = value; }
    }
    private string _NoOfSeatsAvailable;

    public string NoOfSeatsAvailable
    {
        get { return _NoOfSeatsAvailable; }
        set { _NoOfSeatsAvailable = value; }
    }
	private DateTime _DateOfJourney;

	public DateTime DateOfJourney
	{
		get { return _DateOfJourney;}
		set { _DateOfJourney = value;}
	}
	private DateTime _AllotedDate;

	public DateTime AllotedDate
	{
		get { return _AllotedDate;}
		set { _AllotedDate = value;}
	}

    //For Inserting Into tblCompanyInfo
    public int InsertIntoBusInfo()
    {
        try
        {
            BusInfoDAL ObjBusInfoDAL = new BusInfoDAL();
            return ObjBusInfoDAL.InsertIntoBusInfo(this);
        }
        catch
        {
            return 0;
        }
    }
    public DataSet ShowBusDetails()
    {
        try
        {
            BusInfoDAL ObjBusInfoDAL = new BusInfoDAL();
            return ObjBusInfoDAL.ShowBusDetails(this);
        }
        catch
        {
            return null;
        }
    }
    public DataSet EditBusDetails()
    {
        try
        {
            BusInfoDAL ObjBusInfoDAL = new BusInfoDAL();
            return ObjBusInfoDAL.EditBusDetails(this);
        }
        catch
        {
            return null;
        }
    }
    //For Deleting from tblBusInfo
    public Boolean DeleteFromtblBusInfo(String StrIds)
    {
        try
        {
            BusInfoDAL ObjBusInfoDAL = new BusInfoDAL();
            return ObjBusInfoDAL.DeleteFromtblBusInfo(StrIds);
        }
        catch
        {
            return false;
        }
    }
    public int UpdatetblBusInfo()
    {
        try
        {
            BusInfoDAL ObjBusInfoDAL = new BusInfoDAL();
            return ObjBusInfoDAL.UpdatetblBusInfo(this);
        }
        catch
        {
            return 0;
        }
    }
    public DataSet SearchDetails(string SearchString)
    {
        try
        {
            BusInfoDAL ObjBusInfoDAL = new BusInfoDAL();
            return ObjBusInfoDAL.SearchDetails(SearchString);
        }
        catch
        {
            return null;
        }
    }
}
