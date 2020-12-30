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
    public partial class UserPendingDefect : System.Web.UI.UserControl
    {
        clsDefects objDefects = new clsDefects();
        clsLogin objLogin = new clsLogin();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    GetEmployeeDets();
                    CheckDefectReport();
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
                lblMsg.Visible = true;
            }
        }

        // To Get the Defects according to the Login Id  ie., User

        public void CheckDefectReport()
        {
            objDefects.EmployeeId = Convert.ToInt32(Session["UserAccountID"]);
            DataSet dsReport = objDefects.CheckDefectPendingReport();
            if (dsReport.Tables[0].Rows.Count > 0)
            {
                GVDefectPendingReports.DataSource = dsReport.Tables[0];
                GVDefectPendingReports.DataBind();
            }
        }

        //Login User
        public void GetEmployeeDets()
        {
            objLogin.UserAccountId = Session["UserAccountID"].ToString();
            DataSet dsEmpReports = objLogin.GetLoginEmployeeDetails();
            if (dsEmpReports.Tables[0].Rows.Count > 0)
            {
                LblLoginUser.Text = dsEmpReports.Tables[0].Rows[0]["FirstName"].ToString() + " " + dsEmpReports.Tables[0].Rows[0]["LastName"].ToString();
            }

        }

        protected void GVDefectReports_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GVDefectPendingReports.PageIndex = e.NewPageIndex;
            CheckDefectReport();
        }

        protected void GVDefectReports_RowEditing(object sender, GridViewEditEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(GVDefectPendingReports.DataKeys[e.NewEditIndex].Value);
                Response.Redirect("~/UserEditDefect.aspx?DefectId=" + id);



            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message.ToString();
                lblMsg.Visible = true;
            }
        }
    }
}