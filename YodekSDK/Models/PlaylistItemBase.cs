using System.Text.Json.Serialization;

namespace YodeckSDK.Models;

[JsonConverter(typeof(PlaylistItemConverter))]
public class PlaylistItemBase
{
    [JsonPropertyName("priority")]
    public int Priority { get; set; }
    
    [JsonPropertyName("type")]
    public string Type { get; set; }
}
