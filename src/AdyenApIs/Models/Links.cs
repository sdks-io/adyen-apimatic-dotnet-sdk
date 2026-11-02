using System.Text.Json.Serialization;

namespace AdyenApIs.Models;

public record Links
{
    [JsonPropertyName("self")]
    public required LinksElement Self { get; init; }
}
