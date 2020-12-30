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
    public partial class UpdateprojDets : System.Web.UI.UserControl
    {
        clsProject objProj = new clsProject();
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
           
            try
            {
                if (!IsPostBack)
                {
                    GetDefectDescription();
                }
            }
            catch (Exception ex)
            {
                lblMsg.Visible = true;
                lblMsg.Text = ex.Message.ToString();
            }
        }


        public void GetDefectDescription()
        {
            objProj.ProjectId = Convert.ToInt32(Request["ProjectId"].ToString());
            DataSet dsReports = objProj.GetPojectById();
            if (dsReports.Tables[0].Rows.Count > 0)
            {
                DataRow dr = dsReports.Tables[0].Rows[0];
                
                txtProjectName.Text = dsReports.Tables[0].Rows[0]["Title"].ToString();
                txtNoOfModules.Text = dsReports.Tables[0].Rows[0]["NoOfModules"].ToString();
                txtDescription.Text = dsReports.Tables[0].Rows[0]["Description"].ToString();
                txtPlatform.Text = dsReports.Tables[0].Rows[0]["PlatForm"].ToString();
                txtClient.Text = dsReports.Tables[0].Rows[0]["Client"].ToString();
                txtStatus.Text = dsReports.Tables[0].Rows[0]["ProjectStatus"].ToString();
                txtStDate.Text = dsReports.Tables[0].Rows[0]["projectStartDate"].ToString();
                TxtEdDate.Text = dsReports.Tables[0].Rows[0]["projectEndDate"].ToString();
                dt = dsReports.Tables[0];

            }

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            objProj.Title = txtProjectName.Text.Trim();
            objProj.NoOfModules = Convert.ToInt32(txtNoOfModules.Text);
            objProj.Description = txtDescription.Text;
            objProj.PlatForm = txtPlatform.Text.Trim();
            objProj.Client = txtClient.Text;
            objProj.ProjectStatus = txtStatus.Text.Trim();
            objProj.ProjectStartDate = txtStDate.Text;
            objProj.ProjectEndDate = TxtEdDate.Text;
            objProj.AddNewApplication();
            Response.Redirect("AllProjects.aspx");
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            Response.Redirect("AllProjects.aspx");
        }
    }
}