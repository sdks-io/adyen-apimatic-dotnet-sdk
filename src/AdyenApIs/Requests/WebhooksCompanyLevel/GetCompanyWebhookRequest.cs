namespace AdyenApIs.Requests.WebhooksCompanyLevel;

/// <summary>
/// The inputs of the GetCompanyWebhook operation.
/// </summary>
public sealed record GetCompanyWebhookRequest
{
    /// <summary>
    /// Unique identifier of the <see href="https://docs.adyen.com/account/account-structure#company-account">company account</see>.
    /// </summary>
    public required string CompanyId { get; init; }

    /// <summary>
    /// Unique identifier of the webhook configuration.
    /// </summary>
    public required string WebhookId { get; init; }
}
