using AdyenApIs.Models;

namespace AdyenApIs.Requests.Donations;

/// <summary>
/// The inputs of the GetDonationCampaigns operation.
/// </summary>
public sealed record GetDonationCampaignsRequest
{
    /// <summary>
    /// A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).
    /// </summary>
    public string? IdempotencyKey { get; init; }

    public DonationCampaignsRequest? Body { get; init; }
}
