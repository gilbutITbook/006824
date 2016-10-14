using System;

namespace DevCounter
{
    public partial class FrmCounter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 현재 접속자 수 표시
            lblNow.Text = Application["CurrentVisit"].ToString();
        }
    }
}
