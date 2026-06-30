using System.Text.Json.Serialization;

namespace Melon.Models;

public class Member
{
    [JsonPropertyName("serverId")]
    public ulong ServerId { get; private set; }
    
    [JsonPropertyName("roles")]
    public List<object>? Roles { get; private set; }
    
    [JsonPropertyName("createdAt")]
    public required ulong CreatedAt { get; set; }
    
    [JsonPropertyName("id")]
    public required string Id { get; set; }
    

}