namespace AdyenApIs.Requests.TerminalOrdersMerchantLevel;

/// <summary>
/// The inputs of the ListMerchantShippingLocations operation.
/// </summary>
public sealed record ListMerchantShippingLocationsRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }

    /// <summary>
    /// The name of the shipping location.
    /// </summary>
    public string? Name { get; init; }

    /// <summary>
    /// The number of locations to skip.
    /// </summary>
    public int? Offset { get; init; }

    /// <summary>
    /// The number of locations to return.
    /// </summary>
    public int? Limit { get; init; }
}
