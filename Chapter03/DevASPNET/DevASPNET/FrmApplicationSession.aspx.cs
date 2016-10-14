using System;

namespace DevASPNET
{
    public partial class FrmApplicationSession : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //[1] Application 변수 1 증가
            if (Application["Count"] == null)
            {
                Application.Lock(); // 먼저 온 사용자가 변수 수정 잠그기
                Application["Count"] = 1; // 응용프로그램 변수 선언 및 초기화
                Application.UnLock(); // 잠금 해제 : 다른 사용자가 사용 가능
            }
            else
            {
                Application["Count"] = (int)Application["Count"] + 1;
            }
            //[2] Session 변수 1 증가
            if (Session["Count"] == null)
            {
                Session["Count"] = 1; // 세션변수 선언과 동시에 1로 초기화
            }
            else
            {
                Session["Count"] = (int)Session["Count"] + 1;
            }
            //[3] 출력
            // 누구나 다 1씩 증가
            this.lblApplication.Text = Application["Count"].ToString();
            // 현재 접속자만 1씩 증가
            this.lblSession.Text = Session["Count"].ToString();
            // 현재 접속자의 고유 접속 번호
            this.lblSessionID.Text = Session.SessionID;
            // 현재 세션의 유지 시간
            this.lblTimeout.Text = Session.Timeout.ToString();
        }
    }
}