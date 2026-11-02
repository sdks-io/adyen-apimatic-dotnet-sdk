using System.Text.Json.Serialization;

namespace AdyenApIs.Models;

public record TaxTotal
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    public Amount? Amount { get; init; }
}
