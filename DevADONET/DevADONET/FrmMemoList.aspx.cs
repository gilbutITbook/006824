using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DevADONET
{
    public partial class FrmMemoList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //[1] 커넥션
            SqlConnection con = new SqlConnection(ConfigurationManager
                .ConnectionStrings["ConnectionString"].ConnectionString);
            con.Open();
            //[2] 커멘드
            SqlCommand cmd = new SqlCommand("ListMemo", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //[3] 데이터어댑터
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //[4] 데이터셋
            DataSet ds = new DataSet();
            da.Fill(ds, "Memos");
            //[5] 출력
            ctlMemoList.DataSource = ds;
            ctlMemoList.DataBind(); 
            //[6] 마무리
            con.Close();
        }
    }
}
