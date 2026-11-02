namespace AdyenApIs.Requests.AccountStoreLevel;

/// <summary>
/// The inputs of the GetStore operation.
/// </summary>
public sealed record GetStoreRequest
{
    /// <summary>
    /// The unique identifier of the store.
    /// </summary>
    public required string StoreId { get; init; }
}
