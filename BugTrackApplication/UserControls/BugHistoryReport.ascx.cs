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
    public partial class BugHistoryReport : System.Web.UI.UserControl
    {
        clsDefects objDefects = new clsDefects();
        clsLogin objLogin = new clsLogin();
        clsProject objProj = new clsProject();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    GetEmployeeDets();
                    CheckDefectHistoryUserReport();
                    GetProjectList();
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
                lblMsg.Visible = true;
            }
        }

        // To Get the Defects according to the Login Id  ie., User

        public void CheckDefectHistoryUserReport()
        {
            objDefects.EmployeeId = Convert.ToInt32(Session["UserAccountID"]);
            DataSet dsReport = objDefects.CheckHistoryDefectReportbyLoginId();
            if (dsReport.Tables[0].Rows.Count > 0)
            {
                GVDefectHistoryReports.DataSource = dsReport.Tables[0];
                GVDefectHistoryReports.DataBind();
            }
        }


        // To Get the Defects according to the Login Id  ie., User - use Later

        //public void CheckDefectHistoryApplnReport()
        //{
        //    objDefects.EmployeeId = Convert.ToInt32(Session["UserAccountID"]);
        //    DataSet dsReport = objDefects.CheckHistoryDefectReportbyAppln();
        //    if (dsReport.Tables[0].Rows.Count > 0)
        //    {
        //        GVDefectHistoryReports.DataSource = dsReport.Tables[0];
        //        GVDefectHistoryReports.DataBind();
        //    }
        //}

        //Get All employee in dropdown
        public void GetProjectList()
        {
            objProj.EmployeeId = Convert.ToInt32(Session["UserAccountID"]);
            DataSet dsEmpLists = objProj.GetProjectsByEmps();
            if (dsEmpLists.Tables[0].Rows.Count > 0)
            {

                ddlProjectName.DataTextField = dsEmpLists.Tables[0].Columns["Title"].ToString(); // text field name of table dispalyed in dropdown
                ddlProjectName.DataValueField = dsEmpLists.Tables[0].Columns["EmployeeProjectId"].ToString();             // to retrive specific  textfield name 
                ddlProjectName.DataSource = dsEmpLists.Tables[0];      //assigning datasource to the dropdownlist
                ddlProjectName.DataBind();  //binding dropdownlist

                ddlProjectName.Items.Insert(0, new ListItem("--Select--", "0"));
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
            GVDefectHistoryReports.PageIndex = e.NewPageIndex;
            CheckDefectHistoryUserReport();
        }

        protected void GVDefectReports_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                GVDefectHistoryReports.Columns[1].ItemStyle.Width = 50;
                GVDefectHistoryReports.Columns[2].ItemStyle.Width = 150;
            }

        }

   
        protected void ProjectName(object sender, EventArgs e)
        {
            objDefects.ProjectId = Convert.ToInt32(ddlProjectName.SelectedItem.Value);
            DataSet dsReport = objDefects.CheckHistoryDefectReportbyAppln();
            if (dsReport.Tables[0].Rows.Count > 0)
            {
                       GVDefectHistoryReports.DataSource = dsReport.Tables[0];
                    GVDefectHistoryReports.DataBind();
               
            }
            else
            {
                Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "myscript", "alert('No Users allocated for this Application')", true);


            }
        }

     
        protected void btnExcelFormat_Click(object sender, EventArgs e)
        {

            try
            {
                Response.Clear();
                Response.AddHeader("content-disposition", "attachment;filename=DocumentReport.xls");
                Response.Charset = "";
                Response.Cache.SetCacheability(HttpCacheability.NoCache);
                Response.ContentType = "application/vnd.ms-excel";
                System.IO.StringWriter stringWrite = new System.IO.StringWriter();
                System.Web.UI.HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);
                GVDefectHistoryReports.RenderControl(htmlWrite);
                Response.Write(stringWrite.ToString());
                Response.End();
            }
            catch (Exception ex)
            {
                lblMsg.Visible = true;
                lblMsg.Text = ex.Message.ToString();
            }
        }

        protected void btnPdfFormat_Click(object sender, EventArgs e)
        {
            try
            {
                Response.Clear();
                Response.AddHeader("content-disposition", "attachment;filename=DocumentReport.pdf");
                Response.Charset = "";
                Response.Cache.SetCacheability(HttpCacheability.NoCache);
                Response.ContentType = "application/pdf";
                System.IO.StringWriter stringWrite = new System.IO.StringWriter();
                System.Web.UI.HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);
                GVDefectHistoryReports.RenderControl(htmlWrite);
                Response.Write(stringWrite.ToString());
                Response.End();
            }
            catch (Exception ex)
            {
                lblMsg.Visible = true;
                lblMsg.Text = ex.Message.ToString();
            }
        }
    }
}