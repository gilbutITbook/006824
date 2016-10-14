using System;

namespace DevStandardControl
{
    public partial class FrmDropDownList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack && lstJob.Items.Count > 1)
            {
                this.lstJob.SelectedIndex = 1;
            }
        }

        protected void lstJob_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 문자열 변수 선언과 동시 초기화
            string strMsg = String.Empty;
            strMsg =
                lstJob.SelectedItem.Text
                + "을(를) 선택하셨습니다.";
            // 레이블에 현재 선택된 값 출력
            this.lblDisplay.Text = strMsg;
        }
    }
}