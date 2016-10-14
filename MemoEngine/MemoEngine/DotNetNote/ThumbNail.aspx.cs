using System;
using System.Drawing;

namespace MemoEngine.DotNetNote
{
    /// <summary>
    /// ThumbNail : 축소판 이미지 생성기
    /// </summary>
    public partial class ThumbNail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //변수 초기화
            int boxWidth = 100;
            int boxHeight = 100;
            double scale = 0;

            //파일 이름을 설정
            string fileName = String.Empty;
            string selectedFile = String.Empty;

            if (Request["FileName"] != null)
            {
                selectedFile = Request.QueryString["FileName"];
                fileName = Server.MapPath("./MyFiles/" + selectedFile);
            }
            else
            {
                selectedFile = "/images/dnn/img.jpg";//기본 이미지로 초기화
                fileName = Server.MapPath("/images/dnn/img.jpg");
            }

            int tmpW = 0;
            int tmpH = 0;

            if (Request.QueryString["Width"] != null 
                && Request.QueryString["Height"] != null)
            {
                tmpW = Convert.ToInt32(Request.QueryString["Width"]);
                tmpH = Convert.ToInt32(Request.QueryString["Height"]);
            }

            if (tmpW > 0 && tmpH > 0)
            {
                boxWidth = tmpW;
                boxHeight = tmpH;
            }

            //새 이미지 생성
            Bitmap b = new Bitmap(fileName);

            //크기 비율을 계산한다.
            if (b.Height < b.Width)
            {
                scale = ((double)boxHeight) / b.Width;
            }
            else
            {
                scale = ((double)boxWidth) / b.Height;
            }

            //새 너비와 높이를 설정한다.
            int newWidth = (int)(scale * b.Width);
            int newHeight = (int)(scale * b.Height);

            //출력 비트맵을 생성, 출력한다.
            Bitmap bOut = new Bitmap(b, newWidth, newHeight);
            bOut.Save(Response.OutputStream, b.RawFormat);

            //마무리
            b.Dispose();
            bOut.Dispose();
        }
    }
}