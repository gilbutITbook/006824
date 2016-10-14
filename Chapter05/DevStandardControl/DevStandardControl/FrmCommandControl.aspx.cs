using System;
using System.Web.UI;

namespace DevStandardControl
{
    public partial class FrmCommandControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 레이블의 배경색 변경
            this.lblDisplay.ForeColor = System.Drawing.Color.Red;
        }
        protected void btnCommand_Click(object sender, EventArgs e)
        {
            // sender(전달자): 현재 이벤트핸들러를 호출한 객체(이름으로 접근 가능)
            // 버튼 컨트롤인지 링크버튼 컨트롤인지 구분
            if (sender == btnButton)
            {
                this.lblDisplay.Text = "버튼 클릭됨.";
            }
            else if (sender == btnLink)
            {
                this.lblDisplay.Text = "링크버튼 클릭됨.";
            }
        }
        protected void btnImage_Click(object sender, ImageClickEventArgs e)
        {
            // XXXEventArgs 클래스형 매개변수는 현재시점에서 필요한 추가적인 정보 제공
            // 클릭된 이미지의 좌표 출력
            this.lblDisplay.Text = String.Format(
             "이미지 버튼 클릭됨.<br />X좌표:{0}, Y좌표: {1}"
              , e.X, e.Y
            );
            // 해당 이미지의 가로 20픽셀, 세로 20픽셀 이상 클릭하면 이동
            if (e.X > 20 && e.Y > 20) // IE에 최적화
            {
                Response.Redirect("http://dotnetkorea.com/");
            }
        }
    }
}