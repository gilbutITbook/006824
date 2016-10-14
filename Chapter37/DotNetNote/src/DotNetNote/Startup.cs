using DotNetNote.Models; // *
using DotNetNote.Settings; // * 
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http; // * 
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
                .AddJsonFile(
                    $"Settings\\DotNetNoteSettings.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<DotNetNoteSettings>(
                Configuration.GetSection("DotNetNoteSettings"));
            
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


            services.AddMvc();

            //[User][5] 회원 관리
            services.AddTransient<IUserRepository, UserRepository>();

            services.AddSingleton<IConfiguration>(Configuration);
            services.AddTransient<INoteRepository, NoteRepository>();
            services.AddSingleton<INoteCommentRepository>(
                new NoteCommentRepository(
                    Configuration["ConnectionStrings:DefaultConnection"]));
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

            app.UseSession();


            app.UseCookieAuthentication(
                new CookieAuthenticationOptions()
                {
                    AuthenticationScheme = "Cookies",
                    LoginPath = new PathString("/User/Login"),
                    AccessDeniedPath = new PathString("/User/Forbidden"),
                    AutomaticAuthenticate = true,
                    AutomaticChallenge = true
                }
            );


            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
