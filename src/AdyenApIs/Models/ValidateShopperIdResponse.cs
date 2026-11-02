using System.Text.Json.Serialization;
using AdyenApIs.Core.Models;
using AdyenApIs.Models.Enums;

namespace AdyenApIs.Models;

public record ValidateShopperIdResponse
{
    /// <summary>
    /// Reason for the result.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason")]
    public string? Reason { get; init; }

    /// <summary>
    /// Result of the validation. Ex: valid, invalid, unknown
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("result")]
    public ResultValidateShopperIdResponse? Result { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
