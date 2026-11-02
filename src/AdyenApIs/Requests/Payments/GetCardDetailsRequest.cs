using AdyenApIs.Models;

namespace AdyenApIs.Requests.Payments;

/// <summary>
/// The inputs of the GetCardDetails operation.
/// </summary>
public sealed record GetCardDetailsRequest
{
    /// <summary>
    /// A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).
    /// </summary>
    public string? IdempotencyKey { get; init; }

    public CardDetailsRequest? Body { get; init; }
}
