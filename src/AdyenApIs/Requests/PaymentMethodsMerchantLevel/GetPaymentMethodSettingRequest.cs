namespace AdyenApIs.Requests.PaymentMethodsMerchantLevel;

/// <summary>
/// The inputs of the GetPaymentMethodSetting operation.
/// </summary>
public sealed record GetPaymentMethodSettingRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }

    /// <summary>
    /// The unique identifier of the payment method.
    /// </summary>
    public required string PaymentMethodId { get; init; }
}
