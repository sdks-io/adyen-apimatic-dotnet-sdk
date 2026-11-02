namespace AdyenApIs.Requests.TerminalSettingsStoreLevel;

/// <summary>
/// The inputs of the GetStoreTerminalSettings operation.
/// </summary>
public sealed record GetStoreTerminalSettingsRequest
{
    /// <summary>
    /// The unique identifier of the store.
    /// </summary>
    public required string StoreId { get; init; }
}
