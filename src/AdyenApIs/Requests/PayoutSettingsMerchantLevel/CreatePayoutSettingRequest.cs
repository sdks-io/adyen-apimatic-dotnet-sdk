using AdyenApIs.Models;

namespace AdyenApIs.Requests.PayoutSettingsMerchantLevel;

/// <summary>
/// The inputs of the CreatePayoutSetting operation.
/// </summary>
public sealed record CreatePayoutSettingRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }

    public PayoutSettingsRequest? Body { get; init; }
}
