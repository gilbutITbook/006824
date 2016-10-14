using System;

namespace DevStandardControl
{
    public partial class FrmLiteral : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 리터럴에 날짜 출력
            ctlDate.Text = DateTime.Now.ToShortDateString();
            // 레이블에 시간 출력
            lblTime.Text = DateTime.Now.ToShortTimeString();
        }
    }
}