using System;

namespace DevCounter
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            //[1] 사이트 통계 1/3
            Application["CurrentVisit"] = 0; // 현재 사용자
        }
        protected void Session_Start(object sender, EventArgs e)
        {
            //[2] 사이트 통계 2/3
            Application.Lock();
            Application["CurrentVisit"] =
                Convert.ToInt32(Application["CurrentVisit"]) + 1; // 현재 사용자
            Application.UnLock();
        }
        protected void Session_End(object sender, EventArgs e)
        {
            //[3] 사이트 통계 3/3
            Application.Lock();
            Application["CurrentVisit"] =
                  (int)Application["CurrentVisit"] - 1; // 현재 사용자
            Application.UnLock();
        }
        protected void Application_End(object sender, EventArgs e)
        {
            // Empty
        }
    }
}
