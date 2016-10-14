using System;

namespace DevStandardControl
{
    public partial class FrmStandardControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnHtml.Value = "HTML 서버 컨트롤 - 버튼";
            btnServer.Text = "표준 컨트롤 - 버튼";
        }
    }
}