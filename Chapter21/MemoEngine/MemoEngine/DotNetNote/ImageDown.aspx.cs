using System;
using System.IO;

namespace MemoEngine.DotNetNote
{
    /// <summary>
    /// ImageDown : 완성형(DotNetNote) 게시판의 이미지전용다운 페이지
    /// 이미지 경로를 보여주지 않고 다운로드한다.
    /// </summary>
    public partial class ImageDown : System.Web.UI.Page
    {
        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 넘겨온 파일명 체크
            if (String.IsNullOrEmpty(Request.QueryString["FileName"]))
            {
                Response.End();
            }

            string fileName = Request.Params["FileName"].ToString();
            string ext = Path.GetExtension(fileName); // 확장자만 추출
            string contentType = "";
            if (ext == ".gif" || ext == ".jpg" 
                || ext == ".jpeg" || ext == ".png")
            {
                switch (ext)
                {
                    case ".gif":
                        contentType = "image/gif"; break;
                    case ".jpg":
                        contentType = "image/jpeg"; break;
                    case ".jpeg":
                        contentType = "image/jpeg"; break;
                    case ".png":
                        contentType = "image/png"; break;
                }
            }
            else
            {
                Response.Write(
                  "<script language='javascript'>"
                  + "alert('이미지 파일이 아닙니다.')</script>");
                Response.End();
            }
            string file = Server.MapPath("./MyFiles/") + fileName;

            // 강제 다운로드 로직 적용
            Response.Clear();
            Response.ContentType = contentType;
            Response.WriteFile(file);
            Response.End();
        }
    }
}