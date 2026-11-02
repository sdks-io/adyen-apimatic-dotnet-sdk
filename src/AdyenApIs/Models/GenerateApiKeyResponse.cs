using System.Text.Json.Serialization;

namespace AdyenApIs.Models;

public record GenerateApiKeyResponse
{
    /// <summary>
    /// The generated API key.
    /// </summary>
    [JsonPropertyName("apiKey")]
    public required string ApiKey { get; init; }
}
