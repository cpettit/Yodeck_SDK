using System.Text.Json.Serialization;

namespace YodeckSDK.Models;

public class MediaOrigin
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("source")]
    public string Source { get; set; }

    [JsonPropertyName("format")]
    public string Format { get; set; }
}