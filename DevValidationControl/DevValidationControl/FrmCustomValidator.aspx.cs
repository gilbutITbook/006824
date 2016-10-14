using System;
using System.Web.UI.WebControls;

namespace DevValidationControl
{
    public partial class FrmCustomValidator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void valEvenNumber_ServerValidate(
            object source, ServerValidateEventArgs args)
        {
            if (Convert.ToInt32(args.Value) % 2 == 0)
            {
                args.IsValid = true; // 유효성 검사 통과
            }
            else
            {
                args.IsValid = false; // 에러 메시지 출력
            }
        }
    }
}
