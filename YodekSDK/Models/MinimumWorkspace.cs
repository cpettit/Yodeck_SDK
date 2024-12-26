using System.Text.Json.Serialization;

namespace YodeckSDK.Models;

public class MinimumWorkspace
{
    /// <summary>
    /// Unique ID for the workspace resource.
    /// </summary>
    [JsonPropertyName("id")]
    public long Id { get; set; }

    /// <summary>
    /// The name of the workspace.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}
