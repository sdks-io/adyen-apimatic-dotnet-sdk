namespace AdyenApIs.Requests.TerminalOrdersMerchantLevel;

/// <summary>
/// The inputs of the ListMerchantTerminalModels operation.
/// </summary>
public sealed record ListMerchantTerminalModelsRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }
}
