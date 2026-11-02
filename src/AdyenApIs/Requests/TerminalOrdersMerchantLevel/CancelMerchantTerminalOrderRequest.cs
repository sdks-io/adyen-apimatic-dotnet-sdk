namespace AdyenApIs.Requests.TerminalOrdersMerchantLevel;

/// <summary>
/// The inputs of the CancelMerchantTerminalOrder operation.
/// </summary>
public sealed record CancelMerchantTerminalOrderRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }

    /// <summary>
    /// The unique identifier of the order.
    /// </summary>
    public required string OrderId { get; init; }
}
