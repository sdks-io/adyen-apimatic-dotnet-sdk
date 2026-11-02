using AdyenApIs.Models;

namespace AdyenApIs.Requests.WebhooksCompanyLevel;

/// <summary>
/// The inputs of the UpdateCompanyWebhook operation.
/// </summary>
public sealed record UpdateCompanyWebhookOperationRequest
{
    /// <summary>
    /// The unique identifier of the company account.
    /// </summary>
    public required string CompanyId { get; init; }

    /// <summary>
    /// Unique identifier of the webhook configuration.
    /// </summary>
    public required string WebhookId { get; init; }

    public UpdateCompanyWebhookRequest? Body { get; init; }
}
