using System.Text.Json.Serialization;
using AdyenApIs.Models.Enums;

namespace AdyenApIs.Models;

public record ReleaseUpdateDetails
{
    /// <summary>
    /// Type of terminal action: Update Release.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public TypeReleaseUpdateDetails? Type { get; init; } = TypeReleaseUpdateDetails.ReleaseUpdate;

    /// <summary>
    /// Boolean flag that tells if the terminal should update at the first next maintenance call. If false, terminal will update on its configured reboot time.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updateAtFirstMaintenanceCall")]
    public bool? UpdateAtFirstMaintenanceCall { get; init; }
}
