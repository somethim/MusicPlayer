using DotNetEnv;
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
        Env.Load();

        var host = Host.CreateDefaultBuilder()
            .ConfigureAppConfiguration((_, config) =>
            {
                config.Sources.Clear();
                config.AddEnvironmentVariables();
                config.AddJsonFile("appsettings.json", true);
            })
            .ConfigureServices((_, services) =>
            {
                var connectionString = Environment.GetEnvironmentVariable("DATABASE_CONNECTION_STRING");
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