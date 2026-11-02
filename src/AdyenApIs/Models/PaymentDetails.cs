using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AdyenApIs.Models.Enums;

namespace AdyenApIs.Models;

public record PaymentDetails
{
    /// <summary>
    /// The checkout attempt identifier.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("checkoutAttemptId")]
    public string? CheckoutAttemptId { get; init; }

    /// <summary>
    /// Base64-encoded JSON object containing SDK related parameters required by the SDK
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sdkData")]
    [MaxLength(50000)]
    public string? SdkData { get; init; }

    /// <summary>
    /// The payment method type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public TypePaymentDetails? Type { get; init; }
}
