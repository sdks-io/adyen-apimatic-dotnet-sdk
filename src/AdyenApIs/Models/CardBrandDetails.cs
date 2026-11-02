using System.Text.Json.Serialization;

namespace AdyenApIs.Models;

public record CardBrandDetails
{
    /// <summary>
    /// Indicates if you support the card brand.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("supported")]
    public bool? Supported { get; init; }

    /// <summary>
    /// The name of the card brand.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }
}
