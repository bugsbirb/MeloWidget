using Melon.Models;
using Melon.Services;
using Microsoft.Data.Sqlite;

namespace Melon.Tasks;

public class Refresh : BackgroundService
{
    private readonly ILogger<Refresh> _logger;
    private readonly Sqlite _sqlite;
    private readonly Discord _discord;
    public Refresh(ILogger<Refresh> logger,  Sqlite sqlite, Discord discord)
    {
        _logger = logger;
        _sqlite = sqlite;
        _discord = discord;
    }
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            List<UserTasks> tasks = await _sqlite.GetTasks();
            foreach (UserTasks users in tasks)
            {
                object? dynamicData = await _discord.DynamicData(users.UserId, null);
                if (dynamicData == null)
                {
                    continue;
                }
                bool result = await _discord.Call(users.DiscordId, dynamicData);
                if (!result)
                {
                    continue;
                }
                await Task.Delay(TimeSpan.FromSeconds(10), stoppingToken);

            }
            await Task.Delay(TimeSpan.FromMinutes(30), stoppingToken);
        }
    }
}