using AdyenApIs.Models;

namespace AdyenApIs.Requests.WebhooksMerchantLevel;

/// <summary>
/// The inputs of the CreateMerchantWebhook operation.
/// </summary>
public sealed record CreateMerchantWebhookOperationRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }

    public CreateMerchantWebhookRequest? Body { get; init; }
}
