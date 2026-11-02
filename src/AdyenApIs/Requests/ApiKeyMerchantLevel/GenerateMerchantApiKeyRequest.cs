namespace AdyenApIs.Requests.ApiKeyMerchantLevel;

/// <summary>
/// The inputs of the GenerateMerchantApiKey operation.
/// </summary>
public sealed record GenerateMerchantApiKeyRequest
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
