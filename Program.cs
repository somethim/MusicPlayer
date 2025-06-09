using DotNetEnv;
using DotNetEnv.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MusicPlayer.Auth;
using MusicPlayer.database;
using MusicPlayer.database.Models;
using MusicPlayer.Utils;

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
                services.AddDbContext<RemoteMusicPlayerContext>(options =>
                    options.UseNpgsql(connectionString));

                services.AddDbContext<LocalMusicPlayerContext>(options =>
                    options.UseSqlite("Data Source=local_music_player.db"));

                services.AddScoped<SignIn>();
            })
            .Build();

        ApplicationConfiguration.Initialize();

        try
        {
            var dbContext = host.Services.GetRequiredService<RemoteMusicPlayerContext>();
            var token = TokenHandler.GetStoredToken() ??
                        throw new InvalidOperationException("No token found in local storage.");
            if (token == null || string.IsNullOrEmpty(token.Token))
                throw new InvalidOperationException("No valid token found in local storage.");

            var user = User.FindByToken(dbContext, token);

            if (!TokenHandler.ValidateToken(user.EncryptedToken ??
                                            throw new InvalidOperationException("User token is null.")))
                throw new InvalidOperationException("Invalid or expired token.");

            // var localDbContext = host.Services.GetRequiredService<LocalMusicPlayerContext>();
            Application.Run(new Dashboard());
        }
        catch (Exception)
        {
            Application.Run(host.Services.GetRequiredService<SignIn>());
        }
    }
}