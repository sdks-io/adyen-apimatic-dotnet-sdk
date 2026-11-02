using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Models;

namespace AdyenApIs.Models;

public record UpiPaymentMethodProperties
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("virtualPaymentAddress")]
    [StringLength(256, MinimumLength = 1)]
    public string? VirtualPaymentAddress { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
