using System;

namespace DevStandardControl
{
    public partial class FrmFileUpload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Empty
        }
        protected void btnUpload_Click(object sender, EventArgs e)
        {
            //[1] 파일이 첨부되었다면
            if (ctlFileUpload.HasFile)
            {
                //[2] App_Data 폴더로 파일 업로드
                ctlFileUpload.SaveAs(Server.MapPath(".")
                  + "\\files\\" + ctlFileUpload.FileName);
                //[3] 다운로드 링크 만들기
                lblResult.Text = String.Format("<a href='{0}{1}'>{1}</a>"
                  , "./files/"
                  , Server.UrlEncode(ctlFileUpload.FileName));
            }
        }
    }
}