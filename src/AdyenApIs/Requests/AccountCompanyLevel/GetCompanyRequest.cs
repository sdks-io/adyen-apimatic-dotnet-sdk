namespace AdyenApIs.Requests.AccountCompanyLevel;

/// <summary>
/// The inputs of the GetCompany operation.
/// </summary>
public sealed record GetCompanyRequest
{
    /// <summary>
    /// The unique identifier of the company account.
    /// </summary>
    public required string CompanyId { get; init; }
}
