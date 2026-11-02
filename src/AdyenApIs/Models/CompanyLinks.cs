using System.Text.Json.Serialization;

namespace AdyenApIs.Models;

public record CompanyLinks
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("apiCredentials")]
    public LinksElement? ApiCredentials { get; init; }

    [JsonPropertyName("self")]
    public required LinksElement Self { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("users")]
    public LinksElement? Users { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("webhooks")]
    public LinksElement? Webhooks { get; init; }
}
