using System.Text.Json.Serialization;

namespace AdyenApIs.Models;

public record CancelOrderRequest
{
    /// <summary>
    /// The merchant account identifier that orderData belongs to.
    /// </summary>
    [JsonPropertyName("merchantAccount")]
    public required string MerchantAccount { get; init; }

    [JsonPropertyName("order")]
    public required EncryptedOrderData Order { get; init; }
}
