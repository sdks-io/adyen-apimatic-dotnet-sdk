using System.Text.Json.Serialization;

namespace AdyenApIs.Models;

/// <summary>
/// Pagination references.
/// </summary>
public record PaginationLinksListCompanyResponse
{
    [JsonPropertyName("first")]
    public required LinksElement First { get; init; }

    [JsonPropertyName("last")]
    public required LinksElement Last { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("next")]
    public LinksElement? Next { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("prev")]
    public LinksElement? Prev { get; init; }

    [JsonPropertyName("self")]
    public required LinksElement Self { get; init; }
}
