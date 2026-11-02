using System.Text.Json.Serialization;
using AdyenApIs.Core.Models;
using AdyenApIs.Models.Enums;

namespace AdyenApIs.Models;

public record UninstallAndroidAppDetails
{
    /// <summary>
    /// The unique identifier of the app to be uninstalled.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("appId")]
    public string? AppId { get; init; }

    /// <summary>
    /// Type of terminal action: Uninstall an Android app.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public TypeUninstallAndroidAppDetails? Type { get; init; } = TypeUninstallAndroidAppDetails.UninstallAndroidApp;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
