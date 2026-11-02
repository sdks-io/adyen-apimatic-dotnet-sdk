using AdyenApIs.Models;

namespace AdyenApIs.Requests.AccountStoreLevel;

/// <summary>
/// The inputs of the CreateMerchantStore operation.
/// </summary>
public sealed record CreateMerchantStoreRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }

    public StoreCreationRequest? Body { get; init; }
}
