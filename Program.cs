using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ForYod;
using ForYod.Components;
using ForYod.Components.Services; // Add this line to include the UserService namespace

namespace ForYod
{
    public class Program
    {
        public static void Main(string[] args)
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

            // Register the UserService as a singleton
            builder.Services.AddSingleton<UserService>();
     


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
