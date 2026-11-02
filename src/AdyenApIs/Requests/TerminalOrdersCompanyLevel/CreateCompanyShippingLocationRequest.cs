using AdyenApIs.Models;

namespace AdyenApIs.Requests.TerminalOrdersCompanyLevel;

/// <summary>
/// The inputs of the CreateCompanyShippingLocation operation.
/// </summary>
public sealed record CreateCompanyShippingLocationRequest
{
    /// <summary>
    /// The unique identifier of the company account.
    /// </summary>
    public required string CompanyId { get; init; }

    public ShippingLocation? Body { get; init; }
}
