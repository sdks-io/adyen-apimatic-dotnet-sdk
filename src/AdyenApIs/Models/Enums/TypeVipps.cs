using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// <b>vipps</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeVipps>))]
public sealed record TypeVipps : OpenStringEnum<TypeVipps>
{
    private TypeVipps(string value) : base(value)
    {
    }

    public static readonly TypeVipps Vipps = new("vipps");

    public TResult Match<TResult>(Func<TResult> onVipps, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Vipps => onVipps(),
            _ => otherwise(Value)
        };

    public void Match(Action onVipps, Action<string> otherwise)
    {
        if (this == Vipps) onVipps();
        else otherwise(Value);
    }
}
