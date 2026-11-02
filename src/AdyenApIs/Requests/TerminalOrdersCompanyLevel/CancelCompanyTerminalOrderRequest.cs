namespace AdyenApIs.Requests.TerminalOrdersCompanyLevel;

/// <summary>
/// The inputs of the CancelCompanyTerminalOrder operation.
/// </summary>
public sealed record CancelCompanyTerminalOrderRequest
{
    /// <summary>
    /// The unique identifier of the company account.
    /// </summary>
    public required string CompanyId { get; init; }

    /// <summary>
    /// The unique identifier of the order.
    /// </summary>
    public required string OrderId { get; init; }
}
