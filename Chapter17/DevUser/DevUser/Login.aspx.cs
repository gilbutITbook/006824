using DevUser.Repositories;
using System;
using System.Web.Security;
using System.Web.UI;

namespace DevUser
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            var userRepo = new UserRepository();
            if (userRepo.IsCorrectUser(txtUserID.Text, txtPassword.Text))
            {
                //[!] 인증 부여
                if (!String.IsNullOrEmpty(Request.QueryString["ReturnUrl"]))
                {
                    // 인증 쿠키값 부여
                    FormsAuthentication.RedirectFromLoginPage(txtUserID.Text, false);
                }
                else
                {
                    // 인증 쿠키값 부여
                    FormsAuthentication.SetAuthCookie(txtUserID.Text, false); 
                    Response.Redirect("~/Welcome.aspx");
                }
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(
                    this.GetType(), "showMsg", 
                    "<script>alert('잘못된 사용자입니다.');</script>");
            }
        }
    }
}