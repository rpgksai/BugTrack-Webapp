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
    public partial class EditUserDefects : System.Web.UI.UserControl
    {
        clsDefects objDefects = new clsDefects();
        clsLogin objLogin = new clsLogin();
        DataTable dt = new DataTable();
        public string AssignedValue;

        protected void Page_Load(object sender, EventArgs e)
        {
           
            try
            {
                if (!IsPostBack)
                {
                    HdnLoginUser.Value = Session["UserAccountID"].ToString();
                    HdnDefectID.Value = Request["DefectId"].ToString();
                    GetDefectTypeList();
                    GetEmployeeList();
                    GetEmployeeDets();
                    GetDefectDescription();
                   
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
                lblMsg.Visible = true;
            }

           
        }



       //Get All employee in dropdown
       public void GetEmployeeList()
        {
            DataSet dsEmpLists = objLogin.GetAllEmpDetails();
             if (dsEmpLists.Tables[0].Rows.Count > 0)
            {

                ddlAssignedTo.DataTextField = dsEmpLists.Tables[0].Columns["FullName"].ToString(); // text field name of table dispalyed in dropdown
                ddlAssignedTo.DataValueField = dsEmpLists.Tables[0].Columns["Empid"].ToString();             // to retrive specific  textfield name 
                ddlAssignedTo.DataSource = dsEmpLists.Tables[0];      //assigning datasource to the dropdownlist
                ddlAssignedTo.DataBind();  //binding dropdownlist

            ddlAssignedTo.Items.Insert(0, new ListItem("--Select--", "0"));
            }


        }

        public void GetEmployeeDets()
        {
            objLogin.UserAccountId = Session["UserAccountID"].ToString();
            DataSet dsEmpReports = objLogin.GetEmployeeDetails();
            if (dsEmpReports.Tables[0].Rows.Count > 0)
            {
                LblLoginUser.Text = dsEmpReports.Tables[0].Rows[0]["FirstName"].ToString() +  " " + dsEmpReports.Tables[0].Rows[0]["LastName"].ToString();
                txtUserName.Text = LblLoginUser.Text;
             }



        }

        // Get particular defects list
        public void GetDefectDescription()
        {
            objDefects.DefectId = Convert.ToInt32(Request["DefectId"].ToString());
            DataSet dsReports = objDefects.GetDefectDescription();
            if (dsReports.Tables[0].Rows.Count > 0)
            {
                DataRow dr = dsReports.Tables[0].Rows[0];
                txtUserId.Text = dsReports.Tables[0].Rows[0]["UserAccountId"].ToString();
                txtProjectName.Text = dsReports.Tables[0].Rows[0]["Title"].ToString();
                txtModuleName.Text= dsReports.Tables[0].Rows[0]["ModuleName"].ToString();
                txtDefectName.Text = dsReports.Tables[0].Rows[0]["DefectName"].ToString();
                ddlDefectTypeName.DataTextField = dsReports.Tables[0].Columns["DefectTypeName"].ToString();
               // ddlDefectTypeName.DataValueField = dsReports.Tables[0].Columns["DefectTypeName"].ToString();
                ddlDefectTypeName.DataBind();
                txtPriority.Text = dsReports.Tables[0].Rows[0]["Priority"].ToString();
                TxtAssignedTo.Text = dsReports.Tables[0].Rows[0]["FirstName"].ToString() + " " + dsReports.Tables[0].Rows[0]["LastName"].ToString(); 
                txtDescription.Text= dsReports.Tables[0].Rows[0]["Description"].ToString();
                TxtAssignedDate.Text = dsReports.Tables[0].Rows[0]["SendingDate"].ToString();

                HdnProjectId.Value = dsReports.Tables[0].Rows[0]["ProjectId"].ToString();
                HdnDefectTypeId.Value = dsReports.Tables[0].Rows[0]["DefectTypeId"].ToString();
                HdnEmployeeId.Value = dsReports.Tables[0].Rows[0]["EmpId"].ToString();
                // ddlAssignedTo.Visible = false;
                dt = dsReports.Tables[0];
           
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


        protected void ddlAssignedTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtAssignedTo.Text = ddlAssignedTo.SelectedItem.Text;
             AssignedValue = ddlAssignedTo.SelectedItem.Value;
        }

        //User will Edit the defects
        protected void EditDefect_Click(object sender, EventArgs e)
        {

            try
            {
                objDefects.DefectId = Convert.ToInt32(HdnDefectID.Value);
                objDefects.DefectName = txtDefectName.Text;
                objDefects.UserAccountId = Convert.ToInt32(HdnLoginUser.Value);
                objDefects.ProjectNo = HdnProjectId.Value.ToString();
                objDefects.ModuleName = txtModuleName.Text;
                objDefects.Description = txtDescription.Text;
                objDefects.DefectTypeId = Convert.ToInt32(ddlDefectTypeName.SelectedItem.Value);
                objDefects.EmpId = HdnEmployeeId.Value.ToString();
                objDefects.Status = rblStatus.SelectedItem.Value.ToString();
                objDefects.Priority = txtPriority.Text;
                objDefects.UpdateDefectReport();

                Session["UserAccountID"] = HdnLoginUser.Value.ToString();
                Response.Redirect("AdminHomePage.aspx");

            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
                lblMsg.Visible = true;
            }

        }

        protected void CancelMe(object sender, EventArgs e)
        {
            Session["UserAccountID"] = HdnLoginUser.Value.ToString();
            Response.Redirect("AdminHomePage.aspx");
        }
    }
}