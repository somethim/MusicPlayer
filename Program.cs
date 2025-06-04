using DotNetEnv;
using DotNetEnv.Configuration;
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
                config.AddEnvironmentVariables()
                    .AddJsonFile("appsettings.json", true)
                    .AddDotNetEnv();
            })
            .ConfigureServices((context, services) =>
            {
                var connectionString = context.Configuration["DATABASE_CONNECTION_STRING"];
                services.AddDbContext<MusicPlayerContext>(options =>
                    options.UseNpgsql(connectionString));

                services.AddScoped<SignIn>();
            })
            .Build();

        ApplicationConfiguration.Initialize();
        var signIn = host.Services.GetRequiredService<SignIn>();
        Application.Run(signIn);
    }
}