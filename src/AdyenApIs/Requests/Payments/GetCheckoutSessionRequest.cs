namespace AdyenApIs.Requests.Payments;

/// <summary>
/// The inputs of the GetCheckoutSession operation.
/// </summary>
public sealed record GetCheckoutSessionRequest
{
    /// <summary>
    /// A unique identifier of the session.
    /// </summary>
    public required string SessionId { get; init; }

    /// <summary>
    /// The <c>sessionResult</c> value from the Drop-in or Component.
    /// </summary>
    public required string SessionResult { get; init; }
}
