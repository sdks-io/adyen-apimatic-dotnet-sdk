using System.Text.Json.Serialization;

namespace AdyenApIs.Models;

public record CreateAllowedOriginRequest
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("_links")]
    public Links? Links { get; init; }

    /// <summary>
    /// Domain of the allowed origin.
    /// </summary>
    [JsonPropertyName("domain")]
    public required string Domain { get; init; }

    /// <summary>
    /// Unique identifier of the allowed origin.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }
}
