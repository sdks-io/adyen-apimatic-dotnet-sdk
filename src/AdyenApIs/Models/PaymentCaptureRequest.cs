using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AdyenApIs.Models;

public record PaymentCaptureRequest
{
    [JsonPropertyName("amount")]
    public required Amount Amount { get; init; }

    /// <summary>
    /// Information about your application. For more details, see <see href="https://docs.adyen.com/development-resources/building-adyen-solutions">Building Adyen solutions</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("applicationInfo")]
    public ApplicationInfoPaymentCaptureRequest? ApplicationInfo { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enhancedSchemeData")]
    public EnhancedSchemeData? EnhancedSchemeData { get; init; }

    /// <summary>
    /// Price and product information of the refunded items, required for <see href="https://docs.adyen.com/online-payments/refund#refund-a-payment">partial refunds</see>.
    /// &gt; This field is required for partial refunds with 3x 4x Oney, Affirm, Afterpay, Atome, Clearpay, Klarna, Ratepay, Walley, and Zip.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lineItems")]
    public IReadOnlyList<LineItem>? LineItems { get; init; }

    /// <summary>
    /// The merchant account that is used to process the payment.
    /// </summary>
    [JsonPropertyName("merchantAccount")]
    public required string MerchantAccount { get; init; }

    /// <summary>
    /// Defines how to book chargebacks when using <see href="https://docs.adyen.com/adyen-for-platforms-model">Adyen for Platforms</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("platformChargebackLogic")]
    public PlatformChargebackLogicPaymentCaptureRequest? PlatformChargebackLogic { get; init; }

    /// <summary>
    /// Your reference for the capture request. Maximum length: 80 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference")]
    public string? Reference { get; init; }

    /// <summary>
    /// An array of objects specifying how the amount should be split between accounts when using Adyen for Platforms. For more information, see how to process payments for <see href="https://docs.adyen.com/marketplaces/split-payments">marketplaces</see> or <see href="https://docs.adyen.com/platforms/online-payments/split-payments/">platforms</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("splits")]
    public IReadOnlyList<Split>? Splits { get; init; }

    /// <summary>
    /// A List of sub-merchants.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subMerchants")]
    public IReadOnlyList<SubMerchantInfo>? SubMerchants { get; init; }
}
