using MiddleWareMVCApp.Services;

namespace MiddleWareMVCApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            //builder.Services.AddSingleton<IEmailService,GmailService>();
            builder.Services.AddTransient<IEmailService, GmailService>();
            //builder.Services.AddSingleton<IEmailService, GmailService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            //Middleware Function F1
            app.Use(async (context, next) =>
            {
                Console.WriteLine("(Red) Before f1");
                await next(context);
                Console.WriteLine("(Blue) After f1");
            });
            //Middleware Function F2
            app.Use(async (context, next) =>
            {
                Console.WriteLine("(Red) Before f2");
                await next(context);
                Console.WriteLine("(Blue) After f2");
            });
            //app.Map()
            app.Map("/api/hello", (appBuilder) =>
            {
                appBuilder.Use(async (context, next) =>
                {
                    Console.WriteLine("(Red) Before f3");
                    await next(context);
                    Console.WriteLine("(Blue) After f3");
                });
                //app.Run(async (context) =>
                //{
                //    Console.WriteLine("(Red) Before f3");
                //    await context.Response.WriteAsync("End of Pipeline");
                //});
            });
            //app.UseMiddleware<MiddlewareFoo>();
            app.UseMiddlewareFoo();
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}