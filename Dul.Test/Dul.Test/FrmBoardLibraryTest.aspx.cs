using System;

namespace Dul.Test
{
    public partial class FrmBoardLibraryTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnClick_Click(object sender, EventArgs e)
        {
            // 파일 크기에 단위 붙이기
            lblDisplay.Text = Dul.BoardLibrary.ConvertToFileSize(
                    Convert.ToInt32(txtInput.Text));
        }
    }
}
