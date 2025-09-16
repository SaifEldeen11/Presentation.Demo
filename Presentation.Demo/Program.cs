//This Code was made by Eng Saif:)
using BusniessLogicLayer.Services;
using BusniessLogicLayer.Services.InterFaces;
using Demo.Data_Acess_Layer.Data.Contexts;
using Demo.Data_Acess_Layer.Repostries;
using Microsoft.EntityFrameworkCore;

namespace Presentation.Demo
{
    // By far this is my best demo :D
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            #region Add-Services to container
            builder.Services.AddControllersWithViews();
            //builder.Services.AddScoped<ApplicationDbContext>();
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            //options.UseSqlServer(builder.Configuration["ConnectionStrings:DefultConnection"]);
            //options.UseSqlServer(builder.Configuration.GetSection("ConnectionStrings")["DefultConnection"];
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefultConnection")

            ));
            builder.Services.AddScoped<IDepartmentRepostiry,DepartmentRepostiry>(); // when he ask for IDepartmentRepostiry give him DepartmentRepostiry
            builder.Services.AddScoped<IDepartmentServices, DepartmentServices>();
            //builder.Services.AddAutoMapper();
            #endregion

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            #region Configure the HTTP request pipeline. 
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            #endregion

            app.UseHttpsRedirection(); // when have http it will redirect to https
            app.UseStaticFiles();

            app.UseRouting();

            //app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}"); 

            app.Run();
        }
    }
}





