using AdyenApIs.Models;

namespace AdyenApIs.Requests.RecurringApi;

/// <summary>
/// The inputs of the ForwardRequest operation.
/// </summary>
public sealed record ForwardRequest
{
    /// <summary>
    /// A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).
    /// </summary>
    public string? IdempotencyKey { get; init; }

    public CheckoutForwardRequest? Body { get; init; }
}
