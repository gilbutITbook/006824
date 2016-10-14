<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="FrmButtonClickOnce.aspx.cs" 
    Inherits="DevStateManagement.FrmButtonClickOnce" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>초간단 중복 방지</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtInput" runat="server"></asp:TextBox>
            <asp:Button ID="btnSave" runat="server" Text="저장" OnClick="btnSave_Click" />
            <asp:Label ID="lblDisplay" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
