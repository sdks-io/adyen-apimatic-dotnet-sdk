namespace AdyenApIs.Requests.WebhooksCompanyLevel;

/// <summary>
/// The inputs of the DeleteCompanyWebhook operation.
/// </summary>
public sealed record DeleteCompanyWebhookRequest
{
    /// <summary>
    /// The unique identifier of the company account.
    /// </summary>
    public required string CompanyId { get; init; }

    /// <summary>
    /// Unique identifier of the webhook configuration.
    /// </summary>
    public required string WebhookId { get; init; }
}
