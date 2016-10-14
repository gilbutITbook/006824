<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="FrmDataControl.aspx.cs" 
    Inherits="DevDataControl.FrmDataControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>DataControl 데모</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>SqlDataSource 컨트롤</h2>
            <asp:DropDownList ID="DropDownList1" runat="server" 
                DataSourceID="SqlDataSource1" 
                DataTextField="Name" 
                DataValueField="Num">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                ConnectionString=
                    '<%$ ConnectionStrings:DevADONETConnectionString %>' 
                SelectCommand=
                    "SELECT [Num], [Name] FROM [Memos] ORDER BY [Num] DESC">
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
