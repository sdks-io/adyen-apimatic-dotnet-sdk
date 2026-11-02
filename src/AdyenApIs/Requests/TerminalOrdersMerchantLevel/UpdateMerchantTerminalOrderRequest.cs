using AdyenApIs.Models;

namespace AdyenApIs.Requests.TerminalOrdersMerchantLevel;

/// <summary>
/// The inputs of the UpdateMerchantTerminalOrder operation.
/// </summary>
public sealed record UpdateMerchantTerminalOrderRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }

    /// <summary>
    /// The unique identifier of the order.
    /// </summary>
    public required string OrderId { get; init; }

    public TerminalOrderRequest? Body { get; init; }
}
