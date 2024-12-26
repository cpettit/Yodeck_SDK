using System.Text.Json.Serialization;

namespace YodeckSDK.Models;

public class MediaAvailabilitySlot
{
    /// <summary>
    /// Start time (HH:mm:ss) when the media becomes available.
    /// </summary>
    [JsonPropertyName("start")]
    public string Start { get; set; }

    /// <summary>
    /// End time (HH:mm:ss) when the media is no longer available.
    /// </summary>
    [JsonPropertyName("end")]
    public string End { get; set; }

    /// <summary>
    /// A binary string representing active days (Mon=0 to Sun=6). E.g., "0101011".
    /// </summary>
    [JsonPropertyName("days_of_week")]
    public string DaysOfWeek { get; set; }
}