<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master"
    AutoEventWireup="true" CodeBehind="BoardView.aspx.cs"
    Inherits="MemoEngine.DotNetNote.BoardView" %>

<%@ Register Src="~/DotNetNote/Controls/BoardCommentControl.ascx"
    TagPrefix="uc1" TagName="BoardCommentControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2 style="text-align: center;">게시판</h2>
    <span style="color: #ff0000">
        글 보기 - 현재 글에 대해서 수정 및 삭제를 할 수 있습니다. </span>
    <hr />
    <table style="width: 700px; margin-left: auto; margin-right: auto;">
        <tbody>
            <tr style="color: white; background-color: #46698c;">
                <td style="width: 80px; text-align: right; height: 35px;">
                    <b style="font-size: 18px">제 목</b> :
                </td>
                <td colspan="3">
                    <asp:Label ID="lblTitle" Font-Bold="True" Font-Size="18px" 
                        Width="100%" runat="server"></asp:Label>
                </td>
            </tr>
            <tr style="background-color: #efefef;">
                <td class="text-right">번 호 :
                </td>
                <td>
                    <asp:Label ID="lblNum" Width="84" runat="server">
                    </asp:Label>
                </td>
                <td class="text-right">E-mail :
                </td>
                <td>
                    <asp:Label ID="lblEmail" Width="100%" runat="server">
                    </asp:Label>
                </td>
            </tr>
            <tr style="background-color: #efefef;">
                <td class="text-right">이 름 :
                </td>
                <td>
                    <asp:Label ID="lblName" Width="100%" runat="server">
                    </asp:Label>
                </td>
                <td class="text-right">Homepage :
                </td>
                <td>
                    <asp:Label ID="lblHomepage" Width="100%" runat="server">
                    </asp:Label>
                </td>
            </tr>
            <tr style="background-color: #efefef;">
                <td class="text-right">작성일 :
                </td>
                <td>
                    <asp:Label ID="lblPostDate" Width="100%" runat="server">
                    </asp:Label></td>
                <td class="text-right">IP 주소 :
                </td>
                <td>
                    <asp:Label ID="lblPostIP" Width="100%" runat="server">
                    </asp:Label>
                </td>
            </tr>
            <tr style="background-color: #efefef;">
                <td class="text-right">조회수 :
                </td>
                <td>
                    <asp:Label ID="lblReadCount" Width="100%" runat="server">
                    </asp:Label>
                </td>
                <td class="text-right">파일 :
                </td>
                <td>
                    <asp:Label ID="lblFile" Width="100%" runat="server">
                    </asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="4" style="padding: 10px;">
                    <asp:Literal ID="ltrImage" runat="server"></asp:Literal>
                    <asp:Label ID="lblContent" runat="server" 
                        Width="100%" Height="115px"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="4">
                    <hr />
                </td>
            </tr>
            <tr>
                <td colspan="4">

                    <uc1:BoardCommentControl runat="server" 
                        ID="BoardCommentControl" />

                </td>
            </tr>
        </tbody>
    </table>

    <div style="text-align: center;">
        <asp:HyperLink ID="lnkDelete" runat="server" 
            CssClass="btn btn-default">삭제</asp:HyperLink>
        <asp:HyperLink ID="lnkModify" runat="server" 
            CssClass="btn btn-default">수정</asp:HyperLink>
        <asp:HyperLink ID="lnkReply" runat="server" 
            CssClass="btn btn-default">답변</asp:HyperLink>
        <asp:HyperLink ID="lnkList" runat="server" 
            NavigateUrl="BoardList.aspx" 
            CssClass="btn btn-default">리스트</asp:HyperLink>
    </div>

    <asp:Label ID="lblError" runat="server" 
        ForeColor="Red" EnableViewState="False"></asp:Label>
    <br />

</asp:Content>
