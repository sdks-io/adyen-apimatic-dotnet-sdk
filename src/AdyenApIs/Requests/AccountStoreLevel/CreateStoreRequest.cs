using AdyenApIs.Models;

namespace AdyenApIs.Requests.AccountStoreLevel;

/// <summary>
/// The inputs of the CreateStore operation.
/// </summary>
public sealed record CreateStoreRequest
{
    public StoreCreationWithMerchantCodeRequest? Body { get; init; }
}
