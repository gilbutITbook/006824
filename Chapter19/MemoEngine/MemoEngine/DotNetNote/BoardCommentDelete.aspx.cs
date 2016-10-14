using DotNetNote.Models;
using System;

namespace MemoEngine.DotNetNote
{
    public partial class BoardCommentDelete : System.Web.UI.Page
    {
        public int BoardId { get; set; } // 게시판 글 번호
        public int Id { get; set; } // 댓글 번호

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["BoardId"] != null && Request.QueryString["Id"] != null)
            {
                BoardId = Convert.ToInt32(Request["BoardId"]);
                Id = Convert.ToInt32(Request["Id"]);
            }
            else
            {
                Response.End();
            }
        }

        protected void btnCommentDelete_Click(object sender, EventArgs e)
        {
            var repo = new NoteCommentRepository();
            if (repo.GetCountBy(BoardId, Id, txtPassword.Text) > 0)
            {
                repo.DeleteNoteComment(BoardId, Id, txtPassword.Text);
                Response.Redirect($"BoardView.aspx?Id={BoardId}");
            }
            else
            {
                lblError.Text = "암호가 틀립니다. 다시 입력해주세요.";
            }
        }
    }
}