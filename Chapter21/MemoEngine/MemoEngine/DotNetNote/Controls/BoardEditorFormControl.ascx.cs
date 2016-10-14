using DotNetNote.Models;
using Dul;
using System;
using System.IO;

namespace MemoEngine.DotNetNote.Controls
{
    public partial class BoardEditorFormControl : System.Web.UI.UserControl
    {
        /// <summary>
        ///  공통 속성
        /// </summary>
        public BoardWriteFormType FormType { get; set; }

        private string _Id;//앞(리스트)에서 넘겨져 온 번호 저장

        private string _BaseDir = String.Empty;//파일 업로드 폴더
        private string _FileName = String.Empty;//파일명 저장 필드
        private int _FileSize = 0;//파일크기 저장 필드

        protected void Page_Load(object sender, EventArgs e)
        {
            _Id = Request.QueryString["Id"];

            if (!Page.IsPostBack) // 처음 로드할 때에만 바인딩
            {
                switch (FormType)
                {
                    case BoardWriteFormType.Write:
                        lblTitleDescription.Text = 
                            "글 쓰기 - 다음 필드들을 채워주세요.";
                        break;
                    case BoardWriteFormType.Modify:
                        lblTitleDescription.Text = 
                            "글 수정 - 아래 항목을 수정하세요.";
                        DisplayDataForModify();
                        break;
                    case BoardWriteFormType.Reply:
                        lblTitleDescription.Text = 
                            "글 답변 - 다음 필드들을 채워주세요.";
                        DisplayDataForReply();
                        break;
                }
            }
        }

        private void DisplayDataForModify()
        {
            // 넘겨온 Id 값에 해당하는 레코드 하나 읽어서 Note 클래스에 바인딩
            var note = (new NoteRepository()).GetNoteById(Convert.ToInt32(_Id));

            txtName.Text = note.Name;
            txtEmail.Text = note.Email;
            txtHomepage.Text = note.Homepage;
            txtTitle.Text = note.Title;
            txtContent.Text = note.Content;

            // 인코딩 방식에 따른 데이터 출력
            string strEncoding = note.Encoding;
            if (strEncoding == "Text") // Text : 소스 그대로 표현
            {
                rdoEncoding.SelectedIndex = 0;
            }
            else if (strEncoding == "Mixed") // Mixed : 엔터처리만
            {
                rdoEncoding.SelectedIndex = 2;
            }
            else // HTML : HTML 형식으로 출력
            {
                rdoEncoding.SelectedIndex = 1;
            }

            // 첨부된 파일명 및 파일크기 기록
            if (note.FileName.Length > 1)
            {
                ViewState["FileName"] = note.FileName;
                ViewState["FileSize"] = note.FileSize;

                pnlFile.Height = 50;
                lblFileNamePrevious.Visible = true;
                lblFileNamePrevious.Text = 
                    $"기존에 업로드된 파일명: {note.FileName}";
            }
            else
            {
                ViewState["FileName"] = "";
                ViewState["FileSize"] = 0;
            }
        }

        private void DisplayDataForReply()
        {
            // 넘겨온 Id 값에 해당하는 레코드 하나 읽어서 Note 클래스에 바인딩
            var note = (new NoteRepository()).GetNoteById(Convert.ToInt32(_Id));

            txtTitle.Text = $"Re : {note.Title}";
            txtContent.Text = 
                $"\n\nOn {note.PostDate}, '{note.Name}' wrote:\n----------\n>" 
                + $"{note.Content.Replace("\n", "\n>")}\n---------";
        }

        protected void btnWrite_Click(object sender, EventArgs e)
        {
            // 보안 문자를 정확히 입력했거나, 로그인이 된 상태라면...
            if (IsImageTextCorrect())
            {
                UploadProcess(); // 파일 업로드 관련 코드 분리

                Note note = new Note();

                note.Id = Convert.ToInt32(_Id);

                note.Name = txtName.Text;
                note.Email = HtmlUtility.Encode(txtEmail.Text);
                note.Homepage = txtHomepage.Text;
                note.Title = HtmlUtility.Encode(txtTitle.Text);
                note.Content = txtContent.Text;
                note.FileName = _FileName;
                note.FileSize = _FileSize;
                note.Password = txtPassword.Text;
                note.PostIp = Request.UserHostAddress;
                note.Encoding = rdoEncoding.SelectedValue;

                NoteRepository repository = new NoteRepository();

                switch (FormType)
                {
                    case BoardWriteFormType.Write:
                        repository.Add(note);
                        Response.Redirect("BoardList.aspx");
                        break;
                    case BoardWriteFormType.Modify:
                        note.ModifyIp = Request.UserHostAddress;
                        note.FileName = ViewState["FileName"].ToString();
                        note.FileSize = Convert.ToInt32(ViewState["FileSize"]);
                        int r = repository.UpdateNote(note);
                        if (r > 0) // 업데이트 완료
                        {
                            Response.Redirect($"BoardView.aspx?Id={_Id}");
                        }
                        else
                        {
                            lblError.Text = 
                                "업데이트가 되지 않았습니다. 암호를 확인하세요.";
                        }
                        break;
                    case BoardWriteFormType.Reply:
                        note.ParentNum = Convert.ToInt32(_Id);
                        repository.ReplyNote(note);
                        Response.Redirect("BoardList.aspx");
                        break;
                    default:
                        repository.Add(note);
                        Response.Redirect("BoardList.aspx");
                        break;
                }
            }
            else
            {
                lblError.Text = "보안코드가 틀립니다. 다시 입력하세요.";
            }
        }

        private void UploadProcess()
        {
            //파일 업로드 처리 시작
            _BaseDir = Server.MapPath("./MyFiles");
            _FileName = String.Empty;
            _FileSize = 0;
            if (txtFileName.PostedFile != null)
            {
                if (txtFileName.PostedFile.FileName.Trim().Length > 0 
                    && txtFileName.PostedFile.ContentLength > 0)
                {
                    if (FormType == BoardWriteFormType.Modify)
                    {
                        ViewState["FileName"] = 
                            FileUtility.GetFileNameWithNumbering(
                                _BaseDir, Path.GetFileName(
                                    txtFileName.PostedFile.FileName));
                        ViewState["FileSize"] = 
                            txtFileName.PostedFile.ContentLength;
                        //업로드 처리 : SaveAs()
                        txtFileName.PostedFile.SaveAs(
                            Path.Combine(_BaseDir, 
                                ViewState["FileName"].ToString()));
                    }
                    else // BoardWrite, BoardReply
                    {
                        _FileName = 
                            FileUtility.GetFileNameWithNumbering(
                                _BaseDir, 
                                    Path.GetFileName(
                                        txtFileName.PostedFile.FileName));
                        _FileSize = txtFileName.PostedFile.ContentLength;
                        //업로드 처리 : SaveAs()
                        txtFileName.PostedFile.SaveAs(
                            Path.Combine(_BaseDir, _FileName));
                    }
                }
            }//파일 업로드 처리 끝
        }

        /// <summary>
        /// 로그인하였거나, 이미지 텍스트를 정상적으로 입력하면 true 값 반환
        /// </summary>
        private bool IsImageTextCorrect()
        {
            if (Page.User.Identity.IsAuthenticated)
            {
                return true;
            }
            else
            {
                if (Session["ImageText"] != null)
                {
                    return (txtImageText.Text == Session["ImageText"].ToString());
                }
            }
            return false; // 보안 코드를 통과하지 못함
        }

        // 파일 첨부 레이어 보이기/감추기
        protected void chkUpload_CheckedChanged(object sender, EventArgs e)
        {
            pnlFile.Visible = !pnlFile.Visible;
        }
    }
}
