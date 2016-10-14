using System;

namespace DevStateManagement
{
    public partial class FrmStateShow : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.txtApplication.Text = Application["Now"].ToString();

            this.txtSession.Text = Session["Now"].ToString();

            if (Cache["Now"] != null)
            {
                this.txtCache.Text = Cache["Now"].ToString();
            }

            if (Request.Cookies["Now"] != null)
            {
                this.txtCookies.Text = 
                    Server.UrlDecode(Request.Cookies["Now"].Value);
            }

            // 뷰 상태 개체는 해당 페이지에서만 살아있는 변수이다.
            if (ViewState["Now"] != null)
            {
                this.txtViewState.Text = ViewState["Now"].ToString();
            }
        }
    }
}