<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" 
    Inherits="DevUser.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>회원 관리 - 로그인</title>
</head>
<body>
<form id="form1" runat="server">
<div>
<h1>회원 관리</h1>
<h2>로그인</h2>

아이디: <asp:TextBox ID="txtUserID" runat="server"></asp:TextBox><br />
암호: <asp:TextBox ID="txtPassword" runat="server" 
    TextMode="Password"></asp:TextBox><br />
<asp:Button ID="btnLogin" runat="server" Text="로그인" OnClick="btnLogin_Click" />
</div>
</form>
</body>
</html>
