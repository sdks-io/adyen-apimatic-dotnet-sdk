using System.Text.Json.Serialization;

namespace AdyenApIs.Models;

public record PaymentValidations
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public NamePaymentValidations? Name { get; init; }
}
