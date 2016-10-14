using System;
using System.Web.UI;

namespace DevASPNET
{
    public partial class FrmResponseRedirect : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnDotNetKorea_Click(object sender, EventArgs e)
        {
            Response.Redirect(
                "http://www.dotnetkorea.com/");
        }
        protected void btnDevLec_Click(object sender, EventArgs e)
        {
            string strUrl =
                "http://www.devlec.com/";
            Response.Redirect(strUrl);
        }
        protected void btnVisualAcademy_Click(
            object sender, ImageClickEventArgs e)
        {
            string strUrl = String.Format(
                "http://{0}/{1}?{2}={3}"
            , "www.visualacademy.com"
            , "default.htm", "UserID", "RedPlus");
            Response.Redirect(strUrl);
        }
    }
}