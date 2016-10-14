using System;

namespace DevStateManagement
{
    public partial class FrmStateManagement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 처음 로드할 때에만 출력
            if (!Page.IsPostBack)
            {
                // 애플리케이션 변수와 세션 변수는 주로 Global.asax에서 선언
                this.txtApplication.Text = Application["Now"].ToString();
                this.txtSession.Text = Session["Now"].ToString();

                // 저장된 캐시, 쿠키, 뷰상태가 있다면 출력
                if (Cache["Now"] != null)
                {
                    this.txtCache.Text = Cache["Now"].ToString();
                }

                if (Request.Cookies["Now"] != null)
                {
                    this.txtCookies.Text = 
                        Server.UrlDecode(Request.Cookies["Now"].Value);
                }

                if (ViewState["Now"] != null)
                {
                    this.txtViewState.Text = ViewState["Now"].ToString();
                } 
            }
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            // 각각의 상태 변수에 데이터 저장
            Application["Now"] = this.txtApplication.Text;
            Session["Now"] = this.txtSession.Text;
            Cache["Now"] = this.txtCache.Text;
            Response.Cookies["Now"].Value = Server.UrlEncode(txtCookies.Text);
            ViewState["Now"] = this.txtViewState.Text;
            Response.Redirect("FrmStateShow.aspx");
        }
    }
}
