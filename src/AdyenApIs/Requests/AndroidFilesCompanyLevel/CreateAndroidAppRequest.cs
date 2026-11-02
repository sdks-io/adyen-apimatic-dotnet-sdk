namespace AdyenApIs.Requests.AndroidFilesCompanyLevel;

/// <summary>
/// The inputs of the CreateAndroidApp operation.
/// </summary>
public sealed record CreateAndroidAppRequest
{
    /// <summary>
    /// The unique identifier of the company account.
    /// </summary>
    public required string CompanyId { get; init; }
}
