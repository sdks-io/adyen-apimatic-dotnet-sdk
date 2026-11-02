using System.Text.Json.Serialization;

namespace AdyenApIs.Models;

public record SodexoInfo
{
    /// <summary>
    /// Sodexo merchantContactPhone
    /// </summary>
    [JsonPropertyName("merchantContactPhone")]
    public required string MerchantContactPhone { get; init; }
}
