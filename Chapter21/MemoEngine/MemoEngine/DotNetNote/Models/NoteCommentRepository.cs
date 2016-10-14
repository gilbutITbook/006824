using Dapper;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DotNetNote.Models
{
    public class NoteCommentRepository
    {
        private SqlConnection con;

        public NoteCommentRepository()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings[
                "ConnectionString"].ConnectionString);
        }

        /// <summary>
        /// 특정 게시물에 댓글 추가
        /// </summary>
        public void AddNoteComment(NoteComment model)
        {
            // 파라미터 추가
            var parameters = new DynamicParameters();
            parameters.Add(
                "@BoardId", value: model.BoardId, dbType: DbType.Int32);
            parameters.Add(
                "@Name", value: model.Name, dbType: DbType.String);
            parameters.Add(
                "@Opinion", value: model.Opinion, dbType: DbType.String);
            parameters.Add(
                "@Password", value: model.Password, dbType: DbType.String);

            string sql = @"
                Insert Into NoteComments (BoardId, Name, Opinion, Password)
                Values(@BoardId, @Name, @Opinion, @Password);
                Update Notes Set CommentCount = CommentCount + 1 
                Where Id = @BoardId
            ";

            con.Execute(sql, parameters, commandType: CommandType.Text);
        }

        /// <summary>
        /// 특정 게시물에 해당하는 댓글 리스트
        /// </summary>
        public List<NoteComment> GetNoteComments(int boardId)
        {
            return con.Query<NoteComment>(
                "Select * From NoteComments Where BoardId = @BoardId"
                , new { BoardId = boardId }
                , commandType: CommandType.Text).ToList();
        }

        /// <summary>
        /// 특정 게시물의 특정 Id에 해당하는 댓글 카운트
        /// </summary>
        public int GetCountBy(int boardId, int id, string password)
        {
            return con.Query<int>(@"Select Count(*) From NoteComments 
                Where BoardId = @BoardId And Id = @Id And Password = @Password"
                , new { BoardId = boardId, Id = id, Password = password }
                , commandType: CommandType.Text).SingleOrDefault();
        }

        /// <summary>
        /// 댓글 삭제 
        /// </summary>
        public int DeleteNoteComment(int boardId, int id, string password)
        {
            return con.Execute(@"Delete NoteComments 
                Where BoardId = @BoardId And Id = @Id And Password = @Password; 
                Update Notes Set CommentCount = CommentCount - 1 
                Where Id = @BoardId"
                , new { BoardId = boardId, Id = id, Password = password }
                , commandType: CommandType.Text);
        }

        /// <summary>
        /// 최근 댓글 리스트 전체
        /// </summary>
        public List<NoteComment> GetRecentComments()
        {
            string sql = @"SELECT TOP 3 Id, BoardId, Opinion, PostDate 
                FROM NoteComments Order By Id Desc";
            return con.Query<NoteComment>(sql).ToList();
        }
    }
}
