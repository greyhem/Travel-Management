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
/// Summary description for CompanyInfoDAL
/// </summary>
public class CompanyInfoDAL
{
    SqlConnection SqlCon = BaseDAL.Connection_through_Config();
	public CompanyInfoDAL()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public int InsertCompanyInfo(CompanyInfoBO ObjCompanyInfoBO)
    {
        SqlCon.Open();
        SqlCommand Inscommand = new SqlCommand("sp_tblCompanyInfo", SqlCon);
        Inscommand.CommandType = CommandType.StoredProcedure;
        Inscommand.Parameters.AddWithValue("@Type", "I");
        Inscommand.Parameters.AddWithValue("@CompanyName", ObjCompanyInfoBO.CompanyName);
        Inscommand.Parameters.AddWithValue("@Description", ObjCompanyInfoBO.Description);
        Inscommand.Parameters.AddWithValue("@Address", ObjCompanyInfoBO.Address);
        Inscommand.Parameters.AddWithValue("@CompanyLogo", ObjCompanyInfoBO.CompanyLogo);
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
    public int UpdatetblCompanyInfo(CompanyInfoBO ObjCompanyInfoBO)
    {

        SqlCon.Open();
        SqlCommand Upscommand = new SqlCommand("sp_tblCompanyInfo", SqlCon);
        Upscommand.CommandType = CommandType.StoredProcedure;
        Upscommand.Parameters.AddWithValue("@Type", "U");
        Upscommand.Parameters.AddWithValue("@CompanyID", ObjCompanyInfoBO.CompanyID);
        Upscommand.Parameters.AddWithValue("@CompanyName", ObjCompanyInfoBO.CompanyName);
        Upscommand.Parameters.AddWithValue("@Description", ObjCompanyInfoBO.Description);
        Upscommand.Parameters.AddWithValue("@Address", ObjCompanyInfoBO.Address);
        Upscommand.Parameters.AddWithValue("@CompanyLogo", ObjCompanyInfoBO.CompanyLogo);
        //Upscommand.Parameters.AddWithValue("@UpdatedDate", ObjCompanyInfoBO.UpdatedDate);
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
    public DataSet EditCompanyDetails(CompanyInfoBO ObjCompanyInfoBO)
    {

        SqlCon.Open();
        SqlCommand ShowCommand = new SqlCommand("sp_tblCompanyInfo", SqlCon);
        ShowCommand.CommandType = CommandType.StoredProcedure;
        ShowCommand.Parameters.AddWithValue("@Type", "T");
        ShowCommand.Parameters.AddWithValue("@CompanyID", ObjCompanyInfoBO.CompanyID);
        SqlDataAdapter DataAdapter = new SqlDataAdapter(ShowCommand);
        DataSet ds = new DataSet();
        try
        {
            DataAdapter.Fill(ds, "tblCompanyInfo");
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
    public DataSet GetDataOrderByDate(CompanyInfoBO ObjCompanyInfoBO)
    {
        try
        {
            SqlDataAdapter DaGetDataOrderByDate = new SqlDataAdapter("sp_tblCompanyInfo", SqlCon);
            DaGetDataOrderByDate.SelectCommand.CommandType = CommandType.StoredProcedure;
            DaGetDataOrderByDate.SelectCommand.Parameters.AddWithValue("@Type", "S");
            DataSet DsGetDataOrderByDate = new DataSet();
            DaGetDataOrderByDate.Fill(DsGetDataOrderByDate);
            return DsGetDataOrderByDate;
        }
        catch
        {
            return null;
        }
    }
}
