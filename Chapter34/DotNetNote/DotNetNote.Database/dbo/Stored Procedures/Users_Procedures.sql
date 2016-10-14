--[1] 입력 저장 프로시저
Create Proc dbo.WriteUsers
	@UserID NVarChar(25),
	@Password NVarChar(20)
As
	Insert Into Users Values(@UserID, @Password)
Go

--[2] 출력 저장 프로시저
Create Proc dbo.ListUsers
As
	Select [UID], [UserID], [Password] From Users Order By UID Desc
Go

--[3] 상세 저장 프로시저
Create Proc dbo.ViewUsers
	@UID Int
As
	Select [UID], [UserID], [Password] From Users Where UID = @UID
Go

--[4] 수정 저장 프로시저
Create Proc dbo.ModifyUsers
	@UserID NVarChar(25),
	@Password NVarChar(20),
	@UID Int
As
	Begin Tran
		Update Users
		Set	
			UserID = @UserID,
			[Password] = @Password
		Where UID = @UID
	Commit Tran
Go

--[5] 삭제 저장 프로시저
Create Proc dbo.DeleteUsers
	@UID Int
As
	Delete Users Where UID = @UID
Go

--[6] 검색 저장 프로시저
Create Proc dbo.SearchUsers
	@SearchField NVarChar(25),
	@SearchQuery NVarChar(25)
As
	Declare @strSql NVarChar(255)
	Set @strSql = '
		Select * From Users 
		Where 
			' + @SearchField + ' Like ''%' + @SearchQuery + '%''
	'
	Exec(@strSql)
Go
