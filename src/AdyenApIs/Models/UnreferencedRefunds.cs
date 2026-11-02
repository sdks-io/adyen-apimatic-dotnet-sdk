using System.Text.Json.Serialization;

namespace AdyenApIs.Models;

/// <summary>
/// Settings for unreferenced refunds.
/// </summary>
public record UnreferencedRefunds
{
    /// <summary>
    /// Indicates whether unreferenced refunds are enabled on the terminal.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enableUnreferencedRefunds")]
    public bool? EnableUnreferencedRefunds { get; init; }
}
