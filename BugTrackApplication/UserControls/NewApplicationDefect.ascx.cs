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
    public partial class NewApplicationDefect : System.Web.UI.UserControl
    {

        clsDefects objDefects = new clsDefects();
        clsLogin objLogin = new clsLogin();
        clsProject objProjDets = new clsProject();
        DataTable dt = new DataTable();
        DateTime dateTime = DateTime.UtcNow.Date;

        public string AssignedValue;


        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                     //Session["UserAccountID"] = "1";

                    HdnLoginUser.Value = Session["UserAccountID"].ToString();
                    GetEmployeeDets();
                    TxtAssignedDate.Text = dateTime.ToString("dd/MM/yyyy");
                     GetProjectName();
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
                lblMsg.Visible = true;
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


        public void GetApplicationEmployeeList()
        {
            objProjDets.ProjectId = Convert.ToInt32(ddlProjectName.SelectedItem.Value);
            DataSet dsEmpLists = objProjDets.GetSelectedAppEmpDetails();
            if (dsEmpLists.Tables[0].Rows.Count > 0)
            {

                ddlAssignedTo.DataTextField = dsEmpLists.Tables[0].Columns["FullName"].ToString(); // text field name of table dispalyed in dropdown
                ddlAssignedTo.DataValueField = dsEmpLists.Tables[0].Columns["Empid"].ToString();             // to retrive specific  textfield name 
                ddlAssignedTo.DataSource = dsEmpLists.Tables[0];      //assigning datasource to the dropdownlist
                ddlAssignedTo.DataBind();  //binding dropdownlist

                ddlAssignedTo.Items.Insert(0, new ListItem("--Select--", "0"));
            }
        }



        // To Get all DefectTypes
        public void GetDefectTypeList()
        {
            DataSet dsDefectTypeLists = objDefects.GetDefectName();
            if (dsDefectTypeLists.Tables[0].Rows.Count > 0)
            {

                ddlDefectTypeName.DataTextField = dsDefectTypeLists.Tables[0].Columns["DefectTypeName"].ToString(); // text field name of table dispalyed in dropdown
                ddlDefectTypeName.DataValueField = dsDefectTypeLists.Tables[0].Columns["DefectTypeId"].ToString();             // to retrive specific  textfield name 
                ddlDefectTypeName.DataSource = dsDefectTypeLists.Tables[0];      //assigning datasource to the dropdownlist
                ddlDefectTypeName.DataBind();  //binding dropdownlist

                ddlDefectTypeName.Items.Insert(0, new ListItem("--Select--", "0"));
            }
        }


        public void GetProjectName()
        {
            DataSet dsEmpLists = objProjDets.DisplayProjectTypes();
            if (dsEmpLists.Tables[0].Rows.Count > 0)
            {

                ddlProjectName.DataTextField = dsEmpLists.Tables[0].Columns["Title"].ToString(); // text field name of table dispalyed in dropdown
                ddlProjectName.DataValueField = dsEmpLists.Tables[0].Columns["ProjectId"].ToString();             // to retrive specific  textfield name 
                ddlProjectName.DataSource = dsEmpLists.Tables[0];      //assigning datasource to the dropdownlist
                ddlProjectName.DataBind();  //binding dropdownlist

                ddlProjectName.Items.Insert(0, new ListItem("--Select--", "0"));
            }


        }

        protected void AddDefect_Click(object sender, EventArgs e)
        {
            try
            {
                InsertDefectDetails();
                Response.Redirect("InsertDefectDetails.aspx");
            }
            catch (Exception ex)
            {
                lblMsg.Visible = true;
                lblMsg.Text = ex.Message;

            }
        }


        public void InsertDefectDetails()
        {
            if (HdnLoginUser.Value.Length != 0)
            {
                objDefects.DefectName = txtDefectName.Text;
                objDefects.UserAccountId = Convert.ToInt32(HdnLoginUser.Value);
                objDefects.ProjectId = Convert.ToInt32(ddlProjectName.SelectedItem.Value);
                objDefects.ModuleName = txtModuleName.Text;
                objDefects.Description = txtDescription.Text;
                objDefects.DefectTypeId = Convert.ToInt32(ddlDefectTypeName.SelectedItem.Value);
                objDefects.EmployeeId = Convert.ToInt32(ddlAssignedTo.SelectedItem.Value);
                objDefects.Status = rblStatus.SelectedItem.Text;
                objDefects.Priority = txtPriority.Text;
                objDefects.InsertDefectDetails();


                Session["UserAccountID"] = HdnLoginUser.Value.ToString();
                Response.Redirect("HomeLogin.aspx");

            }
            else
            {
                Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "myscript", "alert('Confirm Me to Add The Defect!!')", true);

            }


        }

        protected void CancelMe(object sender, EventArgs e)
        {

        }

        protected void ddlProjectName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Projid = Convert.ToInt32(ddlProjectName.SelectedItem.Value);
            string ProjName = ddlProjectName.SelectedItem.Text;
            txtProjectName.Text = ddlProjectName.SelectedItem.Text;

            GetDefectTypeList();
            GetApplicationEmployeeList();

        }
    }
}