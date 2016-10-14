using DotNetNote.Models;
using System;

namespace MemoEngine.DotNetNote
{
    public partial class BoardDelete : System.Web.UI.Page
    {
        private string _Id;
        protected void Page_Load(object sender, EventArgs e)
        {
            _Id = Request.QueryString["Id"];
            lnkCancel.NavigateUrl = "BoardView.aspx?Id=" + _Id;
            lblId.Text = _Id;

            // 버튼의 OnClientClick 속성 지정 방식과 동일
            btnDelete.Attributes["onclick"] = "return ConfirmDelete();";

            if (String.IsNullOrEmpty(_Id))
            {
                Response.Redirect("BoardList.aspx");
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            // 현재 글(Id)의 비밀번호가 맞으면 삭제
            if ((new NoteRepository()).DeleteNote(
                Convert.ToInt32(_Id), txtPassword.Text) > 0)
            {
                Response.Redirect("BoardList.aspx");
            }
            else
            {
                lblMessage.Text = "삭제되지 않았습니다. 비밀번호를 확인하세요.";
            }
        }
    }
}