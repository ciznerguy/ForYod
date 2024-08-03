using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ForYod;
using ForYod.Components;
<<<<<<< HEAD
using ForYod.Components.Services; // Add this line to include the UserService namespace

namespace ForYod
{
    public class Program
    {
        public static void Main(string[] args)
=======

namespace ForYod
{
    class Program
    {
        static void Main(string[] args)
>>>>>>> 230d044b6afcb745ab8d418295da8c43078c0935
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            // Add logging
            builder.Logging.AddConsole();

            // Register the DbContext with the SQLite connection string
            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"))
                       .EnableSensitiveDataLogging()
                       .LogTo(Console.WriteLine, LogLevel.Information));

<<<<<<< HEAD
            // Register the UserService as a singleton
            builder.Services.AddSingleton<UserService>();
     


=======
>>>>>>> 230d044b6afcb745ab8d418295da8c43078c0935
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}
