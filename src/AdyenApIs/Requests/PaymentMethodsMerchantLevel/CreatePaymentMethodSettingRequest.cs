using AdyenApIs.Models;

namespace AdyenApIs.Requests.PaymentMethodsMerchantLevel;

/// <summary>
/// The inputs of the CreatePaymentMethodSetting operation.
/// </summary>
public sealed record CreatePaymentMethodSettingRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }

    public PaymentMethodSetupInfo? Body { get; init; }
}
