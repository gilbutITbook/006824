--[1] 게시판(DotNetNote)에 글을 작성 : WriteNote
Create Proc dbo.WriteNote
    @Name       NVarChar(25), 
    @Email      NVarChar(100), 
    @Title      NVarChar(150), 
    @PostIp     NVarChar(15), 
    @Content    NText, 
    @Password   NVarChar(20), 
    @Encoding   NVarChar(10), 
    @Homepage   NVarChar(100),
    @FileName   NVarChar(255),
    @FileSize   Int
As
    Declare @MaxRef Int
    Select @MaxRef = Max(Ref) From Notes
 
    If @MaxRef is Null
        Set @MaxRef = 1 -- 테이블 생성 후 처음만 비교
    Else
        Set @MaxRef = @MaxRef + 1

    Insert Notes
    (
        Name, Email, Title, PostIp, Content, Password, Encoding, 
        Homepage, Ref, FileName, FileSize
    )
    Values
    (
        @Name, @Email, @Title, @PostIp, @Content, @Password, @Encoding, 
        @Homepage, @MaxRef, @FileName, @FileSize
    )
Go
