using DotNetNote.Models;
using System;
using System.Web.UI;

namespace MemoEngine.DotNetNote
{
    public partial class BoardList : System.Web.UI.Page
    {
        // 공통 속성: 검색 모드: 검색 모드이면 true, 그렇지 않으면 false.
        // [참고] 이러한 공통 속성들은 Base 클래스에 모아 넣고 상속해줘도 좋음
        public bool SearchMode { get; set; } = false;
        public string SearchField { get; set; }
        public string SearchQuery { get; set; }

        public int PageIndex = 0; // 현재 보여줄 페이지 번호
        public int RecordCount = 0; // 총 레코드 갯수(글번호 순서 정렬용)

        private NoteRepository _repository;
        public BoardList()
        {
            _repository = new NoteRepository();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            // 검색 모드 결정
            SearchMode =
                (!string.IsNullOrEmpty(Request.QueryString["SearchField"]) &&
                    !string.IsNullOrEmpty(Request.QueryString["SearchQuery"]));
            if (SearchMode)
            {
                SearchField = Request.QueryString["SearchField"];
                SearchQuery = Request.QueryString["SearchQuery"];
            }

            // 쿼리스트링에 따른 페이지 보여주기
            if (Request["Page"] != null)
            {
                // Page는 보여지는 쪽은 1, 2, 3, ... 코드단에서는 0, 1, 2, ...
                PageIndex = Convert.ToInt32(Request["Page"]) - 1;
            }
            else
            {
                PageIndex = 0; // 1 페이지
            }

            // 쿠키를 사용한 리스트 페이지 번호 유지 적용: 
            //    100번째 페이지의 글 보고, 다시 리스트 왔을 때 100번째 페이지 표시
            if (Request.Cookies["DotNetNote"] != null)
            {
                if (!String.IsNullOrEmpty(
                    Request.Cookies["DotNetNote"]["PageNum"]))
                {
                    PageIndex = Convert.ToInt32(
                        Request.Cookies["DotNetNote"]["PageNum"]);
                }
                else
                {
                    PageIndex = 0;
                }
            }

            // 레코드 카운트 출력
            if (SearchMode == false)
            {
                // Notes 테이블의 전체 레코드
                RecordCount =
                    _repository.GetCountAll();
            }
            else
            {
                // Notes 테이블 중 SearchField+SearchQuery에 해당하는 레코드 수
                RecordCount =
                    _repository.GetCountBySearch(SearchField, SearchQuery);
            }
            lblTotalRecord.Text = RecordCount.ToString();

            // 페이징 처리
            AdvancedPagingSingleWithBootstrap.PageIndex = PageIndex;
            AdvancedPagingSingleWithBootstrap.RecordCount = RecordCount;

            if (!Page.IsPostBack)
            {
                DisplayData();
            }
        }

        private void DisplayData()
        {
            if (SearchMode == false) // 기본 리스트
            {
                ctlBoardList.DataSource = _repository.GetAll(PageIndex);
            }
            else // 검색 결과 리스트
            {
                ctlBoardList.DataSource = _repository.GetSeachAll(
                    PageIndex, SearchField, SearchQuery);
            }

            ctlBoardList.DataBind();
        }
    }
}