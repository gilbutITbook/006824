using System;
using System.Net;
using System.Net.Mail;

namespace DevSendMail
{
    public partial class FrmSendEmailWithMicrosoftEmail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Empty
        }

        protected void btnSendEmail_Click(object sender, EventArgs e)
        {
            SmtpClient SmtpServer = new SmtpClient("smtp.live.com");
            var mail = new MailMessage();
            mail.From = new MailAddress("youremail@yourdomain");
            mail.To.Add("youremail@yourdomain");
            mail.Subject = "메일 보내기 테스트";
            mail.IsBodyHtml = true;
            string htmlBody;
            htmlBody = "안녕하세요. <em>아웃룩</em> 메일 보내기 테스트입니다.";
            mail.Body = htmlBody;
            SmtpServer.Port = 587;
            SmtpServer.UseDefaultCredentials = false;
            SmtpServer.Credentials = 
                new NetworkCredential("youremail@yourdomain", "password");
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mail);
        }
    }
}