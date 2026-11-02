namespace AdyenApIs.Requests.ApiCredentialsMerchantLevel;

/// <summary>
/// The inputs of the GetMerchantApiCredential operation.
/// </summary>
public sealed record GetMerchantApiCredentialRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }

    /// <summary>
    /// Unique identifier of the API credential.
    /// </summary>
    public required string ApiCredentialId { get; init; }
}
