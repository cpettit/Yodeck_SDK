using System.Text.Json.Serialization;

namespace YodeckSDK.Models;

public class TakeoverContent
{
    /// <summary>
    /// Unique ID for the Schedule/Media/Playlist/Layout used in the takeover.
    /// </summary>
    [JsonPropertyName("source_id")]
    public long SourceId { get; set; }

    /// <summary>
    /// The type of the source component ("playlist", "media", "layout").
    /// </summary>
    [JsonPropertyName("source_type")]
    public string SourceType { get; set; }

    /// <summary>
    /// The name of the content shown during the takeover.
    /// </summary>
    [JsonPropertyName("source_name")]
    public string SourceName { get; set; }

    /// <summary>
    /// The date/time when the content started displaying (ISO 8601).
    /// </summary>
    [JsonPropertyName("start")]
    public DateTime Start { get; set; }

    /// <summary>
    /// The date/time when the content will end (ISO 8601).
    /// </summary>
    [JsonPropertyName("end")]
    public DateTime End { get; set; }
}