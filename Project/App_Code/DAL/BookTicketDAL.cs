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
/// Summary description for BookTicketDAL
/// </summary>
public class BookTicketDAL
{
    SqlConnection SqlCon = BaseDAL.Connection_through_Config();
	public BookTicketDAL()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public DataSet GetServiceNumbers(BookTicketBO ObjBookTicketBO)
    {

        SqlCon.Open();
        SqlCommand ShowCommand = new SqlCommand("sp_tblBusInfo", SqlCon);
        ShowCommand.CommandType = CommandType.StoredProcedure;
        ShowCommand.Parameters.AddWithValue("@Type", "S");
        SqlDataAdapter DataAdapter = new SqlDataAdapter(ShowCommand);
        DataSet ds = new DataSet();
        try
        {
            DataAdapter.Fill(ds, "tblBusInfo");
            return ds;
        }
        catch
        {
            throw;
        }
        finally
        {
            ShowCommand.Dispose();
            SqlCon.Close();
        }

    }
    public DataSet Record(BookTicketBO ObjBookTicketBO)
    {


        SqlCon.Open();
        SqlCommand ShowCommand = new SqlCommand("sp_tblBusInfo", SqlCon);
        ShowCommand.CommandType = CommandType.StoredProcedure;
        ShowCommand.Parameters.AddWithValue("@Type", "R");
        ShowCommand.Parameters.AddWithValue("@ServiceNumber", ObjBookTicketBO.ServiceNumber);
        SqlDataAdapter DataAdapter = new SqlDataAdapter(ShowCommand);
        DataSet ds = new DataSet();
        try
        {
            DataAdapter.Fill(ds, "tblBusInfo");
            return ds;
        }
        catch
        {
            throw;
        }
        finally
        {
            ShowCommand.Dispose();
            SqlCon.Close();
        }


    }
    //For Inserting into tblBookTicket
    public Int64 InsertIntotblBookTicket(BookTicketBO ObjBookTicketBO)
    {
        Int64 intUserId = 0;
        try
        {
            SqlCon.Open();
            SqlCommand InsertCmd = new SqlCommand("sp_tblBookTicket", SqlCon);
            InsertCmd.CommandType = CommandType.StoredProcedure;
            SqlParameter ParamUserId = InsertCmd.Parameters.Add("@TicketID", SqlDbType.BigInt, 8);
            ParamUserId.Direction = ParameterDirection.Output;
            InsertCmd.Parameters.AddWithValue("@FullName", ObjBookTicketBO.FullName);
            InsertCmd.Parameters.AddWithValue("@PaymentMode", ObjBookTicketBO.PaymentMode);
            InsertCmd.Parameters.AddWithValue("@Mobile", ObjBookTicketBO.Mobile);
            InsertCmd.Parameters.AddWithValue("@Gender", ObjBookTicketBO.Gender);
            InsertCmd.Parameters.AddWithValue("@Email", ObjBookTicketBO.Email);
            InsertCmd.Parameters.AddWithValue("@Address", ObjBookTicketBO.Address);
            InsertCmd.Parameters.AddWithValue("@IDCardType", ObjBookTicketBO.IDCardType);
            InsertCmd.Parameters.AddWithValue("@IDCardNumber", ObjBookTicketBO.IDCardNumber);
            InsertCmd.Parameters.AddWithValue("@IssuingAuthority", ObjBookTicketBO.IssuingAuthority);
            InsertCmd.Parameters.AddWithValue("@Source", ObjBookTicketBO.Source);
            InsertCmd.Parameters.AddWithValue("@Destination", ObjBookTicketBO.Destination);
            InsertCmd.Parameters.AddWithValue("@SeatNumber", ObjBookTicketBO.SeatNumber);
            InsertCmd.Parameters.AddWithValue("@JourneyDate", ObjBookTicketBO.JourneyDate);
            InsertCmd.Parameters.AddWithValue("@ServiceNumber", ObjBookTicketBO.ServiceNumber);
            InsertCmd.Parameters.AddWithValue("@NoOfPassengers", ObjBookTicketBO.NoOfPassengers);
            InsertCmd.Parameters.AddWithValue("@AvailableSeats", ObjBookTicketBO.AvailableSeats);
            InsertCmd.Parameters.AddWithValue("@StartTime", ObjBookTicketBO.StartTime);
            InsertCmd.Parameters.AddWithValue("@BusType", ObjBookTicketBO.BusType);
            InsertCmd.Parameters.AddWithValue("@TravelName", ObjBookTicketBO.TravelName);
            InsertCmd.Parameters.AddWithValue("@BoardingPoint", ObjBookTicketBO.BoardingPoint);
            InsertCmd.Parameters.AddWithValue("@TotalAmount", ObjBookTicketBO.TotalAmount);
            InsertCmd.Parameters.AddWithValue("@ServiceTax", ObjBookTicketBO.ServiceTax);
            InsertCmd.Parameters.AddWithValue("@TransactionFee", ObjBookTicketBO.TransactionFee);
            InsertCmd.Parameters.AddWithValue("@NetAmount", ObjBookTicketBO.NetAmount);
            InsertCmd.Parameters.AddWithValue("@Fare", ObjBookTicketBO.Fare);
            InsertCmd.Parameters.AddWithValue("@Phone", ObjBookTicketBO.Phone);
            InsertCmd.Parameters.AddWithValue("@Type", 'I');
            InsertCmd.ExecuteNonQuery();
            ObjBookTicketBO.TicketID = Convert.ToInt64(ParamUserId.Value.ToString());
            intUserId = ObjBookTicketBO.TicketID;
            return intUserId;
        }
        catch
        {
            throw;
        }
        finally
        {
            SqlCon.Close();
            //SqlCmd.Dispose();
        }
    }

}
