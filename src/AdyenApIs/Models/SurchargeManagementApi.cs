using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AdyenApIs.Models;

public record SurchargeManagementApi
{
    /// <summary>
    /// Show the surcharge details on the terminal, so the shopper can confirm.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("askConfirmation")]
    public bool? AskConfirmation { get; init; }

    /// <summary>
    /// Surcharge fees or percentages for specific cards, funding sources (credit or debit), and currencies.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("configurations")]
    public IReadOnlyList<ConfigurationModel>? Configurations { get; init; }

    /// <summary>
    /// Exclude the tip amount from the surcharge calculation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("excludeGratuityFromSurcharge")]
    public bool? ExcludeGratuityFromSurcharge { get; init; }
}
