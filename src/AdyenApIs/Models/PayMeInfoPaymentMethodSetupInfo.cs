using System.Text.Json.Serialization;

namespace AdyenApIs.Models;

/// <summary>
/// Details to provide if <c>type</c> is <b>payme</b>.
/// </summary>
public record PayMeInfoPaymentMethodSetupInfo
{
    /// <summary>
    /// Merchant display name
    /// </summary>
    [JsonPropertyName("displayName")]
    public required string DisplayName { get; init; }

    /// <summary>
    /// Merchant logo. Format: Base64-encoded string.
    /// </summary>
    [JsonPropertyName("logo")]
    public required string Logo { get; init; }

    /// <summary>
    /// The email address of merchant support.
    /// </summary>
    [JsonPropertyName("supportEmail")]
    public required string SupportEmail { get; init; }
}
