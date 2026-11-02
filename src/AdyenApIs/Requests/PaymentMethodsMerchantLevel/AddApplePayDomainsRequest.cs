using AdyenApIs.Models;

namespace AdyenApIs.Requests.PaymentMethodsMerchantLevel;

/// <summary>
/// The inputs of the AddApplePayDomains operation.
/// </summary>
public sealed record AddApplePayDomainsRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }

    /// <summary>
    /// The unique identifier of the payment method.
    /// </summary>
    public required string PaymentMethodId { get; init; }

    public ApplePayInfo? Body { get; init; }
}
