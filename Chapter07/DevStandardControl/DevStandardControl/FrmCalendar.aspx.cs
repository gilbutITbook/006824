using System;

namespace DevStandardControl
{
    public partial class FrmCalendar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Empty
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            // 선택된 날짜를 출력
            Response.Write(Calendar1.SelectedDate.ToShortDateString() + "<hr />");
        }
    }
}