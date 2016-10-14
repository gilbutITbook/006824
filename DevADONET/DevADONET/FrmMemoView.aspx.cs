using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DevADONET
{
    public partial class FrmMemoView : System.Web.UI.Page
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
                DisplayData();
                lnkMemoModify.NavigateUrl = 
                    $"FrmMemoModify.aspx?Num={Request["Num"]}";
                lnkMemoDelete.NavigateUrl = 
                    $"FrmMemoDelete.aspx?Num={Request["Num"]}";
            }
        }

        private void DisplayData()
        {
            //[1] 커넥션
            SqlConnection con = new SqlConnection(ConfigurationManager
                .ConnectionStrings["ConnectionString"].ConnectionString);
            con.Open();
            //[2] 커멘드
            SqlCommand cmd = new SqlCommand("ViewMemo", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //[!] 파라미터 추가
            cmd.Parameters.Add("Num", SqlDbType.Int); // 정수형
            cmd.Parameters["Num"].Value = Convert.ToInt32(Request["Num"]);
            //[3] 데이터리더
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                //[!] 각각의 컨트롤에 바인딩
                this.lblNum.Text = Request["Num"];
                this.lblName.Text = dr["Name"].ToString();
                this.lblEmail.Text = dr[2].ToString();
                this.lblTitle.Text = dr.GetString(3);
                this.lblPostDate.Text = dr.GetDateTime(4).ToString();
                this.lblPostIP.Text = dr.GetString(5);
            }
            else
            {
                Response.Write("없는 데이터입니다.");
                Response.End();
            }
            //[4] 마무리
            dr.Close();
            con.Close(); 
        }
    }
}