using AdyenApIs.Models;

namespace AdyenApIs.Requests.AccountStoreLevel;

/// <summary>
/// The inputs of the UpdateStore operation.
/// </summary>
public sealed record UpdateStoreOperationRequest
{
    /// <summary>
    /// The unique identifier of the store.
    /// </summary>
    public required string StoreId { get; init; }

    public UpdateStoreRequest? Body { get; init; }
}
