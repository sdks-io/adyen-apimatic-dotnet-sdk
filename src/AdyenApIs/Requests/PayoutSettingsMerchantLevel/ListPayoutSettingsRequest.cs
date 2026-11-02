namespace AdyenApIs.Requests.PayoutSettingsMerchantLevel;

/// <summary>
/// The inputs of the ListPayoutSettings operation.
/// </summary>
public sealed record ListPayoutSettingsRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }
}
