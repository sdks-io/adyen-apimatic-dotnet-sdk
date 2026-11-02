using System.Text.Json.Serialization;

namespace AdyenApIs.Models;

/// <summary>
/// Settings for refunds.
/// </summary>
public record RefundsTerminalSettings
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
