<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="FrmMemoList.aspx.cs" Inherits="DevADONET.FrmMemoList" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>출력 패턴</title>
</head>
<body>
<form id="form1" runat="server">
<div>
    <h3>메모 리스트</h3>
    <asp:GridView ID="ctlMemoList" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField HeaderText="번호" DataField="Num" />
            <asp:BoundField HeaderText="작성자" DataField="Name" />
            <asp:HyperLinkField HeaderText="메모" 
                DataTextField="Title" 
                DataNavigateUrlFormatString="FrmMemoView.aspx?Num={0}"
                DataNavigateUrlFields="Num" />
            <asp:TemplateField HeaderText="작성일">
                <ItemTemplate>
                    <%# Eval("PostDate") %>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <hr />
    <asp:HyperLink ID="lnkMemoWrite" runat="server"
        NavigateUrl="~/FrmMemoWrite.aspx">글쓰기</asp:HyperLink>
</div>
</form>
</body>
</html>
