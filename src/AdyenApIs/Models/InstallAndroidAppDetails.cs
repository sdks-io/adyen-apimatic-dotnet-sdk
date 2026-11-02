using System.Text.Json.Serialization;
using AdyenApIs.Models.Enums;

namespace AdyenApIs.Models;

public record InstallAndroidAppDetails
{
    /// <summary>
    /// The unique identifier of the app to be installed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("appId")]
    public string? AppId { get; init; }

    /// <summary>
    /// Type of terminal action: Install an Android app.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public TypeInstallAndroidAppDetails? Type { get; init; } = TypeInstallAndroidAppDetails.InstallAndroidApp;
}
