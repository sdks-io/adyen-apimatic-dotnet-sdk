namespace AdyenApIs.Requests.WebhooksMerchantLevel;

/// <summary>
/// The inputs of the DeleteMerchantWebhook operation.
/// </summary>
public sealed record DeleteMerchantWebhookRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }

    /// <summary>
    /// Unique identifier of the webhook configuration.
    /// </summary>
    public required string WebhookId { get; init; }
}
