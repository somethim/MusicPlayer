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
            .ConfigureServices((context, services) =>
            {
                var connectionString = context.Configuration.GetConnectionString("DefaultConnection");
                services.AddDbContext<MusicPlayerContext>(options =>
                    options.UseNpgsql(connectionString));
                services.AddScoped<Settings>();
            })
            .Build();

        ApplicationConfiguration.Initialize();
        var settings = host.Services.GetRequiredService<Settings>();
        Application.Run(settings);
    }
}