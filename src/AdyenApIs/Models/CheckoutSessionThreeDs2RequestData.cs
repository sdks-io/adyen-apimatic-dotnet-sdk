using System.Text.Json.Serialization;
using AdyenApIs.Models.Enums;

namespace AdyenApIs.Models;

public record CheckoutSessionThreeDs2RequestData
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("homePhone")]
    public Phone? HomePhone { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mobilePhone")]
    public Phone? MobilePhone { get; init; }

    /// <summary>
    /// Indicates whether a challenge is requested for this transaction. Possible values:
    /// * <b>01</b> — No preference
    /// * <b>02</b> — No challenge requested
    /// * <b>03</b> — Challenge requested (3DS Requestor preference)
    /// * <b>04</b> — Challenge requested (Mandate)
    /// * <b>05</b> — No challenge (transactional risk analysis is already performed)
    /// * <b>06</b> — Data Only
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDSRequestorChallengeInd")]
    public ThreeDsRequestorChallengeInd? ThreeDsRequestorChallengeInd { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("workPhone")]
    public Phone? WorkPhone { get; init; }
}
