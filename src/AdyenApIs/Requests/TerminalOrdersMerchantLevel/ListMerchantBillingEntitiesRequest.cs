namespace AdyenApIs.Requests.TerminalOrdersMerchantLevel;

/// <summary>
/// The inputs of the ListMerchantBillingEntities operation.
/// </summary>
public sealed record ListMerchantBillingEntitiesRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }

    /// <summary>
    /// The name of the billing entity.
    /// </summary>
    public string? Name { get; init; }
}
