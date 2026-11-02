using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AdyenApIs.Models.Enums;

namespace AdyenApIs.Models;

public record PayTo
{
    /// <summary>
    /// The checkout attempt identifier.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("checkoutAttemptId")]
    public string? CheckoutAttemptId { get; init; }

    /// <summary>
    /// This is the <c>recurringDetailReference</c> returned in the response when you created the token.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recurringDetailReference")]
    public string? RecurringDetailReference { get; init; }

    /// <summary>
    /// Base64-encoded JSON object containing SDK related parameters required by the SDK
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sdkData")]
    [MaxLength(50000)]
    public string? SdkData { get; init; }

    /// <summary>
    /// The shopper's banking details or payId reference, used to complete payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperAccountIdentifier")]
    public string? ShopperAccountIdentifier { get; init; }

    /// <summary>
    /// This is the <c>recurringDetailReference</c> returned in the response when you created the token.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("storedPaymentMethodId")]
    [MaxLength(64)]
    public string? StoredPaymentMethodId { get; init; }

    /// <summary>
    /// <b>payto</b>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public TypePayTo? Type { get; init; } = TypePayTo.Payto;
}
