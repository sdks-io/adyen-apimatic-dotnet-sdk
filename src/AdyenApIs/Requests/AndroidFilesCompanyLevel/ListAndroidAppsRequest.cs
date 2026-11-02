namespace AdyenApIs.Requests.AndroidFilesCompanyLevel;

/// <summary>
/// The inputs of the ListAndroidApps operation.
/// </summary>
public sealed record ListAndroidAppsRequest
{
    /// <summary>
    /// The unique identifier of the company account.
    /// </summary>
    public required string CompanyId { get; init; }

    /// <summary>
    /// The number of the page to fetch.
    /// </summary>
    public int? PageNumber { get; init; }

    /// <summary>
    /// The number of items to have on a page, maximum 100. The default is 20 items on a page.
    /// </summary>
    public int? PageSize { get; init; }

    /// <summary>
    /// The package name that uniquely identifies the Android app.
    /// </summary>
    public string? PackageName { get; init; }

    /// <summary>
    /// The version number of the app.
    /// </summary>
    public int? VersionCode { get; init; }
}
