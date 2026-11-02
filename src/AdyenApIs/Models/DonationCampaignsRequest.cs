using System.Text.Json.Serialization;

namespace AdyenApIs.Models;

public record DonationCampaignsRequest
{
    /// <summary>
    /// The three-character <see href="https://docs.adyen.com/development-resources/currency-codes/">ISO currency code</see>.
    /// </summary>
    [JsonPropertyName("currency")]
    public required string Currency { get; init; }

    /// <summary>
    /// Locale on the shopper interaction device.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("locale")]
    public string? Locale { get; init; }

    /// <summary>
    /// Your merchant account identifier.
    /// </summary>
    [JsonPropertyName("merchantAccount")]
    public required string MerchantAccount { get; init; }
}
