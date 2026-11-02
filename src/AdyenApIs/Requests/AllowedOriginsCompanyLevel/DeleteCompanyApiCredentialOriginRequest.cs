namespace AdyenApIs.Requests.AllowedOriginsCompanyLevel;

/// <summary>
/// The inputs of the DeleteCompanyApiCredentialOrigin operation.
/// </summary>
public sealed record DeleteCompanyApiCredentialOriginRequest
{
    /// <summary>
    /// The unique identifier of the company account.
    /// </summary>
    public required string CompanyId { get; init; }

    /// <summary>
    /// Unique identifier of the API credential.
    /// </summary>
    public required string ApiCredentialId { get; init; }

    /// <summary>
    /// Unique identifier of the allowed origin.
    /// </summary>
    public required string OriginId { get; init; }
}
