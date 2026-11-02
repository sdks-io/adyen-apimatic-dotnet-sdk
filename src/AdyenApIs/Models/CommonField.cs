using System.Text.Json.Serialization;

namespace AdyenApIs.Models;

public record CommonField
{
    /// <summary>
    /// Name of the field. For example, Name of External Platform.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// Version of the field. For example, Version of External Platform.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version")]
    public string? Version { get; init; }
}
