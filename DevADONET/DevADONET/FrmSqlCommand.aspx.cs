using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DevADONET
{
    public partial class FrmSqlCommand : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSqlCommand_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings[
                    "ConnectionString"].ConnectionString;
            con.Open();

            //[1] SqlCommand의 인스턴스 생성
            SqlCommand cmd = new SqlCommand();
            //[2] Connection 속성 지정
            cmd.Connection = con;
            //[3] CommandText 속성 설정
            cmd.CommandText = @"
                Insert Into Memos 
                Values(
                N'홍길동', N'h@h.com', N'홍길동입니다.', GetDate(), '127.0.0.1')
            ";
            //[4] CommandType 속성 지정
            cmd.CommandType = CommandType.Text;
            //[5] ExecuteXXX() 메서드로 실행
            cmd.ExecuteNonQuery();
            //[6] 마무리
            lblDisplay.Text = "데이터 저장 완료";

            con.Close(); 
        }
    }
}
