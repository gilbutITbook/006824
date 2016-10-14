using System;
using System.Configuration;
using System.Data.SqlClient;
using DevADONET.Models;

namespace DevADONET
{
    public partial class FrmMemoWrite : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnWrite_Click(object sender, EventArgs e)
        {
            //[0] 변수 선언부
            Memo memo = new Memo();
            memo.Name = txtName.Text;
            memo.Email = txtEmail.Text;
            memo.Title = txtTitle.Text;
            memo.PostDate = DateTime.Now;
            memo.PostIp = Request.UserHostAddress;
            //[1] 커넥션
            SqlConnection con = new SqlConnection(ConfigurationManager
                .ConnectionStrings["ConnectionString"].ConnectionString);
            con.Open();
            //[2] 커멘드
            SqlCommand cmd = new SqlCommand("WriteMemo", con);
            //cmd.Connection = con;
            //cmd.CommandText = "WriteMemo";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //[!] 파라미터 추가
            cmd.Parameters.AddWithValue("@Name", memo.Name);
            cmd.Parameters.AddWithValue("@Email", memo.Email);
            cmd.Parameters.AddWithValue("@Title", memo.Title);
            cmd.Parameters.AddWithValue("@PostIP", memo.PostIp);
            //[!] 실행
            cmd.ExecuteNonQuery(); 
            //[3] 마무리
            con.Close();
            lblDisplay.Text = "저장되었습니다.";
        }

        protected void btnList_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmMemoList.aspx");
        }
    }
}
