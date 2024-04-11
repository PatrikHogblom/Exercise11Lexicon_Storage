using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Storage.Data;
namespace Storage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            //creates a srvice connection to database named StorageContext-cd9928e5-9e0c-492b-8a84-1181434a4d5f
            builder.Services.AddDbContext<StorageContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("StorageContext") ?? throw new InvalidOperationException("Connection string 'StorageContext' not found.")));

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();//Adds middleware for redirecting HTTP Requests to HTTPS.
            app.UseStaticFiles();//Enables static file serving for the current request path, i.e. js, css files 

            app.UseRouting();

            app.UseAuthorization();

            /*app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");*/

            //changed the default routing from Home/Index to Product/Index
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Products}/{action=Index}/{id?}");


            app.Run();
        }
    }
}
