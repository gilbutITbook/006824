using System;

namespace DevADONET.Models
{
    /// <summary>
    /// Memos 테이블과 일대일 매핑되는 Memo 클래스
    /// </summary>
    public class Memo
    {
        public int Num { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public DateTime PostDate { get; set; }
        public string PostIp { get; set; }
    }
}
