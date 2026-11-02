using AdyenApIs.Models;

namespace AdyenApIs.Requests.Payments;

/// <summary>
/// The inputs of the CreateCheckoutSession operation.
/// </summary>
public sealed record CreateCheckoutSessionOperationRequest
{
    /// <summary>
    /// A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).
    /// </summary>
    public string? IdempotencyKey { get; init; }

    public CreateCheckoutSessionRequest? Body { get; init; }
}
