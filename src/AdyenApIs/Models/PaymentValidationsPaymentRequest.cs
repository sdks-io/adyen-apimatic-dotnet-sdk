using System.Text.Json.Serialization;

namespace AdyenApIs.Models;

/// <summary>
/// The object that you can use to enable payment validations for a transaction.
/// </summary>
public record PaymentValidationsPaymentRequest
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public NamePaymentValidations? Name { get; init; }
}
