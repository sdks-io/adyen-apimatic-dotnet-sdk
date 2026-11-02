using AdyenApIs.Models;

namespace AdyenApIs.Requests.AccountStoreLevel;

/// <summary>
/// The inputs of the UpdateMerchantStore operation.
/// </summary>
public sealed record UpdateMerchantStoreRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }

    /// <summary>
    /// The unique identifier of the store.
    /// </summary>
    public required string StoreId { get; init; }

    public UpdateStoreRequest? Body { get; init; }
}
