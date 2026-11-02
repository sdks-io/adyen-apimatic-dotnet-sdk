using System.Text.Json.Serialization;
using AdyenApIs.Core.Models;

namespace AdyenApIs.Models;

public record ShopperIdPaymentMethod
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
