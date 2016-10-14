<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="FrmServerMapPath.aspx.cs" 
    Inherits="DevASPNET.FrmServerMapPath" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Server 개체</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            현재 파일(웹 폼)의 물리적인 전체 경로 :
            <asp:Label ID="Label1" runat="server"></asp:Label><br />
            현재 스크립트 파일의 루트 경로 :
            <asp:Label ID="Label2" runat="server"></asp:Label><br />
        </div>
    </form>
</body>
</html>