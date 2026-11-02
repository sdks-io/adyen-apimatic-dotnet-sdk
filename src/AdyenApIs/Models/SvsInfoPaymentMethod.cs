using System.Text.Json.Serialization;

namespace AdyenApIs.Models;

/// <summary>
/// Details to provide if <c>type</c> is <b>svs</b>.
/// </summary>
public record SvsInfoPaymentMethod
{
    /// <summary>
    /// The merchant ID (MID) that the acquirer recognizes you by.
    /// </summary>
    [JsonPropertyName("authorisationMid")]
    public required string AuthorisationMid { get; init; }

    /// <summary>
    /// The three-character ISO currency code, example <b>USD</b>
    /// </summary>
    [JsonPropertyName("currencyCode")]
    public required string CurrencyCode { get; init; }
}
