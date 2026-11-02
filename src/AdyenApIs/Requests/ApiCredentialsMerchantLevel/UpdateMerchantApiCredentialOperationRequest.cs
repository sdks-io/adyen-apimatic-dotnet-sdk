using AdyenApIs.Models;

namespace AdyenApIs.Requests.ApiCredentialsMerchantLevel;

/// <summary>
/// The inputs of the UpdateMerchantApiCredential operation.
/// </summary>
public sealed record UpdateMerchantApiCredentialOperationRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }

    /// <summary>
    /// Unique identifier of the API credential.
    /// </summary>
    public required string ApiCredentialId { get; init; }

    public UpdateMerchantApiCredentialRequest? Body { get; init; }
}
