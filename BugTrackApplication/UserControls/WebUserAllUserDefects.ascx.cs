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
    public partial class WebUserAllUserDefects : System.Web.UI.UserControl
    {
        clsDefects objDefects = new clsDefects();
        clsLogin objLogin = new clsLogin();

        protected void Page_Load(object sender, EventArgs e)
        {
          //  Session["UserAccountID"] = "1";
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
            DataSet dsReport = objDefects.CheckDefectReport();
            if (dsReport.Tables[0].Rows.Count > 0)
            {
                GVDefectReports.DataSource = dsReport.Tables[0];
                GVDefectReports.DataBind();
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


        //To Get all defect details in the Grid
        protected void GVDefectReports_RowEditing(object sender, GridViewEditEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(GVDefectReports.DataKeys[e.NewEditIndex].Value);
                Response.Redirect("~/UserEditDefect.aspx?DefectId=" + id);



            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message.ToString();
                lblMsg.Visible = true;
            }
        }

       

        protected void GVDefectReports_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GVDefectReports.PageIndex = e.NewPageIndex;
            CheckDefectReport();
        }

        protected void GVDefectReports_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                GVDefectReports.Columns[1].ItemStyle.Width = 50;
                GVDefectReports.Columns[2].ItemStyle.Width = 150;
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
                GVDefectReports.RenderControl(htmlWrite);
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
                GVDefectReports.RenderControl(htmlWrite);
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