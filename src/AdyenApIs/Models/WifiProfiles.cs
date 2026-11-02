using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AdyenApIs.Models;

public record WifiProfiles
{
    /// <summary>
    /// List of remote Wi-Fi profiles.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("profiles")]
    public IReadOnlyList<Profile>? Profiles { get; init; }

    /// <summary>
    /// General Wi-Fi settings.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("settings")]
    public SettingsWifiProfiles? Settings { get; init; }
}
