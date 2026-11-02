using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AdyenApIs.Models;

public record DonationCampaignsResponse
{
    /// <summary>
    /// List of active donation campaigns for your merchant account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("donationCampaigns")]
    public IReadOnlyList<DonationCampaign>? DonationCampaigns { get; init; }
}
