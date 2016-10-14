using System;

namespace DevASPNET
{
    public partial class FrmRequest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string strUserId = "";
            string strPassword = String.Empty;
            string strName = "";
            string strAge = String.Empty;

            //[1] Request 객체의 QueryString 컬렉션
            strUserId = Request.QueryString["UserID"];
            //[2] Request 객체의 Params 컬렉션
            strPassword = Request.Params["Password"];
            //[3] Request 객체의 Form 컬렉션
            strName = Request.Form["Name"];
            //[4] Request 객체 자체로 받기
            strAge = Request["Age"];

            string strMsg = String.Format(
                "입력하신 아이디는 {0}이고<br />"
                + "암호는 {1}입니다.<br />"
                + "이름은 {2}이고,<br />"
                + "나이는 {3}살 입니다.<br />",
                strUserId, strPassword,
                strName, strAge);

            Response.Write(strMsg);
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // ASP.NET에서는 Request개체 보다는
            // 컨트롤의 속성을 사용해서 값은 받는다.
            string name = Name.Text; //
            int age = Convert.ToInt16(Age.Text); //
        }
    }
}