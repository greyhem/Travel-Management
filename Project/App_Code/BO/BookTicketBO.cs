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
/// Summary description for BookTicketBO
/// </summary>
public class BookTicketBO
{
	public BookTicketBO()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private Int64 _TicketID;

    public Int64 TicketID
    {
        get { return _TicketID; }
        set { _TicketID = value; }
    }
    private string _FullName;

    public string FullName
    {
        get { return _FullName; }
        set { _FullName = value; }
    }
    private string _Mobile;

    public string Mobile
    {
        get { return _Mobile; }
        set { _Mobile = value; }
    }
    private string _Gender;

    public string Gender
    {
        get { return _Gender; }
        set { _Gender = value; }
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
    private string _IDCardType;

    public string IDCardType
    {
        get { return _IDCardType; }
        set { _IDCardType = value; }
    }

    private string _IDCardNumber;

    public string IDCardNumber
    {
        get { return _IDCardNumber; }
        set { _IDCardNumber = value; }
    }
    private string _IssuingAuthority;

    public string IssuingAuthority
    {
        get { return _IssuingAuthority; }
        set { _IssuingAuthority = value; }
    }
    private string _PaymentMode;

    public string PaymentMode
    {
        get { return _PaymentMode; }
        set { _PaymentMode = value; }
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
    private string _SeatNumber;

    public string SeatNumber
    {
        get { return _SeatNumber; }
        set { _SeatNumber = value; }
    }
    private string _JourneyDate;

    public string JourneyDate
    {
        get { return _JourneyDate; }
        set { _JourneyDate = value; }
    }
    private string _ServiceNumber;

    public string ServiceNumber
    {
        get { return _ServiceNumber; }
        set { _ServiceNumber = value; }
    }
    private string _NoOfPassengers;

    public string NoOfPassengers
    {
        get { return _NoOfPassengers; }
        set { _NoOfPassengers = value; }
    }
    private string _BusType;

    public string BusType
    {
        get { return _BusType; }
        set { _BusType = value; }
    }
    private string _TravelName;

    public string TravelName
    {
        get { return _TravelName; }
        set { _TravelName = value; }
    }
    private string _BoardingPoint;

    public string BoardingPoint
    {
        get { return _BoardingPoint; }
        set { _BoardingPoint = value; }
    }
    private string _TotalAmount;

    public string TotalAmount
    {
        get { return _TotalAmount; }
        set { _TotalAmount = value; }
    }
    private string _ServiceTax;

    public string ServiceTax
    {
        get { return _ServiceTax; }
        set { _ServiceTax = value; }
    }
    private string _TransactionFee;

    public string TransactionFee
    {
        get { return _TransactionFee; }
        set { _TransactionFee = value; }
    }
    private string _StartTime;

    public string StartTime
    {
        get { return _StartTime; }
        set { _StartTime = value; }
    }
	
    private string _NetAmount;

    public string NetAmount
    {
        get { return _NetAmount; }
        set { _NetAmount = value; }
    }
    private DateTime _BookedDate;

    public DateTime BookedDate
    {
        get { return _BookedDate; }
        set { _BookedDate = value; }
    }
    private string _AvailableSeats;

    public string AvailableSeats
    {
        get { return _AvailableSeats; }
        set { _AvailableSeats = value; }
    }
    private string _Fare;

    public string Fare
    {
        get { return _Fare; }
        set { _Fare = value; }
    }
    private string _Phone;

    public string Phone
    {
        get { return _Phone; }
        set { _Phone = value; }
    }
	
    public DataSet GetServiceNumbers()
    {
       
        try
        {
            BookTicketDAL ObjBookTicketDAL = new BookTicketDAL();
            return ObjBookTicketDAL.GetServiceNumbers(this);
        }
        catch
        {
            return null;
        }
       
    }
    public DataSet Record()
    {
        
        try
        {
            BookTicketDAL ObjBookTicketDAL = new BookTicketDAL();
            return ObjBookTicketDAL.Record(this);

        }
        catch
        {
            return null;
        }
       
    }
    //For Inserting Into tblBookTicket
    public Int64 InsertIntotblBookTicket()
    {
        try
        {
            BookTicketDAL ObjBookTicketDAL = new BookTicketDAL();
            return ObjBookTicketDAL.InsertIntotblBookTicket(this);
        }
        catch
        {
            return 0;
        }
    }
  
}
