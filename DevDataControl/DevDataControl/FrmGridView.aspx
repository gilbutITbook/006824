<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="FrmGridView.aspx.cs" Inherits="DevDataControl.FrmGridView" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>GridView 컨트롤</title>
</head>
<body>
<form id="form1" runat="server">
<div>
<asp:GridView ID="ctlMemoList" runat="server" AutoGenerateColumns="false" 
    DataKeyNames="Num" DataSourceID="sdsMemoList">
    <Columns>
        <asp:BoundField DataField="Num" HeaderText="번호" 
            HeaderStyle-Width="70px" 
            HeaderStyle-HorizontalAlign="Center"
            ItemStyle-HorizontalAlign="Center" />
        <asp:HyperLinkField DataTextField="Title" HeaderText="메모" 
            DataNavigateUrlFormatString="FrmFormView.aspx?Num={0}" 
            DataNavigateUrlFields="Num" />
        <asp:BoundField DataField="Name" HeaderText="작성자" />
        <asp:TemplateField HeaderText="작성일">
            <ItemTemplate>
                <%# Eval("PostDate", "{0:yyyy-MM-dd}") %>
            </ItemTemplate>
            <AlternatingItemTemplate>
                <em><%# Eval("PostDate", "{0:hh:mm:ss}") %></em>
            </AlternatingItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>
<asp:SqlDataSource runat="server" ID="sdsMemoList" 
    ConnectionString='<%$ ConnectionStrings:DevADONETConnectionString %>' 
    SelectCommand="SELECT * FROM [Memos] ORDER BY [Num] DESC"></asp:SqlDataSource>
</div>
</form>
</body>
</html>
