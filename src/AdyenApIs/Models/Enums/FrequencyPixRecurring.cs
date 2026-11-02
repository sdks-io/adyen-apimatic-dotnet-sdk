using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// The frequency at which the shopper will be charged.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FrequencyPixRecurring>))]
public sealed record FrequencyPixRecurring : OpenStringEnum<FrequencyPixRecurring>
{
    private FrequencyPixRecurring(string value) : base(value)
    {
    }

    public static readonly FrequencyPixRecurring Weekly = new("weekly");

    public static readonly FrequencyPixRecurring Monthly = new("monthly");

    public static readonly FrequencyPixRecurring Quarterly = new("quarterly");

    public static readonly FrequencyPixRecurring HalfYearly = new("half-yearly");

    public static readonly FrequencyPixRecurring Yearly = new("yearly");

    public TResult Match<TResult>(Func<TResult> onWeekly,
        Func<TResult> onMonthly,
        Func<TResult> onQuarterly,
        Func<TResult> onHalfYearly,
        Func<TResult> onYearly,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Weekly => onWeekly(),
            _ when this == Monthly => onMonthly(),
            _ when this == Quarterly => onQuarterly(),
            _ when this == HalfYearly => onHalfYearly(),
            _ when this == Yearly => onYearly(),
            _ => otherwise(Value)
        };

    public void Match(Action onWeekly,
        Action onMonthly,
        Action onQuarterly,
        Action onHalfYearly,
        Action onYearly,
        Action<string> otherwise)
    {
        if (this == Weekly) onWeekly();
        else if (this == Monthly) onMonthly();
        else if (this == Quarterly) onQuarterly();
        else if (this == HalfYearly) onHalfYearly();
        else if (this == Yearly) onYearly();
        else otherwise(Value);
    }
}
