using DotNetNote.Models;
using DotNetNote.Services; // *
using DotNetNote.Settings; // * 
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace DotNetNote
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
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

            services.AddMvc();

            //[DI] InfoService 클래스 의존성 주입
            services.AddSingleton<InfoService>();
            services.AddSingleton<IInfoService, InfoService>();

            //[DI(Dependency Injection)] 서비스 등록
            services.AddTransient<ICopyrightService, CopyrightService>();
            //[DI] @inject 키워드로 뷰에 직접 클래스의 속성 또는 메서드 값 출력
            services.AddSingleton<CopyrightService>();

            //[DNN][!] Configuration 개체 주입: 
            //    IConfiguration 또는 IConfigurationRoot에 Configuration 개체 전달
            //    appsettings.json 파일의 데이터베이스 연결 문자열을 
            //    리파지터리 클래스에서 사용할 수 있도록 설정
            services.AddSingleton<IConfiguration>(Configuration);


            //[Tech] 기술 목록
            services.AddTransient<ITechRepository, TechRepository>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
