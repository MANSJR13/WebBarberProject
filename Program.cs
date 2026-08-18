using Microsoft.EntityFrameworkCore;
using WebBarber.Data;
using WebBarber.Repositorio;

namespace WebBarber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // MVC
            builder.Services.AddControllersWithViews();

            // Entity Framework Core + SQL Server
            builder.Services.AddDbContext<BancoContext>(options =>
                options.UseSqlServer(
                    builder.Configuration.GetConnectionString("DataBase")
                ));
            builder.Services.AddScoped<IClientesRepositorio, ClientesRepositorio>();
            builder.Services.AddScoped<IServicosRepositorio, ServicosRepositorio>();

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

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}