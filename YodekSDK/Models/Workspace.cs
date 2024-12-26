using System.Text.Json.Serialization;

namespace YodeckSDK.Models;

public class Workspace
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("last_applied")]
    public DateTime LastApplied { get; set; }

    [JsonPropertyName("parent_workspace")]
    public Workspace ParentWorkspace { get; set; }

    [JsonPropertyName("screen_quota")]
    public int ScreenQuota { get; set; }
}