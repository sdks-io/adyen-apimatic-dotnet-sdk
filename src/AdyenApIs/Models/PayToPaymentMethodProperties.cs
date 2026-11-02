using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Models;

namespace AdyenApIs.Models;

public record PayToPaymentMethodProperties
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperReference")]
    [StringLength(256, MinimumLength = 0)]
    public string? ShopperReference { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
