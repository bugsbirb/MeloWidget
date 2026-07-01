using System.Net.Http.Json;
using DotNetEnv;
using Melon.Models;
using NetCord.Services;

namespace Melon.Services;

public static class Endpoints
{
    public const string Moderations = "/server/logs/staff";
    public const string Shifts = "/server/shifts/user";
    public const string Member = "/server/members/discord";
    public const string Server = "/server/info";
}

public class Melonly
{

    private string _baseUrl = "https://api.melonly.xyz/api/v1";
    private string _token = Env.GetString("MELOTOKEN") ?? string.Empty;
    private HttpClient _http = new();
    

    public Melonly()
    {
        if (string.IsNullOrEmpty(_token))
        {
            Environment.FailFast("no token for melo set.");
        }
        _http.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", _token);

    }

    public async Task<Server?> GetServer()
    {
        string url = $"{_baseUrl}{Endpoints.Server}";
        HttpResponseMessage response = await _http.GetAsync(url);
        response.EnsureSuccessStatusCode();
        Server? result = await response.Content.ReadFromJsonAsync<Server>();
        return result;
        
    }

    public async Task<Member?> GetUser(ulong userId)
    {
        string url = $"{_baseUrl}{Endpoints.Member}/{userId}";
        HttpResponseMessage response = await _http.GetAsync(url);
        response.EnsureSuccessStatusCode();
        Member? result = await response.Content.ReadFromJsonAsync<Member>();
        return result;
    }

    public async Task<int> GetModerations(string uId)
    {
        string url = $"{_baseUrl}{Endpoints.Moderations}/{uId}?page=1&pageSize=1&limit=1"; // ;)
        HttpResponseMessage response = await _http.GetAsync(url);
        response.EnsureSuccessStatusCode();
        var result = await response.Content.ReadFromJsonAsync<APiPagination<object>>();
        return result != null ? (int)result.Total : 0;
         
        
    }
    
    public async Task<(List<Shifts>? Shifts, long TotalCount)?> GetShifts(string uId)
    {
        string url = $"{_baseUrl}{Endpoints.Shifts}/{uId}";
        async Task<APiPagination<List<Shifts>>?> FetchPage(int pageNum)        
        {
            HttpResponseMessage response = await _http.GetAsync(url + $"?page={pageNum}&pageSize=100");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<APiPagination<List<Shifts>>>();
        }
    
        var shifts = await FetchPage(1);
        if (shifts == null)
        {
            return (null, 0);
        }
    
        long total = shifts.Total;
        List<Shifts> idk = new();

        if (shifts.TotalPages == 1)
        {
            idk.AddRange(shifts.Data);
            return (idk, total); 
        }
    
        for (int page = 2; page <= (int)shifts.TotalPages; page++)
        {
            var next = await FetchPage(page);

            if (next?.Data != null)
            {
                idk.AddRange(next.Data);
            }
        }

        return (idk, total);
    }


}