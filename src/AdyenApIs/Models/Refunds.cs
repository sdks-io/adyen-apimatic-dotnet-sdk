using System.Text.Json.Serialization;

namespace AdyenApIs.Models;

public record Refunds
{
    /// <summary>
    /// Settings for referenced refunds.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("referenced")]
    public ReferencedRefunds? Referenced { get; init; }

    /// <summary>
    /// Settings for unreferenced refunds.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("unreferenced")]
    public UnreferencedRefunds? Unreferenced { get; init; }
}
