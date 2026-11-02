using System.Collections.Generic;
using System.Text.Json.Serialization;
using AdyenApIs.Models.Enums;

namespace AdyenApIs.Models;

/// <summary>
/// Display options for the 3D Secure 2 SDK.
/// Optional and only for <c>deviceChannel</c> <b>app</b>.
/// </summary>
public record DeviceRenderOptionsThreeDs2RequestFields
{
    /// <summary>
    /// Supported SDK interface types.
    /// Allowed values:
    /// * native
    /// * html
    /// * both
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sdkInterface")]
    public SdkInterface? SdkInterface { get; init; } = SdkInterface.Both;

    /// <summary>
    /// UI types supported for displaying specific challenges.
    /// Allowed values:
    /// * text
    /// * singleSelect
    /// * outOfBand
    /// * otherHtml
    /// * multiSelect
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sdkUiType")]
    public IReadOnlyList<SdkUiType>? SdkUiType { get; init; }
}
