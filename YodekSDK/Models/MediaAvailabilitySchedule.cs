using System.Text.Json.Serialization;

namespace YodeckSDK.Models;

public class MediaAvailabilitySchedule
{
    /// <summary>
    /// When true, the media is only available during the specified time slots/date range.
    /// </summary>
    [JsonPropertyName("enable")]
    public bool Enable { get; set; }

    /// <summary>
    /// The datetime after which the media becomes available (no timezone).
    /// </summary>
    [JsonPropertyName("available_after")]
    public DateTime? AvailableAfter { get; set; }

    /// <summary>
    /// The datetime until which the media is available (no timezone).
    /// </summary>
    [JsonPropertyName("available_before")]
    public DateTime? AvailableBefore { get; set; }

    /// <summary>
    /// Weekly time slots when the media can be displayed.
    /// </summary>
    [JsonPropertyName("availability_slots")]
    public List<MediaAvailabilitySlot> AvailabilitySlots { get; set; }
}