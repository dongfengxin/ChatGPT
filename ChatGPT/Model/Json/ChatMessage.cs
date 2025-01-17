using System.Text.Json.Serialization;

namespace ChatGPT.Model.Json;

public class ChatMessage
{
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    [JsonPropertyName("content")]
    public string? Content { get; set; }
}
