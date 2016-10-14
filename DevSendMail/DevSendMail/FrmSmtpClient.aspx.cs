using System;

namespace DevSendMail
{
    public partial class FrmSmtpClient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSendMail_Click(object sender, EventArgs e)
        {
            // 가장 간단하게 메일 전송
            System.Net.Mail.SmtpClient objMail =
              new System.Net.Mail.SmtpClient();
            objMail.Send(
              "youremail@yourdomain.com"     // 보내는 이
              , "youremail@yourdomain.com"   // 받는 이
              , "메일 보내기 테스트"      // 제목
              , "안녕하세요..."          // 내용
            );
        }
    }
}