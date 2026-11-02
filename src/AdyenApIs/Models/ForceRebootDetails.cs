using System.Text.Json.Serialization;
using AdyenApIs.Models.Enums;

namespace AdyenApIs.Models;

public record ForceRebootDetails
{
    /// <summary>
    /// The type of terminal action. The value <b>ForceReboot</b> triggers an immediate reboot of the specified terminal(s).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public TypeForceRebootDetails? Type { get; init; } = TypeForceRebootDetails.ForceReboot;
}
