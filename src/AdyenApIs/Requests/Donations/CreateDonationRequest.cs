using AdyenApIs.Models;

namespace AdyenApIs.Requests.Donations;

/// <summary>
/// The inputs of the CreateDonation operation.
/// </summary>
public sealed record CreateDonationRequest
{
    /// <summary>
    /// A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).
    /// </summary>
    public string? IdempotencyKey { get; init; }

    public DonationPaymentRequest? Body { get; init; }
}
