using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace YodeckSDK.Models
{
    public class PlaylistItemConverter : JsonConverter<PlaylistItemBase>
    {
        public override PlaylistItemBase Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            // Parse the raw JSON into a JsonDocument for inspection
            using (JsonDocument jsonDocument = JsonDocument.ParseValue(ref reader))
            {
                // Extract the 'type' property
                if (!jsonDocument.RootElement.TryGetProperty("type", out JsonElement typeElement))
                {
                    throw new JsonException("Playlist item JSON missing 'type' property.");
                }

                string itemType = typeElement.GetString();

                // Decide which subclass to instantiate based on 'type'
                // You can add more "cases" as needed.
                switch (itemType)
                {
                    case "media":
                        return JsonSerializer.Deserialize<PlaylistItemMedia>(
                            jsonDocument.RootElement.GetRawText(), options);

                    case "layout":
                        return JsonSerializer.Deserialize<PlaylistItemLayout>(
                            jsonDocument.RootElement.GetRawText(), options);
                    
                    case "subplaylist":
                        return JsonSerializer.Deserialize<PlaylistItemSubplaylist>(
                            jsonDocument.RootElement.GetRawText(), options);
                    
                    case "hide_playlist":
                        return JsonSerializer.Deserialize<PlaylistItemHidePlaylist>(
                            jsonDocument.RootElement.GetRawText(), options);

                    default:
                        // If Yodeck adds new types in the future, you might handle them here or fallback:
                        throw new JsonException($"Unknown playlist item type '{itemType}'.");
                }
            }
        }

        public override void Write(Utf8JsonWriter writer, PlaylistItemBase value, JsonSerializerOptions options)
        {
            // Serialize the derived type as JSON
            JsonSerializer.Serialize(writer, (object)value, value.GetType(), options);
        }
    }
}
