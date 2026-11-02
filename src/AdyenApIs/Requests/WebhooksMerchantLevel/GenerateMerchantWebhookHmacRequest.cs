namespace AdyenApIs.Requests.WebhooksMerchantLevel;

/// <summary>
/// The inputs of the GenerateMerchantWebhookHmac operation.
/// </summary>
public sealed record GenerateMerchantWebhookHmacRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }

    public required string WebhookId { get; init; }
}
