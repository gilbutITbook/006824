<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="FrmFormView.aspx.cs" Inherits="DevDataControl.FrmFormView" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>FormView 컨트롤</title>
</head>
<body>
<form id="form1" runat="server">
<div>
    <asp:FormView ID="ctlMemoView" runat="server" 
        DataSourceID="sdsMemoView" DataKeyNames="Num">
        <ItemTemplate>
            작성자: <%# Eval("Name") %><br />
            메모: <%# Eval("Title") %><br />
        </ItemTemplate>
    </asp:FormView>
    <asp:SqlDataSource ID="sdsMemoView" runat="server"
        ConnectionString="<%$ ConnectionStrings:DevADONETConnectionString %>"
        SelectCommand="SELECT * FROM [Memos] WHERE ([Num] = @Num)">
        <SelectParameters>
            <asp:QueryStringParameter Name="Num" QueryStringField="Num" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
</div>
</form>
</body>
</html>
