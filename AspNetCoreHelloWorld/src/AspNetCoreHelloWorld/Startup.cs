using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace AspNetCoreHelloWorld
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env,
            ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Hello World! [1]");
                await next();
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World! [2]");
            });

            app.Run(async (context) =>
            {
                //await context.Response.WriteAsync("Hello World!");
                await context.Response.WriteAsync("Hello World! - ASP.NET Core 1.0");
            });
        }
    }
}
