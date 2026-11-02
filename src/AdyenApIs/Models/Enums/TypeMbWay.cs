using System;
using System.Text.Json.Serialization;
using AdyenApIs.Core.Enum;

namespace AdyenApIs.Models.Enums;

/// <summary>
/// <b>mbway</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeMbWay>))]
public sealed record TypeMbWay : OpenStringEnum<TypeMbWay>
{
    private TypeMbWay(string value) : base(value)
    {
    }

    public static readonly TypeMbWay Mbway = new("mbway");

    public TResult Match<TResult>(Func<TResult> onMbway, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Mbway => onMbway(),
            _ => otherwise(Value)
        };

    public void Match(Action onMbway, Action<string> otherwise)
    {
        if (this == Mbway) onMbway();
        else otherwise(Value);
    }
}
