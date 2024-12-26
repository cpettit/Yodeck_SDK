using System.Text.Json.Serialization;

namespace YodeckSDK.Models;

public class Media
    {
        /// <summary>
        /// Unique ID for the media resource.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// The name of the media, used to identify it in the system.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Detailed information about the origin and type of the media.
        /// </summary>
        [JsonPropertyName("media_origin")]
        public MediaOrigin MediaOrigin { get; set; }

        /// <summary>
        /// The type of the media (e.g., image, video, audio, webpage, document).
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// The source of the media (e.g., local, url, stream, usb_stream, or null).
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }

        /// <summary>
        /// The format (pdf, video, or null). Applies mostly to document-type media.
        /// </summary>
        [JsonPropertyName("format")]
        public string Format { get; set; }

        /// <summary>
        /// A short description providing additional context about the media.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The default duration (in seconds) for which the media is displayed.
        /// </summary>
        [JsonPropertyName("default_duration")]
        public long DefaultDuration { get; set; }

        /// <summary>
        /// A list of tags associated with the media.
        /// </summary>
        [JsonPropertyName("tags")]
        public List<string> Tags { get; set; }

        /// <summary>
        /// The file extension (e.g., 'jpg', 'mp4'), or null if not applicable.
        /// </summary>
        [JsonPropertyName("file_extension")]
        public string FileExtension { get; set; }

        /// <summary>
        /// The datetime when the media was created (ISO 8601 format).
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// The datetime when the media was last modified (ISO 8601 format).
        /// </summary>
        [JsonPropertyName("last_modified")]
        public DateTime LastModified { get; set; }

        /// <summary>
        /// The datetime when the media was last uploaded (ISO 8601 format).
        /// </summary>
        [JsonPropertyName("last_uploaded")]
        public DateTime LastUploaded { get; set; }

        /// <summary>
        /// The current status of the media: initialized, uploading, encoding, finished, or failed.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// The URL of the media's thumbnail, if available.
        /// </summary>
        [JsonPropertyName("thumbnail_url")]
        public string ThumbnailUrl { get; set; }

        /// <summary>
        /// The schedule that defines when the media is available for display.
        /// </summary>
        [JsonPropertyName("availability_schedule")]
        public MediaAvailabilitySchedule AvailabilitySchedule { get; set; }

        /// <summary>
        /// Specific attributes related to the type of media (image, video, audio, document, webpage).
        /// </summary>
        [JsonPropertyName("arguments")]
        public ArgumentsDetail Arguments { get; set; }

        /// <summary>
        /// The workspace in which the media is allocated. Null if not in a workspace.
        /// </summary>
        [JsonPropertyName("workspace")]
        public MinimumWorkspace Workspace { get; set; }

        /// <summary>
        /// The folder to which the media belongs. Null if not assigned to any folder.
        /// </summary>
        [JsonPropertyName("parent_folder")]
        public MinimumFolder ParentFolder { get; set; }
    }