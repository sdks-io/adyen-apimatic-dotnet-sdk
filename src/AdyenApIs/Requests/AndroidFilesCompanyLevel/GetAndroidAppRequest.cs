namespace AdyenApIs.Requests.AndroidFilesCompanyLevel;

/// <summary>
/// The inputs of the GetAndroidApp operation.
/// </summary>
public sealed record GetAndroidAppRequest
{
    /// <summary>
    /// The unique identifier of the company account.
    /// </summary>
    public required string CompanyId { get; init; }

    /// <summary>
    /// The unique identifier of the app.
    /// </summary>
    public required string Id { get; init; }
}
