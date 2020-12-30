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

using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Summary description for clsLogin
/// </summary>
public class clsLogin
{
	public clsLogin()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    string loginName , userName,password,newPassword, userAccountId;
    int roleId ;
    public string UserName
    {
        get { return userName; }
        set { userName = value; }
    }

    public string LoginName
    {
        get { return loginName; }
        set { loginName = value; }
    }

    public string Password
    {
        get { return password; }
        set { password = value; }
    }
    public int RoleId
    {
        get { return roleId; }
        set { roleId = value; }
    }
    public string UserAccountId
    {
        get { return userAccountId; }
        set { userAccountId = value; }
    }

    public string NewPassword
    {
        get { return newPassword; }
        set { newPassword = value; }
    }
    public int LoginValidate()
    {
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter();
        
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cnstr"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SP_UserDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username",loginName.Trim());
            cmd.Parameters.AddWithValue("@pwd", Password.Trim());
            adp.SelectCommand = cmd;
            adp.Fill(dt);
            cmd.Dispose();
            if (dt.Rows.Count > 0)
            {
                userAccountId = dt.Rows[0]["EmpId"].ToString();
                return dt.Rows.Count;

            }
            else
            {
                //ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "alert('wrong Password');", true);
                //lblStatus.Text = "Wrong Username/Password";
                //Or show in messagebox usingScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "alert('Wrong Username/Password');", true);
                //Or write using Response.Write("Wrong Username/Password");
                //return "wrong";
                return dt.Rows.Count;
            }
       

    }

  // To get particular employee details accoring to userAccountId
    public DataSet GetEmployeeDetails()
    {

        SqlParameter[] p = new SqlParameter[1];
        p[0] = new SqlParameter("@UserAccountId", UserAccountId);
        p[0].SqlDbType = SqlDbType.VarChar;
        return SqlHelper.ExecuteDataset(clsConnection.ConnenctionString(), CommandType.StoredProcedure, "SP_ParticularEmployeeDetails", p);

    }


    // To get particular employee details accoring to EmployeeId
    public DataSet GetLoginEmployeeDetails()
    {

        SqlParameter[] p = new SqlParameter[1];
        p[0] = new SqlParameter("@UserAccountId", UserAccountId);
        p[0].SqlDbType = SqlDbType.VarChar;
        return SqlHelper.ExecuteDataset(clsConnection.ConnenctionString(), CommandType.StoredProcedure, "SP_LoginmployeeDetails", p);

    }


    public DataSet GetAllEmpDetails()
    {
        string SqlStat = "select EmpId, FirstName +' '+ LastName as FullName from tblUsersEmployeesDetails";
        return SqlHelper.ExecuteDataset(clsConnection.ConnenctionString(), CommandType.Text, SqlStat);
    }


    /*public int CheckChangePassword()
    {
        SqlParameter[] p = new SqlParameter[4];
        p[0] = new SqlParameter("@UserName", UserName);
        p[0].SqlDbType = SqlDbType.VarChar;
        p[1] = new SqlParameter("@OldPassword", Password);
        p[1].SqlDbType = SqlDbType.VarChar;
        p[2] = new SqlParameter("@NewPassword", NewPassword);
        p[2].SqlDbType = SqlDbType.VarChar;
        p[3] = new SqlParameter("@Result", SqlDbType.Int);
        p[3].Direction = ParameterDirection.Output;
        SqlHelper.ExecuteNonQuery(clsConnection.ConnenctionString(), CommandType.StoredProcedure, "spCheckPassword", p);
        return Convert.ToInt32(p[3].Value);
        
    }
    */
}
