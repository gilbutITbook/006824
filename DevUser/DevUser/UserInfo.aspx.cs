using DevUser.Repositories;
using System;
using System.Web.UI;

namespace DevUser
{
    public partial class UserInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.User.Identity.IsAuthenticated)
            {
                Response.Redirect("~/Login.aspx");
            }

            if (!Page.IsPostBack)
            {
                DisplayData();
            }
        }

        private void DisplayData()
        {
            UserRepository userRepo = new UserRepository();
            var model = userRepo.GetUserByUserId(Page.User.Identity.Name);

            lblUID.Text = model.Id.ToString();
            txtUserID.Text = model.UserId;
            txtPassword.Text = model.Password; 
        }

        protected void btnModify_Click(object sender, EventArgs e)
        {
            // 데이터 수정
            var userRepo = new UserRepository();
            userRepo.ModifyUser(
                Convert.ToInt32(lblUID.Text), txtUserID.Text, txtPassword.Text);

            // 메시지 박스 출력 후 기본 페이지로 이동
            string strJs =
            "<script>alert('수정완료');location.href='Default.aspx';</script>";
            Page.ClientScript.RegisterClientScriptBlock(
                this.GetType(), "goDefault", strJs);
        }
    }
}