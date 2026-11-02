namespace AdyenApIs.Requests.AllowedOriginsMerchantLevel;

/// <summary>
/// The inputs of the ListMerchantApiCredentialOrigins operation.
/// </summary>
public sealed record ListMerchantApiCredentialOriginsRequest
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
