using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BugTrackApplication.UserControls
{
    public partial class AssignProjectUsers : System.Web.UI.UserControl
    {
        clsUserDetails objclsUserDetails = new clsUserDetails();
        clsProject objProj = new clsProject();
        clsLogin objLogin = new clsLogin();

        protected void Page_Load(object sender, EventArgs e)
        {
           // Session["UserAccountID"] = '1';

            
            try
            {
                if (!IsPostBack)
                {
                    //HdnLoginUser.Value = Session["UserAccountID"].ToString();
                    //HdnDefectID.Value = Request["DefectId"].ToString();
                    GetEmployeeDets();
                    GetProjectList();
                    GetEmployeeList();
                    AllProjectUsers();
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
                lblMsg.Visible = true;
            }

        }

        //Get All employee in dropdown
        public void GetProjectList()
        {
            DataSet dsEmpLists = objProj.DisplayProjectTypes();
            if (dsEmpLists.Tables[0].Rows.Count > 0)
            {

                ddlProjectName.DataTextField = dsEmpLists.Tables[0].Columns["Title"].ToString(); // text field name of table dispalyed in dropdown
                ddlProjectName.DataValueField = dsEmpLists.Tables[0].Columns["ProjectId"].ToString();             // to retrive specific  textfield name 
                ddlProjectName.DataSource = dsEmpLists.Tables[0];      //assigning datasource to the dropdownlist
                ddlProjectName.DataBind();  //binding dropdownlist

                ddlProjectName.Items.Insert(0, new ListItem("--Select--", "0"));
            }


        }

        public void GetEmployeeList()
        {
            DataSet dsEmpLists = objLogin.GetAllEmpDetails();
            if (dsEmpLists.Tables[0].Rows.Count > 0)
            {

                ddlEmployeeName.DataTextField = dsEmpLists.Tables[0].Columns["FullName"].ToString(); // text field name of table dispalyed in dropdown
                ddlEmployeeName.DataValueField = dsEmpLists.Tables[0].Columns["Empid"].ToString();             // to retrive specific  textfield name 
                ddlEmployeeName.DataSource = dsEmpLists.Tables[0];      //assigning datasource to the dropdownlist
                ddlEmployeeName.DataBind();  //binding dropdownlist

                ddlEmployeeName.Items.Insert(0, new ListItem("--Select--", "0"));
            }


        }

        // To Get the Defects according to the Login Id  ie., User

        public void AllProjectUsers()
        {
            objProj.EmployeeId = Convert.ToInt32(Session["UserAccountID"]);
            DataSet dsReport = objProj.AssignedEmpProjects();
            if (dsReport.Tables[0].Rows.Count > 0)
            {
                GVProjectEmployees.DataSource = dsReport.Tables[0];
                GVProjectEmployees.DataBind();
            }
        }


        protected void GVDefectReports_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            

        }

        protected void ProjectName(object sender, EventArgs e)
        {
            objProj.ProjectId = Convert.ToInt32(ddlProjectName.SelectedItem.Value);
            DataSet dsReport = objProj.GetUsersPerProject();
            if (dsReport.Tables[0].Rows.Count > 0)
            {
                GVProjectEmployees.DataSource = dsReport.Tables[0];
                GVProjectEmployees.DataBind();
            }
            else
            {
                Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "myscript", "alert('No Users allocated for this Application')", true);


            }
        }


        public void GetEmployeeDets()
        {
            objLogin.UserAccountId = Session["UserAccountID"].ToString();
            DataSet dsEmpReports = objLogin.GetEmployeeDetails();
            if (dsEmpReports.Tables[0].Rows.Count > 0)
            {
                LblLoginUser.Text = dsEmpReports.Tables[0].Rows[0]["FirstName"].ToString() + " " + dsEmpReports.Tables[0].Rows[0]["LastName"].ToString();
            }



        }


        protected void btnNew_Click(object sender, EventArgs e)
        {
            objProj.EmployeeId = Convert.ToInt32(ddlEmployeeName.SelectedItem.Value);
            objProj.ProjectId = Convert.ToInt32(ddlProjectName.SelectedItem.Value);
            objProj.WorkStartDate = GMWorkStartDate.DateString;
            objProj.WorkEndDate = GMWorkEndDate.DateString;
            objProj.UserAccountId = Convert.ToInt32(Session["UserAccountID"]);
            objProj.UpdateUserPerProject();

            //objProj.ProjectId = Convert.ToInt32(ddlProjectName.SelectedItem.Value);
            DataSet dsReport = objProj.GetUsersPerProject();
            if (dsReport.Tables[0].Rows.Count > 0)
            {
                GVProjectEmployees.DataSource = dsReport.Tables[0];
                GVProjectEmployees.DataBind();
            }



        }

        protected void GVProjectEmployees_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //int x  = Convert.ToInt32(GVProjectEmployees.Rows[e.RowIndex].FindControl("ID").ToString());
            int index = Convert.ToInt32(e.RowIndex);
            objProj.DeleteSelectedAppEmpDetails(index);
           
            objProj.ProjectId = Convert.ToInt32(ddlProjectName.SelectedItem.Value);
            DataSet dsReport = objProj.GetUsersPerProject();
            if (dsReport.Tables[0].Rows.Count > 0)
            {
                GVProjectEmployees.DataSource = dsReport.Tables[0];
                GVProjectEmployees.DataBind();
            }

        }


       /* public void GetUsersByProj()
        {
            objProj.ProjectId = Convert.ToInt32(ddlProjectName.SelectedItem.Value);
            DataSet dsReport = objProj.GetUsersPerProject();
            if (dsReport.Tables[0].Rows.Count > 0)
            {
                GVProjectEmployees.DataSource = dsReport.Tables[0];
                GVProjectEmployees.DataBind();
            }


        }*/
    }
}