using Microsoft.EntityFrameworkCore;
using MovieManagerMVC.Data;
using MovieManagerMVC.Data.Services;

namespace MovieManagerMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            #region Service Configurations
            //Db Context
            builder.Services.AddDbContext<AppDbContext>(options => 
                        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString"))
                        );
            //Table Services
            builder.Services.AddScoped<IActorsService, ActorsService>();
            #endregion
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                //app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Movies}/{action=Index}/{id?}");

            AppDbInitializer.Seed(app);

            app.Run();
        }
    }
}