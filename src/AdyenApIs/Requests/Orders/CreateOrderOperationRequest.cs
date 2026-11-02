using AdyenApIs.Models;

namespace AdyenApIs.Requests.Orders;

/// <summary>
/// The inputs of the CreateOrder operation.
/// </summary>
public sealed record CreateOrderOperationRequest
{
    /// <summary>
    /// A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).
    /// </summary>
    public string? IdempotencyKey { get; init; }

    public CreateOrderRequest? Body { get; init; }
}
