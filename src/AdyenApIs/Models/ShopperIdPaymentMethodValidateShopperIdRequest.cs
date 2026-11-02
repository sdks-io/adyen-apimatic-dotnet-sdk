using System.Text.Json.Serialization;
using AdyenApIs.Core.Models;

namespace AdyenApIs.Models;

/// <summary>
/// paymentMethod
/// </summary>
public record ShopperIdPaymentMethodValidateShopperIdRequest
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
