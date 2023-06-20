public class Startup
{
    public IConfiguration Configuration { get; set; }
    public Startup(IConfiguration config)
    {
        this.Configuration = config;
    }
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllersWithViews();
    }
    public void Configure(IApplicationBuilder app, IWebHostEnvironment evn)
    {
        app.UseStaticFiles();
        app.UseRouting();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(name: "Default", 
            pattern: "{controller=Home}/{action=Browse}/{id?}");
        });
    }
}