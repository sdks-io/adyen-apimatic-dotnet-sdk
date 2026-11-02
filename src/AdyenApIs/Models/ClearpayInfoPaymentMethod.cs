using System.Text.Json.Serialization;

namespace AdyenApIs.Models;

/// <summary>
/// Details to provide if <c>type</c> is <b>clearpay</b>.
/// </summary>
public record ClearpayInfoPaymentMethod
{
    /// <summary>
    /// Support Url
    /// </summary>
    [JsonPropertyName("supportUrl")]
    public required string SupportUrl { get; init; }
}
