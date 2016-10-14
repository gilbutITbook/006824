<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" 
    AutoEventWireup="true" CodeBehind="BoardDelete.aspx.cs" 
    Inherits="MemoEngine.DotNetNote.BoardDelete" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script>
        function ConfirmDelete() {
            var varFlag = false;
            if (window.confirm("현재 글을 삭제하시겠습니까?")) {
                varFlag = true;
            }
            else {
                varFlag = false;
            }
            return varFlag;
        }
    </script>

    <h2 style="text-align: center;">게시판</h2>
    <span style="color: #ff0000">
        글 삭제 - 글을 삭제하려면 글 작성시에 기록하였던 비밀번호가 필요합니다.
    </span>
    <hr />
    <div style="text-align: center;">
        <asp:Label ID="lblId" runat="server" ForeColor="Red"></asp:Label>
        번 글을 지우시겠습니까?
    <br />
        비밀번호 :
        <asp:TextBox ID="txtPassword" runat="server" Width="120px" 
            CssClass="form-control" Style="display: inline-block;" 
            TextMode="Password"></asp:TextBox>
        <asp:Button ID="btnDelete" runat="server" Width="100px" 
            CssClass="btn btn-danger" Style="display: inline-block;" 
            Text="지우기" OnClick="btnDelete_Click"></asp:Button>
        <asp:HyperLink ID="lnkCancel" runat="server" 
            CssClass="btn btn-default">취소</asp:HyperLink>
        <br />
        <asp:Label ID="lblMessage" runat="server" ForeColor="Red" />
        <br />
    </div>
</asp:Content>
