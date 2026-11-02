using System.Text.Json.Serialization;

namespace AdyenApIs.Models;

public record TwintInfo
{
    /// <summary>
    /// Twint logo. Format: Base64-encoded string.
    /// </summary>
    [JsonPropertyName("logo")]
    public required string Logo { get; init; }
}
