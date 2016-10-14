using System;
using System.Web.UI.WebControls;

namespace DevStandardControl
{
    public partial class FrmPlaceHolder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //[1] 버튼 개체 하나 생성
            Button btn1 = new Button();
            btn1.ID = "btn1";
            btn1.Text = "버튼 1";
            btn1.Click += btn_Click;
            //[2] PlaceHolder에 프로그래밍 방식으로 버튼 추가
            ctlPlaceHolder.Controls.Add(btn1);

            Literal ltr = new Literal();
            ltr.Text = "<br />";
            ctlPlaceHolder.Controls.Add(ltr);

            Button btn2 = new Button();
            btn2.ID = "btn2";
            btn2.Text = "버튼 2";
            btn2.Click += btn_Click;
            ctlPlaceHolder.Controls.Add(btn2);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = 
                (sender as Button).Text + " 버튼이 클릭되었습니다.<br />";

            Button btnCurrent = sender as Button;
            lblDisplay.Text += btnCurrent.ID + " 버튼입니다.<br />";

            // 부모 컨트롤(컨테이너)로부터 자식 컨트롤 읽어오는 교과서다운 코드
            lblDisplay.Text += 
                ((Button)ctlPlaceHolder.FindControl(btnCurrent.ID)).Text 
                + " 버튼이겠죠?";
        }
    }
}
