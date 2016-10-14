using DevUser.Repositories;
using System;
using System.Web.UI;

namespace DevUser
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            // 데이터 저장
            var userRepo = new UserRepository();
            userRepo.AddUser(txtUserID.Text, txtPassword.Text);

            // 메시지 박스 출력 후 기본 페이지로 이동
            string strJs =
                "<script>alert('가입완료');location.href='Default.aspx';</script>";
            Page.ClientScript.RegisterClientScriptBlock(
                this.GetType(), "goDefault", strJs);
        }
    }
}