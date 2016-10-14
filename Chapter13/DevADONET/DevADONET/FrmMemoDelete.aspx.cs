using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

namespace DevADONET
{
    public partial class FrmMemoDelete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 넘겨온 쿼리스트링 값이 없다면
            if (String.IsNullOrEmpty(Request["Num"]))
            {
                Response.Write("잘못된 요청입니다.");
                Response.End();
            }
            else
            {
                // 처음 로드시만 읽어오고, 수정 버튼 클릭시에는 해당 기능만 구현
                if (!Page.IsPostBack)
                {
                    lblNum.Text = Request["Num"];
                }
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //[1] 커넥션
            SqlConnection con = new SqlConnection(ConfigurationManager
                .ConnectionStrings["ConnectionString"].ConnectionString);
            con.Open();
            //[2] 커멘드
            SqlCommand cmd = new SqlCommand("DeleteMemo", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //[!] 파라미터 추가
            cmd.Parameters.Add("Num", SqlDbType.Int);
            cmd.Parameters["Num"].Value = Convert.ToInt32(Request["Num"]);
            //[!] 실행
            cmd.ExecuteNonQuery();
            //[3] 마무리
            con.Close();
            Response.Redirect("FrmMemoList.aspx");
        }
    }
}
