using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MusicPlayer.database;

namespace MusicPlayer;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        var host = Host.CreateDefaultBuilder()
            .ConfigureAppConfiguration((_, config) => { config.AddJsonFile("Assets/appsettings.json", false, true); })
            .ConfigureServices((context, services) =>
            {
                var connectionString = context.Configuration.GetConnectionString("DefaultConnection");
                services.AddDbContext<MusicPlayerContext>(options =>
                    options.UseNpgsql(connectionString));
                services.AddScoped<Dashboard>();
            })
            .Build();

        ApplicationConfiguration.Initialize();
        var dashboard = host.Services.GetRequiredService<Dashboard>();
        Application.Run(dashboard);
    }
}