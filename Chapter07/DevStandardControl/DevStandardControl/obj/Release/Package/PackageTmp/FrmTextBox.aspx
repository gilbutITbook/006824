<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="FrmTextBox.aspx.cs" Inherits="DevStandardControl.FrmTextBox" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>텍스트 박스 컨트롤</title>
</head>
<body>
<form id="form1" runat="server">
<div>
    <h2>SingleLine:</h2>
    이름 :
    <asp:TextBox ID="txtSingleLine" runat="server" CssClass="myTextAlign" />
    <h2>MultiLine:</h2>
    소개 :
    <asp:TextBox ID="txtMultiLine" runat="server" TextMode="MultiLine" />
    <br />
    <h2>Password:</h2>
    암호 :
    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" />
    <hr />
    <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="확인" />
</div>
</form>
</body>
</html>