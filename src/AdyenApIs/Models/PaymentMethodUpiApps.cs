using System.Text.Json.Serialization;

namespace AdyenApIs.Models;

public record PaymentMethodUpiApps
{
    /// <summary>
    /// The unique identifier of this app, to submit in requests to /payments.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// A localized name of the app.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }
}
