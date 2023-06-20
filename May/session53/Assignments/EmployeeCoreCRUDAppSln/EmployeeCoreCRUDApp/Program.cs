using Microsoft.AspNetCore.Authentication.Cookies;

namespace EmployeeCoreCRUDApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            //builder.Services.AddDistributedMemoryCache();
            //builder.Services.AddSession(options =>
            //{
            //    options.Cookie.Name = "MyApp.Session";
            //    options.IdleTimeout = TimeSpan.FromMinutes(30);
            //});
            //builder.Services.AddAuthentication("CustomScheme")
            //    .AddCookie("CustomScheme", options =>
            //    {
            //        options.LoginPath = new PathString("/Login/Index");
            //    });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            //app.UseSession();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Employee}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
