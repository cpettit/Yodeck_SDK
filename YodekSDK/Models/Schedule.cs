using System.Text.Json.Serialization;

namespace YodeckSDK.Models;

public class Schedule
{
    /// <summary>
    /// Unique ID for the schedule resource.
    /// </summary>
    [JsonPropertyName("id")]
    public long Id { get; set; }

    /// <summary>
    /// The name of the schedule, used to identify it within the system.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// The date/time the schedule was last modified (ISO 8601 format).
    /// </summary>
    [JsonPropertyName("last_modified")]
    public DateTime LastModified { get; set; }

    /// <summary>
    /// The workspace in which the schedule is allocated (null if unassigned).
    /// </summary>
    [JsonPropertyName("workspace")]
    public MinimumWorkspace Workspace { get; set; }

    /// <summary>
    /// The default content of the screen when there is no active schedule.
    /// </summary>
    [JsonPropertyName("default_content")]
    public DefaultContent DefaultContent { get; set; }
}
