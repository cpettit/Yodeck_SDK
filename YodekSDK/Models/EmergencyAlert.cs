using System.Text.Json.Serialization;

namespace YodeckSDK.Models;

public class EmergencyAlert
{
    /// <summary>
    /// The unique identifier for the emergency alert.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// The category of the emergency alert (e.g., geographic, safety, weather).
    /// </summary>
    [JsonPropertyName("category")]
    public string Category { get; set; }

    /// <summary>
    /// The name of the emergency alert.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// The icon associated with the emergency alert.
    /// </summary>
    [JsonPropertyName("icon")]
    public string Icon { get; set; }

    /// <summary>
    /// A short headline for the emergency alert.
    /// </summary>
    [JsonPropertyName("headline")]
    public string Headline { get; set; }

    /// <summary>
    /// A more detailed description of the emergency alert.
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; }

    /// <summary>
    /// Instructions for actions to take in response to the alert.
    /// </summary>
    [JsonPropertyName("instruction")]
    public string Instruction { get; set; }

    /// <summary>
    /// The number of screens assigned to display this emergency alert.
    /// </summary>
    [JsonPropertyName("screen_assigned_count")]
    public int ScreenAssignedCount { get; set; }
}