using System.Text.Json.Serialization;

namespace YodeckSDK.Models;

public class ScreenState
{
    /// <summary>
    /// Indicates whether the screen is currently online.
    /// </summary>
    [JsonPropertyName("online")]
    public bool Online { get; set; }

    /// <summary>
    /// The last time the screen was seen online (ISO 8601).
    /// </summary>
    [JsonPropertyName("last_seen")]
    public DateTime LastSeen { get; set; }

    /// <summary>
    /// Indicates whether the screen software is being updated.
    /// </summary>
    [JsonPropertyName("updating")]
    public bool Updating { get; set; }

    /// <summary>
    /// Indicates whether the screen is registered in the system.
    /// </summary>
    [JsonPropertyName("registered")]
    public bool Registered { get; set; }
}