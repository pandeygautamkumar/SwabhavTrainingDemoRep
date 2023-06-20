public class Startup{
    public IConfiguration Configuration {get; private set;}
    public Startup(IConfiguration connfig)  //DI
    {
        this.Configuration=connfig;
    }

    //Services,DI(Loosally Coupled /OCP)
    public void ConfigureServices(IServiceCollection services){
        services.AddControllersWithViews();

    }

    // Request Pipeline
    public void Configure(IApplicationBuilder app,IWebHostEnvironment env){
        app.UseStaticFiles();
        app.UseRouting();
        app.UseEndpoints(endpoints=>{
            endpoints.MapControllerRoute(name:"default",
            pattern:"{controller=Home}/{action=Index}/{id?}");
        });
        //app.UseMyMiddlewareStattionB
        //app.UseMyMiddlewareStattionA
    }
}