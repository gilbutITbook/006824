--[8] 해당 글을 수정하는 저장 프로시저 : ModifyNote
Create Proc dbo.ModifyNote
    @Name       NVarChar(25), 
    @Email      NVarChar(100), 
    @Title      NVarChar(150), 
    @ModifyIp   NVarChar(15), 
    @Content    NText,
    @Password   NVarChar(30), 
    @Encoding   NVarChar(10), 
    @Homepage   NVarChar(100),
    @FileName	NVarChar(255),
    @FileSize	Int,
    
    @Id Int
As
    Declare @cnt Int

    Select @cnt = Count(*) From Notes 
    Where Id = @Id And Password = @Password

    If @cnt > 0 -- 번호와 암호가 맞는게 있다면...
    Begin
        Update Notes 
        Set 
            Name = @Name, Email = @Email, Title = @Title,
            ModifyIp = @ModifyIp, ModifyDate = GetDate(),
            Content = @Content, Encoding = @Encoding,
            Homepage = @Homepage, FileName = @FileName, FileSize = @FileSize
        Where Id = @Id

        Select '1'
    End
    Else
        Select '0'
Go
