<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="FrmMenu.aspx.cs" Inherits="DevNavigationControl.FrmMenu" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>메뉴 컨트롤</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Menu ID="Menu1" runat="server" Orientation="Horizontal">
                <Items>
                    <asp:MenuItem Text="Home" Value="Home"></asp:MenuItem>
                    <asp:MenuItem Text="사이트맵패스 컨트롤" Value="SiteMapPath" 
                        NavigateUrl="~/FrmSiteMapPath.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="게시판" Value="게시판">
                        <asp:MenuItem Text="공지사항" Value="공지사항"></asp:MenuItem>
                        <asp:MenuItem Text="자유게시판" Value="자유게시판"></asp:MenuItem>
                    </asp:MenuItem>
                    <asp:MenuItem Text="강의실" Value="강의실"></asp:MenuItem>
                </Items>
            </asp:Menu>
        </div>
    </form>
</body>
</html>
