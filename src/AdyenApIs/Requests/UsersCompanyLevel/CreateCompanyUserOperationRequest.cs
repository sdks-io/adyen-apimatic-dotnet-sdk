using AdyenApIs.Models;

namespace AdyenApIs.Requests.UsersCompanyLevel;

/// <summary>
/// The inputs of the CreateCompanyUser operation.
/// </summary>
public sealed record CreateCompanyUserOperationRequest
{
    /// <summary>
    /// The unique identifier of the company account.
    /// </summary>
    public required string CompanyId { get; init; }

    public CreateCompanyUserRequest? Body { get; init; }
}
