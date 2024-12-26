using System.Text.Json.Serialization;

namespace YodeckSDK.Models;

public class Folder
{
    /// <summary>
    /// Unique ID for the folder resource.
    /// </summary>
    [JsonPropertyName("id")]
    public long Id { get; set; }

    /// <summary>
    /// The name of the folder, used to identify it within the system.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// The parent folder to which this folder belongs (null if none).
    /// </summary>
    [JsonPropertyName("parent_folder")]
    public MinimumFolder ParentFolder { get; set; }

    /// <summary>
    /// The workspace in which the folder is allocated (null if none).
    /// </summary>
    [JsonPropertyName("workspace")]
    public MinimumWorkspace Workspace { get; set; }
}