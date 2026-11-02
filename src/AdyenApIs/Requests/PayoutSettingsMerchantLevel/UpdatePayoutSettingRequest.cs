using AdyenApIs.Models;

namespace AdyenApIs.Requests.PayoutSettingsMerchantLevel;

/// <summary>
/// The inputs of the UpdatePayoutSetting operation.
/// </summary>
public sealed record UpdatePayoutSettingRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }

    /// <summary>
    /// The unique identifier of the payout setting.
    /// </summary>
    public required string PayoutSettingsId { get; init; }

    public UpdatePayoutSettingsRequest? Body { get; init; }
}
