<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="FrmStandardControl.aspx.cs" 
    Inherits="DevStandardControl.FrmStandardControl" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>표준 컨트롤</title>
</head>
<body>
<form id="form1" runat="server">
<div>
    <h1>표준 컨트롤(Standard Control)</h1>
        
    <h2>[1] 순수 HTML 사용해서 버튼 만들기</h2>
    <input type="button" value="버튼1" id="btnInput" />

    <h2>[2] runat 속성을 추가해서 서버 컨트롤 버튼 만들기</h2>
    <input type="button" value="버튼2" runat="server" id="btnHtml" />

    <h2>[3] ASP.NET 표준 컨트롤을 사용해서 버튼 만들기</h2>
    <asp:Button Text="버튼3" runat="server" ID="btnServer" />
</div>
</form>
</body>
</html>