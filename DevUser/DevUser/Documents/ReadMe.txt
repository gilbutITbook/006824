초간단 회원 관리(인증 및 허가) 기능 구현

1. DevUser 프로젝트 생성
    Web.config : <authentication Mode="Forms" /> 변경

2. DB: Database 프로젝트로 따로 관리
    Server : (local)\\SQLExpress, (localdb)\MSSQLLocalDB
    Database : DevUser, DotNetNote
    Uid : DevUser
    Pwd : Pa$$w0rd
    Table : Users

3. DevUser 웹 프로젝트 생성

    Web.config : <connectionStrings /> 기록

  <!--[1] 데이터베이스 연결 문자열 -->
  <connectionStrings>
    <add name="ConnectionString" 
      connectionString="Data Source=(localdb)\MSSQLLocalDb;
        Integrated Security=True;Pooling=False;Database=DotNetNote;"
      providerName="System.Data.SqlClient" />
  </connectionStrings>
  
    <!--[2] 폼 인증 적용-->
    <authentication mode="Forms">
      <forms loginUrl="~/Login.aspx"></forms>
    </authentication>

3. 웹 폼
    Default.aspx : 메인
    Login.aspx : 로그인
    Register.aspx : 회원가입
    UserInfo.aspx : 회원정보보기 및 수정 그리고 탈퇴 등 기능 : 인증된 사용자만 접근 가능
    Welcome.aspx : 로그인 환영 페이지 : 인증된 사용자만 접근 가능
    ~/Admin/Default.aspx : 관리 사용자만 접근 가능

4. 주요 명령어
    ■ 로그인 처리
        System.Web.Security.FormsAuthentication.SetAuthCookie()
        System.Web.Security.FormsAuthentication.RedirectFromLoginPage()
    ■ 로그인 확인
        Page.User.Identity.IsAuthenticated
    ■ 로그인 이름
        Page.User.Identity.Name
    ■ 로그아웃
        FormsAuthendtication.SignOut()


