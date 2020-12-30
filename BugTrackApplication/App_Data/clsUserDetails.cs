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
/// Summary description for clsUserDetails
/// </summary>
public class clsUserDetails
{
	public clsUserDetails()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    string firstName, lastName, gender, qualification, dateOfJoin, desgination, address, emailId, contactNo, userName, passWord, roleName, answer;
   




    public string Answer
    {
        get { return answer; }
        set { answer = value; }
    }

    public string RoleName
    {
        get { return roleName; }
        set { roleName = value; }
    }


    public string PassWord
    {
        get { return passWord; }
        set { passWord = value; }
    }

    public string UserName
    {
        get { return userName; }
        set { userName = value; }
    }

    public string ContactNo
    {
        get { return contactNo; }
        set { contactNo = value; }
    }

    public string EmailId
    {
        get { return emailId; }
        set { emailId = value; }
    }

    public string Address
    {
        get { return address; }
        set { address = value; }
    }

    public string Desgination
    {
        get { return desgination; }
        set { desgination = value; }
    }

    public string DateOfJoin
    {
        get { return dateOfJoin; }
        set { dateOfJoin = value; }
    }

    public string Qualification
    {
        get { return qualification; }
        set { qualification = value; }
    }

    public string Gender
    {
        get { return gender; }
        set { gender = value; }
    }

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }
    int userId, roleId;
    public int UserId
    {
        get { return userId; }
        set { userId = value; }
    }
    public int RoleId
    {
        get { return roleId ; }
        set { roleId  = value; }
    }
  
    // To Insert New  User Details
    public void InserUserDetails()
    {
        SqlParameter[] p = new SqlParameter[12];
        p[0] = new SqlParameter("@FirstName", FirstName);
        p[0].SqlDbType = SqlDbType.VarChar;
        p[1] = new SqlParameter("@LastName", LastName );
        p[1].SqlDbType = SqlDbType.VarChar;
        p[2] = new SqlParameter("@Gender", Gender);
        p[2].SqlDbType = SqlDbType.VarChar;
        p[3] = new SqlParameter("@Qualification", Qualification );
        p[3].SqlDbType = SqlDbType.VarChar;
        p[4] = new SqlParameter("@DateOfJoin", DateOfJoin );
        p[4].SqlDbType = SqlDbType.VarChar;
        p[5] = new SqlParameter("@Desgination", Desgination );
        p[5].SqlDbType = SqlDbType.VarChar;
        p[6] = new SqlParameter("@Address", Address );
        p[6].SqlDbType = SqlDbType.VarChar;
        p[7] = new SqlParameter("@EmailId", EmailId );
        p[7].SqlDbType = SqlDbType.VarChar;
        p[8] = new SqlParameter("@ContactNo", ContactNo );
        p[8].SqlDbType = SqlDbType.VarChar;
        p[9] = new SqlParameter("@UserName", UserName);
        p[9].SqlDbType = SqlDbType.VarChar;
        p[10] = new SqlParameter("@Password", PassWord );
        p[10].SqlDbType = SqlDbType.VarChar;
        p[11] = new SqlParameter("@RoleID", RoleId );
        p[11].SqlDbType = SqlDbType.VarChar;
        SqlHelper.ExecuteNonQuery(clsConnection.ConnenctionString(),CommandType.StoredProcedure, "sp_InsertUserDetails", p);  
    }

    // to chk the emp username availability
    public bool CheckAvailableUserName()
    {
        SqlParameter p = new SqlParameter("@UserName", UserName);
        p.SqlDbType = SqlDbType.VarChar;
        SqlDataReader dr;
        
       dr=SqlHelper.ExecuteReader (clsConnection.ConnenctionString(), CommandType.StoredProcedure, "sp_CheckAvaliableUserName", p);
       dr.Read();
       if (dr.HasRows)
       {
           return true;
       }
       else
       {
           return false;
       }
    }
    public DataSet  DisplayUsers()
    {
        return SqlHelper.ExecuteDataset(clsConnection.ConnenctionString(), CommandType.StoredProcedure, "spDisplayUserDetails");  
    }
    public DataSet DisplayUserById()
    {
        SqlParameter p = new SqlParameter("@UserAccountId",UserId);
        p.SqlDbType = SqlDbType.Int;
        return SqlHelper.ExecuteDataset(clsConnection.ConnenctionString(), CommandType.StoredProcedure, "spGetUserDetailsById",p);  
    }
    public void UpdateUserDetails()
    {
        SqlParameter[] p = new SqlParameter[8];
        p[0] = new SqlParameter("@UserAccountId", UserId);
        p[0].SqlDbType = SqlDbType.Int;
        p[1] = new SqlParameter("@FirstName", FirstName);
        p[1].SqlDbType = SqlDbType.VarChar;        
        p[2] = new SqlParameter("@Qualification", Qualification);
        p[2].SqlDbType = SqlDbType.VarChar;
        p[3] = new SqlParameter("@Desgination", Desgination);
        p[3].SqlDbType = SqlDbType.VarChar;
        p[4] = new SqlParameter("@Address", Address);
        p[4].SqlDbType = SqlDbType.VarChar;
        p[5] = new SqlParameter("@EmailId", EmailId);
        p[5].SqlDbType = SqlDbType.VarChar;
        p[6] = new SqlParameter("@ContactNo", ContactNo);
        p[6].SqlDbType = SqlDbType.VarChar;
        p[7] = new SqlParameter("@RoleId", RoleId );
        p[7].SqlDbType = SqlDbType.Int;
       
        SqlHelper.ExecuteNonQuery(clsConnection.ConnenctionString(), CommandType.StoredProcedure, "spUpdateUserAccount", p);
    }

    //To Get all the Employee Roles
    public DataSet UserRoleDetails()
    {
        string SqlStat = "select * from tblRoles order by RoleName" ;
         return SqlHelper.ExecuteDataset(clsConnection.ConnenctionString(), CommandType.Text, SqlStat);
    }

    public DataSet SortUserDetails()
    {
        string SqlStat = " select * from tblUsersAccountDetails order by " + FirstName;
        return SqlHelper.ExecuteDataset(clsConnection.ConnenctionString(), CommandType.Text, SqlStat);
    }
    public void DeleteUsers()
    {
        string SqlStat = "Delete from tblUsersAccountDetails where UserAccountId=" + UserId;
        SqlHelper.ExecuteNonQuery(clsConnection.ConnenctionString(), CommandType.StoredProcedure, SqlStat);
    }
    public DataSet GetEmpId()
    {
        string SqlStat = "select UserAccountId from tblUsersAccountDetails";
        return SqlHelper.ExecuteDataset(clsConnection.ConnenctionString(), CommandType.Text, SqlStat);
    }
    public DataSet GetUserDetailsById()
    {
        string SqlStat = "select FirstName,Qualification from tblUsersAccountDetails where UserAccountId="+UserId ;
        return SqlHelper.ExecuteDataset(clsConnection.ConnenctionString(), CommandType.Text, SqlStat);
    }
    public DataSet GetUserAccount()
    {
        SqlParameter[] p = new SqlParameter[1];
        p[0] = new SqlParameter("@UserName", UserName);
        p[0].SqlDbType = SqlDbType.VarChar;
        return SqlHelper.ExecuteDataset(clsConnection.ConnenctionString(), CommandType.StoredProcedure, "spGetUserAccountDetails", p); 
    }
    public void UpdateUserAccount()
    {
        SqlParameter[] p = new SqlParameter[7];
        p[0] = new SqlParameter("@UserAccountId", UserId);
        p[0].SqlDbType = SqlDbType.Int;
        p[1] = new SqlParameter("@FirstName", FirstName);
        p[1].SqlDbType = SqlDbType.VarChar;
        p[2] = new SqlParameter("@Qualification", Qualification);
        p[2].SqlDbType = SqlDbType.VarChar;
        p[3] = new SqlParameter("@Desgination", Desgination);
        p[3].SqlDbType = SqlDbType.VarChar;
        p[4] = new SqlParameter("@Address", Address);
        p[4].SqlDbType = SqlDbType.VarChar;
        p[5] = new SqlParameter("@EmailId", EmailId);
        p[5].SqlDbType = SqlDbType.VarChar;
        p[6] = new SqlParameter("@ContactNo", ContactNo);
        p[6].SqlDbType = SqlDbType.VarChar;
        SqlHelper.ExecuteNonQuery(clsConnection.ConnenctionString(), CommandType.StoredProcedure, "spUpdateUserAccountByuser", p);
    }
}
