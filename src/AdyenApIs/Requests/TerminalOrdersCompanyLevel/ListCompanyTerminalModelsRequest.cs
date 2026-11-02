namespace AdyenApIs.Requests.TerminalOrdersCompanyLevel;

/// <summary>
/// The inputs of the ListCompanyTerminalModels operation.
/// </summary>
public sealed record ListCompanyTerminalModelsRequest
{
    /// <summary>
    /// The unique identifier of the company account.
    /// </summary>
    public required string CompanyId { get; init; }
}
