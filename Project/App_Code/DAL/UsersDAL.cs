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
/// Summary description for UsersDAL
/// </summary>
public class UsersDAL
{
    SqlConnection SqlCon = BaseDAL.Connection_through_Config();
	public UsersDAL()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    //For UserName Check Availability By Praveen    
    public DataSet CheckAvailability(UsersBO objUsersBO)
    {
        try
        {
            SqlDataAdapter DaCheckAvail = new SqlDataAdapter("sp_tblUsers", SqlCon);
            DaCheckAvail.SelectCommand.CommandType = CommandType.StoredProcedure;
            DaCheckAvail.SelectCommand.Parameters.AddWithValue("@Type", "L");
            DaCheckAvail.SelectCommand.Parameters.AddWithValue("@UserName", objUsersBO.UserName);
            DataSet DsCheckAvail = new DataSet();
            DaCheckAvail.Fill(DsCheckAvail);
            return DsCheckAvail;
        }
        catch
        {
            return null;
        }
    }
    //For Inserting into tblUsers
    public Int64 InsertIntotblUsers(UsersBO ObjUsersBO)
    {
        Int64 intUserId = 0;
        try
        {
            SqlCon.Open();
            SqlCommand InsertCmd = new SqlCommand("sp_tblUsers", SqlCon);
            InsertCmd.CommandType = CommandType.StoredProcedure;
            SqlParameter ParamUserId = InsertCmd.Parameters.Add("@UserID", SqlDbType.BigInt, 8);
            ParamUserId.Direction = ParameterDirection.Output;
            InsertCmd.Parameters.AddWithValue("@UserName", ObjUsersBO.UserName);
            InsertCmd.Parameters.AddWithValue("@Password", ObjUsersBO.Password);
            InsertCmd.Parameters.AddWithValue("@Email", ObjUsersBO.Email);
            InsertCmd.Parameters.AddWithValue("@Mobile", ObjUsersBO.Mobile);
            InsertCmd.Parameters.AddWithValue("@Phone", ObjUsersBO.Phone);
            InsertCmd.Parameters.AddWithValue("@Country", ObjUsersBO.Country);
            InsertCmd.Parameters.AddWithValue("@City", ObjUsersBO.City);
            InsertCmd.Parameters.AddWithValue("@Address", ObjUsersBO.Address);
            //InsertCmd.Parameters.AddWithValue("@Status", ObjUsersBO.Status);
            InsertCmd.Parameters.AddWithValue("@Type", 'I');
            InsertCmd.ExecuteNonQuery();
            intUserId = Convert.ToInt64(ParamUserId.Value.ToString());
            //intUserId = ObjUsersBO.UserID;
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
    public DataSet ShowUsersInfo(UsersBO ObjUsersBO)
    {

        SqlCon.Open();
        SqlCommand ShowCommand = new SqlCommand("sp_tblUsers", SqlCon);
        ShowCommand.CommandType = CommandType.StoredProcedure;
        ShowCommand.Parameters.AddWithValue("@Type", "R");
        ShowCommand.Parameters.AddWithValue("@UserID", ObjUsersBO.UserID);
        SqlDataAdapter DataAdapter = new SqlDataAdapter(ShowCommand);
        DataSet ds = new DataSet();
        try
        {
            DataAdapter.Fill(ds, "tblUsers");
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
    public DataSet ShowUsersInfo1(UsersBO ObjUsersBO)
    {

        SqlCon.Open();
        SqlCommand ShowCommand = new SqlCommand("sp_tblUsers", SqlCon);
        ShowCommand.CommandType = CommandType.StoredProcedure;
        ShowCommand.Parameters.AddWithValue("@Type", "B");
        SqlDataAdapter DataAdapter = new SqlDataAdapter(ShowCommand);
        DataSet ds = new DataSet();
        try
        {
            DataAdapter.Fill(ds, "tblUsers");
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
    public int UpdatetblUsers(UsersBO ObjUsersBO)
    {

        SqlCon.Open();
        SqlCommand Upscommand = new SqlCommand("sp_tblUsers", SqlCon);
        Upscommand.CommandType = CommandType.StoredProcedure;
        Upscommand.Parameters.AddWithValue("@Type", "U");
        Upscommand.Parameters.AddWithValue("@UserId", ObjUsersBO.UserID);
        Upscommand.Parameters.AddWithValue("@Email", ObjUsersBO.Email);
        Upscommand.Parameters.AddWithValue("@Address", ObjUsersBO.Address);
        Upscommand.Parameters.AddWithValue("@Country", ObjUsersBO.Country);
        Upscommand.Parameters.AddWithValue("@Phone", ObjUsersBO.Phone);
        Upscommand.Parameters.AddWithValue("@City", ObjUsersBO.City);
        Upscommand.Parameters.AddWithValue("@Mobile", ObjUsersBO.Mobile);
        //Upscommand.Parameters.AddWithValue("@UpdatedDate", ObjUsersBO.UpdatedDate);
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
    //To ChangePassword

    public int ChangePassword(UsersBO usersBO)
    {
        SqlCon.Open();
        SqlCommand SqlCmd = new SqlCommand("sp_tblUsers", SqlCon);
        SqlCmd.CommandType = CommandType.StoredProcedure;
        SqlCmd.Parameters.AddWithValue("@UserID", usersBO.UserID);
        SqlCmd.Parameters.AddWithValue("@Password", usersBO.Password);
        SqlCmd.Parameters.AddWithValue("@Type", "C");
        try
        {
            return SqlCmd.ExecuteNonQuery();
        }
        catch
        {
            return 0;
        }
        finally
        {
            SqlCmd.Dispose();
            SqlCon.Close();

        }
    }
    public DataSet ShowUsers(UsersBO ObjUsersBO)
    {
        SqlCon.Open();
        SqlCommand SqlCmd = new SqlCommand("sp_tblUsers", SqlCon);
        SqlCmd.CommandType = CommandType.StoredProcedure;
        SqlCmd.Parameters.AddWithValue("@UserID", ObjUsersBO.UserID);
        SqlCmd.Parameters.AddWithValue("@Type", "R");
        SqlDataAdapter SqlDA = new SqlDataAdapter(SqlCmd);
        DataSet ds = new DataSet();
        try
        {
            SqlDA.Fill(ds, "tblUsers");
            return ds;
        }
        catch
        {
            throw;
        }
        finally
        {
            SqlCon.Close();
            SqlCmd.Dispose();
        }
    }
    public DataSet EditUserDetails(UsersBO ObjUsersBO)
    {

        SqlCon.Open();
        SqlCommand ShowCommand = new SqlCommand("sp_tblUsers", SqlCon);
        ShowCommand.CommandType = CommandType.StoredProcedure;
        ShowCommand.Parameters.AddWithValue("@Type", "S");
        ShowCommand.Parameters.AddWithValue("@UserID", ObjUsersBO.UserID);
        SqlDataAdapter DataAdapter = new SqlDataAdapter(ShowCommand);
        DataSet ds = new DataSet();
        try
        {
            DataAdapter.Fill(ds, "tblUsers");
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
    public Boolean DeleteFromtblUsers(String StrIds)
    {
        try
        {
            SqlCon.Open();
            SqlCommand DeleteCommand = new SqlCommand("sp_tblUsers", SqlCon);
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
    //For Updating the status of users
    public int UpdateUserStatus(UsersBO ObjUsersBO)
    {
        try
        {
            SqlCon.Open();
            SqlCommand SqlCmd = new SqlCommand("sp_tblUsers", SqlCon);
            SqlCmd.CommandType = CommandType.StoredProcedure;
            SqlCmd.Parameters.AddWithValue("@Type", "F");

            SqlCmd.Parameters.AddWithValue("@Status", ObjUsersBO.Status);
            SqlCmd.Parameters.AddWithValue("@UserID", ObjUsersBO.UserID);
            return SqlCmd.ExecuteNonQuery();
        }
        catch
        {
            return 0;
        }
        finally
        {
            SqlCon.Close();
        }
    }
    //For Checking User Login
    public DataSet CheckLogin(UsersBO usersBO)
    {
        SqlCon.Open();
        SqlCommand SqlCmd = new SqlCommand("sp_tblUsers", SqlCon);
        SqlCmd.CommandType = CommandType.StoredProcedure;
        SqlCmd.Parameters.AddWithValue("@UserName", usersBO.UserName);
        SqlCmd.Parameters.AddWithValue("@Password", usersBO.Password);
        SqlCmd.Parameters.AddWithValue("@Type", "L");
        SqlDataAdapter SqlDA = new SqlDataAdapter(SqlCmd);
        DataSet ds = new DataSet();
        try
        {
            SqlDA.Fill(ds, "tblUsers");
            return ds;
        }
        catch
        {
            throw;
        }
        finally
        {
            SqlCon.Close();
            SqlCmd.Dispose();
        }
    }
    public DataSet ForgotPasswordforEamil(string Email)
    {
        SqlCon.Open();
        SqlCommand SqlCmd = new SqlCommand("sp_tblUsers", SqlCon);
        SqlCmd.CommandType = CommandType.StoredProcedure;
        SqlCmd.Parameters.AddWithValue("@Email", Email);

        SqlCmd.Parameters.AddWithValue("@Type", "X");
        SqlDataAdapter SqlDA = new SqlDataAdapter(SqlCmd);
        DataSet ds = new DataSet();
        try
        {
            SqlDA.Fill(ds, "tblUsers");
            return ds;
        }
        catch
        {
            return null;
        }
        finally
        {
            SqlCon.Close();
            SqlCmd.Dispose();
        }
    }
    public DataSet ForgotPassword(UsersBO usersBO)
    {
        SqlCon.Open();
        SqlCommand SqlCmd = new SqlCommand("sp_tblUsers", SqlCon);
        SqlCmd.CommandType = CommandType.StoredProcedure;
        SqlCmd.Parameters.AddWithValue("@UserName", usersBO.UserName);

        SqlCmd.Parameters.AddWithValue("@Type", "L");
        SqlDataAdapter SqlDA = new SqlDataAdapter(SqlCmd);
        DataSet ds = new DataSet();
        try
        {
            SqlDA.Fill(ds, "tblUsers");
            return ds;
        }
        catch
        {
            return null;
        }
        finally
        {
            SqlCon.Close();
            SqlCmd.Dispose();
        }
    }
    public DataSet Login(UsersBO usersBO, string check)
    {
        try
        {
            SqlDataAdapter DaGetData = new SqlDataAdapter("sp_tblUsers", SqlCon);
            DaGetData.SelectCommand.CommandType = CommandType.StoredProcedure;
            DaGetData.SelectCommand.Parameters.AddWithValue("@check", check);
            DaGetData.SelectCommand.Parameters.AddWithValue("@Username", usersBO.UserName);
            DaGetData.SelectCommand.Parameters.AddWithValue("@Password", usersBO.Password);

            DaGetData.SelectCommand.Parameters.AddWithValue("@Type", "Z");
            DataSet DsGetData = new DataSet();
            DaGetData.Fill(DsGetData);
            return DsGetData;
        }
        catch
        {
            return null;
        }
    }
}
