using AdyenApIs.Models;

namespace AdyenApIs.Requests.TerminalSettingsMerchantLevel;

/// <summary>
/// The inputs of the UpdateMerchantTerminalSettings operation.
/// </summary>
public sealed record UpdateMerchantTerminalSettingsRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }

    public TerminalSettings? Body { get; init; }
}
