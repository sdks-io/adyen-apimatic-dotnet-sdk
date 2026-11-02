namespace AdyenApIs.Requests.PayoutSettingsMerchantLevel;

/// <summary>
/// The inputs of the DeletePayoutSetting operation.
/// </summary>
public sealed record DeletePayoutSettingRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }

    /// <summary>
    /// The unique identifier of the payout setting.
    /// </summary>
    public required string PayoutSettingsId { get; init; }
}
