using System.Text.Json.Serialization;

namespace AdyenApIs.Models;

public record UpdatePaymentLinkRequest
{
    /// <summary>
    /// Status of the payment link. Possible values:
    /// * <b>expired</b>
    /// </summary>
    [JsonPropertyName("status")]
    public string Status { get; } = "expired";
}
