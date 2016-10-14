<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="FrmMemoWrite.aspx.cs" Inherits="DevADONET.FrmMemoWrite" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>입력 패턴</title>
</head>
<body>
<form id="form1" runat="server">
<div>
    <h3>데이터 입력</h3>
    이름: <asp:TextBox ID="txtName" runat="server"></asp:TextBox><br />
    이메일: <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox><br />
    메모: <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox><br />
    <asp:Button ID="btnWrite" runat="server" Text="저장" 
        OnClick="btnWrite_Click" />&nbsp;
    <asp:Button ID="btnList" runat="server" Text="리스트" 
        OnClick="btnList_Click" />
    <hr />
    <asp:Label ID="lblDisplay" runat="server"></asp:Label>
</div>
</form>
</body>
</html>
