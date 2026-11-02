using System.Text.Json.Serialization;

namespace AdyenApIs.Models;

/// <summary>
/// References to resources connected with this webhook.
/// </summary>
public record WebhookLinksWebhook
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("company")]
    public LinksElement? Company { get; init; }

    [JsonPropertyName("generateHmac")]
    public required LinksElement GenerateHmac { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchant")]
    public LinksElement? Merchant { get; init; }

    [JsonPropertyName("self")]
    public required LinksElement Self { get; init; }

    [JsonPropertyName("testWebhook")]
    public required LinksElement TestWebhook { get; init; }
}
