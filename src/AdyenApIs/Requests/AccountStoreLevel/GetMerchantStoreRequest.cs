namespace AdyenApIs.Requests.AccountStoreLevel;

/// <summary>
/// The inputs of the GetMerchantStore operation.
/// </summary>
public sealed record GetMerchantStoreRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }

    /// <summary>
    /// The unique identifier of the store.
    /// </summary>
    public required string StoreId { get; init; }
}
