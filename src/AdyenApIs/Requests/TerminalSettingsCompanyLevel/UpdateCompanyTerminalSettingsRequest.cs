using AdyenApIs.Models;

namespace AdyenApIs.Requests.TerminalSettingsCompanyLevel;

/// <summary>
/// The inputs of the UpdateCompanyTerminalSettings operation.
/// </summary>
public sealed record UpdateCompanyTerminalSettingsRequest
{
    /// <summary>
    /// The unique identifier of the company account.
    /// </summary>
    public required string CompanyId { get; init; }

    public TerminalSettings? Body { get; init; }
}
