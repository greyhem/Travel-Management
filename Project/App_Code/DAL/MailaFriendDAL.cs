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
/// Summary description for MailaFriendDAL
/// </summary>
public class MailaFriendDAL
{
    SqlConnection SqlCon = BaseDAL.Connection_through_Config();
	public MailaFriendDAL()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public int InserttblMailaFriend(MailaFriendBO ObjMailaFriendBO)
    {
        SqlCon.Open();
        SqlCommand Inscommand = new SqlCommand("sp_tblMailaFriend", SqlCon);
        Inscommand.CommandType = CommandType.StoredProcedure;
        Inscommand.Parameters.AddWithValue("@Type", "I");
        Inscommand.Parameters.AddWithValue("@YourEmailID", ObjMailaFriendBO.YourEmailID);
        Inscommand.Parameters.AddWithValue("@FriendsEmailID1", ObjMailaFriendBO.FriendsEmailID1);
        Inscommand.Parameters.AddWithValue("@EmailID2", ObjMailaFriendBO.EmailID2);
        Inscommand.Parameters.AddWithValue("@EmailID3", ObjMailaFriendBO.EmailID3);
        Inscommand.Parameters.AddWithValue("@EmailID4", ObjMailaFriendBO.EmailID4);
        Inscommand.Parameters.AddWithValue("@EmailID5", ObjMailaFriendBO.EmailID5);
        Inscommand.Parameters.AddWithValue("@StandardContent", ObjMailaFriendBO.StandardContent);
        Inscommand.Parameters.AddWithValue("@Comments", ObjMailaFriendBO.Comments);
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
    public DataSet getEmailId(MailaFriendBO ObjMailaFriendBO)
    {

        SqlCon.Open();
        SqlCommand ShowCommand = new SqlCommand("sp_tblMailaFriend", SqlCon);
        ShowCommand.CommandType = CommandType.StoredProcedure;
        ShowCommand.Parameters.AddWithValue("@Type", "S");
        ShowCommand.Parameters.AddWithValue("@ID", ObjMailaFriendBO.ID);
        SqlDataAdapter DataAdapter = new SqlDataAdapter(ShowCommand);
        DataSet ds = new DataSet();
        try
        {
            DataAdapter.Fill(ds, "tblMailaFriend");
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
