--[0] Users 테이블 생성
Create Table dbo.Users
(
    UID Int Identity(1, 1) Primary Key Not Null,
    UserID NVarChar(25) Not Null,
    [Password] NVarChar(20) Not Null
    -- 필요한 항목이 있으면, 언제든 추가
)
Go
