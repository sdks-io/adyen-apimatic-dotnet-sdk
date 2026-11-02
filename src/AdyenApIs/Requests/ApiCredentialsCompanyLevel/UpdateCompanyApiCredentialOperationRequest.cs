using AdyenApIs.Models;

namespace AdyenApIs.Requests.ApiCredentialsCompanyLevel;

/// <summary>
/// The inputs of the UpdateCompanyApiCredential operation.
/// </summary>
public sealed record UpdateCompanyApiCredentialOperationRequest
{
    /// <summary>
    /// The unique identifier of the company account.
    /// </summary>
    public required string CompanyId { get; init; }

    /// <summary>
    /// Unique identifier of the API credential.
    /// </summary>
    public required string ApiCredentialId { get; init; }

    public UpdateCompanyApiCredentialRequest? Body { get; init; }
}
