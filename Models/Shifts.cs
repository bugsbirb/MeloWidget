using System.Text.Json.Serialization;
namespace Melon.Models;

public class Break
{
    [JsonPropertyName("startedAt")]
    public required ulong? StartedAt { get; set; }
    
    [JsonPropertyName("endedAt")]
    public ulong? EndedAt { get; set; }

}

public class Shifts
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }
    
    [JsonPropertyName("autoEnd")]
    public bool AutoEnd { get; set; }

    [JsonPropertyName("breakTimestamps")] 
    public List<Break>? BreakTimeStamps { get; set; } = new List<Break>();
    
    [JsonPropertyName("createdAt")]
    public required ulong? CreatedAt { get; set; }
    
    [JsonPropertyName("endedAt")]
    public ulong? EndedAt { get; set; }
    
    [JsonPropertyName("wave")]
    public ulong? Wave { get; set; }
    
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}