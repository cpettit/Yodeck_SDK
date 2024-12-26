using System.Text.Json.Serialization;

namespace YodeckSDK.Models;

public class MinimumFolder
{
    /// <summary>
    /// Unique ID for the folder resource.
    /// </summary>
    [JsonPropertyName("id")]
    public long Id { get; set; }

    /// <summary>
    /// The name of the folder.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}