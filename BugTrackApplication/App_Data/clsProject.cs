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
/// Summary description for clsSoftware
/// </summary>
public class clsProject
{
	public clsProject()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    string typeName, model, description, remarks;
    int projectId, employeeId;
    string title,  platForm , client, projectStatus, projectStartDate , projectEndDate;
    string softWareId, tested , workStartDate, workEndDate;
    int userAccountId, employeeProjectId;

    public string WorkStartDate
    {
        get { return workStartDate; }
        set { workStartDate = value; }
    }
    public string WorkEndDate
    {
        get { return workEndDate; }
        set { workEndDate = value; }
    }

    public int UserAccountId
    {
        get { return userAccountId; }
        set { userAccountId = value; }
    }

    public int EmployeeProjectId
    {
        get { return employeeProjectId; }
        set { employeeProjectId = value; }
    }

    public string Client
    {
        get { return client; }
        set { client = value; }
    }
    public string ProjectStatus
    {
        get { return projectStatus; }
        set { projectStatus = value; }
    }
    public string ProjectStartDate
    {
        get { return projectStartDate; }
        set { projectStartDate = value; }
    }
    public string ProjectEndDate
    {
        get { return projectEndDate; }
        set { projectEndDate = value; }
    }
    public string TypeName
    {
        get { return typeName; }
        set { typeName = value; }
    }
    public string Model
    {
        get { return model; }
        set { model = value; }
    }
    public string Description
    {
        get { return description; }
        set { description = value; }
    }
    public string Remarks
    {
        get { return remarks; }
        set { remarks = value; }
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

  
    public string Tested
    {
        get { return tested; }
        set { tested = value; }
    }

    public string PlatForm
    {
        get { return platForm; }
        set { platForm = value; }
    }

    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public string SoftWareId
    {
        get { return softWareId; }
        set { softWareId = value; }
    }
    int noOfModules;

    public int NoOfModules
    {
        get { return noOfModules; }
        set { noOfModules = value; }
    }






    public void AddNewApplication()
    {
        SqlParameter[] p = new SqlParameter[8];
        p[0] = new SqlParameter("@Title", Title);
        p[0].SqlDbType = SqlDbType.VarChar;
        p[1] = new SqlParameter("@NoOfModules", NoOfModules);
        p[1].SqlDbType = SqlDbType.Int;
        p[2] = new SqlParameter("@Description", Description);
        p[2].SqlDbType = SqlDbType.VarChar;
        p[3] = new SqlParameter("@PlatForm", PlatForm);
        p[3].SqlDbType = SqlDbType.VarChar;
        p[4] = new SqlParameter("@Client", Client);
        p[4].SqlDbType = SqlDbType.VarChar;
        p[5] = new SqlParameter("@ProjectStatus", ProjectStatus);
        p[5].SqlDbType = SqlDbType.VarChar;
        p[6] = new SqlParameter("@projectStartDate", projectStartDate);
        p[6].SqlDbType = SqlDbType.VarChar;
        p[7] = new SqlParameter("@projectEndDate", projectEndDate);
        p[7].SqlDbType = SqlDbType.VarChar;
      
        SqlHelper.ExecuteNonQuery(clsConnection.ConnenctionString(), CommandType.StoredProcedure, "sp_InsertNewProject", p);

        }


              // To get all project Names 
        public DataSet DisplayProjectTypes()
    {
        string SqlStat = "select * from tblProjectDetails";
        return SqlHelper.ExecuteDataset(clsConnection.ConnenctionString(), CommandType.Text, SqlStat);   

    }

    // Get Projects as per User login
    public DataSet GetProjectsByEmps()
    {

        SqlParameter[] p = new SqlParameter[1];
        p[0] = new SqlParameter("@EmpId", EmployeeId);
        p[0].SqlDbType = SqlDbType.VarChar;
        return SqlHelper.ExecuteDataset(clsConnection.ConnenctionString(), CommandType.StoredProcedure, "sp_GetProjectsByLoginUsers", p);
  

    }



    // To get all project Names according to Employee
    public DataSet AssignedEmpProjects()
    {
           return SqlHelper.ExecuteDataset(clsConnection.ConnenctionString(), CommandType.StoredProcedure, "sp_GetProjectUsers");

    }

    // To Get the User Accoing
    public DataSet GetUsersPerProject()
    {
        SqlParameter[] p = new SqlParameter[1];
        p[0] = new SqlParameter("@ProjectId", ProjectId);
        p[0].SqlDbType = SqlDbType.VarChar;
        return SqlHelper.ExecuteDataset(clsConnection.ConnenctionString(), CommandType.StoredProcedure, "sp_GetUsersPerProject", p);
    }


    // To Get the Defects according to the Login Id  ie., User
    public DataSet CheckProjectUser()
    {
        SqlParameter[] p = new SqlParameter[1];
        p[0] = new SqlParameter("@UserName", EmployeeId);
        p[0].SqlDbType = SqlDbType.VarChar;
        return SqlHelper.ExecuteDataset(clsConnection.ConnenctionString(), CommandType.StoredProcedure, "spAllDefectReport", p);
    }


    public DataSet GetAppEmpDetails()
    {
        string SqlStat = "select EmpId, FirstName +' '+ LastName as FullName from tblUsersEmployeesDetails";
        return SqlHelper.ExecuteDataset(clsConnection.ConnenctionString(), CommandType.Text, SqlStat);
    }

    //selected Employee as per Application
    public DataSet GetSelectedAppEmpDetails()
    {

        string SqlStat = "select * , FirstName + ' ' + LastName as FullName from tblUsersEmployeesDetails e join EmployeeProjectDetails p  on e.EmpId = p.EmployeeId  where p.ProjectId = " + ProjectId;
        return SqlHelper.ExecuteDataset(clsConnection.ConnenctionString(), CommandType.Text, SqlStat);


    }

    //selected Employee as per Application
    public DataSet DeleteSelectedAppEmpDetails(int UserProjId)
    {

        string SqlStat = "delete from dbo.EmployeeProjectDetails where EmployeeProjectId =  " + UserProjId;
        return SqlHelper.ExecuteDataset(clsConnection.ConnenctionString(), CommandType.Text, SqlStat);


    }
    public void UpdateUserPerProject()
    {
        SqlParameter[] p = new SqlParameter[5];
    p[0] = new SqlParameter("@EmployeeId", EmployeeId);
    p[0].SqlDbType = SqlDbType.Int;
        p[1] = new SqlParameter("@ProjectId", ProjectId);
    p[1].SqlDbType = SqlDbType.Int;
        p[2] = new SqlParameter("@WorkStartDate", WorkStartDate);
    p[2].SqlDbType = SqlDbType.VarChar;
        p[3] = new SqlParameter("@WorkEndDate", WorkEndDate);
    p[3].SqlDbType = SqlDbType.VarChar;
        p[4] = new SqlParameter("@AssignedBy", UserAccountId);
    p[4].SqlDbType = SqlDbType.Int;
       
        SqlHelper.ExecuteNonQuery(clsConnection.ConnenctionString(), CommandType.StoredProcedure, "sp_AddempForProjects", p);

    }



// To get Particular Project
public DataSet GetPojectById()
    {
        string SqlStat = "select * from tblProjectDetails where ProjectId = '" + ProjectId + "'"; ;
        return SqlHelper.ExecuteDataset(clsConnection.ConnenctionString(), CommandType.Text, SqlStat);
    }

  


    //public void UpdateSoftWares()
    //{
    //    SqlParameter[] p = new SqlParameter[6];
    //    p[0] = new SqlParameter("@SoftWareId", SoftWareId);
    //    p[0].SqlDbType = SqlDbType.VarChar;
    //    p[1] = new SqlParameter("@Title", Title);
    //    p[1].SqlDbType = SqlDbType.VarChar;
    //    p[2] = new SqlParameter("@NoOfModules", NoOfModules);
    //    p[2].SqlDbType = SqlDbType.Int;
    //    p[3] = new SqlParameter("@Description", Description);
    //    p[3].SqlDbType = SqlDbType.VarChar;
    //    p[4] = new SqlParameter("@PlatForm", PlatForm);
    //    p[4].SqlDbType = SqlDbType.VarChar;
    //    p[5] = new SqlParameter("@Tested", Tested);
    //    p[5].SqlDbType = SqlDbType.VarChar;

    //    SqlHelper.ExecuteNonQuery(clsConnection.ConnenctionString(), CommandType.StoredProcedure, "spUpdateSoftWares", p);

    //}







}
