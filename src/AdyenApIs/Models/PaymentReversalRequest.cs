using System.Text.Json.Serialization;

namespace AdyenApIs.Models;

public record PaymentReversalRequest
{
    /// <summary>
    /// Information about your application. For more details, see <see href="https://docs.adyen.com/development-resources/building-adyen-solutions">Building Adyen solutions</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("applicationInfo")]
    public ApplicationInfoPaymentReversalRequest? ApplicationInfo { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enhancedSchemeData")]
    public EnhancedSchemeData? EnhancedSchemeData { get; init; }

    /// <summary>
    /// The merchant account that is used to process the payment.
    /// </summary>
    [JsonPropertyName("merchantAccount")]
    public required string MerchantAccount { get; init; }

    /// <summary>
    /// Your reference for the reversal request. Maximum length: 80 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference")]
    public string? Reference { get; init; }
}
