namespace AdyenApIs.Requests.AccountMerchantLevel;

/// <summary>
/// The inputs of the GetMerchant operation.
/// </summary>
public sealed record GetMerchantRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }
}
