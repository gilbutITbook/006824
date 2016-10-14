using DotNetNote.Models;
using DotNetNote.Services;
using DotNetNote.Settings;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http; // ASP.NET Core 인증
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
//using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Logging;
//using Newtonsoft.Json.Serialization;
//using System.IO;

namespace DotNetNote
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            //[!] Configuration 
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile(
                    "appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile(
                    $"appsettings.{env.EnvironmentName}.json", optional: true)
                //[!] Configuration : Strongly Typed Configuration Setting
                //    추가 환경 설정 파일 지정
                .AddJsonFile(
                    $"Settings\\DotNetNoteSettings.json", optional: true) 
                .AddEnvironmentVariables();

            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            //[!] Configuration: JSON 파일의 데이터를 POCO 클래스에 주입
            services.Configure<DotNetNoteSettings>(
                Configuration.GetSection("DotNetNoteSettings"));

            //[!] 디렉터리 브라우징 기능 제공(옵션)
            services.AddDirectoryBrowser();

            //[DNN] TempData[] 개체 사용
            services.AddMemoryCache();
            services.AddSession();

            //[User][9] Policy 설정
            services.AddAuthorization(options =>
            {
                // Users Role이 있으면, Users Policy 부여
                options.AddPolicy(
                    "Users", policy => policy.RequireRole("Users"));
                // Users Role이 있고 UserId가 "Admin"이면 "Administrators" 부여
                options.AddPolicy(
                    "Administrators", 
                        policy => policy
                            .RequireRole("Users")
                            .RequireClaim("UserId", // 대소문자 구분
                                Configuration
                                    .GetSection("DotNetNoteSettings")
                                    .GetSection("SiteAdmin").Value)
                            ); 
            });

            //[MVC] MVC 추가 및 JSON 렌더링 옵션 지정
            services.AddMvc();
                //.AddJsonOptions(options =>
                //{
                //    //[Web API] JSON 속성 첫자 소문자: ASP.NET Core 1.0 기본
                //    options.SerializerSettings.ContractResolver =
                //    new CamelCasePropertyNamesContractResolver();
                //});
            
            //[DI] 의존성 주입(Dependency Injection)
            DependencyInjectionContainer(services);
        }

        /// <summary>
        /// 의존성 주입 관련 코드만 따로 모아서 관리
        /// </summary>
        private void DependencyInjectionContainer(IServiceCollection services)
        {
            //[Demo] DemoFinder 의존성 주입: 기본 내장된 DI 컨테이너 사용
            services.AddTransient<DotNetNote.Models.DataFinder>();

            //[DI] InfoService 클래스 의존성 주입: 30.3
            services.AddSingleton<InfoService>();
            services.AddSingleton<IInfoService, InfoService>();

            //[DI(Dependency Injection)] 서비스 등록: 30.4
            //services.AddTransient<CopyrightService>();
            services.AddTransient<ICopyrightService, CopyrightService>();
            
            //[DI] @inject 키워드로 뷰에 직접 클래스의 속성 또는 메서드 값 출력
            services.AddSingleton<CopyrightService>();
            
            //[DI] GuidService 등록
            services.AddTransient<GuidService>();
            services.AddTransient<IGuidService, GuidService>();
            services.AddTransient<ITransientGuidService, TransientGuidService>();
            services.AddScoped<IScopedGuidService, ScopedGuidService>();
            services.AddSingleton<ISingletonGuidService, SingletonGuidService>();



            //[DNN][!] Configuration 개체 주입: 
            //    IConfiguration 또는 IConfigurationRoot에 Configuration 개체 전달
            //    appsettings.json 파일의 데이터베이스 연결 문자열을 
            //    리파지터리 클래스에서 사용할 수 있도록 설정
            services.AddSingleton<IConfiguration>(Configuration);


            //[User][5] 회원 관리
            services.AddTransient<IUserRepository, UserRepository>();


            //[CommunityCamp] 모듈 서비스 등록
            services.AddTransient<ICommunityCampJoinMemberRepository,
                CommunityCampJoinMemberRepository>();


            //[DNN][1] 게시판 관련 서비스 등록            
            //[1] 생성자에 문자열로 연결 문자열 지정
            //services.AddSingleton<INoteRepository>(
            //  new NoteRepository(
            //      Configuration["Data:DefaultConnection:ConnectionString"]));            
            //[2] 의존성 주입으로 Configuration 주입
            //[a] NoteRepository에서 IConfiguration으로 데이터베이스 연결 문자열 접근
            services.AddTransient<INoteRepository, NoteRepository>();
            //[b] CommentRepository의 생성자에 데이터베이스 연결문자열 직접 전송
            services.AddSingleton<INoteCommentRepository>(
                new NoteCommentRepository(
                    Configuration["ConnectionStrings:DefaultConnection"])); 

            services
                .AddTransient<MaximServiceRepository, MaximServiceRepository>();

            //[Tech] 기술 목록
            services.AddTransient<ITechRepository, TechRepository>();
        }
        
        public void Configure(
            IApplicationBuilder app, 
            IHostingEnvironment env, 
            ILoggerFactory loggerFactory)
        {
            //[!] 기본 제공 로깅
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            //[0] 파이프라인 영역: 
            //  HTTP 파이프라인에 필요한 기능을 모듈 단위의 미들웨어로 추가해서 사용
            if (env.IsDevelopment())
            {
                //[!] 예외 발생시 좀 더 자세한 정보 표시
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            
            //[DNN] TempData 개체 사용
            app.UseSession();

            // 미들웨어 추가

            //// 사용자 정의 미들웨어 추가
            //app.Use(async (ctx, next) => {
            //    Console.WriteLine("Hello pipeline, {0}", ctx.Request.Path);
            //    await next();
            //});
                        
            //[!] 샘플 페이지 출력 미들웨어 
            //app.UseWelcomePage(); // 하나의 샘플 페이지 출력
                        
            //[!] MIME 타입 설정 : FileExtensionContentTypeProvider 클래스 사용
            
            //[!] 파일 서버 미들웨어 추가

            //[!] UseDefaultFiles() 미들웨어: 기본 문서 제공
            //DefaultFilesOptions options = new DefaultFilesOptions();
            //options.DefaultFileNames.Clear();
            //options.DefaultFileNames.Add("NewDefault.html");
            //app.UseDefaultFiles(options);
            
            ////[!] 정적 파일 폴더 추가 : Azure Web Apps에서 지원하지 않음
            //// wwwroot에 HTML/CSS/JavaScript/Images 등의 정적인 파일을 실행
            //// Microsoft.AspNetCore.StaticFiles 참조 추가
            //app.UseStaticFiles(
            //    new StaticFileOptions()
            //    {
            //        FileProvider = new PhysicalFileProvider(
            //            Path.Combine(Directory.GetCurrentDirectory()
            //                , @"MyStaticFiles")),
            //        RequestPath = new PathString("/StaticFiles")
            //    }
            //);
                        
            //[!] UseFileServer() 미들웨어 : 정적 파일 및 디렉터리 브라우징 표시 등 
            app.UseFileServer(); // 아래 3개 미들웨어 포함
            //[!] 정적 파일 실행을 위한 UseStaticFiles() 미들웨어 추가
            //app.UseStaticFiles();
            //app.UseDirectoryBrowser();
            //app.UseDefaultFiles(); 
            
            //[!] 상태 코드 표시 
            app.UseStatusCodePages();

            //[User][1] 쿠키 인증 사용 공식 코드: 
            // Microsoft.AspNetCore.Authentication.Cookies 패키지(어셈블리) 추가
            app.UseCookieAuthentication(
                new CookieAuthenticationOptions() {
                    AuthenticationScheme = "Cookies",
                    // 로그인하지 않았을 때 [Authorize]에 의해서 Login으로 이동
                    LoginPath = new PathString("/User/Login"), 
                    AccessDeniedPath = new PathString("/User/Forbidden"),
                    AutomaticAuthenticate = true,
                    AutomaticChallenge = true
                }
            );

            //[!] CORS
            app.UseCors(options => options.WithOrigins(
                "http://dotnetnote.azurewebsites.net/api/values"));
            app.UseCors(
                options => options.AllowAnyOrigin().WithMethods("GET"));


            //[MVC] 
            //[1] MVC 기본 라우트 정의
            //app.UseMvcWithDefaultRoute(); 
            //[2] MVC 사용자 정의 라우트 정의 
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
