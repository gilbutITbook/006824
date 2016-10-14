<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" 
    Inherits="DevUser.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>회원 관리 - 회원 가입</title>
</head>
<body>
<form id="form1" runat="server">
<div>
<h1>회원 관리</h1>
<h2>회원 가입</h2>

아이디: <asp:TextBox ID="txtUserID" runat="server"></asp:TextBox><br />
암호: <asp:TextBox ID="txtPassword" runat="server" 
    TextMode="Password"></asp:TextBox><br />
<asp:Button ID="btnRegister" runat="server" Text="회원가입" 
    OnClick="btnRegister_Click" /><br />
</div>
</form>
</body>
</html>
