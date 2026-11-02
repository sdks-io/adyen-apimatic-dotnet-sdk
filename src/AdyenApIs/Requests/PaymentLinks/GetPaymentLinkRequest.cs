namespace AdyenApIs.Requests.PaymentLinks;

/// <summary>
/// The inputs of the GetPaymentLink operation.
/// </summary>
public sealed record GetPaymentLinkRequest
{
    /// <summary>
    /// Unique identifier of the payment link.
    /// </summary>
    public required string LinkId { get; init; }
}
