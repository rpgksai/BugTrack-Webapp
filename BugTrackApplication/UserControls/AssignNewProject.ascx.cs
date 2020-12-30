using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BugTrackApplication.UserControls
{
    public partial class AssignNewProject : System.Web.UI.UserControl
    {

        clsProject objProj = new clsProject();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
        

            try
            {
                 InsertProjectDetails();
                Response.Redirect("ManageUsers.aspx");
            }
            catch (Exception ex)
            {
                lblMsg.Visible = true;
                lblMsg.Text = ex.Message;

            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {

        }

        // To Insert New Emp Details
        public void InsertProjectDetails()
        {
           // if (txtUserName.Text.Length != 0)
            {
                objProj.Title = txtProjectName.Text.Trim();
                objProj.NoOfModules = Convert.ToInt32(txtNoOfModules.Text);
                objProj.Description= txtDescription.Text;
                objProj.PlatForm = txtPlatform.Text.Trim();
                objProj.Client = txtClient.Text;
                objProj.ProjectStatus = txtStatus.Text.Trim();
                objProj.ProjectStartDate = GMStDate.DateString;
                objProj.ProjectEndDate = GM_EdDate.DateString;
                objProj.AddNewApplication();
            }
            //else
            //{
            //    Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "myscript", "alert('Enter UserName First!!')", true);

            //}
        }

    }
}