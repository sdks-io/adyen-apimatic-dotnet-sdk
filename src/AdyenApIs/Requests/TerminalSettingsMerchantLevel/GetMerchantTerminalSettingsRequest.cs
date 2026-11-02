namespace AdyenApIs.Requests.TerminalSettingsMerchantLevel;

/// <summary>
/// The inputs of the GetMerchantTerminalSettings operation.
/// </summary>
public sealed record GetMerchantTerminalSettingsRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }
}
