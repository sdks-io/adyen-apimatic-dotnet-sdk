using AdyenApIs.Models;

namespace AdyenApIs.Requests.Utility;

/// <summary>
/// The inputs of the UpdatePayPalOrder operation.
/// </summary>
public sealed record UpdatePayPalOrderRequest
{
    /// <summary>
    /// A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).
    /// </summary>
    public string? IdempotencyKey { get; init; }

    public PaypalUpdateOrderRequest? Body { get; init; }
}
