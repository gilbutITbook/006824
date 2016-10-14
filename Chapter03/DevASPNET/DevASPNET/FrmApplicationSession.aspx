<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="FrmApplicationSession.aspx.cs"
    Inherits="DevASPNET.FrmApplicationSession" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Application 및 Session 개체</title>
</head>
<body>
<form id="form1" runat="server">
<div>
    현재 페이지가 모든 사용자에 의해 
    <asp:Label ID="lblApplication" runat="server"></asp:Label>
    번 호출되었습니다.<br />
    현재 페이지가 나에 의해서 
    <asp:Label ID="lblSession" runat="server"></asp:Label>
    번 호출했습니다.<br />
    나의 고유 접속번호 :
    <asp:Label ID="lblSessionID" runat="server"></asp:Label><br />
    현재 세션 유지시간 :
    <asp:Label ID="lblTimeout" runat="server"></asp:Label><br />
</div>
</form>
</body>
</html>