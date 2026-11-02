using System.Text.Json.Serialization;
using AdyenApIs.Models.Enums;

namespace AdyenApIs.Models;

public record AffirmInfo
{
    /// <summary>
    /// Merchant price plan
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pricePlan")]
    public PricePlan? PricePlan { get; init; }

    /// <summary>
    /// Merchant support email
    /// </summary>
    [JsonPropertyName("supportEmail")]
    public required string SupportEmail { get; init; }
}
