using System.Text.Json.Serialization;

namespace YodeckSDK.Models;

public class DefaultContent
{
    /// <summary>
    /// Unique ID of the source component (media, playlist, layout, etc.).
    /// </summary>
    [JsonPropertyName("source_id")]
    public long SourceId { get; set; }

    /// <summary>
    /// Name of the source component.
    /// </summary>
    [JsonPropertyName("source_name")]
    public string SourceName { get; set; }

    /// <summary>
    /// Type of the source component ("playlist", "media", "layout", "turned_off").
    /// If "turned_off", the screen will be turned off and SourceId is ignored.
    /// </summary>
    [JsonPropertyName("source_type")]
    public string SourceType { get; set; }
}