using AdyenApIs.Models;

namespace AdyenApIs.Requests.WebhooksCompanyLevel;

/// <summary>
/// The inputs of the CreateCompanyWebhook operation.
/// </summary>
public sealed record CreateCompanyWebhookOperationRequest
{
    /// <summary>
    /// Unique identifier of the <see href="https://docs.adyen.com/account/account-structure#company-account">company account</see>.
    /// </summary>
    public required string CompanyId { get; init; }

    public CreateCompanyWebhookRequest? Body { get; init; }
}
