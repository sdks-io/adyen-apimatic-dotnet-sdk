using System.Text.Json.Serialization;

namespace AdyenApIs.Models;

public record LinksElement
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("href")]
    public string? Href { get; init; }
}
