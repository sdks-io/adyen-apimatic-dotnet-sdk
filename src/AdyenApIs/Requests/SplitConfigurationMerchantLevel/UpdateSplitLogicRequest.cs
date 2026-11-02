using AdyenApIs.Models;

namespace AdyenApIs.Requests.SplitConfigurationMerchantLevel;

/// <summary>
/// The inputs of the UpdateSplitLogic operation.
/// </summary>
public sealed record UpdateSplitLogicRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }

    /// <summary>
    /// The unique identifier of the split configuration.
    /// </summary>
    public required string SplitConfigurationId { get; init; }

    /// <summary>
    /// The unique identifier of the split configuration rule.
    /// </summary>
    public required string RuleId { get; init; }

    /// <summary>
    /// The unique identifier of the split configuration split.
    /// </summary>
    public required string SplitLogicId { get; init; }

    public UpdateSplitConfigurationLogicRequest? Body { get; init; }
}
