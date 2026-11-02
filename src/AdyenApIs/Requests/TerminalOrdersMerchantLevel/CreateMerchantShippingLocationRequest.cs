using AdyenApIs.Models;

namespace AdyenApIs.Requests.TerminalOrdersMerchantLevel;

/// <summary>
/// The inputs of the CreateMerchantShippingLocation operation.
/// </summary>
public sealed record CreateMerchantShippingLocationRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }

    public ShippingLocation? Body { get; init; }
}
