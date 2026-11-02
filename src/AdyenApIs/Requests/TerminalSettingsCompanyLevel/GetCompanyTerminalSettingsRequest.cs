namespace AdyenApIs.Requests.TerminalSettingsCompanyLevel;

/// <summary>
/// The inputs of the GetCompanyTerminalSettings operation.
/// </summary>
public sealed record GetCompanyTerminalSettingsRequest
{
    /// <summary>
    /// The unique identifier of the company account.
    /// </summary>
    public required string CompanyId { get; init; }
}
