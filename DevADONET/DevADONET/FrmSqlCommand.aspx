<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="FrmSqlCommand.aspx.cs" Inherits="DevADONET.FrmSqlCommand" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>SqlCommand 클래스</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnSqlCommand" runat="server" 
                Text="입력 예시문 실행" OnClick="btnSqlCommand_Click" />
            <hr />
            <asp:Label ID="lblDisplay" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>

