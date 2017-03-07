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
/// Summary description for FeedbackDAL
/// </summary>
public class FeedbackDAL
{
    SqlConnection SqlCon = BaseDAL.Connection_through_Config();
	public FeedbackDAL()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public int InsertFeedback(FeedbackBO ObjFeedbackBO)
    {
        SqlCon.Open();
        SqlCommand Inscommand = new SqlCommand("sp_tblFeedback", SqlCon);
        Inscommand.CommandType = CommandType.StoredProcedure;
        Inscommand.Parameters.AddWithValue("@Type", "I");
        Inscommand.Parameters.AddWithValue("@UserName", ObjFeedbackBO.UserName);
        Inscommand.Parameters.AddWithValue("@Email", ObjFeedbackBO.Email);
        Inscommand.Parameters.AddWithValue("@Mobile", ObjFeedbackBO.Mobile);
        Inscommand.Parameters.AddWithValue("@Phone", ObjFeedbackBO.Phone);
        Inscommand.Parameters.AddWithValue("@Subject", ObjFeedbackBO.Subject);
        Inscommand.Parameters.AddWithValue("@Comments", ObjFeedbackBO.Comments);
        Inscommand.Parameters.AddWithValue("@RatingOfSite", ObjFeedbackBO.RatingOfSite);
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
    public DataSet ShowFeedbackFromtblFeedback(FeedbackBO ObjFeedbackBO)
    {

        SqlCon.Open();
        SqlCommand ShowCommand = new SqlCommand("sp_tblFeedback", SqlCon);
        ShowCommand.CommandType = CommandType.StoredProcedure;
        ShowCommand.Parameters.AddWithValue("@Type", "S");
        SqlDataAdapter DataAdapter = new SqlDataAdapter(ShowCommand);
        DataSet ds = new DataSet();
        try
        {
            DataAdapter.Fill(ds, "tblFeedback");
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
    public Boolean DeleteFromtblFeedback(String StrIds)
    {
        try
        {
            SqlCon.Open();
            SqlCommand DeleteCommand = new SqlCommand("sp_tblFeedback", SqlCon);
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
    public DataSet ShowFeedbackDetailsFromtblFeedback(FeedbackBO ObjFeedbackBO)
    {

        SqlCon.Open();
        SqlCommand ShowCommand = new SqlCommand("sp_tblFeedback", SqlCon);
        ShowCommand.CommandType = CommandType.StoredProcedure;
        ShowCommand.Parameters.AddWithValue("@Type", "T");
        ShowCommand.Parameters.AddWithValue("@FeedbackID", ObjFeedbackBO.FeedbackID);
        SqlDataAdapter DataAdapter = new SqlDataAdapter(ShowCommand);
        DataSet ds = new DataSet();
        try
        {
            DataAdapter.Fill(ds, "tblFeedback");
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

    #region IDisposable Members

    public void Dispose()
    {
        SqlCon.Close();
    }

    #endregion
}

