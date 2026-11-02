using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// Merchant price plan
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PricePlan>))]
public sealed record PricePlan : OpenStringEnum<PricePlan>
{
    private PricePlan(string value) : base(value)
    {
    }

    public static readonly PricePlan Bronze = new("BRONZE");

    public static readonly PricePlan Silver = new("SILVER");

    public static readonly PricePlan Gold = new("GOLD");

    public TResult Match<TResult>(Func<TResult> onBronze,
        Func<TResult> onSilver,
        Func<TResult> onGold,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Bronze => onBronze(),
            _ when this == Silver => onSilver(),
            _ when this == Gold => onGold(),
            _ => otherwise(Value)
        };

    public void Match(Action onBronze, Action onSilver, Action onGold, Action<string> otherwise)
    {
        if (this == Bronze) onBronze();
        else if (this == Silver) onSilver();
        else if (this == Gold) onGold();
        else otherwise(Value);
    }
}
