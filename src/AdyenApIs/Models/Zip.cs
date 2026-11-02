using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Models;
using AdyenApIs.Models.Enums;

namespace AdyenApIs.Models;

public record Zip
{
    /// <summary>
    /// The checkout attempt identifier.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("checkoutAttemptId")]
    public string? CheckoutAttemptId { get; init; }

    /// <summary>
    /// Set this to <b>true</b> if the shopper would like to pick up and collect their order, instead of having the goods delivered to them.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("clickAndCollect")]
    public string? ClickAndCollect { get; init; }

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
    /// This is the <c>recurringDetailReference</c> returned in the response when you created the token.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("storedPaymentMethodId")]
    [MaxLength(64)]
    public string? StoredPaymentMethodId { get; init; }

    /// <summary>
    /// <b>zip</b>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public TypeZip? Type { get; init; } = TypeZip.Zip;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
