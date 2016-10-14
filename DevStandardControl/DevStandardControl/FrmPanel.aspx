<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="FrmPanel.aspx.cs" Inherits="DevStandardControl.FrmPanel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>패널 컨트롤</title>
</head>
<body>
<form id="form1" runat="server">
<div>
    <asp:Panel ID="pnlFirst" runat="server"
        Height="50px" Width="200px" ScrollBars="Vertical">
        안녕하세요.<br />
        안녕하세요.<br />
        안녕하세요.<br />
        안녕하세요.<br />
    </asp:Panel>

    <asp:Panel ID="pnlSecond" runat="server"
        Height="50px" Width="200px" GroupingText="그룹 상자">
        반갑습니다.<br />
    </asp:Panel>
    <br />
    <hr />

    <asp:Panel ID="pnlCommand" runat="server"
        Height="50px" Width="360px" DefaultButton="btnShowPanel2">
        <asp:Button ID="btnShowPanel1" runat="server"
            Text="첫 번째 패널 보이기" OnClick="btnShowPanel1_Click" />
        <asp:Button ID="btnShowPanel2" runat="server"
            Text="두 번째 패널 보이기" OnClick="btnShowPanel2_Click" /><br />
        <asp:TextBox ID="txtMessage" runat="server"
            Width="344px">여기에서 엔터키를 누르면 버튼이 클릭됩니다.</asp:TextBox>
    </asp:Panel>
</div>
</form>
</body>
</html>
