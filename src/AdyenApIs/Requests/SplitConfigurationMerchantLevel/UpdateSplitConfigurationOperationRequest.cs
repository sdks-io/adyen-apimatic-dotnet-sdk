using AdyenApIs.Models;

namespace AdyenApIs.Requests.SplitConfigurationMerchantLevel;

/// <summary>
/// The inputs of the UpdateSplitConfiguration operation.
/// </summary>
public sealed record UpdateSplitConfigurationOperationRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }

    /// <summary>
    /// The unique identifier of the split configuration.
    /// </summary>
    public required string SplitConfigurationId { get; init; }

    public UpdateSplitConfigurationRequest? Body { get; init; }
}
