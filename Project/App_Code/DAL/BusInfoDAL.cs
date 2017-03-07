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
/// Summary description for BusInfoDAL
/// </summary>
public class BusInfoDAL
{
    SqlConnection SqlCon = BaseDAL.Connection_through_Config();
	public BusInfoDAL()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public int InsertIntoBusInfo(BusInfoBO ObjBusInfoBO)
    {
        SqlCon.Open();
        SqlCommand Inscommand = new SqlCommand("sp_tblBusInfo", SqlCon);
        Inscommand.CommandType = CommandType.StoredProcedure;
        Inscommand.Parameters.AddWithValue("@Type", "I");
        Inscommand.Parameters.AddWithValue("@ServiceName", ObjBusInfoBO.ServiceName);
        Inscommand.Parameters.AddWithValue("@ServiceNumber", ObjBusInfoBO.ServiceNumber);
        Inscommand.Parameters.AddWithValue("@TravelName", ObjBusInfoBO.TravelName);
        Inscommand.Parameters.AddWithValue("@BusType", ObjBusInfoBO.BusType);
        Inscommand.Parameters.AddWithValue("@Source", ObjBusInfoBO.Source);
        Inscommand.Parameters.AddWithValue("@Destination", ObjBusInfoBO.Destination);
        Inscommand.Parameters.AddWithValue("@StartTime", ObjBusInfoBO.StartTime);
        Inscommand.Parameters.AddWithValue("@ReachTime", ObjBusInfoBO.ReachTime);
        Inscommand.Parameters.AddWithValue("@Fare", ObjBusInfoBO.Fare);
        Inscommand.Parameters.AddWithValue("@DateOfJourney", ObjBusInfoBO.DateOfJourney);
        Inscommand.Parameters.AddWithValue("@NoOfSeatsAvailable", ObjBusInfoBO.NoOfSeatsAvailable);
        try
        {
            return Inscommand.ExecuteNonQuery();
        }
        catch
        {
            throw;
        }
        finally
        {
            Inscommand.Dispose();
            SqlCon.Close();
        }

    }
    public int UpdatetblBusInfo(BusInfoBO ObjBusInfoBO)
    {
        SqlCon.Open();
        SqlCommand Upscommand = new SqlCommand("sp_tblBusInfo", SqlCon);
        Upscommand.CommandType = CommandType.StoredProcedure;
        Upscommand.Parameters.AddWithValue("@Type", "U");
        Upscommand.Parameters.AddWithValue("@ServiceID", ObjBusInfoBO.ServiceID);
        Upscommand.Parameters.AddWithValue("@ServiceName", ObjBusInfoBO.ServiceName);
        Upscommand.Parameters.AddWithValue("@ServiceNumber", ObjBusInfoBO.ServiceNumber);
        Upscommand.Parameters.AddWithValue("@TravelName", ObjBusInfoBO.TravelName);
        Upscommand.Parameters.AddWithValue("@BusType", ObjBusInfoBO.BusType);
        Upscommand.Parameters.AddWithValue("@Source", ObjBusInfoBO.Source);
        Upscommand.Parameters.AddWithValue("@Destination", ObjBusInfoBO.Destination);
        Upscommand.Parameters.AddWithValue("@StartTime", ObjBusInfoBO.StartTime);
        Upscommand.Parameters.AddWithValue("@ReachTime", ObjBusInfoBO.ReachTime);
        Upscommand.Parameters.AddWithValue("@Fare", ObjBusInfoBO.Fare);
        Upscommand.Parameters.AddWithValue("@DateOfJourney", ObjBusInfoBO.DateOfJourney);
        Upscommand.Parameters.AddWithValue("@NoOfSeatsAvailable", ObjBusInfoBO.NoOfSeatsAvailable);
        try
        {
            return Upscommand.ExecuteNonQuery();
        }
        catch
        {
            throw;
        }
        finally
        {
            Upscommand.Dispose();
            SqlCon.Close();
        }

    }
    public DataSet ShowBusDetails(BusInfoBO ObjBusInfoBO)
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
    public DataSet EditBusDetails(BusInfoBO ObjBusInfoBO)
    {

        SqlCon.Open();
        SqlCommand ShowCommand = new SqlCommand("sp_tblBusInfo", SqlCon);
        ShowCommand.CommandType = CommandType.StoredProcedure;
        ShowCommand.Parameters.AddWithValue("@Type", "T");
        ShowCommand.Parameters.AddWithValue("@ServiceID", ObjBusInfoBO.ServiceID);
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
    public Boolean DeleteFromtblBusInfo(String StrIds)
    {
        try
        {
            SqlCon.Open();
            SqlCommand DeleteCommand = new SqlCommand("sp_tblBusInfo", SqlCon);
            DeleteCommand.CommandType = CommandType.StoredProcedure;
            DeleteCommand.Parameters.AddWithValue("@Type", "D");
            DeleteCommand.Parameters.AddWithValue("@StrIds", StrIds);

            DeleteCommand.ExecuteNonQuery();
            return true;
        }
        catch
        {
            return false;
        }
        finally
        {
            SqlCon.Close();
        }
    }
    public DataSet SearchDetails(string SearchString)
    {

        SqlCon.Open();
        SqlCommand ShowCommand = new SqlCommand("sp_tblBusInfo", SqlCon);
        ShowCommand.CommandType = CommandType.StoredProcedure;
        ShowCommand.Parameters.AddWithValue("@Type", "Z");

        ShowCommand.Parameters.AddWithValue("@SearchString", SearchString);
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
}
