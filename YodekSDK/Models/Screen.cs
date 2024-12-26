using System.Text.Json.Serialization;

namespace YodeckSDK.Models;

public class Screen
    {
        /// <summary>
        /// An object providing details about the default and scheduled content shown on the screen.
        /// </summary>
        [JsonPropertyName("screen_content")]
        public ScreenContent ScreenContent { get; set; }

        /// <summary>
        /// Unique ID for the Screen.
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// The name of the screen.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// A short description of the screen (null if not provided).
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The workspace the screen is allocated to (null if not assigned).
        /// </summary>
        [JsonPropertyName("workspace")]
        public MinimumWorkspace? Workspace { get; set; }

        /// <summary>
        /// The URL of the screen's screenshot.
        /// </summary>
        [JsonPropertyName("screenshot_url")]
        public string ScreenshotUrl { get; set; }

        /// <summary>
        /// The date/time the Screen was created (ISO 8601).
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// The date/time the Screen was last modified (ISO 8601).
        /// </summary>
        [JsonPropertyName("last_modified")]
        public DateTime LastModified { get; set; }

        /// <summary>
        /// The date/time the Screen was last pushed (ISO 8601).
        /// </summary>
        [JsonPropertyName("last_pushed")]
        public DateTime LastPushed { get; set; }

        /// <summary>
        /// Connection and registration state of the Screen.
        /// </summary>
        [JsonPropertyName("state")]
        public ScreenState State { get; set; }

        /// <summary>
        /// Temporary "takeover" content that overrides the default or scheduled content.
        /// </summary>
        [JsonPropertyName("takeover_content")]
        public TakeoverContent? TakeoverContent { get; set; }
    }