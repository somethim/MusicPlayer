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
                services.AddDbContext<MusicPlayerContext>(options =>
                    options.UseNpgsql(connectionString));

                services.AddScoped<SignIn>();
            })
            .Build();

        ApplicationConfiguration.Initialize();


        try
        {
            var dbContext = host.Services.GetRequiredService<MusicPlayerContext>();
            var token = TokenHandler.GetStoredToken();

            if (token == null) throw new InvalidOperationException("No token found in local storage.");
            var user = User.FindByToken(dbContext);

            if (!TokenHandler.ValidateToken(user.EncryptedToken ??
                                            throw new InvalidOperationException("User token is null.")))
                throw new InvalidOperationException("Invalid or expired token.");

            Application.Run(new Dashboard(dbContext, user));
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            Application.Run(host.Services.GetRequiredService<SignIn>());
        }
    }
}