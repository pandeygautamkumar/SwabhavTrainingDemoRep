public class Program{
    public static void Main(string[] args){
        CreateHostBuilder(args)
            .Build()    //Configure Services ,DI Services
            .Run();     //Config, Request Pipeline
    }
    public static IHostBuilder CreateHostBuilder(string[] args){
        return Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults((WebBuilder)=>{
                WebBuilder.UseStartup<Startup>();
            });
    }
}