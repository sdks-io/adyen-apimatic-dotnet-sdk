using AdyenApIs.Models;

namespace AdyenApIs.Requests.ApiCredentialsMerchantLevel;

/// <summary>
/// The inputs of the CreateMerchantApiCredential operation.
/// </summary>
public sealed record CreateMerchantApiCredentialOperationRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }

    public CreateMerchantApiCredentialRequest? Body { get; init; }
}
