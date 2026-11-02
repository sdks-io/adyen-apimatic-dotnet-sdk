using AdyenApIs.Models;

namespace AdyenApIs.Requests.SplitConfigurationMerchantLevel;

/// <summary>
/// The inputs of the CreateSplitConfigurationRule operation.
/// </summary>
public sealed record CreateSplitConfigurationRuleRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }

    /// <summary>
    /// The unique identifier of the split configuration.
    /// </summary>
    public required string SplitConfigurationId { get; init; }

    public SplitConfigurationRule? Body { get; init; }
}
