namespace AdyenApIs.Requests.TerminalSettingsStoreLevel;

/// <summary>
/// The inputs of the GetMerchantStoreTerminalSettingsByReference operation.
/// </summary>
public sealed record GetMerchantStoreTerminalSettingsByReferenceRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }

    /// <summary>
    /// The reference that identifies the store.
    /// </summary>
    public required string Reference { get; init; }
}
