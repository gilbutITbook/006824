using System;
using System.ComponentModel;

namespace MemoEngine.DotNetNote.Controls
{
    public partial class AdvancedPagingSingleWithBootstrap : 
        System.Web.UI.UserControl
    {
        // 공통 속성: 검색 모드: 검색 모드이면 true, 그렇지 않으면 false.
        public bool SearchMode { get; set; } = false; // 일반 모드, 검색 모드
        public string SearchField { get; set; } // 검색 필드: Name, Title, ...
        public string SearchQuery { get; set; } // 검색 내용

        /// <summary>
        /// 몇번째 페이지를 보여줄 건지 : 웹 폼에서 속성으로 전달됨
        /// </summary>
        [Category("페이징처리")] // Category 특성은 모두 생략 가능(속성에 표시됨)
        public int PageIndex { get; set; }


        /// <summary>
        /// 총 몇개의 페이지가 만들어지는지 : 총 레코드 수 / 10(한페이지에서 보여줄)
        /// </summary>
        [Category("페이징처리")]
        public int PageCount { get; set; }


        /// <summary>
        /// 페이지 사이즈 : 한 페이지에 몇개의 레코드를 보여줄건지 결정
        /// </summary>
        [Category("페이징처리")]
        [Description("한 페이지에 몇개의 레코드를 보여줄건지 결정")]
        public int PageSize { get; set; } = 10; // 페이지 사이즈는 기본값이 10


        /// <summary>
        /// 레코드 카운트 : 현재 테이블에 몇개의 레코드가 있는지 지정
        /// </summary>
        private int _RecordCount;
        [Category("페이징처리")]
        [Description("현재 테이블에 몇개의 레코드가 있는지 지정")]
        public int RecordCount
        {
            get { return _RecordCount; }
            set
            {
                _RecordCount = value;
                // 총 페이지 수 계산
                PageCount = ((_RecordCount - 1) / PageSize) + 1; // 계산식
            }
        }

        // 페이지 로드할 때 페이저 구현하기
        protected void Page_Load(object sender, EventArgs e)
        {
            // 검색 모드 결정: 검색 모드이면 SearchMode 속성이 true
            SearchMode =
                (!string.IsNullOrEmpty(Request.QueryString["SearchField"]) &&
                    !string.IsNullOrEmpty(Request.QueryString["SearchQuery"]));

            if (SearchMode)
            {
                SearchField = Request.QueryString["SearchField"];
                SearchQuery = Request.QueryString["SearchQuery"];
            }

            ++PageIndex; // 코드: 0, 1, 2 인덱스로 사용, UI: 1, 2, 3 페이지로 사용
            int i = 0;


            // <!--이전 10개, 다음 10개 페이징 처리 시작-->
            string strPage = "<ul class='pagination pagination-sm'>";
            if (PageIndex > 10) // 이전 10개 링크가 있다면, ...
            {
                // 검색 모드이면 추가적으로 SearchField와 SearchQuery를 전송함
                if (SearchMode)
                {
                    strPage += "<li><a href=\""
                        + Request.ServerVariables["SCRIPT_NAME"]
                        //+ "?BoardName=" + Request["BoardName"] // 멀티 게시판
                        + "?Page="
                        + Convert.ToString(((PageIndex - 1) / (int)10) * 10)
                        + "&SearchField=" + SearchField
                        + "&SearchQuery=" + SearchQuery + "\">◀</a></li>";
                }
                else
                {
                    strPage += "<li><a href=\""
                        + Request.ServerVariables["SCRIPT_NAME"]
                        //+ "?BoardName=" + Request["BoardName"]
                        + "?Page="
                        + Convert.ToString(((PageIndex - 1) / (int)10) * 10)
                        + "\">◀</a></li>";
                }
            }
            else
            {
                strPage += "<li class=\"disabled\"><a>◁</a></li>";
            }


            // 가운데, 숫자 형식의 페이저 표시
            for (
                i = (((PageIndex - 1) / (int)10) * 10 + 1);
                i <= ((((PageIndex - 1) / (int)10) + 1) * 10);
                i++)
            {
                if (i > PageCount)
                {
                    break; // 있는 페이지까지만 페이저 링크 출력
                }
                // 현재 보고있는 페이지면, 활성화(active)
                if (i == PageIndex)
                {
                    strPage += " <li class='active'><a href='#'>"
                        + i.ToString() + "</a></li>";
                }
                else
                {
                    if (SearchMode)
                    {
                        strPage += "<li><a href=\""
                            + Request.ServerVariables["SCRIPT_NAME"]
                            //+ "?BoardName=" + Request["BoardName"]
                            + "?Page=" + i.ToString()
                            + "&SearchField=" + SearchField
                            + "&SearchQuery=" + SearchQuery + "\">"
                            + i.ToString() + "</a></li>";
                    }
                    else
                    {
                        strPage += "<li><a href=\""
                            + Request.ServerVariables["SCRIPT_NAME"]
                            //+ "?BoardName=" + Request["BoardName"]
                            + "?Page=" + i.ToString() + "\">"
                            + i.ToString() + "</a></li>";
                    }
                }
            }

            // 다음 10개 링크
            if (i < PageCount) //  다음 10개 링크가 있다면, ...
            {
                if (SearchMode)
                {
                    strPage += "<li><a href=\""
                        + Request.ServerVariables["SCRIPT_NAME"]
                        //+ "?BoardName=" + Request["BoardName"]
                        + "?Page="
                        + Convert.ToString(((PageIndex - 1) / (int)10) * 10 + 11)
                        + "&SearchField=" + SearchField
                        + "&SearchQuery=" + SearchQuery + "\">▶</a></li>";
                }
                else
                {
                    strPage += "<li><a href=\""
                        + Request.ServerVariables["SCRIPT_NAME"]
                        //+ "?BoardName=" + Request["BoardName"]
                        + "?Page="
                        + Convert.ToString(((PageIndex - 1) / (int)10) * 10 + 11)
                        + "\">▶</a></li>";
                }
            }
            else
            {
                strPage += "<li class=\"disabled\"><a>▷</a></li>";
            }

            // <!--이전 10개, 다음 10개 페이징 처리 종료-->
            strPage += "</ul>";


            ctlAdvancedPaingWithBootstrap.Text = strPage;
        }
    }
}