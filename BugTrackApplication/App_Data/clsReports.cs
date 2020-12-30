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
using BugTrackApplication.DAL;

/// <summary>
/// Summary description for clsReports
/// </summary>
public class clsReports
{
	public clsReports()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    int userId;
    public int UserId
    {
        get { return userId ; }
        set { userId  = value; }
    }
    string softWareId;
    public string  SoftWareId
    {
        get { return softWareId ; }
        set { softWareId  = value; }
    }
    public DataSet ReportForDefects()
    {
        string SqlStat = "select * from tblDefectDetails ";
        return SqlHelper.ExecuteDataset(clsConnection.ConnenctionString(), CommandType.Text, SqlStat);
    }
    public DataSet ReportForUsers()
    {
        string SqlStat = "select * from tblUsersAccountDetails where UserAccountId="+UserId ;
        return SqlHelper.ExecuteDataset(clsConnection.ConnenctionString(), CommandType.Text, SqlStat);

    }
    public DataSet GetUserId()
    {
        string SqlStat = "select UserAccountId from tblUsersAccountDetails";
        return SqlHelper.ExecuteDataset(clsConnection.ConnenctionString(), CommandType.Text, SqlStat);

    }
    public DataSet GetSoftWareId()
    {
        string SqlStat = "select SoftWareId from tblSoftWareDetails";
        return SqlHelper.ExecuteDataset(clsConnection.ConnenctionString(), CommandType.Text, SqlStat);

    }
    public DataSet GetSoftWareDetails()
    {
        SqlParameter p = new SqlParameter("@SoftWareId", SoftWareId);
        p.SqlDbType = SqlDbType.VarChar;
      return  SqlHelper.ExecuteDataset (clsConnection.ConnenctionString (),CommandType.StoredProcedure ,"spGetSoftWareDetails",p);
    }

}
