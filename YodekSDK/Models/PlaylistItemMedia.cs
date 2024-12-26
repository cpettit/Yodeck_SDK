using System.Text.Json.Serialization;

namespace YodeckSDK.Models;

public class PlaylistItemMedia : PlaylistItemBase
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    [JsonPropertyName("max_time")]
    public int MaxTime { get; set; }
    
    [JsonPropertyName("max_items")]
    public int MaxItems { get; set; }
    
    [JsonPropertyName("name")]
    public string Name { get; set; }
}