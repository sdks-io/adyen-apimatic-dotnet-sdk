using System.Text.Json.Serialization;

namespace AdyenApIs.Models;

/// <summary>
/// References to resources linked to the API credential.
/// </summary>
public record ApiCredentialLinksMeApiCredential
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
