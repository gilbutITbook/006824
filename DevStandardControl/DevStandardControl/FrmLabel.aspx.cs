using System;

namespace DevStandardControl
{
    public partial class FrmLabel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 레이블에 현재 날짜와 시간을 출력
            this.lblDateTime.Text = DateTime.Now.ToString();
        }
    }
}