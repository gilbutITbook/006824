using System;

namespace DevStateManagement
{
    public partial class FrmButtonClickOnce : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (Session["ClickTime"] != null)
            {
                DateTime originDate = Convert.ToDateTime(Session["ClickTime"]);

                TimeSpan objTs = DateTime.Now - originDate;
                if (objTs.TotalSeconds < 5) // 5초 동안에 한번만 저장 가능
                {
                    lblDisplay.Text = "잠시 대기할게요^^";
                    return;
                }
            }
            Session["ClickTime"] = DateTime.Now; // 재 초기화
            lblDisplay.Text = txtInput.Text; // 저장 로직 실행
        }
    }
}