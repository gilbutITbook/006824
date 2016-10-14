<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="FrmBoardLibraryTest.aspx.cs"
    Inherits="Dul.Test.FrmBoardLibraryTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>파일 크기 단위 붙이기</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            파일 크기:
            <asp:TextBox ID="txtInput" runat="server"></asp:TextBox>
            <asp:Button ID="btnClick" runat="server" Text="확인"
                OnClick="btnClick_Click" /><br />
            <asp:Label ID="lblDisplay" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
