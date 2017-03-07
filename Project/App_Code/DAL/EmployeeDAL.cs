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
/// Summary description for EmployeeDAL
/// </summary>
public class EmployeeDAL
{
    SqlConnection SqlCon = BaseDAL.Connection_through_Config();
	public EmployeeDAL()
	{
		//
		// TODO: Add constructor logic here
		//
	}
   
    public int InsertEmployeeInfo(EmployeeBO ObjEmployeeBO)
    {
        SqlCon.Open();
        SqlCommand Inscommand = new SqlCommand("sp_tblEmployees", SqlCon);
        Inscommand.CommandType = CommandType.StoredProcedure;
        Inscommand.Parameters.AddWithValue("@Type", "I");
        Inscommand.Parameters.AddWithValue("@EmployeeName", ObjEmployeeBO.EmployeeName);
        Inscommand.Parameters.AddWithValue("@Designation", ObjEmployeeBO.Designation);
        Inscommand.Parameters.AddWithValue("@Email", ObjEmployeeBO.Email);
        Inscommand.Parameters.AddWithValue("@Address", ObjEmployeeBO.Address);
        Inscommand.Parameters.AddWithValue("@Mobile", ObjEmployeeBO.Mobile);
        Inscommand.Parameters.AddWithValue("@AllotedToBranch", ObjEmployeeBO.AllotedToBranch);
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
    public int UpdatetblEmployees(EmployeeBO ObjEmployeeBO)
    {

        SqlCon.Open();
        SqlCommand Upscommand = new SqlCommand("sp_tblEmployees", SqlCon);
        Upscommand.CommandType = CommandType.StoredProcedure;
        Upscommand.Parameters.AddWithValue("@Type", "U");
        Upscommand.Parameters.AddWithValue("@EmployeeID", ObjEmployeeBO.EmployeeID);
        Upscommand.Parameters.AddWithValue("@Email", ObjEmployeeBO.Email);
        Upscommand.Parameters.AddWithValue("@Address", ObjEmployeeBO.Address);
        Upscommand.Parameters.AddWithValue("@EmployeeName", ObjEmployeeBO.EmployeeName);
        Upscommand.Parameters.AddWithValue("@Designation", ObjEmployeeBO.Designation);
        Upscommand.Parameters.AddWithValue("@AllotedToBranch", ObjEmployeeBO.AllotedToBranch);
        Upscommand.Parameters.AddWithValue("@Mobile", ObjEmployeeBO.Mobile);
        //Upscommand.Parameters.AddWithValue("@EmployeeName", ObjEmployeeBO.EmployeeName);
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
    public DataSet ShowEmployeeDetails(EmployeeBO ObjEmployeeBO)
    {

        SqlCon.Open();
        SqlCommand ShowCommand = new SqlCommand("sp_tblEmployees", SqlCon);
        ShowCommand.CommandType = CommandType.StoredProcedure;
        ShowCommand.Parameters.AddWithValue("@Type", "T");
        ShowCommand.Parameters.AddWithValue("@EmployeeID", ObjEmployeeBO.EmployeeID);
        SqlDataAdapter DataAdapter = new SqlDataAdapter(ShowCommand);
        DataSet ds = new DataSet();
        try
        {
            DataAdapter.Fill(ds, "tblEmployees");
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
    public DataSet ShowEmployee(EmployeeBO ObjEmployeeBO)
    {

        SqlCon.Open();
        SqlCommand ShowCommand = new SqlCommand("sp_tblEmployees", SqlCon);
        ShowCommand.CommandType = CommandType.StoredProcedure;
        ShowCommand.Parameters.AddWithValue("@Type", "S");
        SqlDataAdapter DataAdapter = new SqlDataAdapter(ShowCommand);
        DataSet ds = new DataSet();
        try
        {
            DataAdapter.Fill(ds, "tblEmployees");
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
    public Boolean DeleteFromtblEmployees(String StrIds)
    {
        try
        {
            SqlCon.Open();
            SqlCommand DeleteCommand = new SqlCommand("sp_tblEmployees", SqlCon);
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
}
