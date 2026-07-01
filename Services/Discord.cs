using System.Net.Http.Headers;
using System.Text;
using DotNetEnv;
using Melon.Models;

namespace Melon.Services;

public class Discord
{
    private string _baseUrl = "https://discord.com/api/v9";
    private HttpClient _httpClient = new();
    private string _token = Env.GetString("TOKEN") ?? string.Empty;
    private string _botId = Env.GetString("BOTID") ?? string.Empty;

    private Melonly _melon = new();
    private Time _time = new();
    
    public Discord()
    {
        if (string.IsNullOrEmpty(_token))
        {
            Environment.FailFast("Discord API Token is invalid");
        }
    }

    public async Task<object?> DynamicData(string uId, string? serverName)
    {
        (List<Shifts>? Shifts, long TotalCount)? result = await _melon.GetShifts(uId);
        if (result == null)
        {
            return null;
        }

        string? sName = serverName;
        if (string.IsNullOrEmpty(serverName))
        {
            Server? server = await _melon.GetServer();
            if (server != null)
            {
                sName = server.Name;
            }
        }
        
        int totalModerations = await _melon.GetModerations(uId);
        
        List<Shifts>? shifts = result.Value.Shifts;
        
        ulong totalTime = 0;
        
        if (shifts != null && shifts.Count != 0)
        {
            foreach (Shifts shift in shifts)
            {
                if (shift.CreatedAt.HasValue && shift.EndedAt.HasValue)
                {
                    totalTime += (shift.EndedAt.Value - shift.CreatedAt.Value);
                }
                if (shift.BreakTimeStamps != null)
                {
                    foreach (Break breake in shift.BreakTimeStamps)
                    {
                        if (breake.EndedAt.HasValue && breake.StartedAt.HasValue)
                        {
                            totalTime -= (breake.EndedAt.Value - breake.StartedAt.Value);
                        }
                    }
                }
            }
        }
        totalTime = Math.Max(totalTime, 0);
        TimeSpan duration = TimeSpan.FromMilliseconds(totalTime);
        Console.WriteLine(_time.Format(duration));
        List<object> dynamicData = new()
        {
            new { type = 1, name = "time", value = _time.Format(duration)},
            new { type = 1, name = "moderations", value = totalModerations},
            new { type = 1, name = "shifts", value = result.Value.TotalCount.ToString()},
            new { type = 1, name = "server", value = sName ?? "Unknown"}

        };
        return new
        {
            username = "MelWidget", // I don't get the use case for this? But it's on every tutorial.
            data = new { dynamic = dynamicData }
        };
    }


    public async Task<bool> Call(ulong userId, object payload)
    {
        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bot", _token);
        string requestUri = $"{_baseUrl}/applications/{_botId}/users/{userId}/identities/0/profile";

        string jsonString = System.Text.Json.JsonSerializer.Serialize(payload);
        StringContent jsonPayload = new(jsonString, Encoding.UTF8, "application/json");

        HttpResponseMessage response = await _httpClient.PatchAsync(requestUri, jsonPayload);

        if (!response.IsSuccessStatusCode)
        {
            string errorJson = await response.Content.ReadAsStringAsync();
            Console.WriteLine($"[DISCORD API ERROR CODE: {(int)response.StatusCode}] Details: {errorJson}");
            return false;
        }
        return true;
    }

}
