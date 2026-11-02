using AdyenApIs.Models;

namespace AdyenApIs.Requests.PaymentLinks;

/// <summary>
/// The inputs of the CreatePaymentLink operation.
/// </summary>
public sealed record CreatePaymentLinkRequest
{
    /// <summary>
    /// A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).
    /// </summary>
    public string? IdempotencyKey { get; init; }

    public PaymentLinkRequest? Body { get; init; }
}
