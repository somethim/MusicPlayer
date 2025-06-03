using DotNetEnv;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MusicPlayer.Auth;
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

                services.AddScoped<SignIn>();
                services.AddScoped<Dashboard>();
                services.AddScoped<Music>();
                services.AddScoped<Settings>();
            })
            .Build();

        ApplicationConfiguration.Initialize();
        var auth = host.Services.GetRequiredService<SignIn>();
        Application.Run(auth);
    }
}