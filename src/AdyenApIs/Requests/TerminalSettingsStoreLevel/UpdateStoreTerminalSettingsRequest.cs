using AdyenApIs.Models;

namespace AdyenApIs.Requests.TerminalSettingsStoreLevel;

/// <summary>
/// The inputs of the UpdateStoreTerminalSettings operation.
/// </summary>
public sealed record UpdateStoreTerminalSettingsRequest
{
    /// <summary>
    /// The unique identifier of the store.
    /// </summary>
    public required string StoreId { get; init; }

    public TerminalSettings? Body { get; init; }
}
