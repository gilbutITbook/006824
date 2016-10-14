using System;

namespace DevUser
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //[!] 로그아웃
            System.Web.Security.FormsAuthentication.SignOut();

            Response.Redirect("~/Default.aspx");
        }
    }
}
