<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" 
    Inherits="DevUser.Admin.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>관리자 전용 페이지</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>관리자 전용 페이지</h1>
        <h2>관리자명: <asp:LoginName ID="LoginName1" runat="server" />
        </h2>
    </div>
    </form>
</body>
</html>
