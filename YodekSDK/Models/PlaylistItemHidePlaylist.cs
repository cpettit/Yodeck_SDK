using System.Text.Json.Serialization;

namespace YodeckSDK.Models;

public class PlaylistItemHidePlaylist : PlaylistItemBase
{
    [JsonPropertyName("duration")]
    public int Duration { get; set; }
}