--[1] 게시판(DotNetNote)용 테이블 설계
Create Table dbo.Notes
(
    Id              Int Identity(1, 1) Not Null Primary Key,  --번호
    Name            NVarChar(25) Not Null,                    --이름
    Email           NVarChar(100) Null,                       --이메일 
    Title           NVarChar(150) Not Null,                   --제목
    PostDate        DateTime Default GetDate() Not Null,      --작성일 
    PostIp          NVarChar(15) Null,                        --작성IP
    Content         NText Not Null,                           --내용
    Password        NVarChar(20) Null,                        --비밀번호
    ReadCount       Int Default 0,                            --조회수
    Encoding        NVarChar(10) Not Null,                    --인코딩(HTML/Text)
    Homepage        NVarChar(100) Null,                       --홈페이지
    ModifyDate      DateTime Null,                            --수정일 
    ModifyIp        NVarChar(15) Null,                        --수정IP
    FileName        NVarChar(255) Null,                       --파일명
    FileSize        Int Default 0,                            --파일크기
    DownCount       Int Default 0,                            --다운수 
    Ref             Int Not Null,                             --참조(부모글)
    Step            Int Default 0,                            --답변깊이(레벨)
    RefOrder        Int Default 0,                            --답변순서
    AnswerNum       Int Default 0,                            --답변수
    ParentNum       Int Default 0,                            --부모글번호
    CommentCount    Int Default 0,                            --댓글수
    Category        NVarChar(10) Default('Free') Null         --카테고리(확장...)
)
Go
