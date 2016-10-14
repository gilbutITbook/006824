using System;
using System.Drawing;

namespace MemoEngine.DotNetNote
{
    public partial class ImageText : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //[1] 비트맵 이미지 생성
            Bitmap objBitmap = new Bitmap(80, 20);
            Graphics objGraphics = Graphics.FromImage(objBitmap);
            objGraphics.Clear(Color.White);
            objGraphics.SmoothingMode =
                System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            objGraphics.TextRenderingHint =
                System.Drawing.Text.TextRenderingHint.AntiAlias;

            //[2] 랜덤하게 4개의 문자 생성 : 영문 대문자, 정수, 영문 소문자, 정수
            Random random = new Random();
            char c1 = (char)random.Next(65, 90);
            char c2 = (char)random.Next(48, 57);
            char c3 = (char)random.Next(97, 122);
            char c4 = (char)random.Next(48, 57);

            //[3] 입력 페이지에서 비교를 위해서 세션 변수에 담기
            Session["ImageText"] = $"{c1}{c2}{c3}{c4}";

            //[4] 사각형 비트맵 이미지에 4개의 문자 기록
            objGraphics.DrawString(c1.ToString(),
                new Font("Verdana", 12, FontStyle.Bold),
                Brushes.DarkBlue, new PointF(5, 1));
            objGraphics.DrawString(c2.ToString(),
                new Font("Arial", 11, FontStyle.Italic),
                Brushes.DarkBlue, new PointF(25, 1));
            objGraphics.DrawString(c3.ToString(),
                new Font("Verdana", 11, FontStyle.Regular),
                Brushes.DarkBlue, new PointF(45, 1));
            objGraphics.DrawString(c4.ToString(),
                new Font("Arial", 12, FontStyle.Underline),
                Brushes.DarkBlue, new PointF(65, 1));

            //[5] 비트맵 이미지 출력
            Response.ContentType = "image/gif";
            objBitmap.Save(
                Response.OutputStream, System.Drawing.Imaging.ImageFormat.Gif);

            //[6] 메모리 정리
            objBitmap.Dispose();
            objGraphics.Dispose();
        }
    }
}