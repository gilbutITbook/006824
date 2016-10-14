using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DevDataControl
{
    public class FrmObjectDataSourceClass
    {
        public SqlDataReader GetMemos()
        {
            SqlConnection objCon = new SqlConnection();
            // Web.config 파일의 커넥션 스트링 값 읽어오기
            objCon.ConnectionString =
              ConfigurationManager.ConnectionStrings[
                "DevADONETConnectionString"].ConnectionString;
            objCon.Open();

            SqlCommand objCmd = new SqlCommand();
            objCmd.Connection = objCon;
            objCmd.CommandText = "ListMemo";
            objCmd.CommandType = CommandType.StoredProcedure;

            // 데이터리더값을 반환하고 커넥션 종료
            return objCmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}
