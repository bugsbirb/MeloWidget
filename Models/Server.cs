using System.Text.Json.Serialization;

namespace Melon.Models;

public class Server
{
    [JsonPropertyName("createdAt")]
    public long CreatedAt { get; set; }
    
    [JsonPropertyName("discordGuildId")]
    public required string DiscordGuildId { get; set; }
    
    [JsonPropertyName("id")]
    public required string Id { get; set; }
    
    [JsonPropertyName("joinCode")]
    public required string JoinCode { get; set; }
    
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("roles")] 
    public List<string>? Roles { get; set; }

}