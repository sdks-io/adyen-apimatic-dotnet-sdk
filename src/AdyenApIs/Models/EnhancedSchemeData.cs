using System.Text.Json.Serialization;

namespace AdyenApIs.Models;

public record EnhancedSchemeData
{
    /// <summary>
    /// <see href="https://docs.adyen.com/payment-methods/cards/enhanced-scheme-data/airline/">Airline enhanced scheme data</see> that may be required for processing the transaction and/or for interchange savings.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("airline")]
    public AirlineEnhancedSchemeData? Airline { get; init; }

    /// <summary>
    /// <see href="https://docs.adyen.com/payment-methods/cards/enhanced-scheme-data/l2-l3/">Level 2 and Level 3 enhanced scheme data</see> that may be required for processing the transaction and/or for interchange savings.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("levelTwoThree")]
    public LevelTwoThreeEnhancedSchemeData? LevelTwoThree { get; init; }
}
