using System.Text.Json.Serialization;

namespace YodeckSDK.Models;

public class ScreenContent
{
    /// <summary>
    /// Unique ID of the source component (Media, Playlist, Schedule, Layout).
    /// If "turned_off", this is ignored.
    /// </summary>
    [JsonPropertyName("source_id")]
    public long SourceId { get; set; }

    /// <summary>
    /// The name of the source component (Media, Playlist, Schedule, Layout).
    /// </summary>
    [JsonPropertyName("source_name")]
    public string SourceName { get; set; }

    /// <summary>
    /// The type of the source (e.g., "media", "playlist", "layout", "schedule", "turned_off").
    /// If set to "turned_off", the screen is off and SourceId is ignored.
    /// </summary>
    [JsonPropertyName("source_type")]
    public string SourceType { get; set; }
}