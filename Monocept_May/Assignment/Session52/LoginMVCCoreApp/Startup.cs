public class Startup{
    public IConfiguration Configuration {get; private set;}
    public Startup(IConfiguration connfig)  //DI
    {
        this.Configuration=connfig;
    }

    //Services,DI(Loosally Coupled /OCP)
    public void ConfigureServices(IServiceCollection services){
        services.AddControllersWithViews();
        // services.AddAuthentication(Cookies)
        //services.Add
    }

    // Request Pipeline
    public void Configure(IApplicationBuilder app,IWebHostEnvironment env){
        app.UseStaticFiles();
        app.UseHttpsRedirection();
        app.UseRouting();
        app.UseAuthentication();
        app.UseAuthorization();
        app.UseEndpoints(endpoints=>{
            endpoints.MapControllerRoute(name:"default",
            pattern:"{controller=Login}/{action=Index}/{id?}");
        });
        //app.UseMyMiddlewareStattionB
        //app.UseMyMiddlewareStattionA
    }
}