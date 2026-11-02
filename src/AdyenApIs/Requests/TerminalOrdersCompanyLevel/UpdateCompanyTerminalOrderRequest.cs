using AdyenApIs.Models;

namespace AdyenApIs.Requests.TerminalOrdersCompanyLevel;

/// <summary>
/// The inputs of the UpdateCompanyTerminalOrder operation.
/// </summary>
public sealed record UpdateCompanyTerminalOrderRequest
{
    /// <summary>
    /// The unique identifier of the company account.
    /// </summary>
    public required string CompanyId { get; init; }

    /// <summary>
    /// The unique identifier of the order.
    /// </summary>
    public required string OrderId { get; init; }

    public TerminalOrderRequest? Body { get; init; }
}
