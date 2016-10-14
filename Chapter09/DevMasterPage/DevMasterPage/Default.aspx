<%@ Page Title="" Language="C#" 
    MasterPageFile="~/Site.Master" AutoEventWireup="true" 
    CodeBehind="Default.aspx.cs" Inherits="DevMasterPage.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeaderContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET 마스터 페이지</h1>
        <p>
            마스터 페이지, 레이아웃 페이지 등의 표현 방법은
            웹 사이트 공통 레이아웃을 정의하는 기능입니다.
        </p>
    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="FooterContent" runat="server">
</asp:Content>
