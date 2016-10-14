using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DevMvcTaskList.Models
{
    /// <summary>
    /// Tasks(할 일) 테이블과 일대일
    /// </summary>
    public class TaskModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime CreationDate { get; set; }
    }

    public class TaskRepository
    {
        private IDbConnection db = new SqlConnection(
            ConfigurationManager.ConnectionStrings[
                "ConnectionString"].ConnectionString);

        public void AddTask(TaskModel model)
        {
            this.db.Execute(
                @"
                    Insert Into Tasks (Title, IsCompleted) 
                    Values (@Title, Cast('false' As Bit))
                ", model);
        }

        public List<TaskModel> GetTasks()
        {
            return this.db.Query<TaskModel>(
                "Select * From Tasks Order By Id Desc").ToList();
        }

        public void CompleteTask(int id)
        {
            // db.Execute(@"Update Tasks Set IsCompleted = Cast('TRUE' As Bit) 
            // Where Id = @Id", new { id });
            db.Execute(@"Update Tasks Set IsCompleted = ~IsCompleted 
                Where Id = @Id", new { id });
        }
    }
}
