using AdyenApIs.Models;

namespace AdyenApIs.Requests.Payments;

/// <summary>
/// The inputs of the GetPaymentDetails operation.
/// </summary>
public sealed record GetPaymentDetailsRequest
{
    /// <summary>
    /// A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).
    /// </summary>
    public string? IdempotencyKey { get; init; }

    public PaymentDetailsRequest? Body { get; init; }
}
