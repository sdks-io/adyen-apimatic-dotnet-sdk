using System.Text.Json.Serialization;

namespace AdyenApIs.Models;

/// <summary>
/// The destination address information.
/// </summary>
public record DestinationLevelTwoThree
{
    /// <summary>
    /// The two-letter <see href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO 3166-1 alpha-2</see> or three-letter <see href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-3">ISO 3166-1 alpha-3 country code</see> for the destination address.
    ///  * Encoding: ASCII
    ///  * Min length: 2 characters
    ///  * Max length: 3 characters
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("countryCode")]
    public string? CountryCode { get; init; }

    /// <summary>
    /// The postal code of the destination address.
    /// * Encoding: ASCII
    /// * Max length: 10 characters
    /// * Must not start with a space.
    /// * For the US, it must be in five or nine digits format. For example, 10001 or 10001-0000.
    /// * For Canada, it must be in 6 digits format. For example, M4B 1G5.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("postalCode")]
    public string? PostalCode { get; init; }

    /// <summary>
    /// The state or province code of the destination address.
    /// * Encoding: ASCII
    /// * Max length: 3 characters
    /// * Must not start with a space.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("stateOrProvince")]
    public string? StateOrProvince { get; init; }
}
