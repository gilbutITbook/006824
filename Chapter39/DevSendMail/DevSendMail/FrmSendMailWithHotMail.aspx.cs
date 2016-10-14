using System;
using System.Net;
using System.Net.Mail;

namespace DevSendMail
{
    public partial class FrmSendMailWithHotMail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSendMail_Click(object sender, EventArgs e)
        {
            // MailMessage 클래스를 사용하여 메일 전송 관련 정보 기록
            MailMessage objMail = new MailMessage();

            objMail.From = new MailAddress("youremail@yourdomain");
            objMail.To.Add("youremail@yourdomain");

            objMail.Subject = "라이브메일을 통해서 메일 보내기";
            objMail.Body = "정상적으로 도착했습니다.";
            objMail.SubjectEncoding = System.Text.Encoding.Default;
            objMail.BodyEncoding = System.Text.Encoding.Default;

            // 핫메일 또는 지메일을 통한 메일 전송
            SmtpClient objSend = new SmtpClient("smtp.live.com", 587);
            objSend.Credentials =
                new NetworkCredential(txtUserName.Text, txtPassword.Text);
            objSend.DeliveryMethod = SmtpDeliveryMethod.Network;
            objSend.EnableSsl = true;
            objSend.Send(objMail);

            Response.Write("메일을 전송하였습니다.");
        }
    }
}