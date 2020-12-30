using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;




namespace BugTrackApplication.UserControls
{
    public partial class LoginUserControl : System.Web.UI.UserControl
    {

        clsLogin objLogin = new clsLogin();
        int No;

        protected void Page_Load(object sender, EventArgs e)
        {
            //Session["UserName"] = ;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
                vaidateLogin();
        }

        public void vaidateLogin()
        {

            objLogin.LoginName = txtLoginName.Text;
            objLogin.Password = txtPassword.Text;

            No = objLogin.LoginValidate();
            if(No > 0)
            {
                Session["UserAccountId"] = objLogin.UserAccountId.ToString();
                Response.Redirect("HomeLogin.aspx");

            }
            else
            {
                Response.Redirect("contact.aspx");
            }
          
        }

        protected void Registration_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserRegistration.aspx");
        }
    }
}