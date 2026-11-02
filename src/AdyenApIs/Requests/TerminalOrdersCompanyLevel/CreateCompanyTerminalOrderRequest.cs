using AdyenApIs.Models;

namespace AdyenApIs.Requests.TerminalOrdersCompanyLevel;

/// <summary>
/// The inputs of the CreateCompanyTerminalOrder operation.
/// </summary>
public sealed record CreateCompanyTerminalOrderRequest
{
    /// <summary>
    /// The unique identifier of the company account.
    /// </summary>
    public required string CompanyId { get; init; }

    public TerminalOrderRequest? Body { get; init; }
}
