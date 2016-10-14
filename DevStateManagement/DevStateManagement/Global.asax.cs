using System;

namespace DevStateManagement
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            // 응용 프로그램이 시작될 때 실행되는 코드입니다.
            Application["Now"] = DateTime.Now;
        }
        protected void Session_Start(object sender, EventArgs e)
        {
            // 새 세션이 시작할 때 실행되는 코드입니다.
            Session["Now"] = DateTime.Now;
        }
        protected void Session_End(object sender, EventArgs e)
        {
            // 새 세션이 끝날 때 실행되는 코드입니다. 
            // 참고: Web.config 파일에서 
            // sessionstate 모드가 InProc로 설정되어 있는 경우에만
            // Session_End 이벤트가 발생합니다. 
            // 세션 모드가 StateServer 또는 SQLServer로 
            // 설정되어 있는 경우에는 이 이벤트가 발생하지 않습니다.
        }
        protected void Application_End(object sender, EventArgs e)
        {
            //  응용 프로그램이 종료될 때 실행되는 코드입니다.
        }
        protected void Application_Error(object sender, EventArgs e)
        {
            // 처리되지 않은 오류가 발생할 때 실행되는 코드입니다.
        }
    }
}
