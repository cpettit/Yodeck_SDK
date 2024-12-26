using System.Text.Json.Serialization;

namespace YodeckSDK.Models;

public class Layout
{
    /// <summary>
    /// Unique ID for the layout.
    /// </summary>
    [JsonPropertyName("id")]
    public long Id { get; set; }

    /// <summary>
    /// The name of the layout.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// The workspace in which the layout is allocated (null if not assigned).
    /// </summary>
    [JsonPropertyName("workspace")]
    public MinimumWorkspace Workspace { get; set; }

    /// <summary>
    /// The width of the layout resolution in pixels.
    /// </summary>
    [JsonPropertyName("resolution_width")]
    public int ResolutionWidth { get; set; }

    /// <summary>
    /// The height of the layout resolution in pixels.
    /// </summary>
    [JsonPropertyName("resolution_height")]
    public int ResolutionHeight { get; set; }

    /// <summary>
    /// The date/time the layout was created (ISO 8601).
    /// </summary>
    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// The date/time the layout was last modified (ISO 8601).
    /// </summary>
    [JsonPropertyName("last_modified")]
    public DateTime LastModified { get; set; }
}