namespace AdyenApIs.Requests.TerminalOrdersCompanyLevel;

/// <summary>
/// The inputs of the ListCompanyBillingEntities operation.
/// </summary>
public sealed record ListCompanyBillingEntitiesRequest
{
    /// <summary>
    /// The unique identifier of the company account.
    /// </summary>
    public required string CompanyId { get; init; }

    /// <summary>
    /// The name of the billing entity.
    /// </summary>
    public string? Name { get; init; }
}
