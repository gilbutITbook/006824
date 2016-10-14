<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="FrmResponseWrite.aspx.cs" Inherits="DevASPNET.FrmResponseWrite" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Response 개체</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnClick" runat="server"
                Text="클릭" OnClick="btnClick_Click" />
            <br />
            <%="또 만나요<br />"%>
            <asp:Button ID="btnJavaScript" runat="server"
                Text="자바스크립트로 인사말 출력"
                OnClick="btnJavaScript_Click" />
        </div>
    </form>
</body>
</html>
