using System.Text.Json.Serialization;

namespace AdyenApIs.Models;

/// <summary>
/// Total tax amount from the order.
/// </summary>
public record TaxTotalPaypalUpdateOrderRequest
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    public Amount? Amount { get; init; }
}
