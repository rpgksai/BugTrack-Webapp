using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace BugTrackApplication.UserControls
{
    public partial class AllProjectDetails : System.Web.UI.UserControl
    {
        clsProject objproject = new clsProject();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    DisplayApplication();
                }
            }
            catch (Exception ex)
            {
                lblMsg.Visible = true;
                lblMsg.Text = ex.Message.ToString();
            }
        }

        //Display All Projects
        public void DisplayApplication()
        {
            DataSet dsAppn = objproject.DisplayProjectTypes();
            if (dsAppn.Tables[0].Rows.Count > 0)
            {
                GVApplicationReports.DataSource = dsAppn.Tables[0];
                GVApplicationReports.DataBind();
            }
            else
            {
                lblMsg.Visible = true;
                lblMsg.Text = "No Data Avaliable";
            }
        }

                
        protected void GVDefectReports_RowEditing(object sender, GridViewEditEventArgs e)
        {
            try
            {

                int id = Convert.ToInt32(GVApplicationReports.DataKeys[e.NewEditIndex].Value);

                Response.Redirect("~/UpdateProject.aspx?ProjectId=" + id);
            }
            catch (Exception ex)
            {
                lblMsg.Visible = true;
                lblMsg.Text = ex.Message.ToString();
            }
        }

        protected void GVDefectReports_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GVApplicationReports.PageIndex = e.NewPageIndex;
            DisplayApplication();

        }
    }
    
}