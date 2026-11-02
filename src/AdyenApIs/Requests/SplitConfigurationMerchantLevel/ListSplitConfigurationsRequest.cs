namespace AdyenApIs.Requests.SplitConfigurationMerchantLevel;

/// <summary>
/// The inputs of the ListSplitConfigurations operation.
/// </summary>
public sealed record ListSplitConfigurationsRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }
}
