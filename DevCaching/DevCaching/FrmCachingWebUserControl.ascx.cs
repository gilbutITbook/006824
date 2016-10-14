using System;

namespace DevCaching
{
    public partial class FrmCachingWebUserControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 현재 시간 출력: 5초에 한번씩만 출력
            lblTimeWebUserControl.Text = DateTime.Now.ToString();
        }
    }
}
