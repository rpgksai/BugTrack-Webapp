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
    public partial class UserRegistration : System.Web.UI.UserControl
    {

        clsLogin objLogin = new clsLogin();
       // clsUserDetails objclsUserDetails = new clsUserDetails();
        //   int No;
        clsUserDetails objUserDetails = new clsUserDetails();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    txtFName.Focus();
                    GetRoleList();
                    
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
                lblMsg.Visible = true;
            }
            
        }

        // To Insert New Emp Details
        public void InsertUserDetails()
        {
            if (txtUserName.Text.Length != 0)
            {
                objUserDetails.FirstName = txtFName.Text.Trim();
                objUserDetails.LastName = txtLName.Text.Trim();
                objUserDetails.Gender = rblGender.SelectedItem.Text;
                objUserDetails.Qualification = txtQualification.Text.Trim();
                objUserDetails.DateOfJoin = GMDate.DateString;
                objUserDetails.Desgination = txtDesignation.Text.Trim();
                objUserDetails.Address = txtAddress.Text;
                objUserDetails.EmailId = txtEmail.Text;
                objUserDetails.ContactNo = txtContactNo.Text;
                objUserDetails.UserName = txtUserName.Text.Trim();
                objUserDetails.PassWord = txtPassword.Text.Trim();
                objUserDetails.RoleId = Convert.ToInt32(ddlRole.SelectedItem.Value);
                objUserDetails.InserUserDetails();
            }
            else
            {
                 Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "myscript", "alert('Enter UserName First!!')", true);

            }
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                CheckAvailableUserName();
                InsertUserDetails();
                Response.Redirect("UserRegistrationSS.aspx");
            }
            catch (Exception ex)
            {
                lblMsg.Visible = true;
                lblMsg.Text = ex.Message;

            }
        }


        //Get All employee Roles in dropdown
        public void GetRoleList()
        {
            DataSet dsEmpLists = objUserDetails.UserRoleDetails();
            if (dsEmpLists.Tables[0].Rows.Count > 0)
            {

                ddlRole.DataTextField = dsEmpLists.Tables[0].Columns["RoleName"].ToString(); // text field name of table dispalyed in dropdown
                ddlRole.DataValueField = dsEmpLists.Tables[0].Columns["RoleId"].ToString();             // to retrive specific  textfield name 
                ddlRole.DataSource = dsEmpLists.Tables[0];      //assigning datasource to the dropdownlist
                ddlRole.DataBind();  //binding dropdownlist
                ddlRole.Items.Insert(0, new ListItem("--Select--", "0"));
            }


        }

        // To chck the EMp Username already exist
        public void CheckAvailableUserName()
        {
            if (txtUserName.Text.Length != 0)
            {
                objUserDetails.UserName = txtUserName.Text.Trim();
                bool found;

                found = objUserDetails.CheckAvailableUserName();
                if (found == true)
                {
                    Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "myscript", "alert('UserExists/TryAnother!')", true);
                    txtUserName.Text = "";
                    txtUserName.Focus();
                }
                else
                {
                    Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "myscript", "alert('UserName Available')", true);
                    txtPassword.Focus();

                }


            }
            else
            {
                Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "myscript", "alert('Enter UserName First!!')", true);
                            }

        }
        protected void lbCheck_Click(object sender, EventArgs e)
        {
            try
            {
                CheckAvailableUserName();
            }
            catch (Exception ex)
            {
                lblMsg.Visible = true;
                lblMsg.Text = ex.Message;

            }

        }
        public void Clear()
        {
            lblMsg.Text = "";
            txtFName.Text = "";
            txtLName.Text = "";
            txtQualification.Text = "";
            txtDesignation.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = ""; ;
            txtContactNo.Text = ""; ;
            txtUserName.Text = "";
            txtPassword.Text = ""; ;
            ddlRole.SelectedIndex = 0;
           
        }
        protected void btnClear_Click(object sender, EventArgs e)
        {
            try
            {

                //Clear();
                Response.Redirect("AdminHomePage.aspx");
            }
            catch (Exception ex)
            {
                lblMsg.Visible = true;
                lblMsg.Text = ex.Message;

            }
        }

    }
}