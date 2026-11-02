using System.Text.Json.Serialization;
using AdyenApIs.Core.Models;

namespace AdyenApIs.Models;

public record InvalidField
{
    /// <summary>
    /// The field that has an invalid value.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The invalid value.
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; init; }

    /// <summary>
    /// Description of the validation error.
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
