using AdyenApIs.Models;

namespace AdyenApIs.Requests.PaymentMethodsMerchantLevel;

/// <summary>
/// The inputs of the UpdatePaymentMethodSetting operation.
/// </summary>
public sealed record UpdatePaymentMethodSettingRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }

    /// <summary>
    /// The unique identifier of the payment method.
    /// </summary>
    public required string PaymentMethodId { get; init; }

    public UpdatePaymentMethodInfo? Body { get; init; }
}
