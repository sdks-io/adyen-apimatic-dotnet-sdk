using AdyenApIs.Models;

namespace AdyenApIs.Requests.PaymentLinks;

/// <summary>
/// The inputs of the UpdatePaymentLink operation.
/// </summary>
public sealed record UpdatePaymentLinkOperationRequest
{
    /// <summary>
    /// Unique identifier of the payment link.
    /// </summary>
    public required string LinkId { get; init; }

    public UpdatePaymentLinkRequest? Body { get; init; }
}
