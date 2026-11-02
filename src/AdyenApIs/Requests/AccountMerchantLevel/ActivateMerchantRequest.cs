namespace AdyenApIs.Requests.AccountMerchantLevel;

/// <summary>
/// The inputs of the ActivateMerchant operation.
/// </summary>
public sealed record ActivateMerchantRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }
}
