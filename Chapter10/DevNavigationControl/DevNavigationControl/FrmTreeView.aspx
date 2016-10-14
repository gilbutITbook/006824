<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="FrmTreeView.aspx.cs" Inherits="DevNavigationControl.FrmTreeView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>트리뷰 컨트롤</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TreeView ID="TreeView1" runat="server">
            <Nodes>
                <asp:TreeNode Text="Home" Value="Home">
                    <asp:TreeNode Text="게시판" Value="게시판"></asp:TreeNode>
                    <asp:TreeNode Text="강의실" Value="강의실"></asp:TreeNode>
                </asp:TreeNode>
            </Nodes>
        </asp:TreeView>
        <hr />
        <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />
        <asp:TreeView ID="TreeView2" runat="server" ImageSet="XPFileExplorer" 
            DataSourceID="SiteMapDataSource1"></asp:TreeView>
    </div>
    </form>
</body>
</html>
