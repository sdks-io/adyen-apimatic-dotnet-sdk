using AdyenApIs.Models;

namespace AdyenApIs.Requests.SplitConfigurationMerchantLevel;

/// <summary>
/// The inputs of the CreateSplitConfiguration operation.
/// </summary>
public sealed record CreateSplitConfigurationRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }

    public SplitConfiguration? Body { get; init; }
}
