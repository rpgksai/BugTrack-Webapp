using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using BugTrackApplication.DAL;
using System.Data.SqlClient;  

/// <summary>
/// Summary description for clsDefects
/// </summary>
public class clsDefects
{
	public clsDefects()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    int userAccountId, defectTypeId, projectId, defectId , employeeId;
    string typeName, description, empId, moduleName, emailId, defectName, projectNo, priority;

    public int DefectId
    {
        get { return defectId; }
        set { defectId = value; }
    }

    public int ProjectId
    {
        get { return projectId; }
        set { projectId = value; }

    }

    public int EmployeeId
    {
        get { return employeeId; }
        set { employeeId = value; }
    }

    public string ProjectNo
    {
        get { return projectNo; }
        set { projectNo = value; }

    }

    public string DefectName
    {
        get { return defectName; }
        set { defectName = value; }
    }
    public string ModuleName
    {
        get { return moduleName; }
        set { moduleName = value; }
    }
    public string Priority
    {
        get { return priority; }
        set { priority = value; }
    }
    public int UserAccountId
    {
        get { return userAccountId; }
        set { userAccountId = value; }
    }
    public int DefectTypeId
    {
        get { return defectTypeId; }
        set { defectTypeId = value; }
    }

    public string TypeName
    {
        get { return typeName; }
        set { typeName = value; }
    }
    public string Description
    {
        get { return description; }
        set { description = value; }
    }
    public string EmailId
    {
        get { return emailId; }
        set { emailId = value; }
    }

    public string EmpId
    {
        get { return empId; }
        set { empId = value; }
    }

    string status;
    public string Status
    {
        get { return status; }
        set { status = value; }
    }
    
    string userName;
    public string UserName
    {
        get { return userName; }
        set { userName = value; }
    }
  

    //To Get all Defect Types
    public DataSet GetDefectName()
    {
        string SqlStat = "select *  from tblDefectTypes";
        return SqlHelper.ExecuteDataset(clsConnection.ConnenctionString(), CommandType.Text, SqlStat);
    }

    // To Insert new defects
    public void InsertDefectDetails()
    {
        SqlParameter[] p = new SqlParameter[9];
        p[0] = new SqlParameter("@DefectName", DefectName);
        p[0].SqlDbType = SqlDbType.VarChar;
        p[1] = new SqlParameter("@userAccountId", userAccountId);
        p[1].SqlDbType = SqlDbType.Int;
        p[2] = new SqlParameter("ProjectId", ProjectId);
        p[2].SqlDbType = SqlDbType.VarChar;
        p[3] = new SqlParameter("@ModuleName", ModuleName);
        p[3].SqlDbType = SqlDbType.VarChar;
        p[4] = new SqlParameter("@Description", Description);
        p[4].SqlDbType = SqlDbType.VarChar;
        p[5] = new SqlParameter("@DefectTypeId", DefectTypeId);
        p[5].SqlDbType = SqlDbType.Int;
        p[6] = new SqlParameter("@EmpId", EmployeeId);
        p[6].SqlDbType = SqlDbType.Int;
        p[7] = new SqlParameter("@Status", @Status);
        p[7].SqlDbType = SqlDbType.VarChar;
        p[8] = new SqlParameter("@priority", priority);
        p[8].SqlDbType = SqlDbType.VarChar;
        SqlHelper.ExecuteNonQuery(clsConnection.ConnenctionString(), CommandType.StoredProcedure, "sp_AddNewDefects", p);
    }
    
    
    // To get All defects
    public DataSet  GetDefectTypes()
    {
        string SqlStat = "select * from tblDefectTypes";
        return SqlHelper.ExecuteDataset(clsConnection.ConnenctionString(), CommandType.Text, SqlStat);
    }


     // To Get the Defects according to the Login Id  ie., User
    public DataSet CheckDefectReport()
    {
        SqlParameter[] p = new SqlParameter[1];
        p[0] = new SqlParameter("@UserName", EmployeeId);
        p[0].SqlDbType = SqlDbType.VarChar;
        return SqlHelper.ExecuteDataset(clsConnection.ConnenctionString(), CommandType.StoredProcedure, "spAllDefectReport", p);  
    }


    // To Get the Defects according to the Login Id  ie., User
    public DataSet CheckDefectPendingReport()
    {
        SqlParameter[] p = new SqlParameter[1];
        p[0] = new SqlParameter("@UserName", EmployeeId);
        p[0].SqlDbType = SqlDbType.VarChar;
        return SqlHelper.ExecuteDataset(clsConnection.ConnenctionString(), CommandType.StoredProcedure, "spAllDefectPendingReport", p);
    }


    // To Get the Defects history according to the Login Id  ie., User
    public DataSet CheckHistoryDefectReportbyLoginId()
    {
        SqlParameter[] p = new SqlParameter[1];
        p[0] = new SqlParameter("@EmployeeId", EmployeeId);
        p[0].SqlDbType = SqlDbType.VarChar;
        return SqlHelper.ExecuteDataset(clsConnection.ConnenctionString(), CommandType.StoredProcedure, "sp_DefectHistoryPerEmp", p);
    }


    // To Get the Defects according to the Application Id  ie., User
    public DataSet CheckHistoryDefectReportbyAppln()
    {
        SqlParameter[] p = new SqlParameter[1];
        p[0] = new SqlParameter("@ProjectId", @ProjectId);
        p[0].SqlDbType = SqlDbType.VarChar;
        return SqlHelper.ExecuteDataset(clsConnection.ConnenctionString(), CommandType.StoredProcedure, "sp_DefectHistoryPerAppln", p);
    }

    // to Get Each Defects
    public DataSet GetDefectDescription()
    {
        SqlParameter p = new SqlParameter("@DefectId", DefectId);
        p.SqlDbType = SqlDbType.VarChar;
        return SqlHelper.ExecuteDataset(clsConnection.ConnenctionString(), CommandType.StoredProcedure, "spSelectedDefectReport", p);
    }
  
    
    //To Update the Defect
    public void UpdateDefectReport()
    {
       
        SqlParameter[] p = new SqlParameter[10];
        p[0] = new SqlParameter("@DefectId", DefectId);
        p[0].SqlDbType = SqlDbType.Int;
        p[1] = new SqlParameter("@DefectName", DefectName);
        p[1].SqlDbType = SqlDbType.VarChar;
        p[2] = new SqlParameter("@UserAccountId", UserAccountId);
        p[2].SqlDbType = SqlDbType.VarChar;
        p[3] = new SqlParameter("@ProjectId", ProjectNo);
        p[3].SqlDbType = SqlDbType.VarChar;
        p[4] = new SqlParameter("@ModuleName", ModuleName);
        p[4].SqlDbType = SqlDbType.VarChar;
        p[5] = new SqlParameter("@description", Description);
        p[5].SqlDbType = SqlDbType.VarChar;
        p[6] = new SqlParameter("@DefectTypeId", DefectTypeId);
        p[6].SqlDbType = SqlDbType.Int;
        p[7] = new SqlParameter("@EmpId", EmpId);
        p[7].SqlDbType = SqlDbType.Int;
        p[8] = new SqlParameter("@Status", Status);
        p[8].SqlDbType = SqlDbType.VarChar;
        p[9] = new SqlParameter("@priority", priority);
        p[9].SqlDbType = SqlDbType.VarChar;
        SqlHelper.ExecuteNonQuery(clsConnection.ConnenctionString(), CommandType.StoredProcedure, "spUpdateDefectStatus", p);
    }

    public DataSet ShowDefectStatus()
    {
      SqlParameter p = new SqlParameter("@UserName", UserName);
        p.SqlDbType = SqlDbType.VarChar;
        return SqlHelper.ExecuteDataset(clsConnection.ConnenctionString(), CommandType.StoredProcedure, "spShowDefectStatusToUsers", p);
    }
}
