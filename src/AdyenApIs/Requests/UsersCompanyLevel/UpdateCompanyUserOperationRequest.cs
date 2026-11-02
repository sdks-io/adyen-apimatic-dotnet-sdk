using AdyenApIs.Models;

namespace AdyenApIs.Requests.UsersCompanyLevel;

/// <summary>
/// The inputs of the UpdateCompanyUser operation.
/// </summary>
public sealed record UpdateCompanyUserOperationRequest
{
    /// <summary>
    /// The unique identifier of the company account.
    /// </summary>
    public required string CompanyId { get; init; }

    /// <summary>
    /// The unique identifier of the user.
    /// </summary>
    public required string UserId { get; init; }

    public UpdateCompanyUserRequest? Body { get; init; }
}
