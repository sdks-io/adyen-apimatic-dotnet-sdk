using System.Text.Json.Serialization;

namespace AdyenApIs.Models;

public record ClearpayInfo
{
    /// <summary>
    /// Support Url
    /// </summary>
    [JsonPropertyName("supportUrl")]
    public required string SupportUrl { get; init; }
}
