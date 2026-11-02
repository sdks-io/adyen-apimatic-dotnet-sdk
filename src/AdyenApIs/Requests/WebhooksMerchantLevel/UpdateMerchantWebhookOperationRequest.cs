using AdyenApIs.Models;

namespace AdyenApIs.Requests.WebhooksMerchantLevel;

/// <summary>
/// The inputs of the UpdateMerchantWebhook operation.
/// </summary>
public sealed record UpdateMerchantWebhookOperationRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }

    /// <summary>
    /// Unique identifier of the webhook configuration.
    /// </summary>
    public required string WebhookId { get; init; }

    public UpdateMerchantWebhookRequest? Body { get; init; }
}
