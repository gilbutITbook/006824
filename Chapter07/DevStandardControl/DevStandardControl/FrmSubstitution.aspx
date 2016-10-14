<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="FrmSubstitution.aspx.cs" Inherits="DevStandardControl.FrmSubstitution" %>
<%@ OutputCache Duration="60" VaryByParam="None" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Substitution(대체) 컨트롤</title>
</head>
<body>
    <form id="form1" runat="server">
        <h3>실제 IIS 웹 서버에서만 실행되는 예제임</h3>
        <div>
            캐싱 적용됨: <asp:Label ID="lblCachedLabel" runat="server"></asp:Label>
            <hr />
            캐싱 비적용: <asp:Substitution ID="Substitution1" runat="server" MethodName="GetCurrentTime" />
        </div>
    </form>
</body>
</html>
