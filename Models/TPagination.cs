using System.Text.Json.Serialization;

namespace Melon.Models;

public class APiPagination<T>
{
    [JsonPropertyName("page")]
    public long Page { get; set; }

    [JsonPropertyName("pageSize")]
    public long PageSize { get; set; }

    [JsonPropertyName("total")]
    public long Total { get; set; }

    [JsonPropertyName("totalPages")]
    public long TotalPages { get; set; }
    [JsonPropertyName("data")]
    public required T Data { get; set; } 
}