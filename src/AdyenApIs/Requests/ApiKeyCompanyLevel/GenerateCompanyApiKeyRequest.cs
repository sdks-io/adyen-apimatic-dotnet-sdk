namespace AdyenApIs.Requests.ApiKeyCompanyLevel;

/// <summary>
/// The inputs of the GenerateCompanyApiKey operation.
/// </summary>
public sealed record GenerateCompanyApiKeyRequest
{
    /// <summary>
    /// The unique identifier of the company account.
    /// </summary>
    public required string CompanyId { get; init; }

    /// <summary>
    /// Unique identifier of the API credential.
    /// </summary>
    public required string ApiCredentialId { get; init; }
}
