using AdyenApIs.Models;

namespace AdyenApIs.Requests.AccountMerchantLevel;

/// <summary>
/// The inputs of the CreateMerchant operation.
/// </summary>
public sealed record CreateMerchantOperationRequest
{
    public CreateMerchantRequest? Body { get; init; }
}
