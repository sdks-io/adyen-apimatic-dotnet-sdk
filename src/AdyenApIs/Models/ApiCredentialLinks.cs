using System.Text.Json.Serialization;

namespace AdyenApIs.Models;

public record ApiCredentialLinks
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allowedOrigins")]
    public LinksElement? AllowedOrigins { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("company")]
    public LinksElement? Company { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("generateApiKey")]
    public LinksElement? GenerateApiKey { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("generateClientKey")]
    public LinksElement? GenerateClientKey { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchant")]
    public LinksElement? Merchant { get; init; }

    [JsonPropertyName("self")]
    public required LinksElement Self { get; init; }
}
