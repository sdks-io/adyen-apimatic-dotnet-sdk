using AdyenApIs.Models;

namespace AdyenApIs.Requests.ApiCredentialsCompanyLevel;

/// <summary>
/// The inputs of the CreateCompanyApiCredential operation.
/// </summary>
public sealed record CreateCompanyApiCredentialOperationRequest
{
    /// <summary>
    /// The unique identifier of the company account.
    /// </summary>
    public required string CompanyId { get; init; }

    public CreateCompanyApiCredentialRequest? Body { get; init; }
}
