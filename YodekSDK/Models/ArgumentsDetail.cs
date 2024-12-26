using System.Text.Json.Serialization;

namespace YodeckSDK.Models;

public class ArgumentsDetail
{
    /// <summary>
    /// The URL from which the media can be downloaded (if applicable).
    /// </summary>
    [JsonPropertyName("download_from_url")]
    public string DownloadFromUrl { get; set; }
}