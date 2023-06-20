using EmployeeCoreCRUDApp.Services;
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
            builder.Services.AddSingleton<IEmployeeServices, EmployeeInMemoryServices>();
            builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                            .AddCookie(options =>
                            {
                                options.Cookie.Name = "YourCookieName"; // Set the cookie name
                                options.Cookie.SecurePolicy = CookieSecurePolicy.SameAsRequest; // Adjust the secure policy as per your needs
                                options.Cookie.HttpOnly = true; // Set HttpOnly to prevent JavaScript access
                                options.ExpireTimeSpan = TimeSpan.FromMinutes(30); // Set the cookie expiration time
                                options.LoginPath = "/Login/Index"; // Specify the login path
                                options.AccessDeniedPath = "/Error/AccessDenied"; // Specify the access denied path
                            });
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Employee}/{action=Index}/{id?}");

            app.Run();
        }
    }
}