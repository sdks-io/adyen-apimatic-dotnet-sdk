using AdyenApIs.Models;

namespace AdyenApIs.Requests.TerminalOrdersMerchantLevel;

/// <summary>
/// The inputs of the CreateMerchantTerminalOrder operation.
/// </summary>
public sealed record CreateMerchantTerminalOrderRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }

    public TerminalOrderRequest? Body { get; init; }
}
