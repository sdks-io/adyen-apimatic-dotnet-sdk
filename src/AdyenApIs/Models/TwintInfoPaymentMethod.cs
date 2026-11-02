using System.Text.Json.Serialization;

namespace AdyenApIs.Models;

/// <summary>
/// Details to provide if <c>type</c> is <b>twint</b>.
/// </summary>
public record TwintInfoPaymentMethod
{
    /// <summary>
    /// Twint logo. Format: Base64-encoded string.
    /// </summary>
    [JsonPropertyName("logo")]
    public required string Logo { get; init; }
}
