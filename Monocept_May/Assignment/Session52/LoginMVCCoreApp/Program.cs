public class Program{
    public static void Main(String[] args){
        CreateHostBuilder(args)
            .Build()    //Configure Services , DI Services
            .Run();     //Configure , Request Pipeline 
    }
    public static IHostBuilder CreateHostBuilder(String[] args){
        return  Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults((builder)=>{
                builder.UseStartup<Startup>();
            });
    }
}