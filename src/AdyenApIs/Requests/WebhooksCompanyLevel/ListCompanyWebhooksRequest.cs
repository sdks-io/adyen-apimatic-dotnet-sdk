namespace AdyenApIs.Requests.WebhooksCompanyLevel;

/// <summary>
/// The inputs of the ListCompanyWebhooks operation.
/// </summary>
public sealed record ListCompanyWebhooksRequest
{
    /// <summary>
    /// Unique identifier of the <see href="https://docs.adyen.com/account/account-structure#company-account">company account</see>.
    /// </summary>
    public required string CompanyId { get; init; }

    /// <summary>
    /// The number of the page to fetch.
    /// </summary>
    public int? PageNumber { get; init; }

    /// <summary>
    /// The number of items to have on a page, maximum 100. The default is 10 items on a page.
    /// </summary>
    public int? PageSize { get; init; }
}
