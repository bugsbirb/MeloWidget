using System.Net;
using DotNetEnv;
using Melon.Models;
using Melon.Services;

namespace Melon.Bot.Tasks;

public class Refresh(ILogger<Refresh> logger, Sqlite sqlite, Discord discord) : BackgroundService
{
    private readonly int _delay = Env.GetInt("AUTOMATIC_REFRESH_DELAY", 30);

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            List<UserTasks> tasks = await sqlite.GetTasks();
            foreach (UserTasks users in tasks)
            {
                object? dynamicData = null;
                try
                {
                    dynamicData = await discord.DynamicData(users.UserId, null);
                }
                catch (HttpRequestException ex)
                    when (ex.StatusCode == HttpStatusCode.TooManyRequests)
                {
                    logger.LogWarning(
                        "Melonly rate limited/credits ran out during background refresh."
                    );
                    continue;
                }

                if (dynamicData == null)
                {
                    continue;
                }
                bool result = await discord.Call(users.DiscordId, dynamicData);
                if (!result)
                {
                    continue;
                }
                logger.LogInformation(
                    $"[Automatic Refresh] @{users.UserId} information has been refreshed."
                );
                await Task.Delay(TimeSpan.FromSeconds(10), stoppingToken);
            }
            await Task.Delay(TimeSpan.FromMinutes(_delay), stoppingToken);
        }
    }
}
