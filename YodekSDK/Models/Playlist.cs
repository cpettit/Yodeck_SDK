using System.Text.Json.Serialization;

namespace YodeckSDK.Models;

public class Playlist
{
    
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("workspace")]
    public MinimumWorkspace? Workspace { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("last_modified")]
    public DateTime LastModified { get; set; }

    [JsonPropertyName("thumbnail_url")]
    public string ThumbnailUrl { get; set; }

    [JsonPropertyName("items")]
    public List<PlaylistItemBase> Items { get; set; }
}