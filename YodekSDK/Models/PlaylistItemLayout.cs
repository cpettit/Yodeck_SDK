using System.Text.Json.Serialization;

namespace YodeckSDK.Models;

public class PlaylistItemLayout : PlaylistItemBase
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    [JsonPropertyName("duration")]
    public int Duration { get; set; }
    
    [JsonPropertyName("name")]
    public string Name { get; set; }
}